using FolderSecuringProject.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FolderSecuringProject.Services
{
    public class FolderLogic
    {
        public string SecurityTextFileName = "security.txt";
        //TODO: Implement the logic for unlocking the folder based on the password provided.
        //TODO: Check if folder is locked and if so, prompt for password to unlock it. If the password is correct, unlock the folder; otherwise, show an error message.
        //TODO: When trying to access a locked folder, show the user a UI to enter the password. If the password is correct, allow access; otherwise, deny access and show an error message.
        public void SaveFolderInfo(FolderInfo folderInfo)
        {
            string settingsFile = Path.Combine(folderInfo.FolderPath, SecurityTextFileName);
            File.WriteAllText(settingsFile, $"Folder path: {folderInfo.FolderPath}\nPassword: {folderInfo.Password}\nIs Locked: {folderInfo.IsLocked}");
        }
        public FolderInfo LoadFolderInfo(string folderPath)
        {
            string settingsFile = Path.Combine(folderPath, SecurityTextFileName);
            string[] lines = File.ReadAllLines(settingsFile);

            if (lines.Length < 3 ||
                !lines[0].StartsWith("Folder path: ") ||
                !lines[1].StartsWith("Password: ") ||
                !lines[2].StartsWith("Is Locked: "))
            {
                throw new InvalidDataException("The folder info file has an invalid format.");
            }

            return new FolderInfo
            {
                FolderPath = lines[0]["Folder path: ".Length..],
                Password = lines[1]["Password: ".Length..],
                IsLocked = bool.Parse(lines[2]["Is Locked: ".Length..])
            };
        }
        public bool CheckingValidUserInput(FolderInfo folderInfo)
        {
            if (!ValidateFolderPath(folderInfo.FolderPath))
            {
                return false;
            }

            if (IsFolderLocked(folderInfo.FolderPath))
            {
                DialogResult result = MessageBox.Show("The folder is already locked.\nWould you like to unlock it?", "Folder Locked", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    UserUnlockFolderForm(folderInfo);
                }
                return false;
            }

            return ValidatePasswordInfo(folderInfo);
        }
        private bool ValidateFolderPath(string folderPath)
        {
            if (string.IsNullOrWhiteSpace(folderPath))
            {
                MessageBox.Show("Please select a folder.");
                return false;
            }
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("The selected folder does not exist.");
                return false;
            }
            return true;
        }

        private bool ValidatePasswordInfo(FolderInfo folderInfo)
        {
            if (string.IsNullOrWhiteSpace(folderInfo.Password))
            {
                MessageBox.Show("Please enter a password.");
                return false;
            }
            if (folderInfo.Password != folderInfo.PasswordReinserted)
            {
                MessageBox.Show("Passwords do not match. Please re-enter the password.");
                return false;
            }
            return true;
        }
        public bool UserUnlockFolderForm(FolderInfo folderInfo)
        {
                using UnlockForm unlockForm = new();
                if (unlockForm.ShowDialog() == DialogResult.OK)
                {
                    if (unlockForm.EnteredPassword == GetFolderPassword(folderInfo.FolderPath))
                    {
                    //TODO: Implement logic to unlock the folder here. This could involve changing file attributes, removing encryption, or any other method used to secure the folder.
                    MessageBox.Show("Folder unlocked successfully!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password. Folder remains locked.");
                        return false;
                    }
                 }
            return false;
        }
        private bool SecurityFileExists(string folderPath)
        {
            if (string.IsNullOrWhiteSpace(folderPath))
                return false;

            if (!Directory.Exists(folderPath))
                return false;

            string settingsFile =
                Path.Combine(folderPath, SecurityTextFileName);

            return File.Exists(settingsFile);
        }
        public bool IsFolderLocked(string folderPath)
        {
            if (!SecurityFileExists(folderPath))
                return false;

            return LoadFolderInfo(folderPath).IsLocked;
        }

        public string GetFolderPassword(string folderPath)
        {
            if (!SecurityFileExists(folderPath))
                return null;

            return LoadFolderInfo(folderPath).Password;
        }
    }
}



using FolderSecuringProject.Models;

namespace FolderSecuringProject.Services
{
    public class FolderLogic
    {
        //TODO: Implement the logic for unlocking the folder based on the password provided.
        //TODO: Check if folder is locked and if so, prompt for password to unlock it. If the password is correct, unlock the folder; otherwise, show an error message.
        //TODO: When trying to access a locked folder, show the user a UI to enter the password. If the password is correct, allow access; otherwise, deny access and show an error message.
        public void SettingsFolderTextWrite(FolderInfo folderInfo)
        {
            string settingsFile = Path.Combine(folderInfo.FolderPath, "security.txt");
            File.WriteAllText(settingsFile, $"Folder path: {folderInfo.FolderPath}\nPassword: {folderInfo.PasswordHash}\nIs Locked: {folderInfo.IsLocked}");
        }

        public bool CheckingValidUserInput(FolderInfo folderInfo)
        {
            if (string.IsNullOrWhiteSpace(folderInfo.FolderPath))
            {
                MessageBox.Show("Please select a folder.");
                return false;
            }
            if (!Directory.Exists(folderInfo.FolderPath))
            {
                MessageBox.Show("The selected folder does not exist.");
                return false;
            }
            if (IsFolderLocked(folderInfo.FolderPath))
            {
                DialogResult result = MessageBox.Show("The folder is already locked.\nWould you like to unlock it?", "Folder Locked", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using UnlockForm unlockForm = new();
                    if (unlockForm.ShowDialog() == DialogResult.OK)
                    {
                        string enteredPassword = unlockForm.EnteredPassword;
                        if (enteredPassword == GetFolderPassword(folderInfo.FolderPath))
                        {
                            MessageBox.Show("Folder unlocked successfully!");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect password. Folder remains locked.");
                            return false;
                        }
                    }
                }

                return false;
            }
            if (string.IsNullOrWhiteSpace(folderInfo.PasswordHash))
            {
                MessageBox.Show("Please enter a password.");
                return false;
            }
            if (folderInfo.PasswordHash != folderInfo.PasswordReinsertedHash)
            {
                MessageBox.Show("Passwords do not match. Please re-enter the password.");
                return false;
            }
            return true;
        }

        public bool IsFolderLocked(string folderPath) //TODO: Implement logic to check by other method and not via string
        {
            string settingsFile = Path.Combine(folderPath, "security.txt");
            if (File.Exists(settingsFile))
            {
                string[] lines = File.ReadAllLines(settingsFile);
                foreach (string line in lines)
                {
                    if (line.Contains("True"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
        public string GetFolderPassword(string folderPath)
        {
            string settingsFile = Path.Combine(folderPath, "security.txt");
            if (File.Exists(settingsFile))
            {
                string[] lines = File.ReadAllLines(settingsFile);
                foreach (string line in lines)
                {
                    if (line.StartsWith("Password:"))
                    {
                        return line.Substring("Password:".Length).Trim();
                    }
                }
            }
            return null; 
        }
    }
}

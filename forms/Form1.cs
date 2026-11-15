using FolderSecuringProject.Services;
using FolderSecuringProject.Models;

namespace FolderSecuringProject
{
    public partial class Form1 : Form
    {
        #region "Form1 Designer generated code"
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void ReinsertPasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void SecuringFolder_Click(object sender, EventArgs e)
        {
            FolderInfo folderInfo = new FolderInfo();
            folderInfo.FolderPath = textBox2.Text;
            folderInfo.PasswordHash = textBox1.Text;
            folderInfo.PasswordReinsertedHash = ReinsertPasswordText.Text;
            folderInfo.IsLocked = true;
            FolderLogic folderLogic = new FolderLogic();
            if (folderLogic.CheckingValidUserInput(folderInfo) && !folderLogic.IsFolderLocked(folderInfo.FolderPath))
            {
                folderLogic.SettingsFolderTextWrite(folderInfo);
                MessageBox.Show("Folder secured successfully!");
                return;
            }
        }
        private void ChosingPathButton_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog()) //Note: using statement ensures proper disposal of the dialog, GC runs eventually, but using statement is a good practice to ensure resources are released promptly. FolderBrowserDialog uses 
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    textBox2.Text = selectedPath;
                }
            }
        }
    }
}

namespace FolderSecuringProject
{
    public partial class Form1 : Form
    {
        private string _password;
        private string _reinsertedPassword;
        private string _folderPath;
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

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SecuringFolder_Click(object sender, EventArgs e)
        {
            _password = textBox1.Text;
            _reinsertedPassword = ReinsertPasswordText.Text;
            _folderPath = textBox2.Text;

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please select a folder.");
                return;
            }
            if (!Directory.Exists(textBox2.Text))
            {
                MessageBox.Show("The selected folder does not exist.");
                return;
            }
            if (_password != _reinsertedPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter the password.");
                return;
            }

            if (Directory.Exists(textBox2.Text) && !string.IsNullOrEmpty(textBox1.Text) && _password == _reinsertedPassword)
            {
                string settingsFile = Path.Combine(_folderPath, "security.txt");
                File.WriteAllText(settingsFile,$"Folder path: {_folderPath}\nPassword: {_password}");
                MessageBox.Show("Folder secured successfully!");
            }
           
        }
        private void ChosingPathButton_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    textBox2.Text = selectedPath;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReinsertPasswordText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

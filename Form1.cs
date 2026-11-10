namespace FolderSecuringProject
{
    public partial class Form1 : Form
    {
        // to modify the names of the controls, you can change them in the properties window in Visual Studio.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            //TOOD: Refactor
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
            if (Directory.Exists(textBox2.Text) && !string.IsNullOrEmpty(textBox1.Text))
            {
                // Code to secure the folder with the provided password
                MessageBox.Show("Folder secured successfully!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
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
    }
}

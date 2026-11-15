
namespace FolderSecuringProject
{
    public partial class UnlockForm : Form
    {
        public string EnteredPassword
        {
            get {return textBox1.Text;}
        }
        public UnlockForm()
        {
            InitializeComponent();
        }

        #region "formum generated"
        private void UnlockForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion


    }
}

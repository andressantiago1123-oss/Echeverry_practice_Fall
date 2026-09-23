namespace Echeverry_practice_Fall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTextInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTextInput.Clear();
            txtNumericInput.Clear();
            lstOut.Items.Clear();
        }

        private void lstOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

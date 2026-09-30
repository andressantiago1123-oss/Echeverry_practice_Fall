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

        private void txtTextInput_Enter(object sender, EventArgs e)
        {
            txtTextInput.BackColor = Color.Yellow;
        }

        private void txtTextInput_Leave(object sender, EventArgs e)
        {
            txtTextInput.BackColor = Color.White;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string textInput;
            double numberInput;
            double percentRate;             
            double doubleCalculation;
            string outputLine1;
            string outputLine2;
            string outputLine3;
            string outputLine4;

            textInput = txtTextInput.Text;
            numberInput = double.Parse(txtNumericInput.Text);
            percentRate = 0.10;

            doubleCalculation = numberInput * percentRate;

            outputLine1 = "Input Text:  " + textInput;
            outputLine2 = "Input Number:  " + numberInput.ToString("N");
            outputLine3 = "Rate Applied:  " + percentRate.ToString("P");
            outputLine4 = "Total Bonus:  " + doubleCalculation.ToString("C");

            lstOut.Items.Clear();
            lstOut.Items.Add(outputLine1);
            lstOut.Items.Add(outputLine2);
            lstOut.Items.Add(outputLine3);
            lstOut.Items.Add("-----------------------------");
            lstOut.Items.Add(outputLine4);



        }
    }
}

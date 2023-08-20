namespace MyScientific_Calculator
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        String op;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                        txtResult.Text = txtResult.Text + num.Text;
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }

                    // Add a comma every three digits
                    //string text = txtResult.Text;
                    //int index = 0;
                    ////while (index < text.Length)
                    //{
                    //    if (index > 0 && text[index - 1] != ',' && index % 3 == 0)
                    //    {
                    //        txtResult.Text = txtResult.Text.Insert(index, ",");
                    //    }
                    //    index++;
                    //}
                    ConvertDecimalToHexadecimal();
                    ConvertDecimalToOctal();
                    ConvertDecimalToBinary();
                }
            }

            private void ConvertDecimalToHexadecimal()
            {
                string text = txtResult.Text;
                text = text.Replace(",", "");
                txtResult.Text = text;
                int decimalNumber = Convert.ToInt32(text);
                string hexadecimalNumber = Convert.ToString(decimalNumber, 16);
                txtResultHex.Text = hexadecimalNumber;
            }
            private void ConvertDecimalToOctal()
            {
                string text = txtResult.Text;
                text = text.Replace(",", "");
                int decimalNumber = Convert.ToInt32(text);
                string octalNumber = Convert.ToString(decimalNumber, 8);
                txtResultOct.Text = octalNumber;
            }
            private void ConvertDecimalToBinary()
            {
                string text = txtResult.Text;
                text = text.Replace(",", "");
                int decimalNumber = Convert.ToInt32(text);
                string binaryNumber = Convert.ToString(decimalNumber, 2);
                txtResultBinary.Text = binaryNumber;
            }

        }
}
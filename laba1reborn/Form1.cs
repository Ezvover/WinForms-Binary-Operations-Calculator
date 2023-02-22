namespace laba1reborn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Aquamarine;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Calculate calculate= new Calculate();
            int number = 0;
            try
            {
                int firstNumber = int.Parse(textBox1.Text);
                int secondNumber = int.Parse(textBox2.Text);

                if (radioButton1.Checked)
                {
                    number = firstNumber & secondNumber;
                }
                if (radioButton2.Checked)
                {
                    number = firstNumber | secondNumber;
                }
                if (radioButton3.Checked)
                {
                    number = firstNumber ^ secondNumber;
                }
                if (radioButton4.Checked)
                {
                    number = ~firstNumber;
                }
                if (radioButton5.Checked)
                {
                    number = ~secondNumber;
                }

                BinaryResult.Text = calculate.CalculateBinary(number).ToString();
                OctalResult.Text = calculate.CalculateOctal(number).ToString();
                DecimalResult.Text = calculate.CalculateDecimal(number).ToString();
                HexResult.Text = calculate.CalculateHex(number).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            BinaryResult.Text = "Binary Result";
            OctalResult.Text = "Octal Result";
            DecimalResult.Text = "Decimal Result";
            HexResult.Text = "Hex Result";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            clear += Clear;
            clear();
        }

        public delegate void ClearDelegate();
        public event ClearDelegate clear;
    }

    public class Calculate : ICalculate
    {
        public int CalculateBinary(int number)
        {
            int result;
            string str = Convert.ToString(number, 2);
            result = int.Parse(str);
            return result;
        }
        public int CalculateOctal(int number)
        {
            int result;
            string str = Convert.ToString(number, 8);
            result = int.Parse(str);
            return result;
        }

        public int CalculateDecimal(int number)
        {
            int result;
            string str = Convert.ToString(number, 10);
            result = int.Parse(str);
            return result;
        }

        public string CalculateHex(int number)
        {
            string result = Convert.ToString(number, 16);
            return result;
        }
    }
}
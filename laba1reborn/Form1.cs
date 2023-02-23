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
            Calculate calculate = new Calculate();
            int number = 0;
            try
            {
                int firstNumber = Convert.ToInt32(textBox1.Text);
                int secondNumber = Convert.ToInt32(textBox2.Text);

                if (AndRadio.Checked)
                {
                    number = firstNumber & secondNumber;
                }
                else if (OrRadio.Checked)
                {
                    number = firstNumber | secondNumber;
                }
                else if (XORRadio.Checked)
                {
                    number = firstNumber ^ secondNumber;
                }
                else if (NotFirstRadio.Checked)
                {
                    number = ~firstNumber;
                }
                else if (NotSecondRadio.Checked)
                {
                    number = ~secondNumber;
                }
                else
                {
                    MessageBox.Show("Вам нужно выбрать одну из опций");
                }

                if (AndRadio.Checked || OrRadio.Checked || XORRadio.Checked || NotFirstRadio.Checked || NotSecondRadio.Checked)
                {
                    BinaryResult.Text = calculate.CalculateBinary(number);
                    OctalResult.Text = calculate.CalculateOctal(number);
                    DecimalResult.Text = calculate.CalculateDecimal(number);
                    HexResult.Text = calculate.CalculateHex(number);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            AndRadio.Checked = false;
            OrRadio.Checked = false;
            XORRadio.Checked = false;
            NotFirstRadio.Checked = false;
            NotSecondRadio.Checked = false;
            BinaryResult.Text = "Бинарный ответ";
            OctalResult.Text = "Восьмеричный ответ";
            DecimalResult.Text = "Десятичный ответ";
            HexResult.Text = "Шестнадцатиричный ответ";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            clear += Clear;
            clear();
        }

        public delegate void ClearDelegate();
        public event ClearDelegate clear;
    }

    public class Calculate
    {
        public string CalculateBinary(int number)
        {
            string str = Convert.ToString(number, 2);
            return str;
        }
        public string CalculateOctal(int number)
        {
            string str = Convert.ToString(number, 8);
            return str;
        }

        public string CalculateDecimal(int number)
        {
            string str = Convert.ToString(number, 10);
            return str;
        }

        public string CalculateHex(int number)
        {
            string result = Convert.ToString(number, 16);
            return result;
        }
    }
}
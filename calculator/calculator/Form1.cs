namespace calculator
{
    public partial class Form1 : Form
    {
        private double firstNumber = 0.0;
        private double secondNumber = 0.0;
        private double resultNumber = 0.0;
        private string operatorString = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void Any_Number_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Clear();
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                    textBox.Text += num.Text;
            }
            else

                textBox.Text += num.Text;
        }

        private void suppliedOperator(object sender, EventArgs e)
        {
            Button oper = (Button)sender;
            operatorString = oper.Text;
            firstNumber = Double.Parse(textBox.Text);
            textBox.Text = "0";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            firstNumber = 0.0;
            secondNumber = 0.0;
            resultNumber = 0.0;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            secondNumber = Double.Parse(textBox.Text);
            switch(operatorString)
            {
                case "+":
                    resultNumber = firstNumber + secondNumber;
                    break;
                case "-":
                    resultNumber = firstNumber - secondNumber;
                    break;
                case "*":
                    resultNumber = firstNumber * secondNumber;
                    break;
                case "/":
                    resultNumber = firstNumber / secondNumber;
                    break;
                case "%":
                    resultNumber = firstNumber % secondNumber;
                    break;
                default:
                    break;
            }
            textBox.Text = resultNumber.ToString();
            
        }
    }
}

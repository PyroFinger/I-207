namespace calculator
{
    public partial class calculator : Form
    {

        bool newOperation = true;
        double firstvalue;
        double secondvalue;
        double result = 0.0;
        string operation = "";
        

        public calculator()
        {
            InitializeComponent();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (newOperation)
            {
                textBox1.Clear();
                newOperation = false;
            }
            if (btn.Text == ",")
            {
                var val = textBox1.Text.IndexOf(',');
                if (val != -1)
                {
                    return;
                }
            if (btn.Text != ",")
                    firstvalue = Convert.ToDouble(textBox1.Text);
            }
            textBox1.Text += btn.Text;
        }
        private void ButtonActionResult(object sender, EventArgs e)
        {
            secondvalue = Convert.ToDouble(textBox1.Text);
            switch (operation)
            {
                case "+":
                    result = firstvalue + secondvalue;
                    newOperation = true;
                    break;
                case "-":
                    result = firstvalue - secondvalue;
                    newOperation = true;
                    break;
                case "/":
                    result = firstvalue / secondvalue;
                    newOperation = true;
                    break;
                case "*":
                    result = firstvalue * secondvalue;
                    newOperation = true;
                    break;
                case "%":
                    result = firstvalue % secondvalue;
                    newOperation = true;
                    break;
                case "^":
                    result = Math.Pow(firstvalue, secondvalue);
                    newOperation = true;
                    break;
                default:
                    break;

            }
            textBox1.Text = result.ToString();

        }
        private void ButtonActionOperation(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstvalue = Convert.ToDouble(textBox1.Text);
            operation = btn.Text;
            newOperation = true;
        }
    }
}
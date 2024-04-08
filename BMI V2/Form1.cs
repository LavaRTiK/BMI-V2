namespace BMI_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidationNumbers(textBox1.Text, out errorMsg))
            {
                e.Cancel = true;
                textBox1.Select(0, textBox1.Text.Length);

                this.errorProvider1.SetError(textBox1, errorMsg);
            }
        }
        public bool ValidationNumbers(string text, out string errorMassege)
        {
            if (text.Length == 0)
            {
                errorMassege = "Введіть якесь число";
                return false;
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsNumber(text[i]))
                {
                    errorMassege = "Невірний формат";
                    return false;
                }
            }
            errorMassege = "";
            return true;
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
            checkRule();
        }

        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage;
            if (!ValidationNumbers(textBox2.Text, out errorMessage))
            {
                e.Cancel = true;
                textBox1.Select(0, textBox1.Text.Length);

                this.errorProvider1.SetError(textBox2, errorMessage);
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, "");
            checkRule();
        }

        private void checkRule()
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                double result = double.Parse(textBox2.Text)/((double.Parse(textBox1.Text)/100)*(double.Parse(textBox1.Text) / 100));
                label3.Text ="ІМТ:" + Math.Round(result, 2).ToString();
            }
        }
    }
}

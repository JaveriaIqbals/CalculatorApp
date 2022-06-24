namespace WinFormsApp1
{
    // This is Code Behind file of Form1
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        string operatorVal;
        public Form1()
        {
            num1 = 0;
            num2 = 0;
            operatorVal = "";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text == "0")
                this.richTextBox1.Text = "";
            this.richTextBox1.Text = this.richTextBox1.Text + "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text == "0")
                this.richTextBox1.Clear();
            this.richTextBox1.Text = this.richTextBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text == "0")
                this.richTextBox1.Clear();
            this.richTextBox1.Text = this.richTextBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text == "0")
                this.richTextBox1.Clear();
            this.richTextBox1.Text = this.richTextBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text == "0")
                this.richTextBox1.Clear();
            this.richTextBox1.Text = this.richTextBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text == "0")
                this.richTextBox1.Clear();
            this.richTextBox1.Text = this.richTextBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text == "0")
                this.richTextBox1.Clear();
            this.richTextBox1.Text = this.richTextBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text == "0")
                this.richTextBox1.Clear();
            this.richTextBox1.Text = this.richTextBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text == "0")
                this.richTextBox1.Clear();
            this.richTextBox1.Text = this.richTextBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text == "0")
                this.richTextBox1.Clear();
            this.richTextBox1.Text =  this.richTextBox1.Text + "0";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            // This is + button's Event handler
            num1 = Convert.ToDouble(this.richTextBox1.Text);
            this.richTextBox1.Text = "";
            operatorVal = "+";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            // This is Equal button
            num2 = Convert.ToDouble(this.richTextBox1.Text);
            if (operatorVal == "+")
            {
                this.richTextBox1.Text = (num1 + num2).ToString();
            }
            else if (operatorVal == "-")
            {
                this.richTextBox1.Text = (num1 - num2).ToString();
            }
            else if (operatorVal == "*")
            {
                this.richTextBox1.Text = (num1 * num2).ToString();
            }
            else 
                this.richTextBox1.Text = (num1 / num2).ToString();

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // This is - button's Event handler
            num1 = Convert.ToDouble(this.richTextBox1.Text);
            this.richTextBox1.Text = "";
            operatorVal = "-";

        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            // This is * button's Event handler
            num1 = Convert.ToDouble(this.richTextBox1.Text);
            this.richTextBox1.Text = "";
            operatorVal = "*";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            // This is / button's Event handler
            num1 = Convert.ToDouble(this.richTextBox1.Text);
            this.richTextBox1.Text = "";
            operatorVal = "/";

        }
    }
}
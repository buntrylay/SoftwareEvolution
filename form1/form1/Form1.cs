using System.Windows.Forms;
using classFunction;

namespace form1
{
    public partial class Form1 : Form
    {
        private Calculator calculator = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.AppendInput(button.Text);
            textBox1.Text = calculator.CurrentInput;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            calculator.Clear();
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = calculator.Evaluate();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.AppendInput(button.Text);
            textBox1.Text = calculator.CurrentInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.AppendInput(button.Text);
            textBox1.Text = calculator.CurrentInput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.AppendInput(button.Text);
            textBox1.Text = calculator.CurrentInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.AppendInput(button.Text);
            textBox1.Text = calculator.CurrentInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.AppendInput(button.Text);
            textBox1.Text = calculator.CurrentInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.AppendInput(button.Text);
            textBox1.Text = calculator.CurrentInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.AppendInput(button.Text);
            textBox1.Text = calculator.CurrentInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.AppendInput(button.Text);
            textBox1.Text = calculator.CurrentInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.AppendInput(button.Text);
            textBox1.Text = calculator.CurrentInput;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.SetOperation(button.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.SetOperation(button.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.SetOperation(button.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.SetOperation(button.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional logic
        }
    }
}
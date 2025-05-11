namespace calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);
            float resalt = num1 + num2;
            label3.Text = resalt.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);
            float resalt = num1 - num2;
            label3.Text = resalt.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);
            float resalt = num1 / num2;
            label3.Text = resalt.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);
            float resalt = num1 * num2;
            label3.Text = resalt.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);
            float resalt = num1 % num2;
            label3.Text = resalt.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
        }
    }
}

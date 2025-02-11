namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello World Textbox!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Welcome Console");
            button2.Enabled = false;        
        }
    }
}

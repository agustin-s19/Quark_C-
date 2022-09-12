namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = Text+button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Text = Text+ button3.Text;
        }
    }
}
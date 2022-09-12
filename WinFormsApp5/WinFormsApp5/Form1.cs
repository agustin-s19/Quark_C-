namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(textBox1.Text);
            int valor2 = int.Parse(textBox2.Text);
            int suma = valor1 + valor2;
            label4.Text = suma.ToString();
        }
    }
}
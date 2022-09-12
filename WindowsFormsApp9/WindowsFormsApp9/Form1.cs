using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        Usuario u;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u = new Usuario(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            MessageBox.Show($"El usuario ha sido registrado con exito \n Nombre:{u.Nombre} \n Apellido: {u.Apellido}\n Dni: {u.Dni}\nEmail:{u.Email}\n{u.Direccion} ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            u.Direccion = textBox5.Text;
            MessageBox.Show($"Se actualizo el campo direccion\n Nombre:{u.Nombre} \n Apellido: {u.Apellido}\n Dni: {u.Dni}\nEmail:{u.Email} \n {u.Direccion}");
        }
    }
}

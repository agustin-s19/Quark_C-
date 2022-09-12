using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto41real
{
    public partial class Form1 : Form
    {
        ArrayList clientes = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string dni = textBox3.Text;
            MessageBox.Show("Hola " + textBox1.Text + " " + textBox2.Text);

            Cliente cli = new Cliente(nombre, apellido, dni);
            Boolean existe = false;

            foreach(Cliente _cli in clientes)
            {
                if (_cli.Dni == cli.Dni)
                {
                    existe = true;
                }
                
            }
            if (!existe)
            {
                clientes.Add(cli);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = null;

            foreach(Cliente cli in clientes)
            {
                label4.Text = label4.Text + "\n Nombre: " + cli.Nombre;
                label4.Text = label4.Text + "\n Apellido: " + cli.Apellido;
                label4.Text = label4.Text + "\n Dni: " + cli.Dni;
                label4.Text = label4.Text + "\n--------------------------------";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poyecto43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validacion campo string
            bool validarStringRespuesta = Utiles.validarCampo(textBox2.Text, "string");
            if (!validarStringRespuesta)
            {
                textBox2.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                textBox2.BackColor = System.Drawing.Color.White;
            }
            // Validacion campo int
            bool validarIntRespuesta = Utiles.validarCampo(textBox1.Text, "int");
            if (!validarIntRespuesta)
            {
                textBox1.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                textBox1.BackColor = System.Drawing.Color.White;
            }
            // Validacion Campo float
            bool validarFloatRespuesta = Utiles.validarCampo(textBox3.Text, "float");
            if (!validarFloatRespuesta)
            {
                textBox3.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                textBox3.BackColor = System.Drawing.Color.White;
            }
        }
    }
}

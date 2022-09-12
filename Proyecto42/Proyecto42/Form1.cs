using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClaseHija hijo = new ClaseHija(); // Creamos un objeto de la clase hija

            hijo.Calcular(); // Ejecutamos el metodo calcular. EL mismo va a invocar el primer metodo de la clase padre y luego va a ejecutar el comportamiento particular.
        }
    }
}

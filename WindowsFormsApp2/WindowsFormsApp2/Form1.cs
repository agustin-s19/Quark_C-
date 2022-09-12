using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server = DESKTOP-4UNVPU2; database=articulos; integrated security = true");
            conexion.Open();
            MessageBox.Show("Se ha conectado a la base de datos exitosamente");
            conexion.Close();
            MessageBox.Show("Se ha cerrado la conexion a la BDD");

        }
    }
}

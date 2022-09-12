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

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server =DESKTOP-4UNVPU2; database= ARTICULOS; integrated security= true");
            conexion.Open();
            string cod = textBox1.Text;
            string cadena = "select descripcion, precio from articulos where codigo="+cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                label5.Text = registro["descripcion"].ToString();
                label4.Text = registro["precio"].ToString();
            }
            else
            {
                MessageBox.Show("No existe un articulo con dicho codigo");
                conexion.Close();
            }

        }
    }
}

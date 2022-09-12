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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private SqlConnection conexion = new SqlConnection("server = DESKTOP-4UNVPU2; database= ARTICULOS; integrated security = true");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cod = textBox1.Text;
            string cadena = "select descripcion, precio from articulos where codigo=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                label4.Text = registro["descripcion"].ToString();
                label5.Text = registro["precio"].ToString();
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontro ningun producto con dicho codigo");
                
            }
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cod = textBox1.Text;
            string cadena = "delete from articulos where codigo=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if(cant == 1)
            {
                label4.Text = " ";
                label5.Text = " ";
                MessageBox.Show("Se ha borrado correctamente.");
            }
            else
            {
                MessageBox.Show("No existe un articulo con el codigo ingresado");
            }
            conexion.Close();
            button2.Enabled = false;
        }
    }
}

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


namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private SqlConnection conexion = new SqlConnection("server = DESKTOP-4UNVPU2; database = ARTICULOS; INTEGRATED SECURITY = true");
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
                textBox2.Text = registro["descripcion"].ToString();
                textBox3.Text = registro["precio"].ToString();
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
            string descri = textBox2.Text;
            string prec = textBox3.Text;
            string cadena = "update articulos set descripcion='" + descri + "', precio=" + prec + " where codigo=" + cod;
            SqlCommand comando = new SqlCommand(cadena,conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if(cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del articulo");
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";

            }
            else
            {
                MessageBox.Show("No se encontro ningun articulo con dicho codigo");
            }
            conexion.Close();
            button2.Enabled = false;
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server= DESKTOP-4UNVPU2; database=ARTICULOS; integrated security= true");
            conexion.Open();
            string descrip = textBox1.Text;
            string prec = textBox2.Text;
            string cadena = "insert into articulos(descripcion,precio) values ('" + descrip +"'," + prec + ")";
            SqlCommand comando = new SqlCommand(cadena,conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server= DESKTOP-4UNVPU2; database=ARTICULOS; integrated security= true");
            conexion.Open();
            string cadena = "select codigo,descripcion,precio from articulos";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                textBox3.AppendText(registros["codigo"].ToString());
                textBox3.AppendText(" - ");
                textBox3.AppendText(registros["descripcion"].ToString());
                textBox3.AppendText(" - ");
                textBox3.AppendText(registros["precio"].ToString());
                textBox3.AppendText(Environment.NewLine);
            }
            conexion.Close();
        }
    }
}

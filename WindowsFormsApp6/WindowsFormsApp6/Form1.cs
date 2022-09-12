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

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        private SqlConnection conexion = new SqlConnection("server= DESKTOP-4UNVPU2; database= ARTICULOS; integrated security= true");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "insert into articulos(descripcion,precio) values(@descripcion, @precio)";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar);
            comando.Parameters.Add("@precio", SqlDbType.Float);
            comando.Parameters["@descripcion"].Value = textBox1.Text;
            comando.Parameters["@precio"].Value = float.Parse(textBox2.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se han creado los nuevos articulos correctamente");
            textBox1.Text = " ";
            textBox2.Text = " ";
            conexion.Close();
        }
    }
}

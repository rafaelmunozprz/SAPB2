using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPB2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string servidor = tbServidor.Text;
            string baseDatos = tbBaseDatos.Text;
            string contrasena = tbContrasena.Text;
            string usuario = tbUsuario.Text;
            if (servidor.Equals("") || baseDatos.Equals("") || contrasena.Equals("") || usuario.Equals(""))
            {
                MessageBox.Show("No puede haber campos vacíos");
            }
            else
            {
                Conexion conectar = new Conexion();
                OdbcDataAdapter dat = new OdbcDataAdapter("SELECT TOP 1" + "\"CardCode\"," + "\"CardName\"," + "\"CardType\"," + "\"Address\"," + "\"ZipCode\"," + "\"MailAddres\"," + "\"MailZipCod\"," + "\"Phone1\" FROM " + "\"OCRD\" WHERE " + "\"CardType\" = 'S' ", conectar.ConnectionSQL(servidor, baseDatos, usuario, contrasena));
                DataSet ds = new DataSet();
                dat.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }
    }
}

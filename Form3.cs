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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string servidor = tbServidor.Text;
            string contrasena = tbContrasena.Text;
            string usuario = tbUsuario.Text;
            string puerto = tbPuerto.Text;
            string baseDatos = tbBaseDatos.Text;
            if (servidor.Equals("") || contrasena.Equals("") || usuario.Equals("") || puerto.Equals("") || baseDatos.Equals(""))
            {
                MessageBox.Show("No puede haber campos vacíos");
            }
            else
            {
                Conexion conectar = new Conexion();
                OdbcDataAdapter dat = new OdbcDataAdapter("SELECT TOP 1" + "\"CardCode\"," + "\"CardName\"," + "\"CardType\"," + "\"Address\"," + "\"ZipCode\"," + "\"MailAddres\"," + "\"MailZipCod\"," + "\"Phone1\" FROM " + "\""+baseDatos+"\"." + "\"OCRD\" WHERE " + "\"CardType\" = 'S' ", conectar.ConnectionHANA(servidor, usuario, contrasena, puerto));
                DataSet ds = new DataSet();
                dat.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}

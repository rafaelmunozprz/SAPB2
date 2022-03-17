using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace SAPB2
{
    internal class Conexion
    {
        /**
         * public OdbcConnectionSQL()
         * Recibe los parámetros de conexión mediante ODBC
         *      Servidor
         *      Base de datos
         *      Usuario
         *      Contrasena     
         *  Devuelve el estado de la conexión
         */
        public OdbcConnection ConnectionSQL(string servidor, string baseDatos, string usuario, string contrasena)
        {
            string cadenaConexion = "Driver={SQL Server};Server="+servidor+";Database="+baseDatos+";Uid="+usuario+";Pwd="+contrasena+";";
            OdbcConnection conexion = new OdbcConnection(cadenaConexion);
            try
            {
                conexion.Open();
            }
            catch (OdbcException)
            {
                MessageBox.Show("No se ha podido establecer la conexión");
            }
            return conexion;
        }

        /**
         * public OdbcConnection ConnectionHANA()
         * Recibe los parámetros de conexión mediante ODBC
         *      Servidor
         *      Usuario
         *      Contrasena 
         *      Puerto
         *  Devuelve el estado de la conexión
         */
        public OdbcConnection ConnectionHANA(string servidor, string usuario, string contrasena, string puerto)
        {
            string cadenaConexion = "DRIVER={HDBODBC};UID="+usuario+";PWD=" + contrasena + ";SERVERNODE="+servidor+":"+puerto+";";
            OdbcConnection conexion = new OdbcConnection(cadenaConexion);
            try
            {
                conexion.Open();
            }
            catch (OdbcException)
            {
                MessageBox.Show("No se ha podido establecer la conexión");
            }
            return conexion;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Configuracion;
using MySql.Data.MySqlClient;
using EntidadesDirectorio;

namespace AccesoDatos
{
    public class AccesoDatosLogin
    {
        public int IniciarSesion(string pvc_Correo, string pvc_Password)
        {
            //Variables
            int vln_ID=-1;
            MySqlDataReader vlo_DataReader;
            MySqlConnection Conexion = new MySqlConnection();
            Conexion.ConnectionString = ClsConfiguracion.GetLoginString();
            MySqlCommand Command;
            string vlc_SentenciaSQL=string.Empty;
            //Inicio
            try
            {
                Command = new MySqlCommand();
                Command.Connection = Conexion;
                vlc_SentenciaSQL = "SELECT CORREO, CONTRASENIA, ID_USUARIO FROM LOGIN_PAGINA_WEB.LOGIN WHERE CORREO='" + pvc_Correo + "' AND CONTRASENIA LIKE BINARY'" + pvc_Password + "%'";
                Command.CommandText = vlc_SentenciaSQL;

                Conexion.Open();
                vlo_DataReader = Command.ExecuteReader();

                if (vlo_DataReader.HasRows)
                {
                    vlo_DataReader.Read();
                    vln_ID = vlo_DataReader.GetInt32(2);
                }
                Conexion.Close();
                Command.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexion.Dispose();
            }
            return vln_ID;
        }

        public int Registrar(string pvc_Password, ClsUsuarios pvo_Usuario)
        {
            //Variables
            int vln_ID = 0;


            //Inicio

            return vln_ID;
        }
    }
}

using Configuracion;
using EntidadesDirectorio;
using MySql.Data.MySqlClient;
using System;

namespace AccesoDatos
{
    public class AccesoDatosLogin
    {
        public int IniciarSesion(string pvc_Correo, string pvc_Password)
        {
            //Variables
            int vln_ID = -1;
            MySqlDataReader vlo_DataReader;
            MySqlConnection Conexion = new MySqlConnection
            {
                ConnectionString = ClsConfiguracion.GetLoginString()
            };
            MySqlCommand Command;
            string vlc_SentenciaSQL = string.Empty;
            //Inicio
            try
            {
                Command = new MySqlCommand
                {
                    Connection = Conexion
                };
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
            ClsUsuarios vlo_Usuario = new ClsUsuarios();
            MySqlConnection ConexionLogin;
            MySqlConnection ConexionOagina;
            MySqlCommand CommandLogin;
            MySqlCommand CommandPagina;
            MySqlDataReader ReaderLogin;
            string vlc_SentenciaLogin = string.Empty;
            string vlc_SentenciaPagina = string.Empty;
            //Inicio
            try
            {
                ConexionLogin = new MySqlConnection
                {
                    ConnectionString = ClsConfiguracion.GetLoginString()
                };
                CommandLogin = new MySqlCommand
                {
                    Connection = ConexionLogin
                };

                vlc_SentenciaLogin = "SELECT CORREO, CONTRASENIA, ID_USUARIO FROM LOGIN_PAGINA_WEB.LOGIN WHERE CORREO='" + pvo_Usuario.Correo + "'";
                CommandLogin.CommandText = vlc_SentenciaLogin;

                ConexionLogin.Open();
                ReaderLogin = CommandLogin.ExecuteReader();
                ConexionLogin.Close();
                CommandLogin.Dispose();
                ConexionLogin.Dispose();

                if (ReaderLogin.HasRows)
                {
                    try
                    {
                        ConexionOagina = new MySqlConnection();
                        ConexionOagina.ConnectionString = ClsConfiguracion.getConnectionString();
                        CommandPagina = new MySqlCommand();
                        CommandPagina.Connection = ConexionOagina;

                        vlc_SentenciaPagina = "SP_REGISTRAR_Y_ACTUALIZAR_USUARIO";
                        CommandPagina.Parameters.AddWithValue("",);
                        CommandPagina.Parameters.AddWithValue("",);
                        CommandPagina.Parameters.AddWithValue("",);
                        CommandPagina.Parameters.AddWithValue("",);
                        CommandPagina.Parameters.AddWithValue("",);
                        CommandPagina.Parameters.AddWithValue("",);
                        CommandPagina.Parameters.AddWithValue("",);
                        ConexionOagina.Open();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {
                    vln_ID = -2;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
            return vln_ID;
        }
    }
}

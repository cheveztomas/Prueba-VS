using System;
using System.Collections.Generic;
using System.Data;

using Configuracion;
using EntidadesDirectorio;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class AccesoDatosWebSites
    {
        #region Atributos
        string vgc_CadenaConexion;
        #endregion

        #region Constructores
        public AccesoDatosWebSites()
        {
            //vgc_CadenaConexion = string.Empty;
            vgc_CadenaConexion = ClsConfiguracion.getConnectionString();
        }
        // Constructor que recibe la cadena como parametro
        public AccesoDatosWebSites(string pvc_CadenaConeccion)
        {
            vgc_CadenaConexion = pvc_CadenaConeccion;
        }
        #endregion

        #region Metodos
        public string Guardar(ClsWebSites pvo_EntidadWebSite)
        {
            MySqlConnection vlo_sqlConexion = new MySqlConnection(vgc_CadenaConexion);
            MySqlCommand vlo_sqlCommand = new MySqlCommand();
            //int vln_resultado = 0;
            string vlc_Mensaje = "";
            string vlc_Sentencia = string.Empty; //tambien puede usar ""
            vlo_sqlCommand.Connection = vlo_sqlConexion;

            vlc_Sentencia = "SP_AgregarSitioWeb";
            vlo_sqlCommand.CommandType = CommandType.StoredProcedure;
            vlo_sqlCommand.Parameters.AddWithValue("@_cod_sitio", pvo_EntidadWebSite.Cod_Sitio);
            //vlo_sqlCommand.Parameters["@_cod_sitio"].Direction = ParameterDirection.InputOutput;
            vlo_sqlCommand.Parameters.AddWithValue("@_id", pvo_EntidadWebSite.ID_Usuario);
            vlo_sqlCommand.Parameters.AddWithValue("@_url", pvo_EntidadWebSite.URL_Sitio);
            vlo_sqlCommand.Parameters.AddWithValue("@_nombre", pvo_EntidadWebSite.Nombre_Sitio);
            vlo_sqlCommand.Parameters.Add("@_msj", MySqlDbType.VarChar, 100);
            vlo_sqlCommand.Parameters["@_msj"].Direction = ParameterDirection.Output;

            vlo_sqlCommand.CommandText = vlc_Sentencia;

            try
            {
                vlo_sqlConexion.Open();
                vlo_sqlCommand.ExecuteNonQuery();
                //pvo_EntidadWebSite.Cod_Sitio = Convert.ToInt32(vlo_sqlCommand.Parameters["@_cod_sitio"].Value);
                vlc_Mensaje = Convert.ToString(vlo_sqlCommand.Parameters["@_msj"].Value);
                vlo_sqlConexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                vlo_sqlConexion.Dispose();
                vlo_sqlCommand.Dispose();
            }
            return vlc_Mensaje;
        }

        public string Borrar(string pvc_Codigo)
        {
            MySqlConnection vlo_sqlConexion = new MySqlConnection(vgc_CadenaConexion);
            MySqlCommand vlo_sqlCommand = new MySqlCommand();
            string vlc_Mensaje = "";
            string vlc_Sentencia = string.Empty;
            vlo_sqlCommand.Connection = vlo_sqlConexion;

            vlc_Sentencia = "SP_EliminarSitiosWeb";
            vlo_sqlCommand.CommandType = CommandType.StoredProcedure;
            vlo_sqlCommand.Parameters.AddWithValue("@_cod_sitio", pvc_Codigo);
            vlo_sqlCommand.Parameters.Add("@_msj", MySqlDbType.VarChar, 100);
            vlo_sqlCommand.Parameters["@_msj"].Direction = ParameterDirection.Output;

            vlo_sqlCommand.CommandText = vlc_Sentencia;

            try
            {
                vlo_sqlConexion.Open();
                vlo_sqlCommand.ExecuteNonQuery();
                vlc_Mensaje = Convert.ToString(vlo_sqlCommand.Parameters["@_msj"].Value);
                vlo_sqlConexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                vlo_sqlConexion.Dispose();
                vlo_sqlCommand.Dispose();
            }
            return vlc_Mensaje;
        }
        #endregion
    }
}

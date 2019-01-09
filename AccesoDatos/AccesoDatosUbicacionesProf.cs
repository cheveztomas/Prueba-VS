using System;
using System.Collections.Generic;
using System.Data;

using Configuracion;
using EntidadesDirectorio;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class AccesoDatosUbicacionesProf
    {
        #region Atributos
        string vgc_CadenaConexion;
        #endregion

        #region Constructores
        public AccesoDatosUbicacionesProf()
        {
            //vgc_CadenaConexion = string.Empty;
            vgc_CadenaConexion = ClsConfiguracion.getConnectionString();
        }
        // Constructor que recibe la cadena como parametro
        public AccesoDatosUbicacionesProf(string pvc_CadenaConeccion)
        {
            vgc_CadenaConexion = pvc_CadenaConeccion;
        }
        #endregion

        #region Metodos
        public DataSet ListarRegistros(string pvc_Condicion)
        {
            DataSet vlo_DataSet = new DataSet();
            MySqlConnection vlo_Conexion = new MySqlConnection(vgc_CadenaConexion);
            MySqlDataAdapter vlo_DataAdapter;
            string vlc_Sentencia = string.Empty;

            vlc_Sentencia = "SELECT ID_USUARIO,PROVINCIA,CANTON,DETALLES FROM UBICACIONES_PROFESIONALES" +
                " INNER JOIN UBICACIONES ON UBICACIONES_PROFESIONALES.ID_UBICACION=UBICACIONES.ID_UBICACION";
            if (!string.IsNullOrEmpty(pvc_Condicion))
            {
                vlc_Sentencia = string.Format("{0} WHERE {1}", vlc_Sentencia, pvc_Condicion);
            }

            try
            {
                vlo_DataAdapter = new MySqlDataAdapter(vlc_Sentencia, vlo_Conexion);
                vlo_DataAdapter.Fill(vlo_DataSet, "UbicacionesProf"); // nombre de la tabla encontrada
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                vlo_Conexion.Dispose();
            }
            return vlo_DataSet;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using Configuracion;
using EntidadesDirectorio;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class AccesoDatosOcupaciones
    {

        public DataTable obteberOcupaciones()
        {
            DataTable ocupaciones = new DataTable();
            //se crea el objeto conection y se establece la conexion 
            MySqlConnection conection = new MySqlConnection();
            conection.ConnectionString = ClsConfiguracion.getConnectionString();
            MySqlDataAdapter dataAdapter;
            try
            {
                //se solicitan los nombres de ocupacion de la base de datos 
                MySqlCommand sentencia = new MySqlCommand("SELECT NOMBRE_OCUPACION FROM OCUPACIONES GROUP BY NOMBRE_OCUPACION");

                conection.Open();
                sentencia.Connection = conection;
                //se llena la tabla local con los datos obtenidos
                dataAdapter = new MySqlDataAdapter(sentencia);

                dataAdapter.Fill(ocupaciones);
                //se cierra la coneccion y sew destrullen los objetos 
                conection.Close();
                dataAdapter.Dispose();
                sentencia.Dispose();
                conection.Dispose();
                //se retornan las provincias 
                return ocupaciones;
            }
            catch (Exception)
            {

                throw;
            }
        }//obtener ocupaciones 

        public DataTable obtenerEspecialidad(string ocupacion)
        {

            DataTable especialidades = new DataTable();
            //se crea el objeto conection y se establece la conexion 
            MySqlConnection conection = new MySqlConnection();
            conection.ConnectionString = ClsConfiguracion.getConnectionString();
            MySqlDataAdapter dataAdapter;
            try
            {
                //se solicitan las especialidades de la base de datos 
                MySqlCommand sentencia = new MySqlCommand("SELECT ESPACIALIDAD_OCUPACION FROM OCUPACIONES WHERE NOMBRE_OCUPACION = " + "\"" + ocupacion + "\"");

                conection.Open();
                sentencia.Connection = conection;

                dataAdapter = new MySqlDataAdapter(sentencia);

                dataAdapter.Fill(especialidades);
                //se cierra la coneccion y sew destrullen los objetos 
                conection.Close();
                dataAdapter.Dispose();
                sentencia.Dispose();
                conection.Dispose();
                //se retornan las especialidades 
                return especialidades;
            }
            catch (Exception)
            {

                throw;
            }





        }

        //obtener lista de ocupaciones de un profecional 


        public DataTable listaOcupaciones(int id) {

            DataTable list_Ocupaciones = new DataTable();
            //Se establece el objeto conexión
            MySqlConnection conexion = new MySqlConnection();
            //Captura la cadena de conexión
            conexion.ConnectionString = ClsConfiguracion.getConnectionString();
            MySqlDataAdapter dataAdapter;

            try
            {
                MySqlCommand sentencia = new MySqlCommand("select ocupaciones.ID_OCUPACION, concat(ocupaciones.NOMBRE_OCUPACION,' ',ocupaciones.ESPACIALIDAD_OCUPACION) as PROFESION from ocupaciones inner join ocupaciones_profesionales on ocupaciones.ID_OCUPACION = ocupaciones_profesionales.ID_OCUPACION where ocupaciones_profesionales.ID_USUARIO = "+id+";");
                conexion.Open();
                sentencia.Connection = conexion;

                dataAdapter = new MySqlDataAdapter(sentencia);

                //se guarda el resultado de la sentencia en la tabla list_Ocupaciones
                dataAdapter.Fill(list_Ocupaciones);

                //cerrar conexión
                conexion.Close();
                dataAdapter.Dispose();
                sentencia.Dispose();
                conexion.Dispose();

                //Retorna la lista de ocupaciones 
                return list_Ocupaciones;
            }
            catch (Exception)
            {

                throw;
            }

        }






    }//class
}//namespace

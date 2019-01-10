using Configuracion;
using EntidadesDirectorio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AccesoDatos
{
    public class AccesoDatosUsuario
    {
        //Este metodo retorna una lista de usuarios.
        public DataTable listaUsuarios(string condition)
        {
            //Se establese una variable para retornar una tabla.
            DataTable vlo_ListaUsuarios = new DataTable();

            //Se establese una variable de conexión instanciando la conexion de MySQL
            MySqlConnection conexion = new MySqlConnection();

            //Se establese la cadena de conexión obteniendola de la configuración.
            conexion.ConnectionString = ClsConfiguracion.getConnectionString();

            //Se establese una variable de comandos.
            MySqlCommand command;

            //Se establese una variable de tipo data adapter.
            MySqlDataAdapter vlo_DA;

            try
            {
                //Se abre la conexión.
                conexion.Open();

                //Se instancia el comando con la sentencia.
                command = new MySqlCommand("SELECT * FROM USUARIOS");

                //Se establese la conexión.
                command.Connection = conexion;
                //command.CommandType = System.Data.CommandType.Text;
                //command.CommandText = "SELECT * FROM USUARIOS";

                //Se instancia el data adpter con el comando.
                vlo_DA = new MySqlDataAdapter(command);

                //Se rellena la tabla 
                vlo_DA.Fill(vlo_ListaUsuarios);

                vlo_DA.Dispose();
                conexion.Close();
                command.Dispose();
                conexion.Dispose();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("error, " + ex.Message.ToString());
            }

            return vlo_ListaUsuarios;
        }

        public int InsertarUsuario(ClsUsuarios pvo_Usuario, ClsUbicaciones pvo_Ubicaciones, ClsOcupaciones pvo_Ocupaciones, ClsOcupacionesProfesionales pvo_OcupacionesProfesionales, ClsWebSites pvo_Sitio)
        {
            //Variables
            int vln_Correcta = 0;
            string NombreSP = string.Empty;

            //Se instancia la conexión.
            MySqlConnection Conexion = new MySqlConnection();
            Conexion.ConnectionString = ClsConfiguracion.getConnectionString();

            //Se declara el command
            MySqlCommand Command;

            //Inicio
            try
            {
                //Se llama el procedimiento almacenado.
                NombreSP = "call pagina_web.REGISTRAR_Y_ACTUALIZARINFO_USUARIOS(?,?,?,?,?,?,?,?,?,?,?,?,?);";

                //Se abre la conexión
                Conexion.Open();

                //Se termina de instanciar el command con el procedimiento almacenado
                Command = new MySqlCommand(NombreSP);

                //Se establese la conexión.
                Command.Connection = Conexion;

                //Parametros necesarios de la aplicación.
                Command.Parameters.AddWithValue("_ID_USUARIOS", pvo_Usuario.ID_Usuario);
                Command.Parameters.AddWithValue("_NOMBRE", pvo_Usuario.Nombre_Profesional);
                Command.Parameters.AddWithValue("_APELLIDO1", pvo_Usuario.Apellido1_Profesional);
                Command.Parameters.AddWithValue("_APELLIDO2",pvo_Usuario.Apellido2_Profesional);
                Command.Parameters.AddWithValue("_CORREO",pvo_Usuario.Telefono_Profesional);
                Command.Parameters.AddWithValue("_TELEFONO",pvo_Usuario.Telefono_Profesional);
                Command.Parameters.AddWithValue("_DESCIRPCION",pvo_Usuario.Descripcion);
                Command.Parameters.AddWithValue("_USUARIO_PREMIUM",pvo_Usuario.Usuario_Premium);
                Command.Parameters.AddWithValue("_ES_PROFESIONAL",pvo_Usuario.Perfil_Profesional);
                Command.Parameters.AddWithValue("_ID_OCUPACION",pvo_Ocupaciones.ID_Ocupacion);
                Command.Parameters.AddWithValue("_ID_UBICACION",pvo_Ubicaciones.ID_Ubicacion);
                Command.Parameters.AddWithValue("_DETALLE_UBICACION",pvo_OcupacionesProfesionales.Detalles);
                Command.Parameters.AddWithValue("_URL_SITIO",pvo_Sitio.URL_Sitio);
                Command.Parameters.AddWithValue("_NOMBRE_SITIO",pvo_Sitio.Nombre_Sitio);

                vln_Correcta = Command.ExecuteNonQuery();
                Conexion.Close();
                Conexion.Dispose();
                Command.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return vln_Correcta;
        }

        //proceso para eliminar usuario de la base de datos
        public int EliminarUsuario(int id_usuario)
        {
            //Variables
            int vln_Correcta = 0;
            string NombreSP = string.Empty;
            string Msg = string.Empty;

            //Se instancia la conexión.
            MySqlConnection Conexion = new MySqlConnection();
            Conexion.ConnectionString = ClsConfiguracion.getConnectionString();

            //Se declara el command
            MySqlCommand Command;

            //Inicio
            try
            {
                //Se llama el procedimiento almacenado.
                NombreSP = "call pagina_web.SP_EliminarUsuario(?,?);";

                //Se abre la conexión
                Conexion.Open();

                //Se termina de instanciar el command con el procedimiento almacenado
                Command = new MySqlCommand(NombreSP);

                //Se establese la conexión.
                Command.Connection = Conexion;

                //Parametros necesarios de la aplicación.
                Command.Parameters.AddWithValue("_id", id_usuario);
                Command.Parameters.AddWithValue("msj", Msg);

                vln_Correcta = Command.ExecuteNonQuery();
                Conexion.Close();
                Conexion.Dispose();
                Command.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return vln_Correcta;
        }
        //funcion para obtener datos de la tabla usuario
        public DataTable ObtenerDatosDeUsuario(int id_usuario)
        {
            //Se establese una variable para retornar una tabla.
            DataTable vlo_DatosUsuario = new DataTable();

            //Se establese una variable de conexión instanciando la conexion de MySQL
            MySqlConnection conexion = new MySqlConnection();

            //Se establese la cadena de conexión obteniendola de la configuración.
            conexion.ConnectionString = ClsConfiguracion.getConnectionString();

            //Se establese una variable de comandos.
            MySqlCommand command;

            //Se establese una variable de tipo data adapter.
            MySqlDataAdapter vlo_DA;

            try
            {
                //Se abre la conexión.
                conexion.Open();

                //Se instancia el comando con la sentencia.
                command = new MySqlCommand("SELECT * FROM USUARIOS WHERE ID_USUARIO="+ id_usuario);

                //Se establese la conexión.
                command.Connection = conexion;

                //Se instancia el data adpter con el comando.
                vlo_DA = new MySqlDataAdapter(command);

                //Se rellena la tabla 
                vlo_DA.Fill(vlo_DatosUsuario);

                vlo_DA.Dispose();
                conexion.Close();
                command.Dispose();
                conexion.Dispose();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("error, " + ex.Message.ToString());
            }

            return vlo_DatosUsuario;
        }

    }//class
}//namespace

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
                command = new MySqlCommand("SELECT ID_USUARIO, NOMBRE_PROFESIONAL, APELLIDO1_PROFESIONAL, APELLIDO2_PROFESIONAL, CORREO_PROFESIONAL, TELEFONO_PROFESIONAL, DESCRIPCION, USUARIO_PREMIUM, CALIFIC_CONTADOR, CALIFIC_SUMA, PERFIL_PROFESIONAL FROM PAGINA_WEB.USUARIOS;");

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

        public int InsertarUsuario(ClsUsuarios pvo_Usuario)
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
                NombreSP = "call pagina_web.SP_REGISTRAR_Y_ACTUALIZAR_USUARIO(?,?,?,?,?,?,?,?,?);";

                //Se abre la conexión
                Conexion.Open();

                //Se termina de instanciar el command con el procedimiento almacenado
                Command = new MySqlCommand(NombreSP);

                //Se establese la conexión.
                Command.Connection = Conexion;

                //Parametros necesarios de la aplicación.
                Command.Parameters["_ID_USUARIO"].Direction = ParameterDirection.InputOutput;
                Command.Parameters.AddWithValue("_ID_USUARIO", pvo_Usuario.ID_Usuario);
                Command.Parameters.AddWithValue("_NOMBRE", pvo_Usuario.Nombre_Profesional);
                Command.Parameters.AddWithValue("_APELLIDO1", pvo_Usuario.Apellido1_Profesional);
                Command.Parameters.AddWithValue("_APELLIDO2",pvo_Usuario.Apellido2_Profesional);
                Command.Parameters.AddWithValue("_CORREO",pvo_Usuario.Telefono_Profesional);
                Command.Parameters.AddWithValue("_TELEFONO",pvo_Usuario.Telefono_Profesional);
                Command.Parameters.AddWithValue("_DESCIRPCION",pvo_Usuario.Descripcion);
                Command.Parameters.AddWithValue("_USUARIO_PREMIUM",pvo_Usuario.Usuario_Premium);
                Command.Parameters.AddWithValue("_ES_PROFESIONAL",pvo_Usuario.Perfil_Profesional);
                Command.Parameters.Add("@_msj", MySqlDbType.VarChar, 100);
                Command.Parameters["@_msj"].Direction = ParameterDirection.Output;

                vln_Correcta = Command.ExecuteNonQuery();
                pvo_Usuario.ID_Usuario = Convert.ToInt32(Command.Parameters["_ID_USUARIO"].Value);
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
        public ClsUsuarios ObtenerDatosDeUsuario(int id_usuario)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = ClsConfiguracion.getConnectionString();
            MySqlCommand command= new MySqlCommand();
            MySqlDataReader vlo_RD;
            ClsUsuarios vlo_usuario = new ClsUsuarios();

            try
            {
                //Se establese la conexión.
                command.Connection = conexion;
                command.CommandText = "SELECT NOMBRE_PROFESIONAL,APELLIDO1_PROFESIONAL,APELLIDO2_PROFESIONAL,CORREO_PROFESIONAL,TELEFONO_PROFESIONAL,DESCRIPCION,USUARIO_PREMIUM,CALIFIC_CONTADOR,CALIFIC_SUMA,PERFIL_PROFESIONAL FROM USUARIOS WHERE ID_USUARIO=" + id_usuario;
                conexion.Open();
                vlo_RD = command.ExecuteReader();

                if (vlo_RD.HasRows)
                {
                    vlo_RD.Read();
                    vlo_usuario.Nombre_Profesional= vlo_RD.GetString(0);
                    vlo_usuario.Apellido1_Profesional = vlo_RD.GetString(1);
                    vlo_usuario.Usuario_Premium = vlo_RD.GetBoolean(6);
                    vlo_usuario.Perfil_Profesional = vlo_RD.GetBoolean(9);
                    vlo_usuario.Telefono_Profesional = vlo_RD.GetString(4);
                    if (!vlo_RD.IsDBNull(2))
                    {
                        vlo_usuario.Apellido2_Profesional = vlo_RD.GetString(2);
                    }
                    if (!vlo_RD.IsDBNull(3))
                    {
                        vlo_usuario.Correo = vlo_RD.GetString(3);
                    }
                    if (!vlo_RD.IsDBNull(5))
                    {
                        vlo_usuario.Descripcion = vlo_RD.GetString(5);
                    }
                    if (!vlo_RD.IsDBNull(7))
                    {
                        vlo_usuario.Calif_Contador = vlo_RD.GetInt32(7);
                    }
                    if (!vlo_RD.IsDBNull(8))
                    {
                        vlo_usuario.Calif_Suma = vlo_RD.GetInt32(8);
                    }
                }
                vlo_RD.Dispose();
                conexion.Close();
                command.Dispose();
                conexion.Dispose();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("error, " + ex.Message.ToString());
            }

            return vlo_usuario;
        }
    }//class
}//namespace

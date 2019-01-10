using AccesoDatos;
using EntidadesDirectorio;
using System;
using System.Data;

namespace CapaLogica
{
    public class LogicaUsuario
    {


        public DataTable listaUsuarios(string condition)
        {
            AccesoDatosUsuario accesoDatosUsuario = new AccesoDatosUsuario();
            DataTable lista = null;
            try
            {
                lista = accesoDatosUsuario.listaUsuarios(condition);
            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }

        //Guarda o Actualiza un usuario
        public int IngresarUsuario(ClsUsuarios pvo_Usuario)
        {
            //Variables
            int vln_Correcto = 0;

            //Inicio
            AccesoDatosUsuario vlo_ADUsuario = new AccesoDatosUsuario();

            try
            {
                vln_Correcto = vlo_ADUsuario.InsertarUsuario(pvo_Usuario);
            }
            catch (Exception)
            {

                throw;
            }

            return vln_Correcto;
        }

        //Guarda o Actualiza un usuario
        public int IngresarUsuario(int vgn_ID_Usuario, string vgc_Nombre_Profesional, string vgc_Apellido1_Profesional, string vgc_Apellido2_Profesional, string vgc_correo, string vgc_Telefono_Profesional, string vgc_Descripcion, bool vgb_Usuario_Premium, int vgn_Calif_Contador, int vgn_Calif_Suma, bool vgb_Perfil_Profesional)
        {
            //Variables
            int vln_Correcto = 0;
            ClsUsuarios pvo_Usuario = new ClsUsuarios(vgn_ID_Usuario, vgc_Nombre_Profesional, vgc_Apellido1_Profesional, vgc_Apellido2_Profesional, vgc_correo, vgc_Telefono_Profesional, vgc_Descripcion, vgb_Usuario_Premium, vgn_Calif_Contador, vgn_Calif_Suma, vgb_Perfil_Profesional);
            //Inicio
            AccesoDatosUsuario vlo_ADUsuario = new AccesoDatosUsuario();

            try
            {
                vln_Correcto = vlo_ADUsuario.InsertarUsuario(pvo_Usuario);
            }
            catch (Exception)
            {

                throw;
            }

            return vln_Correcto;
        }

        //Elimina un usuario
        public int EliminarUsuario(int id_usuario)
        {
            //Variables
            int vln_Correcto = 0;
            //Inicio
            AccesoDatosUsuario vlo_ADUsuario = new AccesoDatosUsuario();

            try
            {
                vln_Correcto = vlo_ADUsuario.EliminarUsuario(id_usuario);
            }
            catch (Exception)
            {

                throw;
            }

            return vln_Correcto;
        }

        public DataTable ObtenerDatosDeUsuario(int id_usuario)
        {
            AccesoDatosUsuario accesoDatosUsuario = new AccesoDatosUsuario();
            DataTable DatosUsuario = null;
            try
            {
                DatosUsuario = accesoDatosUsuario.ObtenerDatosDeUsuario(id_usuario);
            }
            catch (Exception)
            {

                throw;
            }

            return DatosUsuario;
        }

    }//class
}//namespace

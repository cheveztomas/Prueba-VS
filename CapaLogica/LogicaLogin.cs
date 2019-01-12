using System;
using System.Collections.Generic;
using System.Text;
using AccesoDatos;
using EntidadesDirectorio;

namespace CapaLogica
{
    public class LogicaLogin
    {
        public int IniciarSesion(string pvc_Correo, string pvc_Password)
        {
            //Variables
            int vln_ID=0;
            AccesoDatosLogin vlo_Login;

            //Inicio
            try
            {
                vlo_Login = new AccesoDatosLogin();
                vln_ID = vlo_Login.IniciarSesion(pvc_Correo, pvc_Password);
            }
            catch (Exception)
            {

                throw;
            }

            return vln_ID;
        }

        public int RegistrarUsuario(string pvc_Password, ClsUsuarios pvo_Usuario)
        {
            //Variables
            int vln_ID=0;
            AccesoDatosLogin Login;

            //Inicio
            try
            {
                Login = new AccesoDatosLogin();
                vln_ID=Login.Registrar(pvc_Password, pvo_Usuario);
            }
            catch (Exception)
            {

                throw;
            }
            return vln_ID;
        }

        public int EnviarCorreo(string pvc_Correo, string pvc_NombreDestinatario, string pvc_Mensaje)
        {
            //Variables
            int vln_Correcto=0;
            AccesoDatosLogin Login = new AccesoDatosLogin();

            //Inicio
            try
            {
                vln_Correcto = Login.EnviarCorreo(pvc_Correo,pvc_NombreDestinatario,pvc_Mensaje);
            }
            catch (Exception)
            {

                throw;
            }
            return vln_Correcto;
        }
    }
}

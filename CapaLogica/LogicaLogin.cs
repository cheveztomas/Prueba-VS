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

            }
            catch (Exception)
            {

                throw;
            }
            return vln_ID;
        }
    }
}

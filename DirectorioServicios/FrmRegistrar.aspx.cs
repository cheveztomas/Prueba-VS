using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;
using EntidadesDirectorio;

namespace DirectorioServicios
{
    public partial class FrmRegistrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Registro()
        {
            //Varaibles
            int vln_ID = 0;
            string Contrasenia=string.Empty;
            LogicaLogin LogicaLog = new LogicaLogin();
            ClsUsuarios Usuario = new ClsUsuarios();

            //Inicio
            try
            {
                Usuario.Apellido1_Profesional = Txt_Apellido1.Text;
                Usuario.Apellido2_Profesional = Txt_Apellido2.Text;
                Usuario.Calif_Contador = 0;
                Usuario.Calif_Suma = 0;
                Usuario.Correo = txt_Correo.Text;
                Usuario.Descripcion = Txt_Descipcion.Text;
                Usuario.ID_Usuario = -1;
                Usuario.Nombre_Profesional = txt_Nombre.Text;
                Usuario.Perfil_Profesional = true;
                Usuario.Telefono_Profesional = Txt_Telefono.Text;
                Usuario.Usuario_Premium = false;
                Contrasenia = txt_Conrteasenia.Text;

                vln_ID=LogicaLog.RegistrarUsuario(Contrasenia, Usuario);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
using CapaLogica;
using System;
using System.Web.UI;

namespace DirectorioServicios
{
    public partial class FrmCambiarPass : System.Web.UI.Page
    {
        private int vgn_ID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Limpiar();
                vgn_ID = int.Parse(Session["ID_USUARIO_SESION"].ToString());
            }
        }

        private void Limpiar()
        {
            txt_Conrteasenia.Text = string.Empty;
            txt_ConrteaseniaConfir.Text = string.Empty;
        }

        private int CambiarContrasenia()
        {
            //Variables
            int vln_Correcto = 0;
            LogicaLogin vlo_Login;

            //Inicio
            try
            {
                vlo_Login = new LogicaLogin();
                vln_Correcto = vlo_Login.CambiarContrasenia(txt_Conrteasenia.Text, vgn_ID);
            }
            catch (Exception)
            {

                throw;
            }

            return vln_Correcto;
        }

        protected void btn_Registrar_Click(object sender, EventArgs e)
        {
            //Variables
            int vlc_Correcto = 0;
            try
            {
                vlc_Correcto = CambiarContrasenia();

                if (vlc_Correcto < 0)
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
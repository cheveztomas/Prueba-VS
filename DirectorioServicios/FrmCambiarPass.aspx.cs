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
    }
}
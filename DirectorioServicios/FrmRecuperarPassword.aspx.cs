using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace DirectorioServicios
{
    public partial class FrmRecuerarContraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txt_Correo.Text = string.Empty;
        }

        protected void btn_Recuperar_Click(object sender, EventArgs e)
        {
            LogicaLogin Logica;
            int vln_Correcto = 0;

            //Inicio
            try
            {
                Logica = new LogicaLogin();
                //vln_Correcto=Logica.EnviarCorreo(txt_Correo.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
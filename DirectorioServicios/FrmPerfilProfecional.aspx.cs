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
    public partial class FrmPerfilProfecional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProfesion_Click(object sender, EventArgs e)
        {
            if (txtIdProf.Text!=string.Empty)
            {
                try
                {
                    LogicaOcupaciones list_Ocupaciones = new LogicaOcupaciones();
                    grd_Ocupaciones.DataSource = list_Ocupaciones.Lg_listaOcupaciones(int.Parse(txtIdProf.Text));
                    grd_Ocupaciones.DataBind();
                }
                catch (Exception)
                {
                    throw;
                }
              



            }
        }
    }
}
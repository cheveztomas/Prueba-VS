using CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DirectorioServicios
{
    public partial class FrmPerfilProf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProfesion_Click(object sender, EventArgs e)
        {
            if (txtIdProf.Text != string.Empty)
            {
                try
                {

                    //----------------------> OCUPACIONES
                    LogicaOcupaciones list_Ocupaciones = new LogicaOcupaciones();
                    grd_Ocupaciones.DataSource = list_Ocupaciones.Lg_listaOcupaciones(int.Parse(txtIdProf.Text));
                    grd_Ocupaciones.DataBind();
                    //----------------------> UBICACIONES

                    LogicaUbicacionProf lista_Ubicaciones = new LogicaUbicacionProf();
                    grd_Ubicacion.DataSource = lista_Ubicaciones.ListarUbicacionesProf(int.Parse(txtIdProf.Text));
                    grd_Ubicacion.DataBind();
                    //----------------------> SITIO WEB

                    LogicaWebSites lista_WebSites = new LogicaWebSites();
                    grd_websites.DataSource = lista_WebSites.ListarWebSites(int.Parse(txtIdProf.Text));
                    grd_websites.DataBind();




                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
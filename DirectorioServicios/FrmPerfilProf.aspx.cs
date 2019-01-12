using CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesDirectorio;

namespace DirectorioServicios
{
    public partial class FrmPerfilProf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                cargarUsuario(id);
            }
            
        }

        protected void btnProfesion_Click(object sender, EventArgs e)
        {
            
        }

        public void cargarUsuario(string id)
        {
            try
            {

                //----------------------> OCUPACIONES
                LogicaOcupaciones list_Ocupaciones = new LogicaOcupaciones();
                grd_Ocupaciones.DataSource = list_Ocupaciones.Lg_listaOcupaciones(int.Parse(id));
                grd_Ocupaciones.DataBind();
                //----------------------> UBICACIONES

                LogicaUbicacionProf lista_Ubicaciones = new LogicaUbicacionProf();
                grd_Ubicacion.DataSource = lista_Ubicaciones.ListarUbicacionesProf(int.Parse(id));
                grd_Ubicacion.DataBind();
                //----------------------> SITIO WEB

                LogicaWebSites lista_WebSites = new LogicaWebSites();
                grd_websites.DataSource = lista_WebSites.ListarWebSites(int.Parse(id));
                grd_websites.DataBind();


                LogicaUsuario user = new LogicaUsuario();
                ClsUsuarios usuarioObtenido;
                usuarioObtenido = user.ObtenerDatosDeUsuario(int.Parse(id));
                lblUser.Text = usuarioObtenido.Nombre_Profesional + ' ' + usuarioObtenido.Apellido1_Profesional + ' ' + usuarioObtenido.Apellido2_Profesional;
                lblCorreo.Text = usuarioObtenido.Correo;
                lblTelefono.Text = usuarioObtenido.Telefono_Profesional;
                lblDescripcion.Text = usuarioObtenido.Descripcion;



            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
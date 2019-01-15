using CapaLogica;
using EntidadesDirectorio;
using System;
using System.Web.UI;

namespace DirectorioServicios
{
    public partial class FrmPerfilProfesional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int vgn_ID = int.Parse(Session["ID_USUARIO_SESION"].ToString());
            string vgc_ID = vgn_ID.ToString();

            if (!Page.IsPostBack)
            {
                try
                {
                    Limpiar();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void Limpiar()
        {
            txtApellido1.Text = string.Empty;
            txtApellido2.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtDetalleDireccion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtNombreSitio.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtURL.Text = string.Empty;
            ddlCanton.SelectedIndex = 1;
            ddlProvincia.SelectedIndex = 1;
            ddlEspecialidad.SelectedIndex = 1;
            ddlProfesion.SelectedIndex = 1;


            try
            {
                int vgn_ID = int.Parse(Session["ID_USUARIO_SESION"].ToString());
                string vgc_ID = vgn_ID.ToString();

                llenarProvincias();
                llenarCantones();
                llenarOcupaciones();
                llenarEspecialidades();

                cargarUsuarioModificar(vgc_ID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region dd
        //procedimiento para llenar las provincias 
        public void llenarProvincias(string SelectProvincia = "")
        {
            //se crea una instancia de las funciones de logica
            LogicaUbicacion funciones = new LogicaUbicacion();
            ddlProvincia.DataTextField = "PROVINCIA";//se le dice que en el texto ponga lo que venga en el campo de datos
            try
            {
                ddlProvincia.DataSource = funciones.obtenerProvincias();
                ddlProvincia.DataBind();//se le agrega el sourse a el dropdownlist

                //seleccionar provincia indicada
                if (SelectProvincia != "")
                {
                    ddlProvincia.Items.FindByText(SelectProvincia).Selected = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //procedimiento para llenar el dropdown de cantones 
        public void llenarCantones(string SelectCanton = "")
        {
            //se crea una instancia de las funciones de logica
            LogicaUbicacion funciones = new LogicaUbicacion();
            ddlCanton.DataTextField = "CANTON";//se le dice que en el texto ponga lo que venga en el campo de datos
            ddlCanton.DataValueField = "ID_UBICACION";
            try
            {
                ddlCanton.DataSource = funciones.obtenerCantones(ddlProvincia.Text);
                ddlCanton.DataBind();//se le agrega el sourse a el dropdownlist 

                //seleccionar canton indicado
                if (SelectCanton != "")
                {
                    ddlCanton.Items.FindByText(SelectCanton).Selected = true;
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void llenarOcupaciones(string SelectProfecion = "")
        {
            //se crea una instancia de las funciones de logica
            LogicaOcupaciones funciones = new LogicaOcupaciones();
            ddlProfesion.DataTextField = "NOMBRE_OCUPACION";//se le dice que en el texto ponga lo que venga en el campo de datos
            try
            {
                ddlProfesion.DataSource = funciones.obtenerOcupaciones();
                ddlProfesion.DataBind();//se le agrega el sourse a el dropdownlist 

                //seleccionar profecion indicada
                if (SelectProfecion != "")
                {
                    ddlProfesion.Items.FindByText(SelectProfecion).Selected = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void llenarEspecialidades(string SelectEspecialidad = "")
        {
            //se crea una instancia de las funciones de logica
            LogicaOcupaciones funciones = new LogicaOcupaciones();
            ddlEspecialidad.DataTextField = "ESPACIALIDAD_OCUPACION";//se le dice que en el texto ponga lo que venga en el campo de datos
            try
            {
                ddlEspecialidad.DataSource = funciones.obtenerEspecialidades(ddlProfesion.Text);
                ddlEspecialidad.DataBind();//se le agrega el sourse a el dropdownlist 

                //seleccionar especialidad indicada
                if (SelectEspecialidad != "")
                {
                    ddlEspecialidad.Items.FindByText(SelectEspecialidad).Selected = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //----------------------> OCUPACIONES
        public void CargarGrdOcupaciones(string id)
        {
            LogicaOcupaciones list_Ocupaciones = new LogicaOcupaciones();
            try
            {
                if (list_Ocupaciones.Lg_listaOcupaciones(int.Parse(id)).Rows.Count > 0)
                {
                    grd_Ocupaciones.DataSource = list_Ocupaciones.Lg_listaOcupaciones(int.Parse(id));
                    grd_Ocupaciones.DataBind();
                    grd_Ocupaciones.Visible = true;
                }
                else
                {
                    grd_Ocupaciones.Visible = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        //----------------------> UBICACIONES
        public void CargarGrdUbicaciones(string id)
        {
            LogicaUbicacionProf lista_Ubicaciones = new LogicaUbicacionProf();
            try
            {
                if (lista_Ubicaciones.ObtenerDatosDeUsuarioUbicaciones(int.Parse(id)).Rows.Count > 0)
                {
                    grd_Ubicacion.DataSource = lista_Ubicaciones.ObtenerDatosDeUsuarioUbicaciones(int.Parse(id));
                    grd_Ubicacion.DataBind();
                    grd_Ubicacion.Visible = true;
                }
                else
                {
                    grd_Ubicacion.Visible = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        //----------------------> SITIO WEB
        public void CargarGrdWebSites(string id)
        {
            LogicaWebSites lista_WebSites = new LogicaWebSites();
            try
            {
                if (lista_WebSites.ObtenerDatosDeUsuarioPaginasWeb(int.Parse(id)).Rows.Count > 0)
                {
                    grd_websites.DataSource = lista_WebSites.ObtenerDatosDeUsuarioPaginasWeb(int.Parse(id));
                    grd_websites.DataBind();
                    grd_websites.Visible = true;
                }
                else
                {
                    grd_websites.Visible = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
       
        }

        //----------------------> Usuario
        public void CargarDatosUsuario(string id)
        {
            LogicaUsuario user = new LogicaUsuario();
            ClsUsuarios usuarioObtenido;
            try
            {
                usuarioObtenido = user.ObtenerDatosDeUsuario(int.Parse(id));
                txtNombre.Text = usuarioObtenido.Nombre_Profesional;
                txtApellido1.Text = usuarioObtenido.Apellido1_Profesional;
                txtApellido2.Text = usuarioObtenido.Apellido2_Profesional;
                txtCorreo.Text = usuarioObtenido.Correo;
                txtTelefono.Text = usuarioObtenido.Telefono_Profesional;
                txtDescripcion.Text = usuarioObtenido.Descripcion;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void cargarUsuarioModificar(string id)
        {
            try
            {
                CargarGrdOcupaciones(id);
                CargarGrdUbicaciones(id);
                CargarGrdWebSites(id);
                CargarDatosUsuario(id);
            }
            catch (Exception)
            {
                //TODO: Mensaje de error
                throw;
            }
        }
        #endregion

        protected void ddlProfesion_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarEspecialidades();
        }

        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCantones();
        }

        //----------------------> Ubicaciones Guardar
        protected void btnGuardarUbicacion_Click(object sender, EventArgs e)
        {
            LogicaUbicacionProf Ubicacion = new LogicaUbicacionProf();
            ClsUbicacionesProfesionales nuevaUbicacion = new ClsUbicacionesProfesionales();
            nuevaUbicacion.ID_Usuario = int.Parse(Session["ID_USUARIO_SESION"].ToString());
            nuevaUbicacion.ID_Ubicacion1 = int.Parse(ddlCanton.SelectedValue);
            nuevaUbicacion.Detalles = txtDetalleDireccion.Text;

            try
            {
                Ubicacion.Guardar(nuevaUbicacion);
                CargarGrdUbicaciones(Session["ID_USUARIO_SESION"].ToString());
            }
            catch (Exception)
            {
                //TODO: Mensaje de error
                throw;
            }
        }

        //-----------------------> ELIMINAR SITIO WEB
        protected void lnkEliminar_Command1(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            string cod_sitio = e.CommandArgument.ToString();
            string msg = string.Empty;
            LogicaWebSites vlo_sitios = new LogicaWebSites();
            try
            {
                msg = vlo_sitios.Borrar(cod_sitio);
                CargarGrdWebSites(Session["ID_USUARIO_SESION"].ToString());
            }
            catch (Exception)
            {
                //TODO: Mensaje de error
                throw;
            }
        }

        protected void btnGuardarSitiosWeb_Click(object sender, EventArgs e)
        {
            //Variables
            string msj = String.Empty;
            LogicaWebSites Logica;
            ClsWebSites Webs = new ClsWebSites();

            //Inicio
            Webs.Cod_Sitio = -1;
            Webs.ID_Usuario = int.Parse(Session["ID_USUARIO_SESION"].ToString());
            Webs.Nombre_Sitio = txtNombreSitio.Text;
            Webs.URL_Sitio = txtURL.Text;
        }
    }
}
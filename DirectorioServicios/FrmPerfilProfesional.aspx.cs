using CapaLogica;
using System;
using System.Web.UI;

namespace DirectorioServicios
{
    public partial class FrmPerfilProfesional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int vgn_ID = int.Parse(Session["ID_USUARIO_SESION"].ToString());

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
                llenarCantones();
                llenarEspecialidades();
                llenarOcupaciones();
                llenarProvincias();
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
            try
            {
                //se crea una instancia de las funciones de logica
                LogicaUbicacion funciones = new LogicaUbicacion();
                ddlProvincia.DataTextField = "PROVINCIA";//se le dice que en el texto ponga lo que venga en el campo de datos
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
            try
            {
                //se crea una instancia de las funciones de logica
                LogicaUbicacion funciones = new LogicaUbicacion();
                ddlCanton.DataTextField = "CANTON";//se le dice que en el texto ponga lo que venga en el campo de datos
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
        {//se crea una instancia de las funciones de logica
            LogicaOcupaciones funciones = new LogicaOcupaciones();
            ddlProfesion.DataTextField = "NOMBRE_OCUPACION";//se le dice que en el texto ponga lo que venga en el campo de datos
            ddlProfesion.DataSource = funciones.obtenerOcupaciones();
            ddlProfesion.DataBind();//se le agrega el sourse a el dropdownlist 

            //seleccionar profecion indicada
            if (SelectProfecion != "")
            {
                ddlProfesion.Items.FindByText(SelectProfecion).Selected = true;
            }
        }

        public void llenarEspecialidades(string SelectEspecialidad = "")
        {
            //se crea una instancia de las funciones de logica
            LogicaOcupaciones funciones = new LogicaOcupaciones();
            ddlEspecialidad.DataTextField = "ESPACIALIDAD_OCUPACION";//se le dice que en el texto ponga lo que venga en el campo de datos
            ddlEspecialidad.DataSource = funciones.obtenerEspecialidades(ddlProfesion.Text);
            ddlEspecialidad.DataBind();//se le agrega el sourse a el dropdownlist 

            //seleccionar especialidad indicada
            if (SelectEspecialidad != "")
            {
                ddlEspecialidad.Items.FindByText(SelectEspecialidad).Selected = true;
            }
        }
        #endregion
    }
}
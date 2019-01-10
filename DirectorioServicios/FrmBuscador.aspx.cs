using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;

namespace DirectorioServicios
{
    public partial class FrmBuscador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //se llaman los procedimientos para llenar los ddl
                llenarProvincias();
                llenarCantones();
                llenarOcupaciones();
                llenarEspecialidades();
            }

        }
        #region llenarddl
        //procedimiento para llenar las provincias 
        public void llenarProvincias()
        {
            try
            {
                //se crea una instancia de las funciones de logica
                LogicaUbicacion funciones = new LogicaUbicacion();
                ddlProvincia.DataTextField = "PROVINCIA";//se le dice que en el texto ponga lo que venga en el campo de datos
                ddlProvincia.DataSource = funciones.obtenerProvincias();
                ddlProvincia.DataBind();//se le agrega el sourse a el dropdownlist 
            }
            catch (Exception)
            {

                throw;
            }


        }
        //procedimiento para llenar el dropdown de cantones 
        public void llenarCantones()
        {
            try
            {
                //se crea una instancia de las funciones de logica
                LogicaUbicacion funciones = new LogicaUbicacion();
                ddlCanton.DataTextField = "CANTON";//se le dice que en el texto ponga lo que venga en el campo de datos
                ddlCanton.DataSource = funciones.obtenerCantones(ddlProvincia.Text);
                ddlCanton.DataBind();//se le agrega el sourse a el dropdownlist 
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void llenarOcupaciones()
        {//se crea una instancia de las funciones de logica
            LogicaOcupaciones funciones = new LogicaOcupaciones();
            ddlProfecion.DataTextField = "NOMBRE_OCUPACION";//se le dice que en el texto ponga lo que venga en el campo de datos
            ddlProfecion.DataSource = funciones.obtenerOcupaciones();
            ddlProfecion.DataBind();//se le agrega el sourse a el dropdownlist 
        }

        public void llenarEspecialidades()
        {
            //se crea una instancia de las funciones de logica
            LogicaOcupaciones funciones = new LogicaOcupaciones();
            ddlEspecialidad.DataTextField = "ESPACIALIDAD_OCUPACION";//se le dice que en el texto ponga lo que venga en el campo de datos
            ddlEspecialidad.DataSource = funciones.obtenerEspecialidades(ddlProfecion.Text);
            ddlEspecialidad.DataBind();//se le agrega el sourse a el dropdownlist 


        }
        #endregion

        protected void ddlProfecion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cuando cambia el index de profecion se cambian las especialidades
            llenarEspecialidades();
        }

        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCantones();
        }
    }
}
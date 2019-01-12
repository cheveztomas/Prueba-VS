using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogica;
using System.Data;

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

        public void cargar_profecionales()
        {
            LogicaUsuario funciones = new LogicaUsuario();
            DataTable vlo_profecionales = funciones.obtenerProfecionales(ddlProfecion.Text, ddlEspecialidad.Text, ddlProvincia.Text, ddlCanton.Text);
            //grd_usuarios.DataSource = funciones.obtenerProfecionales(ddlProfecion.Text,ddlEspecialidad.Text,ddlProvincia.Text,ddlCanton.Text);
            //DataBind();
            //para crear codigo html

            if (vlo_profecionales.Rows.Count>0)
            {
                foreach (DataRow item in vlo_profecionales.Rows)
                {

                    string codigo = "<div class="+"'row'"+"> <div class="+"'col-sm-6'"+"><div class=" + "'card'" + "><div class=" + "'card-body'" + "><h3 class=" + "'card-title'" + ">" + item["NOMBRE_PROFESIONAL"].ToString() + " " + item["APELLIDO1_PROFESIONAL"].ToString() + " " + item["APELLIDO2_PROFESIONAL"].ToString() + "</h3><h5 class=" + "'card-title'" + ">Profesión: " + item["NOMBRE_OCUPACION"].ToString() +" " + item["ESPACIALIDAD_OCUPACION"].ToString() + "</h5><h5 class=" + "'card-title'" + ">Teléfono: " + item["TELEFONO_PROFESIONAL"].ToString() + "</h5><p class=" + "'card-text'" + ">Email: " + item["CORREO_PROFESIONAL"].ToString() + "</p><a id='" + item["ID_USUARIO"].ToString() + "' href = " + "'FrmPerfilProf.aspx?id="+item["ID_USUARIO"].ToString() + "' class=" + "'btn btn-primary'" + ">Ver más</a></div></div></div></div><br />";
                    //codigo += "<b>"+ item["NOMBRE_PROFESIONAL"].ToString()+"</b>  <br>";
                    //codigo += "<br> <button id='button1' runat='server' OnClick='prueba' >Submit</button>";
                    div_test.InnerHtml += codigo;

                }
            }
            else
            {
                div_test.InnerHtml = "<h3 id="+"'contenedor'"+ "class=" + "'text-danger'" + ">No hay registros</h3>";
            }
           
        }

        protected void ddlProfecion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cuando cambia el index de profecion se cambian las especialidades
            llenarEspecialidades();
        }

        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            llenarCantones();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            div_test.InnerHtml = "";
            cargar_profecionales();

        }
    }
}
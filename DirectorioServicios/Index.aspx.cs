using CapaLogica;
using EntidadesDirectorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DirectorioServicios
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {               
                LogicaUsuario logica = new LogicaUsuario();
                Limpiar();
                try
                {
                    grd_usuarios.DataSource = logica.listaUsuarios(null);
                    grd_usuarios.DataBind();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void Limpiar()
        {
            txt_Contrasenia.Text = string.Empty;
            txt_Correo.Text = string.Empty;
            Session.Remove("ID_USUARIO");
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        //Guardar la ocupación
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
        }

        protected void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            //Variables
            int vln_ID=0;
            LogicaLogin vlo_Login = new LogicaLogin();

            //Inicio
            try
            {
                vln_ID = vlo_Login.IniciarSesion(txt_Correo.Text, txt_Contrasenia.Text);
                if (vln_ID>0)
                {
                    Session["ID_USUARIO"] = vln_ID.ToString();
                    Response.Redirect("FrmBuscador.aspx");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
﻿using AccesoDatos;
using EntidadesDirectorio;
using System;
using System.Data;

namespace CapaLogica
{
    public class LogicaUsuario
    {


        public DataTable listaUsuarios(string condition)
        {
            AccesoDatosUsuario accesoDatosUsuario = new AccesoDatosUsuario();
            DataTable lista = null;
            try
            {
                lista = accesoDatosUsuario.listaUsuarios(condition);
            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }


        public int IngresarUsuario(ClsUsuarios pvo_Usuario, ClsUbicaciones pvo_Ubicaciones, ClsOcupaciones pvo_Ocupaciones, ClsOcupacionesProfesionales pvo_OcupacionesProfesionales, ClsWebSites pvo_Sitio)
        {
            //Variables
            int vln_Correcto = 0;

            //Inicio
            AccesoDatosUsuario vlo_ADUsuario = new AccesoDatosUsuario();

            try
            {
                vln_Correcto = vlo_ADUsuario.InsertarUsuario(pvo_Usuario, pvo_Ubicaciones, pvo_Ocupaciones, pvo_OcupacionesProfesionales, pvo_Sitio);
            }
            catch (Exception)
            {

                throw;
            }

            return vln_Correcto;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data;

using AccesoDatos;
using EntidadesDirectorio;

namespace CapaLogica
{
    public class LogicaWebSites
    {
        #region Constructor
        // Constructor vacío
        #endregion

        #region Metodos
        public string Guardar(ClsWebSites pvo_EntidadWebSite)
        {
            string vlc_Mensaje = "";
            AccesoDatosWebSites vlo_AccesoDatosWebSites;

            try
            {
                vlo_AccesoDatosWebSites = new AccesoDatosWebSites();
                vlc_Mensaje = vlo_AccesoDatosWebSites.Guardar(pvo_EntidadWebSite);
            }
            catch (Exception)
            {

                throw;
            }
            return vlc_Mensaje;
        }

        public string Borrar(string pvc_Codigo)
        {
            string vlc_Mensaje = "";
            AccesoDatosWebSites vlo_AccesoDatosWebSites;

            try
            {
                vlo_AccesoDatosWebSites = new AccesoDatosWebSites();
                vlc_Mensaje = vlo_AccesoDatosWebSites.Borrar(pvc_Codigo);
            }
            catch (Exception)
            {

                throw;
            }
            return vlc_Mensaje;
        }
        #endregion
    }
}
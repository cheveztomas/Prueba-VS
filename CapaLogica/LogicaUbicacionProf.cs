using System;
using System.Collections.Generic;
using System.Data;

using AccesoDatos;
using EntidadesDirectorio;

namespace CapaLogica
{
    public class LogicaUbicacionProf
    {
        #region Constructor
        // Constructor vacío
        #endregion

        #region Metodos
        public DataSet ListarUbicacionesProf(string pvc_Condicion)
        {
            DataSet vlo_DSUbicaciones;
            AccesoDatosUbicacionesProf vlo_AccesoDatosUbicaciones;
            try
            {
                vlo_AccesoDatosUbicaciones = new AccesoDatosUbicacionesProf();
                vlo_DSUbicaciones = vlo_AccesoDatosUbicaciones.ListarRegistros(pvc_Condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return vlo_DSUbicaciones;
        }
        #endregion
    }
}

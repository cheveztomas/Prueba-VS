﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using AccesoDatos;

namespace CapaLogica
{
    public class LogicaOcupaciones
    {

        public DataTable obtenerOcupaciones()
        {
            try
            {
                AccesoDatosOcupaciones funciones = new AccesoDatosOcupaciones();
                DataTable ocupaciones = funciones.obteberOcupaciones();
                return ocupaciones;
            }
            catch (Exception)
            {

                throw;
            }



        }




        public DataTable obtenerEspecialidades(string ocupacion)
        {
            //se crea un objeto tabla
            DataTable especialidades = new DataTable();
            //se crea una referencia a el acceso a datos de las ocupaciones  
            AccesoDatosOcupaciones funciones = new AccesoDatosOcupaciones();
            //se obtienen las especialidades de la ocupacion 
            especialidades = funciones.obtenerEspecialidad(ocupacion);
            return especialidades;//se retornan las especialidades 
        }

        public DataTable ObtenerDatosDeUsuarioOcupaciones(int id_usuario)
        {
            try
            {
                AccesoDatosOcupaciones funciones = new AccesoDatosOcupaciones();
                DataTable UsuarioOcupaciones = funciones.ObtenerDatosDeUsuarioOcupaciones(id_usuario);
                return UsuarioOcupaciones;
            }
            catch (Exception)
            {

                throw;
            }



        }



        public DataTable Lg_listaOcupaciones(int id)
        {
            DataTable list_Ocupaciones;
            try
            {
                //DataTable list_Ocupaciones = new DataTable();

                AccesoDatosOcupaciones funciones = new AccesoDatosOcupaciones();
                list_Ocupaciones = funciones.listaOcupaciones(id);
                
            }
            catch (Exception)
            {

                throw;
            }
            return list_Ocupaciones;
        }

    }//class
}//namespace

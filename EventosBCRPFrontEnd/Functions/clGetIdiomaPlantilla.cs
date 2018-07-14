using EventosBCRPFrontEnd.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Functions
{
    public class clGetIdiomaPlantilla
    {
        List<pa_ObtenerListaTextoPlantillaFront_Result> lista;
        List<pa_ObtenerListaPermisosPlantillaFrontPorIDParticipante_Result> listaPermisos;
        public clGetIdiomaPlantilla(object _lista, object _listaPer)
        {
            lista = (List<pa_ObtenerListaTextoPlantillaFront_Result>)_lista;
            listaPermisos = (List<pa_ObtenerListaPermisosPlantillaFrontPorIDParticipante_Result>)_listaPer;
        }

        public string ReadEntityBodyMode( string _CodeID)
        {
            return lista.Where(x => x.CodeID.Trim() == _CodeID).SingleOrDefault().NombrePlantillaFront.ToString();
        }

        public bool ReadEntityEnable(string _CodeID)
        {
            string result = "";
            try
            {
                result = listaPermisos.Where(x => x.CodeID.Trim() == _CodeID).SingleOrDefault().Activado.ToString();
            }
            catch
            {
                result = "true";
            }
            return Convert.ToBoolean(result);
        }
        public bool ReadEntityVisible(string _CodeID)
        {
            string result = "";
            try
            {
                result = listaPermisos.Where(x => x.CodeID.Trim() == _CodeID).SingleOrDefault().Visible.ToString();
            }
            catch
            {
                result = "true";
            }
            return Convert.ToBoolean(result);
        }
    }
}
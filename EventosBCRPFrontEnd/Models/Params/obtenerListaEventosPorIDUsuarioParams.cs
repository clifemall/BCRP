using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
    public class obtenerListaEventosPorIDUsuarioParams
    {
        public int? id_Usuario { get; set; }
        public string codIdioma { get; set; }
    }
}
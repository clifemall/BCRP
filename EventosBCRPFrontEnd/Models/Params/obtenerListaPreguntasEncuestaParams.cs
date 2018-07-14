using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
    public class obtenerListaPreguntasEncuestaParams
    {
        public int id_Evento { get; set; }
        public int id_Participante { get; set; }
        public string codIdioma { get; set; }
    }
}
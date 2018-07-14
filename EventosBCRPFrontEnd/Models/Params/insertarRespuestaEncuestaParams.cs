using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
    public class insertarRespuestaEncuestaParams
    {
        public int id_Participante { get; set; }
        public int id_Pregunta { get; set; } 
        public int calificacionRespuestaEncuesta { get; set; }
    }
}
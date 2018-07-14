using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
    public class obtenerListaParticipantePorIDEventoParams
    {
        public int? id_Evento { get; set; }
        public string filtro { get; set; }
    }
}
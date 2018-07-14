using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
    public class obtenerListaActividadesPorIDParticipanteParams
    {
        public int? id_Participante { get; set; }
        public string codigoTipoActividad { get; set; }
        public string codIdioma { get; set; }
    }
}
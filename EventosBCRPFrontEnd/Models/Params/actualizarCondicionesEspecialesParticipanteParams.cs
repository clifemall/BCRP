using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
    public class actualizarCondicionesEspecialesParticipanteParams
    {
        public int id_Participante { get; set; }
        public bool discapacidadFisicoParticipante { get; set; }
        public bool discapacidadSensorialParticipante { get; set; }
        public string discapacidadObservacionParticipante { get; set; }
        public bool requerimientoEspecialDiabetesParticipante { get; set; }
        public bool requerimientoEspecialOtrosParticipante { get; set; }
        public string requerimientoEspecialObservacionParticipante { get; set; }
    }
}
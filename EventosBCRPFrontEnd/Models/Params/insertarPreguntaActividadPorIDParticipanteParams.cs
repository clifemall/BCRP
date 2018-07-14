using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
    public class insertarPreguntaActividadPorIDParticipanteParams
    {
        public string glosaPreguntaActividad { get; set; }
        public bool aprobancionPreguntaActividad { get; set; }
        public int id_Participante { get; set; }
        public int id_Actividad { get; set; }
    }
}
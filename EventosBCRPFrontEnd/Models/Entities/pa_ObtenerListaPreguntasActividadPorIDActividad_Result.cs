using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Entities
{
    public class pa_ObtenerListaPreguntasActividadPorIDActividad_Result
    {
        public int id_PreguntaActividad { get; set; }
        public int id_Participante { get; set; }
        public string NombreParticipante { get; set; }
        public string GlosaPreguntaActividad { get; set; }
    }
}
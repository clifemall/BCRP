using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
    public class actualizarDatosAdicionalesPorIDParticipanteParams
    {
        public string FotoPersona { get; set; }
        public string ApodoPersona { get; set; }
        public string AerolineaVuelo { get; set; }
        public string CodigoVuelo { get; set; }
        public DateTime FechaLLegadavuelo { get; set; }
        public TimeSpan HoraLLegadavuelo { get; set; }
        //public DateTime FechaLLegadaVuelo { get; set; }
        public DateTime FechaSalidavuelo { get; set; }
        public TimeSpan HoraSalidavuelo { get; set; }
        //public DateTime FechaSalidaVuelo { get; set; }
        public string NombreHotel { get; set; }
        public string DireccionHotel { get; set; }
        public string CoordenadaXHotel { get; set; }
        public string CoordenadaYHotel { get; set; }
        public DateTime FechaEntradaHotel { get; set; }
        //public TimeSpan HoraEntradaHotel { get; set; }
        //public DateTime FechaEntradaHotel { get; set; }
        public DateTime FechaSalidaHotel { get; set; }
        //public TimeSpan HoraSalidaHotel { get; set; }
        //public DateTime FechaSalidaHotel { get; set; }
        public int id_Participante { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Entities
{
    public class pa_ObtenerListaHotelRecomendado_Result
    {
        public int idHotel { get; set; }
        public string NombreHotel { get; set; }
        public string DireccionHotel { get; set; }
        public string CoordenadaXHotel { get; set; }
        public string CoordenadaYHotel { get; set; }
    }
}
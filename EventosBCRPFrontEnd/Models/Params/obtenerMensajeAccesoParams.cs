using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
    public class obtenerMensajeAccesoParams
    {
        public bool estadoAcceso { get; set; }
        public string codigoQR { get; set; }
        public string CodIdioma { get; set; }
    }
}
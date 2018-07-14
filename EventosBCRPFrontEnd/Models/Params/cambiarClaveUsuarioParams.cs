using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
    public class cambiarClaveUsuarioParams
    {
        public int id_Usuario { get; set; }
        public string claveUsuarioAnterior { get; set; }
        public string claveUsuarioNueva { get; set; }
        public string claveUsuarioNueva2 { get; set; }
        public string codIdioma { get; set; }
    }
}
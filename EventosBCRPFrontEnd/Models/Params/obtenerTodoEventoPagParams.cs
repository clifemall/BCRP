using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
    public class obtenerTodoEventoPagParams
    {
        public int nroPag { get; set; }
        public int regPag { get; set; }
        public bool activoEvento { get; set; }
        public string filtro { get; set; }
    }
}
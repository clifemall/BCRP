using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
    public class insertarDelegadoParticipanteParams
    {
        public int id_Participante { get; set; }
        public string correo_Usuario { get; set; }
        public string nombrePersona { get; set; }
        public string apPaternoPersona { get; set; }
        public string apMaternoPersona { get; set; }
        public string organizacionPersona { get; set; }
        public string puestoPersona { get; set; }
        public int id_TipoDocumento { get; set; }
        public string nroDocumentoPersona { get; set; }
    }
}
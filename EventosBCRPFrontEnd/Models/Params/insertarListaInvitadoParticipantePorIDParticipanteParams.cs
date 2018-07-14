using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
    public class insertarListaInvitadoParticipantePorIDParticipanteParams
    {
        public int id_Participante { get; set; }
        public string NombreInvitado { get; set; }
        public DateTime FechaRegInvitado { get; set; }
    }
}
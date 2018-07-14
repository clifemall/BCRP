using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Entities
{
    public class AutenticacionParticipanteResult
    {
        public Nullable<int> id_Usuario { get; set; }
        public Nullable<int> id_RolParticipante { get; set; }
        public bool EstadoLogin { get; set; }
    }
}
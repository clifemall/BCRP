﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
    public class insertarListaActividadesPorIDParticipanteParams
    {
        public Nullable<int> id_Participante { get; set; }
        public Nullable<int> id_Actividad { get; set; }
    }
}
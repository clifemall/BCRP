﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
    public class obtenerListaPreguntasActividadPorIDParticipanteParams
    {
        public int? id_Participante { get; set; }
        public int? id_Actividad { get; set; }
    }
}
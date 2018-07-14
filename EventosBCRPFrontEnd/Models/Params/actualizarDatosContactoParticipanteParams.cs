using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
	public class actualizarDatosContactoParticipanteParams
	{
		public int id_Participante { get; set; }
		public string ciudadPersona { get; set; }
		public string direccionPersona { get; set; }
		public string telefonoPersona { get; set; }
		public string telefonoEmergenciaPersona { get; set; }
		public string correoEmergenciaParticipante { get; set; }
		public string contactoEmergenciaParticipante { get; set; }
	}
}
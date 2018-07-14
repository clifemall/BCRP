using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
	public class actualizarDatosPersonalesParticipanteParams
	{
		public int id_Participante { get; set; }
		public string tituloPersona { get; set; }
		public string organizacionPersona { get; set; }
		public string abreviaturaOrganizacionPersona { get; set; }
		public string puestoPersona { get; set; }
		public string paisPersona { get; set; }
		public int id_TipoDocumento { get; set; }
		public string nroDocumentoPersona { get; set; }
	}
}
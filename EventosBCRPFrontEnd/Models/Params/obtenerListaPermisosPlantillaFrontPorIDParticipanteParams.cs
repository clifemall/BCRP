using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
	/// <summary>
	/// 
	/// </summary>
	public class obtenerListaPermisosPlantillaFrontPorIDParticipanteParams
	{
		/// <summary>
		/// 
		/// </summary>
		public int id_Participante { get; set; }
		/// <summary>
		/// Entorno WEB 1, APP 2
		/// </summary>
		public int id_Entorno { get; set; }
	}
}
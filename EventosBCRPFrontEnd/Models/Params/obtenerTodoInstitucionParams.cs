using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
	public class obtenerTodoInstitucionParams
	{
		public string filtro { get; set; }
		public int? nroPag { get; set; }
		public int? regPag { get; set; }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Models.Params
{
	public class obtenerListaTextoPlantillaFrontParams
	{
		/// <summary>
		/// CodIdioma Español SPA, INGLES ENG
		/// </summary>
		public string codIdioma { get; set; }
        public Nullable<int> id_Participante { get; set; }
    }
}
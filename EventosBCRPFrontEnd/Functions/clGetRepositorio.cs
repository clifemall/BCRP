using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosBCRPFrontEnd.Functions
{
    public class clGetRepositorio
    {
        public static string Read(string dir)
        {
            return clValueKeyConfig.ReadKey("HostRepositories") + "/RepositoriesBCRP" + dir;
        }
    }
}
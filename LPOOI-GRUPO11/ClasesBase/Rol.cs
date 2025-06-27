using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Rol
    {
        public string ROL_Codigo { get; set; }
        public string ROL_Descripcion {get; set;}

        public Rol(string rolCode, string rolDescription)
        {
            ROL_Codigo = rolCode;
            ROL_Descripcion = rolDescription;
        }
    }

}

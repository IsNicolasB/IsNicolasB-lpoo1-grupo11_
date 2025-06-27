using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        public int USU_ID { get; set; }
        public string ROL_Codigo { get; set; }
        public string USU_NombreUsuario { get; set; }
        public string USU_Contraseña {get; set;}
        public string USU_ApellidoNombre { get; set; }

        public Usuario(int id,string rolCode, string username, string password, string apellidoNombre)
        {
            USU_ID = id;
            ROL_Codigo = rolCode;
            USU_NombreUsuario = username;
            USU_Contraseña = password;
            USU_ApellidoNombre = USU_ApellidoNombre;
            
        }
        public Usuario() { }

    }
}

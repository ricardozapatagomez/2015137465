using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensambladora.Entities
{
    public class Propietario
    {
        public String DNI {set;get;}
        public String Nombres { set; get; }
        public String Apellidos { set; get; }
        public String LicenciaConducir { set; get; }

             
        public Propietario(){}
        public Propietario(String DNI, String Nombres, String Apellidos, String LicenciaConducir)
        {
            this.DNI = DNI;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.LicenciaConducir = LicenciaConducir;
        }

       
    }
}

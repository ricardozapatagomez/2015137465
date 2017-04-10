using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensambladora.Entities
{
    public class Volante
    {
        public String NumSerie{set;get;}

        public Volante(String numSerie)
        {
            this.NumSerie = numSerie;
        }

    }
}

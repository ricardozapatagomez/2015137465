using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensambladora.Entities
{
    public interface Carro
    {
         String numSerieMotor { set; get; }
         String numSerieChasis { set; get; }

    
       
       

        TipoCarro getTipoCarro{get;}
              
    }
}

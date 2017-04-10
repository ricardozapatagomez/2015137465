using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensambladora.Entities
{
    public class Automovil : Carro
    {
        public String numSerieMotor { set; get; }
        public String numSerieChasis { set; get; }

        public TipoAuto tipoauto { set; get; }
        public int numAsientos { set; get; }
        public Volante volante { set; get; }
        public Parabrisas parabrisas { set; get; }
        public int numLlantas { set; get; }
        public Propietario propietario { set; get; }
        public TipoCarro tipocarro { set; get; }


        public Automovil(Volante volante, Parabrisas parabrisas, int numLlantas, int numAsientos, Propietario propietario, TipoCarro tipocarro,TipoAuto tipoauto)
      {
          this.volante = volante;
          this.parabrisas = parabrisas;
          this.numLlantas = numLlantas;
          this.numAsientos = numAsientos;
          this.propietario = propietario;
          this.tipocarro = tipocarro;
          this.tipoauto = tipoauto;
      }

        public TipoCarro getTipoCarro { get { return tipocarro; } }

    }
}

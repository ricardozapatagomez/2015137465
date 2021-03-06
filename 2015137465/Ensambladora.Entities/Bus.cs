﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ensambladora.Entities
{
    public class Bus :Carro
    {
        public String numSerieMotor { set; get; }
        public String numSerieChasis { set; get; }

        public TipoBus tipobus{set;get;}
        public int numAsientos{set;get;}
        public Volante volante { set; get; }
        public Parabrisas parabrisas { set; get; }
        public int numLlantas { set; get; }
        public Propietario propietario{ set; get; }
        public TipoCarro tipocarro{ set; get; }

        public Bus(Volante volante, Parabrisas parabrisas, int numLlantas, int numAsientos, Propietario propietario, TipoCarro tipocarro, TipoBus tipobus)
        {
            this.volante = volante;
            this.parabrisas = parabrisas;
            this.numLlantas = numLlantas;
            this.numAsientos = numAsientos;
            this.propietario = propietario;
            this.tipocarro = tipocarro;
            this.tipobus = tipobus;
        }


        public TipoCarro getTipoCarro { get { return tipocarro; } }
        

        }
    }


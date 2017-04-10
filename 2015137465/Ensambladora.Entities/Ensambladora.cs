using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensambladora.Entities
{
    public class Ensambladora
    {

        public List<Carro> listaCarros;


        public Ensambladora()
        {
            listaCarros = new List<Carro>();
        }

        public bool IniciarPersonalizacion(){
            Console.WriteLine("Inicio de la Personalizacion");
            Console.WriteLine();
            RandomNumber r = new RandomNumber();
            int num = r.getrandom();

            for (int i = 0; i < listaCarros.Count; i++)
            {
                Carro carro = listaCarros[i];
                if (carro.getTipoCarro == TipoCarro.Automovil)
                {
                    String numChasis = "AUT-" + num;
                    listaCarros[i].numSerieChasis = numChasis;
                    num++;

                }
                else
                {
                    String numChasis = "BUS-" + num;
                    listaCarros[i].numSerieChasis = numChasis;
                    num++;
                }


            }
            return true;
        }

        public bool FinalizarPersonalizacion(){
            Console.WriteLine();
            Console.WriteLine("REPORTE");
            Console.WriteLine();

            Console.WriteLine("NroCarro".PadRight(11) + "TipoCarro".PadRight(12) + "NroSerieChasis".PadRight(17));

            for (int i = 0; i < listaCarros.Count; i++)
            {
                Carro carro = listaCarros[i];
                Console.WriteLine((i + 1).ToString().PadRight(11) + carro.getTipoCarro.ToString().PadRight(12) + carro.numSerieChasis.PadRight(17));
            }
            return false;
        }



        public void Agregar(Carro carro)
        {
            listaCarros.Add(carro);
        }

        public Carro EnsamblarCarro(TipoCarro tipocarro, TipoBus tipobus, TipoAuto tipoauto)
        {
            Carro carro;
            Random random1,random2;
            
            if (tipocarro==TipoCarro.Automovil)
            {
                random1 = new Random();
                int num = random1.Next(11223, 98231);
                Propietario propietario = new Propietario("72311223","John","Duran","Q72311223");
                Volante volante = new Volante(num.ToString());
                Parabrisas parabrisas = new Parabrisas(num.ToString());
                //Console.WriteLine(volante.NumSerie);
                carro = new Automovil(volante, parabrisas, 4, 5, propietario, tipocarro, tipoauto);
            }
            else
            {
                random2 = new Random();
                int num2 = random2.Next(51223, 68231);
                Propietario propietario = new Propietario("72311223", "John", "Duran", "Q72311223");
                Volante volante = new Volante(num2.ToString());
                Parabrisas parabrisas = new Parabrisas(num2.ToString());
                //Console.WriteLine(volante.NumSerie);
                carro = new Bus(volante, parabrisas, 6, 10, propietario, tipocarro, tipobus);

            }


            return carro;
        }

    }
}

       

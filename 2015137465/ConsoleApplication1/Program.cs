using System;
using System.Collections.Generic;
using System.Linq;
using Ensambladora.Entities;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

                 
    

         //se instancian los objetos de acuerdo a lo requerido, 2 buses y 4 automoviles
         //dentro de la clase ensambladora se crearan los Carros, de acuerdo a lo que se pida y usando valores Predeterminados

            var ensambladora = new Ensambladora.Entities.Ensambladora();
            Carro carro1 = ensambladora.EnsamblarCarro(TipoCarro.Bus, TipoBus.Privado,TipoAuto.Coupe);
            ensambladora.Agregar(carro1);
            Carro carro2 = ensambladora.EnsamblarCarro(TipoCarro.Bus, TipoBus.Publico, TipoAuto.Coupe);
            ensambladora.Agregar(carro2);
            Carro carro3 = ensambladora.EnsamblarCarro(TipoCarro.Automovil, TipoBus.Privado, TipoAuto.Sedan);
            ensambladora.Agregar(carro3);
            Carro carro4 = ensambladora.EnsamblarCarro(TipoCarro.Automovil, TipoBus.Publico, TipoAuto.PickUp);
            ensambladora.Agregar(carro4);
            Carro carro5 = ensambladora.EnsamblarCarro(TipoCarro.Automovil, TipoBus.Privado, TipoAuto.HatchBack);
            ensambladora.Agregar(carro5);
            Carro carro6 = ensambladora.EnsamblarCarro(TipoCarro.Automovil, TipoBus.Publico, TipoAuto.Coupe);
            ensambladora.Agregar(carro6);

            //ensambladora.IniciarPersonalizacion();
            String data;
            Console.WriteLine("Desea Iniciar la Personalizacion? Y(si)/N (no)");
            data=Console.ReadLine();

            while (true) {
            
            if (data.CompareTo("Y") == 0 || data.CompareTo("y") == 0)
            {
                ensambladora.IniciarPersonalizacion();
                Thread.Sleep(2000);
                ensambladora.FinalizarPersonalizacion();
                break;

            }
            else if (data.CompareTo("N") == 0 || data.CompareTo("n") == 0)
            {
                Console.WriteLine("Tenga un buen dia");
                break;

            }
            else
            {
                Console.WriteLine("Escriba una Opcion Válida");
                Console.WriteLine("Desea Iniciar la Personalizacion? Y(si)/N (no)");
                data = Console.ReadLine();
            }


            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void printf<T>(T t) {
            System.Console.Out.WriteLine(t);
        }
        static string scanf() {
            return System.Console.In.ReadLine();
        }
        static void Main(string[] args)
        {
            init: printf("Que unidad desea convertir? [s=SegundosAMinutos | m=MinutosASegundos | h=HorasAMinutos | q=Salir] :  ");
            string opt = scanf().ToLower();
            printf("Inserte la cantidad a convertir:  ");
            switch (opt)
            {
                case "s":
                    printf(HadaP1.Seconds2Minutes(Convert.ToDouble(scanf())));
                    break;
                case "m":
                    printf(HadaP1.Minutes2Seconds(Convert.ToDouble(scanf())));
                    break;
                case "h":
                    printf(HadaP1.Hours2Minutes(Convert.ToDouble(scanf())));
                    break;
                case "q":
                    goto kill;
                default:
                    goto init;
            }
        kill: return;
        }
    }
}

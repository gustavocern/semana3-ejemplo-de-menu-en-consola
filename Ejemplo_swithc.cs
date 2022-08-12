using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana3_ejemplo_de_menu_en_consola
{
    public class Ejemplo_swithc
    {
        public static void programa_swithc()
        {
            System.Console.WriteLine("Switch externo");
            Console.WriteLine("ingrese un numero entre 1 y 3");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("valor es 1");
                    break;
                case 2:
                    Console.WriteLine("valor es 2");
                    break;
                case 3:
                    Console.WriteLine("valor es 3");
                    break;
                default:
                    Console.WriteLine("no se encontro el valor");
                    break;
            }
            Console.ReadKey();
        }

    }

}

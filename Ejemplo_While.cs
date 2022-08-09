using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana3_ejemplo_de_menu_en_consola
{
    class Ejemplo_While
    {
        public static void Main()
        {
            Console.WriteLine("ingrese un numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero mayor que el anterior");
            int num2 = int.Parse(Console.ReadLine());
            while (num1 < num2)
            {
                Console.WriteLine("valores:" + num1);
                num1++;
            }
            Console.ReadKey();
        }
    }
}

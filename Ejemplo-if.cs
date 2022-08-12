using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana3_ejemplo_de_menu_en_consola
{
    public class Ejemplo_if
    {
        public static void programa_if()
        {
            System.Console.WriteLine("if externo");
            string myInput;
            int myInt;
            Console.Write("Dame un número: ");

            myInput = Console.ReadLine();
            myInt = Int32.Parse(myInput);

            // comparación para una toma de decisión SIMPLE 
            if (myInt > 0)
            {
                Console.WriteLine("el número {0} es mayor que cero", myInt);
            }
            // comparación para una toma de decisión SIMPLE 
            if (myInt < 0)
            {
                Console.WriteLine("el número {0} es menor que cero", myInt);
            }
            // comparación para tomar UNA DE DOS decisiones 
            if (myInt != 0)
            {
                Console.WriteLine("el número {0} es distinto de cero", myInt);
            }
            else
            {
                Console.WriteLine("el número {0} es igual a cero", myInt);
            }

            // decisión MÚLTIPLE 
            if (myInt < 0 || myInt == 0)
            {
                Console.WriteLine("el número {0} es menor o igual a cero", myInt);
            }
            else if (myInt > 0 && myInt <= 10)
            {
                Console.WriteLine("el número {0} está entre 1 y 10", myInt);
            }
            else if (myInt > 10 && myInt <= 20)
            {
                Console.WriteLine("el número {0} está entre 11 y 20", myInt);
            }
            else if (myInt > 20 && myInt <= 30)
            {
                Console.WriteLine("el número {0} está entre 21 y 30", myInt);
            }
            else
            {
                Console.WriteLine("el número {0} es mayor que 30", myInt);
            }
        }


    }
}

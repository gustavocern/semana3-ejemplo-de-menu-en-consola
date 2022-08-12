using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana3_ejemplo_de_menu_en_consola
{
    public class Ejemplo_dowhile
    {
        public static void programa_dowhile()
        {
            System.Console.WriteLine("Dowhile externo");
            string secreta;
            string palabra;
            Console.WriteLine("ingrese la palabra secreta");
            secreta = Console.ReadLine();
            do
            {
                Console.WriteLine("vuelva a introducir la palabra secreta");
                palabra = Console.ReadLine();

                if (palabra != secreta)
                    Console.WriteLine("palabra incorrecta");
            } while (palabra != secreta);

            Console.WriteLine("Palabra Correcta");
            Console.ReadKey();
        }

    }
}

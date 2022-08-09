using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana3_ejemplo_de_menu_en_consola
{
    class Menu
    {
        static void Main(string[] args)
        {
            string opcion;
        int opcionint;

        System.Console.WriteLine("Menu Principal de la Practica 1: ");
            System.Console.WriteLine("Selecciona tu opcion: ");
            opcion = Console.ReadLine();
            opcionint = Int32.Parse(opcion);


            switch (opcionint)
            { 
                case 1:
                System.Console.WriteLine("Aqui llamo el programa1");
                break;

                case 2:
                System.Console.WriteLine("Aqui llamo el programa2");
                break;

                case 3:
                System.Console.WriteLine("Aqui llamo el programa3");
                break;

                case 4:
                System.Console.WriteLine("Opcion no disponible");
                break;

            }


    System.Console.ReadKey();
        }
    }
}

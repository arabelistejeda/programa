using System;

namespace Fin_de_semana
    {
        class MainClass
        {
        //Fin de semana
        public static void Main(string[] args)
            {
                Console.WriteLine("Escribe un dia de la semana");
                String dia = Console.ReadLine();

                switch (dia.ToLower())
                {

                    case "lunes":
                    case "martes":
                    case "miercoles":
                    case "jueves":
                    case "viernes":
                        Console.WriteLine("No es fin de semana");
                        break;
                    case "sabado":
                    case "domingo":
                        Console.WriteLine("Es fin de semana");
                        break;

                    default:
                        Console.WriteLine("Error ese dia no es correcto");
                        break;
                }


                Console.ReadLine();
            }
        }
    }
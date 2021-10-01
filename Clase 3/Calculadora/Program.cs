using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            float resultado = 0.00f, num1=0.00f, num2=0.00f;
            int opcion;
            string TipoOpcion= "sa";

            Console.WriteLine("Elija una opcion: ");
            Console.WriteLine("1_Suma");
            Console.WriteLine("2_Resta");
            Console.WriteLine("3_Multiplicacion");
            Console.WriteLine("4_Division");
            Console.WriteLine("Opcion:");
            opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("Dijite Un Numero 1: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Dijite Un Numero 2: ");
            num2 = float.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TipoOpcion = "SUMA";
                    resultado = num1 + num2;
                break;
                case 2:
                    TipoOpcion = "RESTA";
                    resultado = num1 - num2;        
                break;
                case 3:
                    TipoOpcion = "MULTIPLICAICON";
                    resultado = num1 * num2;  
                break;
                case 4:
                    TipoOpcion = "DIVISION";
                    resultado = num1 / num2;
                break;
                default:
                    Console.WriteLine("Opcion No valida");
                break;

            }
            Console.WriteLine("La opcion elegida fue: " + TipoOpcion);
            Console.WriteLine("El resultado es: " + resultado);



            Console.ReadKey();



        }
    }
}

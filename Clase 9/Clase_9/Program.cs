using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desafío de programación: implementar un programa de consola en C# y Visual Studio,
//que contenga una Clase llamada "Operación" y en ella definir dos métodos estáticos
//que permitan sumar y restar dos valores enteros, los cuales deberán ser ingresados por teclado.
//El código del proyecto deberá ser subido a un repositorio de GitHub.
namespace Clase_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Dijite el Numero 1: ");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dijite el Numero 2: ");
            num2 = int.Parse(Console.ReadLine());

            Operacion.Sumar(num1, num2);
            Operacion.Restar(num1, num2);

            Console.WriteLine("Suma: " + Operacion.Suma);
            Console.WriteLine("Resta: " + Operacion.Resta);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9
{
    static class Operacion
    {
       // private static int num1, num2;
        private static int suma, resta;

        public static int Suma { get => suma; set => suma = value; }
        public static int Resta { get => resta; set => resta = value; }

        // private static int Num1 { get => Num1; set => Num1 = value; }
        //private static int Num2 { get => num2; set => num2 = value; }


        public static void Sumar(int num1, int num2)
        {
            Suma = num1 + num2;
        }
        public static void Restar(int num1, int num2)
        {
            Resta = num1 - num2;
        }



    }
}

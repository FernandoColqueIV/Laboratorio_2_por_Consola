using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedios_Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            //atributo
            int CantAlumnos;
            float promedio = 0.00f;
            float cont_promedio= 0.00f;
            float notaMax = 0.00f, notaMin=100000.00f;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Dijite una cantidad de Alumnos: ");
            Console.WriteLine("--------------------------------");
            CantAlumnos = int.Parse(Console.ReadLine());
            float[] nota = new float[CantAlumnos];

            for (int i = 0; i < CantAlumnos; i++)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Alumno [" + (i + 1) + "]");
                Console.WriteLine("Nota: ");
                nota[i] = float.Parse(Console.ReadLine());
                cont_promedio += nota[i];
                Console.WriteLine("-----------------------");
            }
            promedio = cont_promedio/CantAlumnos;

            for(int i=0; i < CantAlumnos; i++)
            {
                if (notaMin>nota[i])
                {
                    notaMin = nota[i];
                }
               
            }
            for(int j = 0; j < CantAlumnos; j++)
            {
                if (notaMax < nota[j])
                {
                    notaMax = nota[j];
                }
            }
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("El promedio de los "+CantAlumnos+" Alumnos es: "+promedio);
            Console.WriteLine("La nota Minima es: " + notaMin);
            Console.WriteLine("La nota Maxima es: " + notaMax);
            Console.WriteLine("----------------------------------------------------------");
            Console.ReadKey();


        }
    }
}

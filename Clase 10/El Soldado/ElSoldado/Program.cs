using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    class Program
    {
        static void Main(string[] args)
        {

            //Arma arma = new Arma();
            Revolver revolverOP = new Revolver();
            Rifle rifleOP = new Rifle();
            Escopeta escopetaOP = new Escopeta();

            int opcion=0;
            bool tenenciaArma = false;
            int opcionArma=0;


            do
            {
                Console.WriteLine("");
                Console.WriteLine("-==Bienvenido al Campo de Entrenamiento, Soldado==-");
                Console.WriteLine("");
                Console.WriteLine("¿Que Desea hacer?");
                Console.WriteLine("(presione el numero correspondiente a la opcion del menu)");
                Console.WriteLine("");
                Console.WriteLine("1_Recoger Arma.");
                Console.WriteLine("2_Dejar Arma.");
                Console.WriteLine("3_Disparar.");
                Console.WriteLine("4_Ver Arma en uso.");
                Console.WriteLine("5_Salir");
                Console.WriteLine("Opcion: ");

                opcion = int.Parse(Console.ReadLine());
                if (opcion > 5 || opcion <= 0)
                {
                    do
                    {
                        Console.WriteLine("Introduzca una opcion valida");
                        opcion = int.Parse(Console.ReadLine());
                    } while (opcion > 5 || opcion <= 0);
                }
                
                Console.Clear();
                
                switch (opcion)
                {
                    case 1:
                        if (tenenciaArma == false)
                        {

                            Console.WriteLine("");
                            Console.WriteLine("Por Favor Escoja el arma que desea utilizar:");
                            Console.WriteLine("");
                            Console.WriteLine("1_Revolver");
                            Console.WriteLine("2_Rifle");
                            Console.WriteLine("3_Escopeta");
                            Console.WriteLine("4_Volver Atraz");
                            Console.WriteLine("Opcion: ");
                            opcionArma = int.Parse(Console.ReadLine());
                            if (opcionArma > 4 || opcionArma <= 0)
                            {
                                do
                                {
                                    Console.WriteLine("----------------------------");
                                    Console.WriteLine("Introduzca una opcion valida");
                                    Console.WriteLine("----------------------------");
                                    opcionArma = int.Parse(Console.ReadLine());
                                } while (opcionArma > 4 || opcionArma <= 0);
                            }
                           
                            Console.WriteLine("");
                            
                            Console.Clear();
                        }
                        else
                        {
                            opcionArma = 0;
                        }
                        

                        switch (opcionArma)
                        {
                            case 0:
                                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                                Console.WriteLine("   Parece que el soldado ya tiene un arma en sus manos   ");
                                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                                opcion = 0;
                            break;
                            case 1:
                                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                                Console.WriteLine(" <<<< El Soldado Ahora esta armado con un Revolver: " + revolverOP.Nombre + " >>>> ");
                                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                                opcion = 0;
                                tenenciaArma = true;
                                break;
                            case 2:
                                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                                Console.WriteLine("   <<<< El Soldado Ahora esta armado con un Rifle:  " + rifleOP.Nombre + " >>>>  ");
                                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                                opcion = 0;
                                tenenciaArma = true;
                                break;
                            case 3:
                                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                                Console.WriteLine("<<<< El Soldado Ahora esta armado con una escopeta: " + escopetaOP.Nombre + " >>>>");
                                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                                opcion = 0;
                                tenenciaArma = true;
                                break;
                            case 4:
                                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                                Console.WriteLine("                 <<<< Volver Atraz >>>>                  ");
                                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                                opcion = 0;
                                tenenciaArma = false;
                                break;
                        }
                        break;


                    case 2:
                        if (tenenciaArma == true)
                        {
                            tenenciaArma = false;
                            opcion = 0;
                            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                            Console.WriteLine("             Ahora el soldado esta DESARMADO             ");
                            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                        }
                        else
                        {
                            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                            Console.WriteLine("        Al Parecer el soldado ya estaba DESARMADO        ");
                            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                            opcion = 0;
                        }
                        break;
                    case 3:
                        if (tenenciaArma==true)
                        {
                            Console.WriteLine("************************");
                            switch (opcionArma)
                            {
                                case 1:                                  
                                    Console.WriteLine("    "+revolverOP.Disparar);                                   
                                break;
                                case 2:                                   
                                    Console.WriteLine("    "+rifleOP.Disparar);
                                break;
                                case 3:                                   
                                    Console.WriteLine("   "+escopetaOP.Disparar);                                    
                                break;
                            }
                            Console.WriteLine("************************");
                        }
                        else
                        {
                            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                            Console.WriteLine("  Al Parecer El soldado No tiene un Arma para disparar   ");
                            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                        }
                        opcion = 0;
                        break;
                    case 4:
                        if (tenenciaArma==true)
                        {
                            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                            switch (opcionArma)
                            {
                                case 1:
                                    Console.WriteLine("     El soldado tiene un: " + revolverOP.Nombre);
                                    break;
                                case 2:
                                    Console.WriteLine("     El soldado tiene un: " + rifleOP.Nombre);
                                    break;
                                case 3:
                                    Console.WriteLine("     El soldado tiene un: " + escopetaOP.Nombre);
                                    break;
                            }
                            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                        }
                        else
                        {
                            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                            Console.WriteLine("     El soldado No Dispone de Ninguna arma para mostrar");
                            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                        }
                        opcion = 0;
                        break;
                    case 5:
                        Console.WriteLine("SALIR");
                        break;
                }
            } while (opcion > 5 || opcion <= 0);
            Console.ReadKey();
        }
    }
}

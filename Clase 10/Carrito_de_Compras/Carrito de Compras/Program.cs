using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito_de_Compras
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=0;
            int _cantidadCamisasop = 0;
            int _carritoop = 0;
            float _totalPagarop = 0.00f;
            float _totalPagarDescuentoop = 0.00f;
            int _descuentoop = 0;
            int _sacar_camisa = 0;
            int opcionAux = 0;
            //int aux = 0;

        Camisas OP = new Camisas(_cantidadCamisasop, _carritoop, _totalPagarop, _totalPagarDescuentoop, _descuentoop, opcion, _sacar_camisa);


            do
            {
                
                Console.WriteLine(" SHOPPING ONLINE DE CAMISAS-Ventas minoristas y mayoritas");
                Console.WriteLine(" --------------------------------------------------------");
                Console.WriteLine(" MENU PRINCIPAL");
                Console.WriteLine(" 1-    Añadir camisa al carro de compras");
                Console.WriteLine(" 2-    Eliminar camisa del carro de compras");
                Console.WriteLine(" 3-    Salir");
                Console.WriteLine(" --------------------------------------------------------");
                Console.WriteLine("      -    Cantidad de camisas en el carro de compras: "+OP.CarritoOP());
                Console.WriteLine("      -    Precio unitario: $1000");
                Console.WriteLine("      -    Precio total sin descuento: $"+OP.PrecioTotaOP());
                OP.CantidadCamisas = 0;//para evitar que siga sumando camisas en caso de poner 0 camisas o elejir otra opcion
                Console.WriteLine("      -    Tipo de descuento aplicado: %"+OP.TipoDescuento());
                Console.WriteLine("      -    Precio final con descuento: $"+OP.TotalPagarDescuentoOP());
                Console.WriteLine(" --------------------------------------------------------"); ;
                Console.WriteLine(" Ingrese una opcion del menu: ");

             
                OP.Opcion = int.Parse(Console.ReadLine());
                if(OP.Opcion > 3 || OP.Opcion <= 0)
                {
                    do
                    {
                        Console.WriteLine("Dijite una opcion valida: ");
                        OP.Opcion = int.Parse(Console.ReadLine());
                    } while (OP.Opcion > 3 || OP.Opcion <= 0);
                }
                opcionAux = OP.CantidadCamisas;
                switch (OP.Opcion)
                {
                    case 1:
                        Console.WriteLine("Añadir camisa al carro de compras");
                        Console.WriteLine("¿Cuantas Camisas desea añadir?");
                        Console.WriteLine("Cantidad: ");

                        do
                        {
                            OP.CantidadCamisas = 0;
                            OP.CantidadCamisas = int.Parse(Console.ReadLine());

                            if (OP.CantidadCamisas<0)
                            {
                                Console.WriteLine("Por Favor introduzca numeros positivos");
                                Console.WriteLine("En caso de querer eliminar una camisa vuelva al menu principal sin agregar ninguna camisa (Introduzca 0 camisas)");
                                Console.WriteLine("Cantidad: ");
                            }

                            
                        } while (OP.CantidadCamisas<0);
                        //OP.Opcion = 0;
                        opcionAux = 0;
                        break;
                    case 2:
                        Console.WriteLine("Eliminar camisa del carro de compras");
                        Console.WriteLine("¿Cuantas Camisas desea Eliminar?");
                        Console.WriteLine("Cantidad: ");

                        if (OP.Carrito>0)
                        {
                            do
                            {
                                OP.CantidadCamisas = 0;
                                OP.CantidadCamisas = int.Parse(Console.ReadLine());

                                if (OP.CantidadCamisas < 0)
                                {
                                    Console.WriteLine("Por Favor introduzca numeros positivos");
                                    Console.WriteLine("En caso de querer añadir una camisa vuelva al menu principal sin agregar ninguna camisa (Introduzca 0 camisas)");
                                    Console.WriteLine("Cantidad: ");
                                }

                            } while (OP.CantidadCamisas < 0);
                            // OP.Opcion = 0;
                            opcionAux = 0;
                        }
                        if(OP.Carrito==0)
                        {
                            Console.WriteLine("No hay camisas para Eliminar, 1ro agrege camisas al carro");
                        }

                        break;
                    case 3:
                        Console.Clear();
                        string Salir = "";
                        Console.WriteLine("SALIR: ");
                        Console.WriteLine("¿Está seguro que desea salir? S/N");
                        Salir = Console.ReadLine();
                        switch (Salir)
                        {
                            case "S":
                                Console.WriteLine("SALIR");
                                opcionAux =4;
                                break;
                            case "N":
                                OP.Opcion = 0;
                                break;
                            default:
                                Console.WriteLine("Opcion no valida, presione cualquier tecla");
                                Console.ReadLine();
                                OP.Opcion = 0;
                                break;
                        }
                        break;                       
                }
                Console.Clear();
            } while (opcionAux == 0);
           
            Console.ReadLine();
        }
    }
}

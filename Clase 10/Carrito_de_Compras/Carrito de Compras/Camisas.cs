using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito_de_Compras
{
    class Camisas
    {
        private int _cantidadCamisas = 0;
        private int _carrito = 0;
        private float _totalPagar = 0.00f;
        private float _totalPagarDescuento = 0.00f;
        private int _descuento = 0;
        private int aux=0;
        private int _opcion = 0;
        private int _sacar_camisa = 0;
        public Camisas( int  CantidadCamisas, int Carrito, float TotalPagar, float TotalPagarDescuento, int Descuento, int opcion, int _sacar_camisa)
        {
            this._cantidadCamisas = CantidadCamisas;
            this._carrito = Carrito;
            this._totalPagar = TotalPagar;
            this._totalPagarDescuento = TotalPagarDescuento;
            this._descuento = Descuento;
            this.Opcion = opcion;
            this._sacar_camisa = _sacar_camisa;
        }
        public int CantidadCamisas { get => _cantidadCamisas; set => _cantidadCamisas = value; }
        public int Carrito { get => _carrito; set => _carrito = value; }
        public float TotalPagar { get => _totalPagar; set => _totalPagar = value; }
        public float TotalPagarDescuento { get => _totalPagarDescuento; set => _totalPagarDescuento = value; }
        public int Descuento { get => _descuento; set => _descuento = value; }
        public int Opcion { get => _opcion; set => _opcion = value; }

        public int CarritoOP()
        {
            if (Opcion == 1)
            {
                Carrito += CantidadCamisas;
            }
            if (Opcion == 2)
            {
                Carrito -= CantidadCamisas;
            }
            return Carrito;
        }
        public float PrecioTotaOP()
        {

            if (Opcion==1 )
            {
                if (Carrito < 1)
                {
                    TotalPagar = 0;
                }
                if (CantidadCamisas < 1)
                {

                }
                if (CantidadCamisas >= 1)
                {
                    aux = Carrito;
                    do
                    {
                        TotalPagar += 1000 * CantidadCamisas;
                    } while (aux < 1);
                }
            }
            if(Opcion==2)
            {
                if (Carrito < 1)
                {
                    TotalPagar = 0;
                }
                if (CantidadCamisas < 1)
                {

                }
                if (CantidadCamisas >= 1)
                {
                    aux = Carrito;
                    do
                    {
                        TotalPagar -= 1000 * CantidadCamisas;
                    } while (aux < 1);
                }
            }
            return TotalPagar;
        }
        public float TipoDescuento()
        {  
            if(Carrito>=0 && Carrito <= 2)
            {
                Descuento = 0;
            }
            
            if (Carrito>=3 && Carrito < 5)
            {
                Descuento = 10;
            }
            if (Carrito > 5)
            {
                Descuento = 20;
            }
            return Descuento;
        }
        public float TotalPagarDescuentoOP()
        {
            TotalPagarDescuento = TotalPagar-(TotalPagar * (TipoDescuento() / 100));
            return TotalPagarDescuento;
        }
    }
}

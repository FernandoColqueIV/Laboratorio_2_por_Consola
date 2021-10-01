using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    class Arma
    {

        private string nombre;
        private string disparar;

        public Arma()
        {
                
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Disparar { get => disparar; set => disparar = value; }
    }
}

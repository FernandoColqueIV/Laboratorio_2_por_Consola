using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    class Rifle : Arma
    {
        public Rifle()
        {
            this.Nombre = "M1903 Springfield";
            this.Disparar = "Púm púm púm!...";
        }
    }
}

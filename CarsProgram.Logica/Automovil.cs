using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProgram.Logica
{
    public class Automovil : Vehiculo
    {
        private int _puertas;

        public int Puertas
        {
            get => _puertas;
            set => _puertas = value;
        }
        public override string getInformation()
        {
            string vehiculoInfo = getInformation();
            return vehiculoInfo;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"{getInformation}\nPuertas: {_puertas}";
        }
    }
}

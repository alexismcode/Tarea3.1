using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProgram.Logica
{
    public class Camioneta : Vehiculo
    {
        private double _capacidadCarga;

        public double CapacidadCarga
        {
            get => _capacidadCarga;
            set => _capacidadCarga = value;
        }
        public override string getInformation()
        {
            string vehiculoInfo = getInformation();
            return vehiculoInfo;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"{getInformation}\nCapacidad de carga: {CapacidadCarga}\n" +
                   $"Cargar camioneta";
        }
    }
}

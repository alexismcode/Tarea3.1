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
            set => _capacidadCarga = ValidateCapacidadCarga(value);
        }
        public override string getInformation()
        {
            string vehiculoInfo = base.ToString();
            return vehiculoInfo;
        }
        public override string RunAction()
        {
            string action = "============> Cargar camioneta <=============\n\n";
            return action;
        }  
        public override string ToString()
        {
            return $"=============================================\n" +
                   $"{getInformation()}\n> Capacidad de carga:....{CapacidadCarga,17} kg\n" +
                   $"{RunAction()}";
        }

        private double ValidateCapacidadCarga(double value)
        {
            ;
            if (value < 1 || value > 3500)
            {
                throw new ArgumentException("El valor de carga es invalido");
            }
            return value;
        }
    }
}

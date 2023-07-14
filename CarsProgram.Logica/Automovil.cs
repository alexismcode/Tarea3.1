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
            set => _puertas = ValidatePuertas(value);
        }
        public override string getInformation()
        {
            string vehiculoInfo = base.ToString();
            return vehiculoInfo;
        }
        public override string RunAction()
        {
            string action = "===========> Conducir automovil <============\n\n";
            return action;
        }
        public override string ToString()
        {
            return $"=============================================\n" +
                   $"{getInformation()}\n> Puertas:...............{Puertas,20}\n" +
                   $"{RunAction()}";
        }

        private int ValidatePuertas(int value)
        {;
            if (value < 1 || value > 7)
            {
                throw new ArgumentException("El valor de puertas del automovil es invalido");
            }
            return value;
        }
    }
}

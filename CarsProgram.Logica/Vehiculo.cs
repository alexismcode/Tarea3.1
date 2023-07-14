using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProgram.Logica
{
    public abstract class Vehiculo
    {
        private string? _marca;
        private string? _modelo;
        private int _año;

        public string? Marca
        {
            get => _marca;
            set => _marca = value;
        }
        public string? Modelo
        {
            get => _modelo;
            set => _modelo = value;
        }
        public int Año
        {
            get => _año;
            set => _año = value;
        }

        public abstract string getInformation();
        public override string ToString()
        {
            return $"Marca: {Marca}\nModelo: {Modelo}\nAño: {Año}";
        }
        public abstract string runAction();
    }
}
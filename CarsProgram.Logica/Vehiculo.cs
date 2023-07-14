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
            set => _marca = ValidateMarca(value);
        }
        public string? Modelo
        {
            get => _modelo;
            set => _modelo = ValidateModelo(value);
        }
        public int Año
        {
            get => _año;
            set => _año = ValidateAño(value);
        }
        public bool Action {get; set;}

        public abstract string getInformation();
        public abstract string RunAction();
        public override string ToString()
        {
            return $"> Marca:.................{Marca,20}\n" +
                   $"> Modelo:................{Modelo,20}\n" +
                   $"> Año:...................{Año,20}";
        }

        private string? ValidateMarca(string? value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("La marca del carro no puede estar vacia");
            }
            return value;
        }
        private string? ValidateModelo(string? value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("El modelo del carro no puede estar vacia");
            }
            return value;
        }
        private int ValidateAño(int value)
        {
            int añoActual = DateTime.Now.Year;
            if (value < 1900 || value > añoActual)
            {
                throw new ArgumentException("El año del carro es invalido");
            }
            return value;
        }
    }
}
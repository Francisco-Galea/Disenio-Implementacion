using FigurasGeometricasWINFORM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricasWINFORM.Models
{
    public class TrianguloModel : ICalculable
    {
        private string nombre {  get; set; }
        private float longitudLado { get; set; }

        public TrianguloModel(string nombre, float longitudLado) {
            this.nombre = nombre;
            this.longitudLado = longitudLado;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public float LongitudLado
        {
            get { return longitudLado; }
            set { longitudLado = value; }
        }

        public float calcularSuperficie()
        {
            return (float) (Math.Pow(longitudLado, 2) * Math.Sqrt(3)) / 4  ;
        }

        public float calcularPerimetro()
        {
            return longitudLado * 3;
        }

    }
}

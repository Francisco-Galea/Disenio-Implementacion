using FigurasGeometricasWINFORM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricasWINFORM.Models
{
    public class TrianguloModel : ICalculable, IFigura
    {
        private string nombre { get; set; }
        private float longitudLado { get; set; }

        public TrianguloModel(string nombre, float longitudLado) {
            this.nombre = nombre;
            this.longitudLado = longitudLado;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setLongitudLado(float longitudLado)
        {
            this.longitudLado = longitudLado;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public float getLongitudLado()
        {
            return this.longitudLado;
        }

        public float calcularAltura()
        {
            return (float)(Math.Sqrt(3) / 2) * longitudLado;
        }

        public float calcularSuperficie()
        {
            return (float)(Math.Pow(longitudLado, 2) * Math.Sqrt(3)) / 4;
        }

        public float calcularPerimetro()
        {
            return (float)longitudLado * 3;
        } 
    }
}

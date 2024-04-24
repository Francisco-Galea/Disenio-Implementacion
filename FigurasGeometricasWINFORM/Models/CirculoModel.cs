using FigurasGeometricasWINFORM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricasWINFORM.Models
{
    public class CirculoModel : ICalculable
    {
        private string nombre {  get; set; }
        private float radio {  get; set; }
     
        public CirculoModel(string nombre, float radio)
        {
            this.nombre = nombre;
            this.radio = radio;
        }

        public float calcularSuperficie()
        {
            return (float) (Math.PI * Math.Pow(radio, 2));
        }

        public float calcularPerimetro()
        {
            return (float)(2 * Math.PI * radio);
        }
    }
}

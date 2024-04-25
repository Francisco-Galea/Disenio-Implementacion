using FigurasGeometricasWINFORM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricasWINFORM.Models
{
    public class CirculoModel : ICalculable, IFigura
    {
        private string nombre {  get; set; }
        private float radio {  get; set; }
     
        public CirculoModel(string nombre, float radio)
        {
            this.nombre = nombre;
            this.radio = radio;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setRadio(float radio)
        {
            this.radio = radio;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public float getRadio()
        {
            return this.radio;
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

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
        private int cantidadLados {  get; set; }
     
        public CirculoModel(string nombre, int cantidadLados, float radio)
        {
            this.nombre = nombre;
            this.cantidadLados = cantidadLados;
            this.radio = radio;            
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int CantidadLados
        {
            set { cantidadLados = value; }
            get { return cantidadLados; }
        }

        public float Radio
        {
           set { radio = value; }
           get { return radio; }
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

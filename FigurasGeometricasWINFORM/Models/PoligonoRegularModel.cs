using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasGeometricasWINFORM.Interfaces;

namespace FigurasGeometricasWINFORM.Models
{
    public class PoligonoRegularModel : ICalculable, IFigura
    {
        private string nombre { get; set; }
        private int cantidadLados { get; set; }
        private float longitudLado { get; set; }

        public PoligonoRegularModel(string nombre, int cantidadLados, float longitudLado)
        {
            this.nombre = nombre;
            this.cantidadLados = cantidadLados;
            this.longitudLado = longitudLado;
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public float LongitudLado
        {
            set { longitudLado = value; }
            get { return longitudLado; }
        }

        public int CantidadLados
        {
            set { cantidadLados = value; }
            get { return cantidadLados; }
        }

        public float calcularPerimetro()
        {
            return (float)((float) ( cantidadLados * Math.Pow(longitudLado, 2) ) / ( 4 * Math.Tan(Math.PI / cantidadLados) ) );
        }

        public float calcularSuperficie()
        {
            return (float) cantidadLados * longitudLado;
        }
    }
}

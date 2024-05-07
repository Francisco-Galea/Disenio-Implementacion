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

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getCantidadLados()
        {
            return cantidadLados;
        }

        public void setCantidadLados(int cantidadLados)
        {
            this.cantidadLados = cantidadLados;
        }

        public float getLongitudLado()
        {
            return longitudLado;
        }

        public void setLongitudLado(float longitudLado)
        {
            this.longitudLado = longitudLado;
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

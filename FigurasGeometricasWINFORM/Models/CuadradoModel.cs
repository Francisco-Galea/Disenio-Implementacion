using FigurasGeometricasWINFORM.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricasWINFORM.Models
{
    public class CuadradoModel : IFigura, ICalculable
    {
        private string nombre {  get; set; }
        private float longitudLado { get; set; }


        public CuadradoModel(string nombre, float longitudLado)
        {
            this.nombre = nombre;
            this.longitudLado = longitudLado;
        }

        public string getNombre()
        {
            return nombre;
        }

        public float getLongitudLado()
        {  
            return longitudLado;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
           
        public void setLongidutLado(float longitudLado)
        {
            this.longitudLado = longitudLado;
        }

       public float calcularSuperficie()
        {
            return (float)Math.Pow(longitudLado, 2);
        }

        public float calcularPerimetro()
        {
            return longitudLado * 4;
        }
    }
}

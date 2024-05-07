using FigurasGeometricasWINFORM.Interfaces;
using FigurasGeometricasWINFORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasWINFORM.Controllers
{
    public class FiguraController
    {
        private static List<IFigura>? listaFiguras = new List<IFigura>();

        public static void validacionFigura(string nombre, string cantidadLados, string longitudLado)
        {
            int cantidadLadosVerificado = validacionCantidadLados(cantidadLados);
            float longitudLadoVerificado = validacionLongitudLados(longitudLado);

            if (cantidadLadosVerificado > 0 && longitudLadoVerificado > 0)
            {
                switch (nombre)
                {
                    case "Circulo":
                        crearCirculo(nombre, cantidadLadosVerificado, longitudLadoVerificado);
                        break;
                    case "Cuadrado":
                        crearCuadrado(nombre, cantidadLadosVerificado, longitudLadoVerificado);
                        break;
                    case "Triangulo":
                        crearTriangulo(nombre, cantidadLadosVerificado, longitudLadoVerificado);
                        break;
                    case "Poligono":
                        if (cantidadLadosVerificado >= 3) 
                        {
                            crearPoligono(nombre, cantidadLadosVerificado, longitudLadoVerificado);
                        }
                        else
                        {
                            MessageBox.Show("Un polígono debe tener al menos 3 lados.");
                        }
                        break;
                    default:
                        MessageBox.Show("Figura no reconocida.");
                        break;
                }
            }
        }

        public static int validacionCantidadLados(string cantidadLados)
        {
            int cantidadLadosVerificado = 0;
            if (!int.TryParse(cantidadLados, out cantidadLadosVerificado) || cantidadLadosVerificado <= 0)
            {
                MessageBox.Show("Ingrese un numero mayor que 0"); ;
            }      
            else
            {
                int.Parse(cantidadLados);
            }
            return cantidadLadosVerificado;
        }


        public static float validacionLongitudLados(string longitudLados)
        {
            float longitudLadosVerificado = 0;
            if(!float.TryParse(longitudLados, out longitudLadosVerificado) || longitudLadosVerificado <= 0)
            {
                MessageBox.Show("Ingrese un numero mayor que 0");      
            }
            else
            {
                float.Parse(longitudLados);
            }
            return longitudLadosVerificado;
        }

        public static void crearPoligono(string nombre, int cantidadLados, float longitudLados)
        {
            IFigura poligono = new PoligonoRegularModel(nombre, cantidadLados, longitudLados);
            agregarFigura(poligono);
            mensajeFiguraCreadaExito();
        }

        public static void crearCuadrado(string nombre, int cantidadLados, float longitudLados)
        {
            IFigura cuadrado = new CuadradoModel(nombre, cantidadLados, longitudLados);
            agregarFigura(cuadrado);
            mensajeFiguraCreadaExito();
        }

        public static void crearTriangulo(string nombre, int cantidadLados, float longitudLados)
        {
            IFigura triangulo = new TrianguloModel(nombre, cantidadLados, longitudLados);
            agregarFigura(triangulo);
            mensajeFiguraCreadaExito();
        }

        public static void crearCirculo(string nombre, int cantidadLados, float longitudLados)
        {
            IFigura circulo = new CirculoModel(nombre, cantidadLados, longitudLados);
            agregarFigura(circulo);
            mensajeFiguraCreadaExito();
        }

        public static void mensajeFiguraCreadaExito()
        {
            MessageBox.Show("¡Figura creada con éxito!");
        }

        public static void agregarFigura(IFigura figura)
        {
            listaFiguras?.Add(figura);
        }

        public static void MostrarFiguras(DataGridView dataGridView)
        {                      
            foreach (var figura in listaFiguras)
            {
                if (figura is CuadradoModel cuadrado)
                {
                    dataGridView.Rows.Add(cuadrado.Nombre, cuadrado.LongitudLado, cuadrado.calcularSuperficie(), cuadrado.calcularPerimetro(), "-");
                }
                else
                    if (figura is TrianguloModel triangulo)
                    {
                        dataGridView.Rows.Add(triangulo.Nombre, triangulo.LongitudLado, triangulo.calcularSuperficie(), triangulo.calcularPerimetro(), triangulo.calcularAltura());
                    }
                    else
                        if (figura is CirculoModel circulo)
                        {
                            dataGridView.Rows.Add(circulo.Nombre, circulo.Radio, circulo.calcularSuperficie(), circulo.calcularPerimetro(),"-", "-");
                        }     
                        else
                            if(figura is PoligonoRegularModel poligono)
                            {
                                dataGridView.Rows.Add(poligono.Nombre, poligono.LongitudLado, poligono.CantidadLados, poligono.calcularSuperficie(), poligono.calcularPerimetro());
                            }
            }
        }
    }
}



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

        public static void validacionLado(string nombre, string longitudLado)
        {
            float test;
            bool valid = false;
            while (!valid)
            {
                valid = float.TryParse(longitudLado, out test);
                if (!valid)
                {
                    MessageBox.Show("Ingrese un numero!");                   
                }
                else
                {
                    switch(nombre)
                    {
                        case "Circulo":
                            crearCirculo(nombre, test);
                            break;

                        case "Cuadrado": 
                            crearCuadrado(nombre, test); 
                            break;

                        case "Triangulo":
                            crearTriangulo(nombre, test);
                            break;
                    }
                }
                valid = true;
            }
        }

        public static void crearCuadrado(string nombre, float test)
        {
            IFigura cuadrado = new CuadradoModel(nombre, test);
            agregarFigura(cuadrado);
            mensajeFiguraCreadaExito();
        }

        public static void crearTriangulo(string nombre, float test)
        {
            IFigura triangulo = new TrianguloModel(nombre, test);
            agregarFigura(triangulo);
            mensajeFiguraCreadaExito();
        }

        public static void crearCirculo(string nombre, float test)
        {
            IFigura circulo = new CirculoModel(nombre,test);
            agregarFigura(circulo);
            mensajeFiguraCreadaExito();
        }

        public static void mensajeFiguraCreadaExito()
        {
            MessageBox.Show("¡Figura creada con éxito!");
        }

        public static void agregarFigura(IFigura figura)
        {
            listaFiguras.Add(figura);
        }
        public static void MostrarFiguras(DataGridView dataGridView)
        {                      
            foreach (var figura in listaFiguras)
            {
                if (figura is CuadradoModel cuadrado)
                {
                    dataGridView.Rows.Add(cuadrado.getNombre(), cuadrado.getLongitudLado(), cuadrado.calcularSuperficie(), cuadrado.calcularPerimetro(), "-");
                }
                else
                    if (figura is TrianguloModel triangulo)
                    {
                        dataGridView.Rows.Add(triangulo.getNombre(), triangulo.getLongitudLado(), triangulo.calcularSuperficie(), triangulo.calcularPerimetro(), triangulo.calcularAltura());
                    }
                    else
                        if (figura is CirculoModel circulo)
                        {
                            dataGridView.Rows.Add(circulo.getNombre(), circulo.getRadio(), circulo.calcularSuperficie(), circulo.calcularPerimetro(),"-", "-");
                        }              
            }
        }
    }
}



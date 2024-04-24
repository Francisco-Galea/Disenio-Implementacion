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
        private static List<IFigura> listaFiguras = new List<IFigura>();


        public static void crearCuadrado(string nombre, float longitudLado)
        {
            IFigura cuadrado = new CuadradoModel(nombre, longitudLado);
            agregarCuadrado(cuadrado);
            MessageBox.Show("¡Figura creada con éxito!");
            
        }

        public static void agregarCuadrado(IFigura figura)
        {
            listaFiguras.Add(figura);
        }
        public static void mostrarFiguras(DataGridView dataGridView)
        {
            

        }



    }
}




/*
    Codigo para mostrar con un cartel mis figuras
    message += $"Tipo: {listaFiguras.Count}\n";
    MessageBox.Show(message);
    string msg = figura.ToString();
    MessageBox.Show($"{msg}");

 
 
 
 
 
 
 
 
 
 
 
 
 */
using FigurasGeometricasWINFORM.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasWINFORM.Views
{
    public partial class PoligonoView : Form
    {
        public PoligonoView()
        {
            InitializeComponent();
            dataGridViewFiguras.AutoGenerateColumns = false;
            dataGridViewFiguras.ColumnCount = 6; 
            dataGridViewFiguras.Columns[0].Name = "Nombre";
            dataGridViewFiguras.Columns[0].DataPropertyName = "Nombre";
            dataGridViewFiguras.Columns[1].Name = "Cantidad de Lados"; 
            dataGridViewFiguras.Columns[1].DataPropertyName = "CantidadLados"; 
            dataGridViewFiguras.Columns[2].Name = "Longitud de Lado";
            dataGridViewFiguras.Columns[2].DataPropertyName = "LongitudLado";
            dataGridViewFiguras.Columns[3].Name = "Superficie";
            dataGridViewFiguras.Columns[3].DataPropertyName = "Superficie";
            dataGridViewFiguras.Columns[4].Name = "Perímetro";
            dataGridViewFiguras.Columns[4].DataPropertyName = "Perimetro";
            dataGridViewFiguras.Columns[5].Name = "Altura";
            dataGridViewFiguras.Columns[5].DataPropertyName = "Altura";
            FiguraController.MostrarFiguras(dataGridViewFiguras);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MainViewForm newFrame = new MainViewForm();
            newFrame.Show();
            this.Hide();
        }

        private void btnCrearPoligono_Click(object sender, EventArgs e)
        {
            string nombre = "Poligono";
            string cantidadLados = txtCantidadLados.Text;
            string longitudLado = txtLongitudLados.Text;
         
            FiguraController.validacionFigura(nombre, cantidadLados, longitudLado);
            FiguraController.MostrarFiguras(dataGridViewFiguras);
        }
    }
}

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
    public partial class CuadradoView : Form
    {
        public CuadradoView()
        {
            InitializeComponent();
            dataGridViewFiguras.AutoGenerateColumns = false;
            dataGridViewFiguras.ColumnCount = 4;
            dataGridViewFiguras.Columns[0].Name = "Nombre";
            dataGridViewFiguras.Columns[0].DataPropertyName = "Nombre";
            dataGridViewFiguras.Columns[1].Name = "Longitud de Lado";
            dataGridViewFiguras.Columns[1].DataPropertyName = "LongitudLado";
            dataGridViewFiguras.Columns[2].Name = "Superficie";
            dataGridViewFiguras.Columns[2].DataPropertyName = "Superficie";
            dataGridViewFiguras.Columns[3].Name = "Perímetro";
            dataGridViewFiguras.Columns[3].DataPropertyName = "Perimetro";
        }

        private void btnCrearCuadrado_Click(object sender, EventArgs e)
        {

            string nombre = "Cuadrado";
            float longitudLado = float.Parse(txtLongitudLado.Text);

            FiguraController.crearCuadrado(nombre, longitudLado);
            //listBox1.Items.Add(nombre);


        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiguraController.mostrarFiguras(dataGridViewFiguras);
        }
    }
}

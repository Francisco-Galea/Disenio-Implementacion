namespace FigurasGeometricasWINFORM.Views
{
    partial class CuadradoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblIngreseLongitudLado = new Label();
            txtLongitudLado = new TextBox();
            btnCrearCuadrado = new Button();
            dataGridViewFiguras = new DataGridView();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiguras).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(74, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cuadrado";
            // 
            // lblIngreseLongitudLado
            // 
            lblIngreseLongitudLado.AutoSize = true;
            lblIngreseLongitudLado.Location = new Point(12, 47);
            lblIngreseLongitudLado.Name = "lblIngreseLongitudLado";
            lblIngreseLongitudLado.Size = new Size(176, 20);
            lblIngreseLongitudLado.TabIndex = 2;
            lblIngreseLongitudLado.Text = "Ingrese longitud del lado";
            // 
            // txtLongitudLado
            // 
            txtLongitudLado.Location = new Point(194, 44);
            txtLongitudLado.Name = "txtLongitudLado";
            txtLongitudLado.Size = new Size(114, 27);
            txtLongitudLado.TabIndex = 3;
            // 
            // btnCrearCuadrado
            // 
            btnCrearCuadrado.Location = new Point(194, 77);
            btnCrearCuadrado.Name = "btnCrearCuadrado";
            btnCrearCuadrado.Size = new Size(114, 29);
            btnCrearCuadrado.TabIndex = 4;
            btnCrearCuadrado.Text = "Crear";
            btnCrearCuadrado.UseVisualStyleBackColor = true;
            btnCrearCuadrado.Click += btnCrearCuadrado_Click;
            // 
            // dataGridViewFiguras
            // 
            dataGridViewFiguras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFiguras.Location = new Point(12, 112);
            dataGridViewFiguras.Name = "dataGridViewFiguras";
            dataGridViewFiguras.RowHeadersWidth = 51;
            dataGridViewFiguras.ShowRowErrors = false;
            dataGridViewFiguras.Size = new Size(680, 326);
            dataGridViewFiguras.TabIndex = 5;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(698, 409);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // CuadradoView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 450);
            Controls.Add(btnRegresar);
            Controls.Add(dataGridViewFiguras);
            Controls.Add(btnCrearCuadrado);
            Controls.Add(txtLongitudLado);
            Controls.Add(lblIngreseLongitudLado);
            Controls.Add(lblTitulo);
            Name = "CuadradoView";
            Text = "CuadradoView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiguras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblIngreseLongitudLado;
        private TextBox txtLongitudLado;
        private Button btnCrearCuadrado;
        private DataGridView dataGridViewFiguras;
        private Button btnRegresar;
    }
}
namespace FigurasGeometricasWINFORM.Views
{
    partial class TrianguloView
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
            dataGridViewFiguras = new DataGridView();
            lblIngreseLongitudLado = new Label();
            txtLongitudLado = new TextBox();
            btnCrearTriangulo = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiguras).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(71, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Triangulo";
            // 
            // dataGridViewFiguras
            // 
            dataGridViewFiguras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFiguras.Location = new Point(12, 128);
            dataGridViewFiguras.Name = "dataGridViewFiguras";
            dataGridViewFiguras.RowHeadersWidth = 51;
            dataGridViewFiguras.Size = new Size(719, 347);
            dataGridViewFiguras.TabIndex = 1;
            // 
            // lblIngreseLongitudLado
            // 
            lblIngreseLongitudLado.AutoSize = true;
            lblIngreseLongitudLado.Location = new Point(12, 42);
            lblIngreseLongitudLado.Name = "lblIngreseLongitudLado";
            lblIngreseLongitudLado.Size = new Size(192, 20);
            lblIngreseLongitudLado.TabIndex = 2;
            lblIngreseLongitudLado.Text = "Ingrese la longitud del lado";
            // 
            // txtLongitudLado
            // 
            txtLongitudLado.Location = new Point(210, 39);
            txtLongitudLado.Name = "txtLongitudLado";
            txtLongitudLado.Size = new Size(160, 27);
            txtLongitudLado.TabIndex = 3;
            // 
            // btnCrearTriangulo
            // 
            btnCrearTriangulo.Location = new Point(276, 93);
            btnCrearTriangulo.Name = "btnCrearTriangulo";
            btnCrearTriangulo.Size = new Size(94, 29);
            btnCrearTriangulo.TabIndex = 4;
            btnCrearTriangulo.Text = "Crear ";
            btnCrearTriangulo.UseVisualStyleBackColor = true;
            btnCrearTriangulo.Click += btnCrearTriangulo_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(737, 446);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // TrianguloView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 487);
            Controls.Add(btnRegresar);
            Controls.Add(btnCrearTriangulo);
            Controls.Add(txtLongitudLado);
            Controls.Add(lblIngreseLongitudLado);
            Controls.Add(dataGridViewFiguras);
            Controls.Add(lblTitulo);
            Name = "TrianguloView";
            Text = "TrianguloView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiguras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dataGridViewFiguras;
        private Label lblIngreseLongitudLado;
        private TextBox txtLongitudLado;
        private Button btnCrearTriangulo;
        private Button btnRegresar;
    }
}
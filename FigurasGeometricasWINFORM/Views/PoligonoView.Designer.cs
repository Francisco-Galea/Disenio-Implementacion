namespace FigurasGeometricasWINFORM.Views
{
    partial class PoligonoView
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
            btnRegresar = new Button();
            lblTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            txtCantidadLados = new TextBox();
            txtLongitudLados = new TextBox();
            btnCrearPoligono = new Button();
            dataGridViewFiguras = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiguras).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(818, 409);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(68, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Poligono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(196, 20);
            label1.TabIndex = 2;
            label1.Text = "Ingrese la cantidad de lados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(217, 20);
            label2.TabIndex = 3;
            label2.Text = "Ingrese la longitud de los lados";
            // 
            // txtCantidadLados
            // 
            txtCantidadLados.Location = new Point(247, 39);
            txtCantidadLados.Name = "txtCantidadLados";
            txtCantidadLados.Size = new Size(157, 27);
            txtCantidadLados.TabIndex = 4;
            // 
            // txtLongitudLados
            // 
            txtLongitudLados.Location = new Point(247, 76);
            txtLongitudLados.Name = "txtLongitudLados";
            txtLongitudLados.Size = new Size(157, 27);
            txtLongitudLados.TabIndex = 5;
            // 
            // btnCrearPoligono
            // 
            btnCrearPoligono.Location = new Point(310, 125);
            btnCrearPoligono.Name = "btnCrearPoligono";
            btnCrearPoligono.Size = new Size(94, 29);
            btnCrearPoligono.TabIndex = 6;
            btnCrearPoligono.Text = "Crear";
            btnCrearPoligono.UseVisualStyleBackColor = true;
            btnCrearPoligono.Click += btnCrearPoligono_Click;
            // 
            // dataGridViewFiguras
            // 
            dataGridViewFiguras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFiguras.Location = new Point(12, 158);
            dataGridViewFiguras.Name = "dataGridViewFiguras";
            dataGridViewFiguras.RowHeadersWidth = 51;
            dataGridViewFiguras.Size = new Size(800, 280);
            dataGridViewFiguras.TabIndex = 7;
            // 
            // PoligonoView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 454);
            Controls.Add(dataGridViewFiguras);
            Controls.Add(btnCrearPoligono);
            Controls.Add(txtLongitudLados);
            Controls.Add(txtCantidadLados);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(btnRegresar);
            Name = "PoligonoView";
            Text = "PoligonoView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiguras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Label lblTitulo;
        private Label label1;
        private Label label2;
        private TextBox txtCantidadLados;
        private TextBox txtLongitudLados;
        private Button btnCrearPoligono;
        private DataGridView dataGridViewFiguras;
    }
}
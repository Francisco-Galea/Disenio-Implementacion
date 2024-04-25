namespace FigurasGeometricasWINFORM.Views
{
    partial class CirculoView
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
            dataGridViewFiguras = new DataGridView();
            lblTitulo = new Label();
            label2 = new Label();
            txtIngreseRadio = new TextBox();
            btnCrearFigura = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiguras).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFiguras
            // 
            dataGridViewFiguras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFiguras.Location = new Point(12, 118);
            dataGridViewFiguras.Name = "dataGridViewFiguras";
            dataGridViewFiguras.RowHeadersWidth = 51;
            dataGridViewFiguras.Size = new Size(676, 320);
            dataGridViewFiguras.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(55, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Circulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el radio";
            // 
            // txtIngreseRadio
            // 
            txtIngreseRadio.Location = new Point(130, 36);
            txtIngreseRadio.Name = "txtIngreseRadio";
            txtIngreseRadio.Size = new Size(182, 27);
            txtIngreseRadio.TabIndex = 3;
            // 
            // btnCrearFigura
            // 
            btnCrearFigura.Location = new Point(218, 83);
            btnCrearFigura.Name = "btnCrearFigura";
            btnCrearFigura.Size = new Size(94, 29);
            btnCrearFigura.TabIndex = 4;
            btnCrearFigura.Text = "Crear";
            btnCrearFigura.UseVisualStyleBackColor = true;
            btnCrearFigura.Click += btnCrearFigura_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(694, 409);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // CirculoView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Controls.Add(btnCrearFigura);
            Controls.Add(txtIngreseRadio);
            Controls.Add(label2);
            Controls.Add(lblTitulo);
            Controls.Add(dataGridViewFiguras);
            Name = "CirculoView";
            Text = "CirculoView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiguras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewFiguras;
        private Label lblTitulo;
        private Label label2;
        private TextBox txtIngreseRadio;
        private Button btnCrearFigura;
        private Button btnRegresar;
    }
}
namespace FigurasGeometricasWINFORM
{
    partial class MainViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnCrearCuadrado = new Button();
            btnCrearTriangulo = new Button();
            btnCrearCirculo = new Button();
            btnPoligono = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(44, 50);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Seleccione que figura desea crear";
            // 
            // btnCrearCuadrado
            // 
            btnCrearCuadrado.Location = new Point(12, 208);
            btnCrearCuadrado.Name = "btnCrearCuadrado";
            btnCrearCuadrado.Size = new Size(94, 29);
            btnCrearCuadrado.TabIndex = 1;
            btnCrearCuadrado.Text = "Cuadrado";
            btnCrearCuadrado.UseVisualStyleBackColor = true;
            btnCrearCuadrado.Click += btnCreateSquare_Click;
            // 
            // btnCrearTriangulo
            // 
            btnCrearTriangulo.Location = new Point(209, 208);
            btnCrearTriangulo.Name = "btnCrearTriangulo";
            btnCrearTriangulo.Size = new Size(94, 29);
            btnCrearTriangulo.TabIndex = 2;
            btnCrearTriangulo.Text = "Triangulo";
            btnCrearTriangulo.UseVisualStyleBackColor = true;
            btnCrearTriangulo.Click += btnCreateTriangle_Click;
            // 
            // btnCrearCirculo
            // 
            btnCrearCirculo.Location = new Point(12, 255);
            btnCrearCirculo.Name = "btnCrearCirculo";
            btnCrearCirculo.Size = new Size(94, 29);
            btnCrearCirculo.TabIndex = 3;
            btnCrearCirculo.Text = "Circulo";
            btnCrearCirculo.UseVisualStyleBackColor = true;
            btnCrearCirculo.Click += btnCreateCircle_Click;
            // 
            // btnPoligono
            // 
            btnPoligono.Location = new Point(209, 255);
            btnPoligono.Name = "btnPoligono";
            btnPoligono.Size = new Size(94, 29);
            btnPoligono.TabIndex = 4;
            btnPoligono.Text = "Poligono";
            btnPoligono.UseVisualStyleBackColor = true;
            btnPoligono.Click += btnPoligono_Click;
            // 
            // MainViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 336);
            Controls.Add(btnPoligono);
            Controls.Add(btnCrearTriangulo);
            Controls.Add(btnCrearCirculo);
            Controls.Add(btnCrearCuadrado);
            Controls.Add(lblTitulo);
            Name = "MainViewForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnCrearCuadrado;
        private Button btnCrearTriangulo;
        private Button btnCrearCirculo;
        private Button btnPoligono;
    }
}

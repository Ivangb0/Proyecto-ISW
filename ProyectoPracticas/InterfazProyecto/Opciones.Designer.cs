namespace InterfazProyecto
{
    partial class Opciones
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
            this.EnviarArticulo = new System.Windows.Forms.Button();
            this.EvaluarArticulo = new System.Windows.Forms.Button();
            this.ConfeccionarEjemplar = new System.Windows.Forms.Button();
            this.ListadoDeArticulos = new System.Windows.Forms.Button();
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnviarArticulo
            // 
            this.EnviarArticulo.Enabled = false;
            this.EnviarArticulo.Location = new System.Drawing.Point(330, 160);
            this.EnviarArticulo.Name = "EnviarArticulo";
            this.EnviarArticulo.Size = new System.Drawing.Size(169, 23);
            this.EnviarArticulo.TabIndex = 0;
            this.EnviarArticulo.Text = "Enviar Artículo";
            this.EnviarArticulo.UseVisualStyleBackColor = true;
            this.EnviarArticulo.Visible = false;
            this.EnviarArticulo.Click += new System.EventHandler(this.EnviarArticulo_Click);
            // 
            // EvaluarArticulo
            // 
            this.EvaluarArticulo.Enabled = false;
            this.EvaluarArticulo.Location = new System.Drawing.Point(330, 189);
            this.EvaluarArticulo.Name = "EvaluarArticulo";
            this.EvaluarArticulo.Size = new System.Drawing.Size(169, 23);
            this.EvaluarArticulo.TabIndex = 1;
            this.EvaluarArticulo.Text = "Evaluar Artículo";
            this.EvaluarArticulo.UseVisualStyleBackColor = true;
            this.EvaluarArticulo.Visible = false;
            this.EvaluarArticulo.Click += new System.EventHandler(this.EvaluarArticulo_Click);
            // 
            // ConfeccionarEjemplar
            // 
            this.ConfeccionarEjemplar.Enabled = false;
            this.ConfeccionarEjemplar.Location = new System.Drawing.Point(330, 218);
            this.ConfeccionarEjemplar.Name = "ConfeccionarEjemplar";
            this.ConfeccionarEjemplar.Size = new System.Drawing.Size(169, 23);
            this.ConfeccionarEjemplar.TabIndex = 2;
            this.ConfeccionarEjemplar.Text = "Confeccionar Ejemplar";
            this.ConfeccionarEjemplar.UseVisualStyleBackColor = true;
            this.ConfeccionarEjemplar.Visible = false;
            this.ConfeccionarEjemplar.Click += new System.EventHandler(this.ConfeccionarEjemplar_Click);
            // 
            // ListadoDeArticulos
            // 
            this.ListadoDeArticulos.Enabled = false;
            this.ListadoDeArticulos.Location = new System.Drawing.Point(330, 247);
            this.ListadoDeArticulos.Name = "ListadoDeArticulos";
            this.ListadoDeArticulos.Size = new System.Drawing.Size(169, 23);
            this.ListadoDeArticulos.TabIndex = 3;
            this.ListadoDeArticulos.Text = " Listado de Artículos";
            this.ListadoDeArticulos.UseVisualStyleBackColor = true;
            this.ListadoDeArticulos.Visible = false;
            this.ListadoDeArticulos.Click += new System.EventHandler(this.ListadoDeArticulos_Click);
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Location = new System.Drawing.Point(330, 350);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(169, 51);
            this.CerrarSesion.TabIndex = 4;
            this.CerrarSesion.Text = "Cerrar Sesión";
            this.CerrarSesion.UseVisualStyleBackColor = true;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CerrarSesion);
            this.Controls.Add(this.ListadoDeArticulos);
            this.Controls.Add(this.ConfeccionarEjemplar);
            this.Controls.Add(this.EvaluarArticulo);
            this.Controls.Add(this.EnviarArticulo);
            this.Name = "Opciones";
            this.Load += new System.EventHandler(this.Opciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnviarArticulo;
        private System.Windows.Forms.Button EvaluarArticulo;
        private System.Windows.Forms.Button ConfeccionarEjemplar;
        private System.Windows.Forms.Button ListadoDeArticulos;
        private System.Windows.Forms.Button CerrarSesion;
    }
}
namespace InterfazProyecto
{
    partial class ListadoDeArticulos
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
            this.ListadoArticulos = new System.Windows.Forms.TreeView();
            this.Volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NEjemplar = new System.Windows.Forms.TextBox();
            this.MensajeError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListadoArticulos
            // 
            this.ListadoArticulos.Location = new System.Drawing.Point(185, 72);
            this.ListadoArticulos.Name = "ListadoArticulos";
            this.ListadoArticulos.Size = new System.Drawing.Size(385, 283);
            this.ListadoArticulos.TabIndex = 0;
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(642, 377);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 1;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Ejemplar";
            // 
            // NEjemplar
            // 
            this.NEjemplar.Location = new System.Drawing.Point(335, 31);
            this.NEjemplar.Name = "NEjemplar";
            this.NEjemplar.Size = new System.Drawing.Size(100, 22);
            this.NEjemplar.TabIndex = 3;
            this.NEjemplar.TextChanged += new System.EventHandler(this.NEjemplar_TextChanged);
            // 
            // MensajeError
            // 
            this.MensajeError.AutoSize = true;
            this.MensajeError.Location = new System.Drawing.Point(335, 392);
            this.MensajeError.Name = "MensajeError";
            this.MensajeError.Size = new System.Drawing.Size(0, 16);
            this.MensajeError.TabIndex = 4;
            // 
            // ListadoDeArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MensajeError);
            this.Controls.Add(this.NEjemplar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.ListadoArticulos);
            this.Name = "ListadoDeArticulos";
            this.Text = "Listado de Artículos";
            this.Load += new System.EventHandler(this.ListadoDeArticulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView ListadoArticulos;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NEjemplar;
        private System.Windows.Forms.Label MensajeError;
    }
}
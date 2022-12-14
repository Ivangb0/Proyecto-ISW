namespace InterfazProyecto
{
    partial class EvaluarArticulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.BoxAreas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.noEvaluados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona area";
            // 
            // BoxAreas
            // 
            this.BoxAreas.FormattingEnabled = true;
            this.BoxAreas.Location = new System.Drawing.Point(392, 88);
            this.BoxAreas.Name = "BoxAreas";
            this.BoxAreas.Size = new System.Drawing.Size(121, 24);
            this.BoxAreas.TabIndex = 1;
            this.BoxAreas.SelectedIndexChanged += new System.EventHandler(this.BoxArea_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Artículos sin evaluar del área seleccionada";
            // 
            // noEvaluados
            // 
            this.noEvaluados.FormattingEnabled = true;
            this.noEvaluados.ItemHeight = 16;
            this.noEvaluados.Location = new System.Drawing.Point(59, 218);
            this.noEvaluados.Name = "noEvaluados";
            this.noEvaluados.Size = new System.Drawing.Size(635, 148);
            this.noEvaluados.TabIndex = 4;
            // 
            // EvaluarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noEvaluados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxAreas);
            this.Controls.Add(this.label1);
            this.Name = "EvaluarArticulo";
            this.Text = "Evaluar Artículo";
            this.Load += new System.EventHandler(this.EvaluarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BoxAreas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox noEvaluados;
    }
}
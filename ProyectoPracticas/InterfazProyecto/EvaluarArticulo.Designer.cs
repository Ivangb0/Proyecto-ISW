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
            this.noEvaluados = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona area";
            // 
            // BoxAreas
            // 
            this.BoxAreas.FormattingEnabled = true;
            this.BoxAreas.Location = new System.Drawing.Point(441, 110);
            this.BoxAreas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BoxAreas.Name = "BoxAreas";
            this.BoxAreas.Size = new System.Drawing.Size(136, 28);
            this.BoxAreas.TabIndex = 1;
            this.BoxAreas.SelectedIndexChanged += new System.EventHandler(this.BoxArea_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Artículos sin evaluar del área seleccionada";
            // 
            // noEvaluados
            // 
            this.noEvaluados.HideSelection = false;
            this.noEvaluados.Location = new System.Drawing.Point(68, 242);
            this.noEvaluados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.noEvaluados.Name = "noEvaluados";
            this.noEvaluados.Size = new System.Drawing.Size(735, 242);
            this.noEvaluados.TabIndex = 4;
            this.noEvaluados.UseCompatibleStateImageBehavior = false;
            this.noEvaluados.View = System.Windows.Forms.View.Details;
            this.noEvaluados.Click += new System.EventHandler(this.PaperSeleccionado);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(759, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EvaluarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.noEvaluados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxAreas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.ListView noEvaluados;
        private System.Windows.Forms.Button button1;
    }
}
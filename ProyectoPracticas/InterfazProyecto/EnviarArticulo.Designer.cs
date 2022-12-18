namespace InterfazProyecto
{
    partial class EnviarArticulo
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
            this.TituloArticulo = new System.Windows.Forms.TextBox();
            this.AreasBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CoAutorName = new System.Windows.Forms.TextBox();
            this.CoAutorSurname = new System.Windows.Forms.TextBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.CoAutorId = new System.Windows.Forms.TextBox();
            this.AddCoAuthor = new System.Windows.Forms.Button();
            this.MensajeError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // TituloArticulo
            // 
            this.TituloArticulo.Location = new System.Drawing.Point(372, 164);
            this.TituloArticulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TituloArticulo.Name = "TituloArticulo";
            this.TituloArticulo.Size = new System.Drawing.Size(231, 26);
            this.TituloArticulo.TabIndex = 1;
            // 
            // AreasBox
            // 
            this.AreasBox.FormattingEnabled = true;
            this.AreasBox.Location = new System.Drawing.Point(372, 95);
            this.AreasBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AreasBox.Name = "AreasBox";
            this.AreasBox.Size = new System.Drawing.Size(136, 28);
            this.AreasBox.TabIndex = 2;
            this.AreasBox.SelectedIndexChanged += new System.EventHandler(this.AreasBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Área";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(642, 402);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 29);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(748, 401);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre CoAutor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido CoAutor";
            // 
            // CoAutorName
            // 
            this.CoAutorName.Location = new System.Drawing.Point(372, 242);
            this.CoAutorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CoAutorName.Name = "CoAutorName";
            this.CoAutorName.Size = new System.Drawing.Size(177, 26);
            this.CoAutorName.TabIndex = 8;
            // 
            // CoAutorSurname
            // 
            this.CoAutorSurname.Location = new System.Drawing.Point(372, 284);
            this.CoAutorSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CoAutorSurname.Name = "CoAutorSurname";
            this.CoAutorSurname.Size = new System.Drawing.Size(177, 26);
            this.CoAutorSurname.TabIndex = 9;
            this.CoAutorSurname.TextChanged += new System.EventHandler(this.CoAutorSurname_TextChanged);
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(256, 331);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(100, 20);
            this.labelDNI.TabIndex = 10;
            this.labelDNI.Text = "DNI CoAutor";
            this.labelDNI.Visible = false;
            // 
            // CoAutorId
            // 
            this.CoAutorId.Location = new System.Drawing.Point(372, 328);
            this.CoAutorId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CoAutorId.Name = "CoAutorId";
            this.CoAutorId.Size = new System.Drawing.Size(177, 26);
            this.CoAutorId.TabIndex = 11;
            this.CoAutorId.Visible = false;
            // 
            // AddCoAuthor
            // 
            this.AddCoAuthor.Location = new System.Drawing.Point(294, 382);
            this.AddCoAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddCoAuthor.Name = "AddCoAuthor";
            this.AddCoAuthor.Size = new System.Drawing.Size(154, 29);
            this.AddCoAuthor.TabIndex = 12;
            this.AddCoAuthor.Text = "Añadir CoAutor";
            this.AddCoAuthor.UseVisualStyleBackColor = true;
            this.AddCoAuthor.Click += new System.EventHandler(this.AddCoAuthor_Click);
            // 
            // MensajeError
            // 
            this.MensajeError.AutoSize = true;
            this.MensajeError.Location = new System.Drawing.Point(349, 440);
            this.MensajeError.Name = "MensajeError";
            this.MensajeError.Size = new System.Drawing.Size(0, 20);
            this.MensajeError.TabIndex = 13;
            this.MensajeError.Visible = false;
            // 
            // EnviarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.MensajeError);
            this.Controls.Add(this.AddCoAuthor);
            this.Controls.Add(this.CoAutorId);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.CoAutorSurname);
            this.Controls.Add(this.CoAutorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AreasBox);
            this.Controls.Add(this.TituloArticulo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EnviarArticulo";
            this.Text = "Enviar Artículo";
            this.Load += new System.EventHandler(this.EnviarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TituloArticulo;
        private System.Windows.Forms.ComboBox AreasBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CoAutorName;
        private System.Windows.Forms.TextBox CoAutorSurname;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox CoAutorId;
        private System.Windows.Forms.Button AddCoAuthor;
        private System.Windows.Forms.Label MensajeError;
    }
}
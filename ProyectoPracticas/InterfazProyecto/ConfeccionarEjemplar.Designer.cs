namespace InterfazProyecto
{
    partial class ConfeccionarEjemplar
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
            this.nRevista = new System.Windows.Forms.Label();
            this.comboBoxAreas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ArticulosPublicados = new System.Windows.Forms.ListBox();
            this.ArticulosPendientes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MensajeError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revista número";
            // 
            // nRevista
            // 
            this.nRevista.AutoSize = true;
            this.nRevista.Location = new System.Drawing.Point(216, 42);
            this.nRevista.Name = "nRevista";
            this.nRevista.Size = new System.Drawing.Size(44, 16);
            this.nRevista.TabIndex = 1;
            this.nRevista.Text = "label2";
            // 
            // comboBoxAreas
            // 
            this.comboBoxAreas.FormattingEnabled = true;
            this.comboBoxAreas.Location = new System.Drawing.Point(219, 73);
            this.comboBoxAreas.Name = "comboBoxAreas";
            this.comboBoxAreas.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAreas.TabIndex = 2;
            this.comboBoxAreas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Área";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ArticulosPublicados
            // 
            this.ArticulosPublicados.FormattingEnabled = true;
            this.ArticulosPublicados.ItemHeight = 16;
            this.ArticulosPublicados.Location = new System.Drawing.Point(176, 173);
            this.ArticulosPublicados.Name = "ArticulosPublicados";
            this.ArticulosPublicados.Size = new System.Drawing.Size(172, 180);
            this.ArticulosPublicados.TabIndex = 4;
            // 
            // ArticulosPendientes
            // 
            this.ArticulosPendientes.FormattingEnabled = true;
            this.ArticulosPendientes.ItemHeight = 16;
            this.ArticulosPendientes.Location = new System.Drawing.Point(469, 173);
            this.ArticulosPendientes.Name = "ArticulosPendientes";
            this.ArticulosPendientes.Size = new System.Drawing.Size(170, 180);
            this.ArticulosPendientes.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nueva fecha de publicacion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(639, 396);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(544, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Artículos seleccionados para publicación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Artículos pendientes de publicación";
            // 
            // MensajeError
            // 
            this.MensajeError.AutoSize = true;
            this.MensajeError.Location = new System.Drawing.Point(350, 396);
            this.MensajeError.Name = "MensajeError";
            this.MensajeError.Size = new System.Drawing.Size(0, 16);
            this.MensajeError.TabIndex = 15;
            // 
            // ConfeccionarEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MensajeError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ArticulosPendientes);
            this.Controls.Add(this.ArticulosPublicados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAreas);
            this.Controls.Add(this.nRevista);
            this.Controls.Add(this.label1);
            this.Name = "ConfeccionarEjemplar";
            this.Text = "Confeccionar Ejemplar";
            this.Load += new System.EventHandler(this.ConfeccionarEjemplar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nRevista;
        private System.Windows.Forms.ComboBox comboBoxAreas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ArticulosPublicados;
        private System.Windows.Forms.ListBox ArticulosPendientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MensajeError;
    }
}
﻿namespace InterfazProyecto
{
    partial class AñadeComentario
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
            this.aparezcaTitutloArt = new System.Windows.Forms.Label();
            this.textoComentario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artículo seleccionado:";
            // 
            // aparezcaTitutloArt
            // 
            this.aparezcaTitutloArt.AutoSize = true;
            this.aparezcaTitutloArt.Location = new System.Drawing.Point(371, 69);
            this.aparezcaTitutloArt.Name = "aparezcaTitutloArt";
            this.aparezcaTitutloArt.Size = new System.Drawing.Size(0, 16);
            this.aparezcaTitutloArt.TabIndex = 1;
            // 
            // textoComentario
            // 
            this.textoComentario.Location = new System.Drawing.Point(153, 187);
            this.textoComentario.Multiline = true;
            this.textoComentario.Name = "textoComentario";
            this.textoComentario.Size = new System.Drawing.Size(479, 136);
            this.textoComentario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Añada un comentario al artículo seleccionado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar artículo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PaperAccepted);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Rechazar artículo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PaperRejected);
            // 
            // AñadeComentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoComentario);
            this.Controls.Add(this.aparezcaTitutloArt);
            this.Controls.Add(this.label1);
            this.Name = "AñadeComentario";
            this.Text = "AñadeComentario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aparezcaTitutloArt;
        private System.Windows.Forms.TextBox textoComentario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
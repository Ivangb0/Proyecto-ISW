namespace InterfazProyecto
{
    partial class MagazineApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IrARegistro = new System.Windows.Forms.LinkLabel();
            this.MensajeError = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.InicializaDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(370, 150);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(239, 22);
            this.login.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(370, 194);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(240, 22);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "¿No está registrado?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // IrARegistro
            // 
            this.IrARegistro.AutoSize = true;
            this.IrARegistro.Location = new System.Drawing.Point(379, 335);
            this.IrARegistro.Name = "IrARegistro";
            this.IrARegistro.Size = new System.Drawing.Size(77, 16);
            this.IrARegistro.TabIndex = 6;
            this.IrARegistro.TabStop = true;
            this.IrARegistro.Text = "Registrarse";
            this.IrARegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IrARegistro_LinkClicked);
            // 
            // MensajeError
            // 
            this.MensajeError.AutoSize = true;
            this.MensajeError.Location = new System.Drawing.Point(328, 301);
            this.MensajeError.Name = "MensajeError";
            this.MensajeError.Size = new System.Drawing.Size(0, 16);
            this.MensajeError.TabIndex = 7;
            this.MensajeError.Visible = false;
            this.MensajeError.Click += new System.EventHandler(this.label4_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(632, 335);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 8;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // InicializaDatos
            // 
            this.InicializaDatos.Location = new System.Drawing.Point(354, 393);
            this.InicializaDatos.Name = "InicializaDatos";
            this.InicializaDatos.Size = new System.Drawing.Size(75, 23);
            this.InicializaDatos.TabIndex = 9;
            this.InicializaDatos.Text = "Datos";
            this.InicializaDatos.UseVisualStyleBackColor = true;
            this.InicializaDatos.Click += new System.EventHandler(this.InicializaDatos_Click);
            // 
            // MagazineApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 463);
            this.Controls.Add(this.InicializaDatos);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.MensajeError);
            this.Controls.Add(this.IrARegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.button1);
            this.Name = "MagazineApp";
            this.Text = "MagazineApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel IrARegistro;
        private System.Windows.Forms.Label MensajeError;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button InicializaDatos;
    }
}


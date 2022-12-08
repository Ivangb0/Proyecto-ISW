namespace InterfazProyecto
{
    partial class Registro
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
            this.label = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConfPassword = new System.Windows.Forms.Label();
            this.RegLogin = new System.Windows.Forms.TextBox();
            this.RegEmail = new System.Windows.Forms.TextBox();
            this.RegPassword = new System.Windows.Forms.TextBox();
            this.RegConfPassword = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RegInicioSesion = new System.Windows.Forms.LinkLabel();
            this.RegSurname = new System.Windows.Forms.TextBox();
            this.RegName = new System.Windows.Forms.TextBox();
            this.RegId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegAreasInterest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RegAlerted = new System.Windows.Forms.CheckBox();
            this.MensajeError = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(279, 180);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(40, 16);
            this.label.TabIndex = 0;
            this.label.Text = "Login";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(279, 221);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(41, 16);
            this.LabelEmail.TabIndex = 1;
            this.LabelEmail.Text = "Email";
            this.LabelEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(252, 261);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 16);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // labelConfPassword
            // 
            this.labelConfPassword.AutoSize = true;
            this.labelConfPassword.Location = new System.Drawing.Point(204, 303);
            this.labelConfPassword.Name = "labelConfPassword";
            this.labelConfPassword.Size = new System.Drawing.Size(115, 16);
            this.labelConfPassword.TabIndex = 3;
            this.labelConfPassword.Text = "Confirm Password";
            // 
            // RegLogin
            // 
            this.RegLogin.Location = new System.Drawing.Point(329, 177);
            this.RegLogin.Name = "RegLogin";
            this.RegLogin.Size = new System.Drawing.Size(198, 22);
            this.RegLogin.TabIndex = 4;
            // 
            // RegEmail
            // 
            this.RegEmail.Location = new System.Drawing.Point(329, 218);
            this.RegEmail.Name = "RegEmail";
            this.RegEmail.Size = new System.Drawing.Size(198, 22);
            this.RegEmail.TabIndex = 5;
            // 
            // RegPassword
            // 
            this.RegPassword.Location = new System.Drawing.Point(329, 258);
            this.RegPassword.Name = "RegPassword";
            this.RegPassword.Size = new System.Drawing.Size(198, 22);
            this.RegPassword.TabIndex = 6;
            // 
            // RegConfPassword
            // 
            this.RegConfPassword.Location = new System.Drawing.Point(329, 300);
            this.RegConfPassword.Name = "RegConfPassword";
            this.RegConfPassword.Size = new System.Drawing.Size(198, 22);
            this.RegConfPassword.TabIndex = 7;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(292, 363);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(130, 39);
            this.btnRegistrarse.TabIndex = 8;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ya estoy registrado.";
            // 
            // RegInicioSesion
            // 
            this.RegInicioSesion.AutoSize = true;
            this.RegInicioSesion.Location = new System.Drawing.Point(386, 418);
            this.RegInicioSesion.Name = "RegInicioSesion";
            this.RegInicioSesion.Size = new System.Drawing.Size(83, 16);
            this.RegInicioSesion.TabIndex = 10;
            this.RegInicioSesion.TabStop = true;
            this.RegInicioSesion.Text = "Inicio Sesión";
            this.RegInicioSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegInicioSesion_LinkClicked);
            // 
            // RegSurname
            // 
            this.RegSurname.Location = new System.Drawing.Point(329, 102);
            this.RegSurname.Name = "RegSurname";
            this.RegSurname.Size = new System.Drawing.Size(198, 22);
            this.RegSurname.TabIndex = 16;
            // 
            // RegName
            // 
            this.RegName.Location = new System.Drawing.Point(329, 62);
            this.RegName.Name = "RegName";
            this.RegName.Size = new System.Drawing.Size(198, 22);
            this.RegName.TabIndex = 15;
            // 
            // RegId
            // 
            this.RegId.Location = new System.Drawing.Point(329, 21);
            this.RegId.Name = "RegId";
            this.RegId.Size = new System.Drawing.Size(198, 22);
            this.RegId.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "DNI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // RegAreasInterest
            // 
            this.RegAreasInterest.Location = new System.Drawing.Point(329, 140);
            this.RegAreasInterest.Name = "RegAreasInterest";
            this.RegAreasInterest.Size = new System.Drawing.Size(198, 22);
            this.RegAreasInterest.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Áreas de interés";
            // 
            // RegAlerted
            // 
            this.RegAlerted.AutoSize = true;
            this.RegAlerted.Location = new System.Drawing.Point(304, 337);
            this.RegAlerted.Name = "RegAlerted";
            this.RegAlerted.Size = new System.Drawing.Size(175, 20);
            this.RegAlerted.TabIndex = 19;
            this.RegAlerted.Text = "Recibir alertas por email";
            this.RegAlerted.UseVisualStyleBackColor = true;
            // 
            // MensajeError
            // 
            this.MensajeError.AutoSize = true;
            this.MensajeError.Location = new System.Drawing.Point(434, 385);
            this.MensajeError.Name = "MensajeError";
            this.MensajeError.Size = new System.Drawing.Size(0, 16);
            this.MensajeError.TabIndex = 20;
            this.MensajeError.Visible = false;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(639, 385);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 21;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.MensajeError);
            this.Controls.Add(this.RegAlerted);
            this.Controls.Add(this.RegAreasInterest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RegSurname);
            this.Controls.Add(this.RegName);
            this.Controls.Add(this.RegId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegInicioSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.RegConfPassword);
            this.Controls.Add(this.RegPassword);
            this.Controls.Add(this.RegEmail);
            this.Controls.Add(this.RegLogin);
            this.Controls.Add(this.labelConfPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.label);
            this.Name = "Registro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfPassword;
        private System.Windows.Forms.TextBox RegLogin;
        private System.Windows.Forms.TextBox RegEmail;
        private System.Windows.Forms.TextBox RegPassword;
        private System.Windows.Forms.TextBox RegConfPassword;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel RegInicioSesion;
        private System.Windows.Forms.TextBox RegSurname;
        private System.Windows.Forms.TextBox RegName;
        private System.Windows.Forms.TextBox RegId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RegAreasInterest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox RegAlerted;
        private System.Windows.Forms.Label MensajeError;
        private System.Windows.Forms.Button Salir;
    }
}
﻿namespace Gestion_Laboratorios
{
    partial class Login_Usuario
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
            this.lblmensaje = new System.Windows.Forms.Label();
            this.IdtipoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(0, 0);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(0, 17);
            this.lblmensaje.TabIndex = 0;
            // 
            // IdtipoUsuario
            // 
            this.IdtipoUsuario.AutoSize = true;
            this.IdtipoUsuario.Location = new System.Drawing.Point(546, 105);
            this.IdtipoUsuario.Name = "IdtipoUsuario";
            this.IdtipoUsuario.Size = new System.Drawing.Size(57, 17);
            this.IdtipoUsuario.TabIndex = 1;
            this.IdtipoUsuario.Text = "Usuario";
            // 
            // Login_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IdtipoUsuario);
            this.Controls.Add(this.lblmensaje);
            this.Name = "Login_Usuario";
            this.Text = "Login_Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label IdtipoUsuario;
    }
}
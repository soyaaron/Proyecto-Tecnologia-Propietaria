namespace Gestion_Laboratorios
{
    partial class FrmReservacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtN_Reservacion = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.fexhaReserva = new System.Windows.Forms.DateTimePicker();
            this.txtComentario = new System.Windows.Forms.RichTextBox();
            this.BtnGuardarReserva = new System.Windows.Forms.Button();
            this.BtnCancelarReserva = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidadHoras = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comentario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de reservación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario";
            // 
            // txtN_Reservacion
            // 
            this.txtN_Reservacion.Location = new System.Drawing.Point(147, 29);
            this.txtN_Reservacion.Name = "txtN_Reservacion";
            this.txtN_Reservacion.Size = new System.Drawing.Size(100, 20);
            this.txtN_Reservacion.TabIndex = 5;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(147, 56);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtEmpleado.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(147, 85);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // fexhaReserva
            // 
            this.fexhaReserva.Location = new System.Drawing.Point(147, 111);
            this.fexhaReserva.Name = "fexhaReserva";
            this.fexhaReserva.Size = new System.Drawing.Size(200, 20);
            this.fexhaReserva.TabIndex = 8;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(147, 163);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(200, 67);
            this.txtComentario.TabIndex = 9;
            this.txtComentario.Text = "";
            // 
            // BtnGuardarReserva
            // 
            this.BtnGuardarReserva.Location = new System.Drawing.Point(302, 279);
            this.BtnGuardarReserva.Name = "BtnGuardarReserva";
            this.BtnGuardarReserva.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardarReserva.TabIndex = 10;
            this.BtnGuardarReserva.Text = "Guardar";
            this.BtnGuardarReserva.UseVisualStyleBackColor = true;
            this.BtnGuardarReserva.Click += new System.EventHandler(this.BtnGuardarReserva_Click);
            // 
            // BtnCancelarReserva
            // 
            this.BtnCancelarReserva.Location = new System.Drawing.Point(383, 279);
            this.BtnCancelarReserva.Name = "BtnCancelarReserva";
            this.BtnCancelarReserva.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarReserva.TabIndex = 11;
            this.BtnCancelarReserva.Text = "Cancelar";
            this.BtnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad de horas";
            // 
            // txtCantidadHoras
            // 
            this.txtCantidadHoras.Location = new System.Drawing.Point(147, 137);
            this.txtCantidadHoras.Name = "txtCantidadHoras";
            this.txtCantidadHoras.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadHoras.TabIndex = 13;
            // 
            // FrmReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 316);
            this.Controls.Add(this.txtCantidadHoras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCancelarReserva);
            this.Controls.Add(this.BtnGuardarReserva);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.fexhaReserva);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtN_Reservacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmReservacion";
            this.Text = "Reservar";
            this.Load += new System.EventHandler(this.FrmReservar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtN_Reservacion;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DateTimePicker fexhaReserva;
        private System.Windows.Forms.RichTextBox txtComentario;
        private System.Windows.Forms.Button BtnGuardarReserva;
        private System.Windows.Forms.Button BtnCancelarReserva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidadHoras;
    }
}
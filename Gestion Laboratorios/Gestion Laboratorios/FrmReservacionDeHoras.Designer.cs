namespace Gestion_Laboratorios
{
    partial class FrmReservacionDeHoras
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReservacion = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.CbxAula = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.DateFecha = new System.Windows.Forms.DateTimePicker();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.txtEstados = new System.Windows.Forms.TextBox();
            this.CmdImprimir = new System.Windows.Forms.Button();
            this.CmdEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Reservacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comentario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad Horas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Reservacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Empleado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estado";
            // 
            // txtReservacion
            // 
            this.txtReservacion.Location = new System.Drawing.Point(216, 26);
            this.txtReservacion.Name = "txtReservacion";
            this.txtReservacion.Size = new System.Drawing.Size(100, 20);
            this.txtReservacion.TabIndex = 8;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(192, 54);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtEmpleado.TabIndex = 9;
            // 
            // CbxAula
            // 
            this.CbxAula.FormattingEnabled = true;
            this.CbxAula.Location = new System.Drawing.Point(171, 83);
            this.CbxAula.Name = "CbxAula";
            this.CbxAula.Size = new System.Drawing.Size(121, 21);
            this.CbxAula.TabIndex = 10;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(171, 116);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 11;
            // 
            // DateFecha
            // 
            this.DateFecha.Location = new System.Drawing.Point(229, 142);
            this.DateFecha.Name = "DateFecha";
            this.DateFecha.Size = new System.Drawing.Size(200, 20);
            this.DateFecha.TabIndex = 13;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(209, 175);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 20);
            this.txtHoras.TabIndex = 14;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(192, 205);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(100, 20);
            this.txtComentarios.TabIndex = 15;
            // 
            // txtEstados
            // 
            this.txtEstados.Location = new System.Drawing.Point(169, 234);
            this.txtEstados.Name = "txtEstados";
            this.txtEstados.Size = new System.Drawing.Size(100, 20);
            this.txtEstados.TabIndex = 16;
            // 
            // CmdImprimir
            // 
            this.CmdImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdImprimir.BackgroundImage = global::Gestion_Laboratorios.Properties.Resources._61764;
            this.CmdImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CmdImprimir.Location = new System.Drawing.Point(229, 296);
            this.CmdImprimir.Name = "CmdImprimir";
            this.CmdImprimir.Size = new System.Drawing.Size(80, 79);
            this.CmdImprimir.TabIndex = 17;
            this.CmdImprimir.UseVisualStyleBackColor = true;
            this.CmdImprimir.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CmdEliminar.BackgroundImage = global::Gestion_Laboratorios.Properties.Resources.download;
            this.CmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CmdEliminar.Location = new System.Drawing.Point(367, 296);
            this.CmdEliminar.Name = "CmdEliminar";
            this.CmdEliminar.Size = new System.Drawing.Size(80, 79);
            this.CmdEliminar.TabIndex = 18;
            this.CmdEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmReservacionDeHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdEliminar);
            this.Controls.Add(this.CmdImprimir);
            this.Controls.Add(this.txtEstados);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.DateFecha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.CbxAula);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtReservacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmReservacionDeHoras";
            this.Text = "FrmReservacionDeHoras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReservacion;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.ComboBox CbxAula;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DateTimePicker DateFecha;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.TextBox txtEstados;
        private System.Windows.Forms.Button CmdImprimir;
        private System.Windows.Forms.Button CmdEliminar;
    }
}
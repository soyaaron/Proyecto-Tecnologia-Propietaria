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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.fexhaReserva = new System.Windows.Forms.DateTimePicker();
            this.txtComentario = new System.Windows.Forms.RichTextBox();
            this.BtnGuardarReserva = new System.Windows.Forms.Button();
            this.BtnCancelarReserva = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAulaReserv = new System.Windows.Forms.ComboBox();
            this.gestion_laboratoriosDataSet = new Gestion_Laboratorios.Gestion_laboratoriosDataSet();
            this.aulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulaTableAdapter = new Gestion_Laboratorios.Gestion_laboratoriosDataSetTableAdapters.AulaTableAdapter();
            this.DTHorasReserva = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxEstadoAulaReserv = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numNumeroReserv = new System.Windows.Forms.NumericUpDown();
            this.EliminarReserv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_laboratoriosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroReserv)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comentario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de reservación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(167, 50);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtEmpleado.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(167, 79);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // fexhaReserva
            // 
            this.fexhaReserva.CustomFormat = "YYYY/mm/dd";
            this.fexhaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fexhaReserva.Location = new System.Drawing.Point(167, 105);
            this.fexhaReserva.Name = "fexhaReserva";
            this.fexhaReserva.Size = new System.Drawing.Size(100, 20);
            this.fexhaReserva.TabIndex = 8;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(167, 235);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(200, 67);
            this.txtComentario.TabIndex = 9;
            this.txtComentario.Text = "";
            // 
            // BtnGuardarReserva
            // 
            this.BtnGuardarReserva.Location = new System.Drawing.Point(302, 308);
            this.BtnGuardarReserva.Name = "BtnGuardarReserva";
            this.BtnGuardarReserva.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardarReserva.TabIndex = 10;
            this.BtnGuardarReserva.Text = "Guardar";
            this.BtnGuardarReserva.UseVisualStyleBackColor = true;
            this.BtnGuardarReserva.Click += new System.EventHandler(this.BtnGuardarReserva_Click);
            // 
            // BtnCancelarReserva
            // 
            this.BtnCancelarReserva.Location = new System.Drawing.Point(383, 308);
            this.BtnCancelarReserva.Name = "BtnCancelarReserva";
            this.BtnCancelarReserva.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarReserva.TabIndex = 11;
            this.BtnCancelarReserva.Text = "Cancelar";
            this.BtnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad de horas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Aula";
            // 
            // cbxAulaReserv
            // 
            this.cbxAulaReserv.FormattingEnabled = true;
            this.cbxAulaReserv.Items.AddRange(new object[] {
            "LAB-A",
            "LAB-B",
            "LAB-C"});
            this.cbxAulaReserv.Location = new System.Drawing.Point(167, 158);
            this.cbxAulaReserv.Name = "cbxAulaReserv";
            this.cbxAulaReserv.Size = new System.Drawing.Size(121, 21);
            this.cbxAulaReserv.TabIndex = 15;
            this.cbxAulaReserv.SelectedIndexChanged += new System.EventHandler(this.CbxAulaReserv_SelectedIndexChanged);
            // 
            // gestion_laboratoriosDataSet
            // 
            this.gestion_laboratoriosDataSet.DataSetName = "Gestion_laboratoriosDataSet";
            this.gestion_laboratoriosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aulaBindingSource
            // 
            this.aulaBindingSource.DataMember = "Aula";
            this.aulaBindingSource.DataSource = this.gestion_laboratoriosDataSet;
            // 
            // aulaTableAdapter
            // 
            this.aulaTableAdapter.ClearBeforeFill = true;
            // 
            // DTHorasReserva
            // 
            this.DTHorasReserva.CustomFormat = "HH:mm:ss";
            this.DTHorasReserva.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTHorasReserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTHorasReserva.Location = new System.Drawing.Point(167, 128);
            this.DTHorasReserva.Name = "DTHorasReserva";
            this.DTHorasReserva.Size = new System.Drawing.Size(100, 20);
            this.DTHorasReserva.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Estado";
            // 
            // cbxEstadoAulaReserv
            // 
            this.cbxEstadoAulaReserv.FormattingEnabled = true;
            this.cbxEstadoAulaReserv.Items.AddRange(new object[] {
            "Disponible",
            "Reservado",
            "Deshabilitado"});
            this.cbxEstadoAulaReserv.Location = new System.Drawing.Point(167, 193);
            this.cbxEstadoAulaReserv.Name = "cbxEstadoAulaReserv";
            this.cbxEstadoAulaReserv.Size = new System.Drawing.Size(121, 21);
            this.cbxEstadoAulaReserv.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Numero Reserv.";
            // 
            // numNumeroReserv
            // 
            this.numNumeroReserv.Enabled = false;
            this.numNumeroReserv.InterceptArrowKeys = false;
            this.numNumeroReserv.Location = new System.Drawing.Point(167, 25);
            this.numNumeroReserv.Name = "numNumeroReserv";
            this.numNumeroReserv.Size = new System.Drawing.Size(68, 20);
            this.numNumeroReserv.TabIndex = 20;
            // 
            // EliminarReserv
            // 
            this.EliminarReserv.Location = new System.Drawing.Point(361, 12);
            this.EliminarReserv.Name = "EliminarReserv";
            this.EliminarReserv.Size = new System.Drawing.Size(97, 23);
            this.EliminarReserv.TabIndex = 21;
            this.EliminarReserv.Text = "Eliminar Reserva";
            this.EliminarReserv.UseVisualStyleBackColor = true;
            this.EliminarReserv.Click += new System.EventHandler(this.EliminarReserv_Click);
            // 
            // FrmReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 343);
            this.Controls.Add(this.EliminarReserv);
            this.Controls.Add(this.numNumeroReserv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxEstadoAulaReserv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DTHorasReserva);
            this.Controls.Add(this.cbxAulaReserv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCancelarReserva);
            this.Controls.Add(this.BtnGuardarReserva);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.fexhaReserva);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmReservacion";
            this.Text = "Reservar";
            this.Load += new System.EventHandler(this.FrmReservar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_laboratoriosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroReserv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DateTimePicker fexhaReserva;
        private System.Windows.Forms.RichTextBox txtComentario;
        private System.Windows.Forms.Button BtnGuardarReserva;
        private System.Windows.Forms.Button BtnCancelarReserva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAulaReserv;
        private Gestion_laboratoriosDataSet gestion_laboratoriosDataSet;
        private System.Windows.Forms.BindingSource aulaBindingSource;
        private Gestion_laboratoriosDataSetTableAdapters.AulaTableAdapter aulaTableAdapter;
        private System.Windows.Forms.DateTimePicker DTHorasReserva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxEstadoAulaReserv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numNumeroReserv;
        private System.Windows.Forms.Button EliminarReserv;
    }
}
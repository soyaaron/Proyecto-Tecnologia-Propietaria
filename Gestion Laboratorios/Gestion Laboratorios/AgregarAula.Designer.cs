namespace Gestion_Laboratorios
{
    partial class AgregarAula
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
            this.cbxEstadoAulaReserv = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnCancelarReserva = new System.Windows.Forms.Button();
            this.BtnGuardarAula = new System.Windows.Forms.Button();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEdificio = new System.Windows.Forms.ComboBox();
            this.cbxTipoAula = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxEstadoAulaReserv
            // 
            this.cbxEstadoAulaReserv.FormattingEnabled = true;
            this.cbxEstadoAulaReserv.Items.AddRange(new object[] {
            "Disponible",
            "Reservado",
            "Deshabilitado"});
            this.cbxEstadoAulaReserv.Location = new System.Drawing.Point(147, 96);
            this.cbxEstadoAulaReserv.Name = "cbxEstadoAulaReserv";
            this.cbxEstadoAulaReserv.Size = new System.Drawing.Size(100, 21);
            this.cbxEstadoAulaReserv.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Estado";
            // 
            // BtnCancelarReserva
            // 
            this.BtnCancelarReserva.Location = new System.Drawing.Point(388, 162);
            this.BtnCancelarReserva.Name = "BtnCancelarReserva";
            this.BtnCancelarReserva.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarReserva.TabIndex = 28;
            this.BtnCancelarReserva.Text = "Cancelar";
            this.BtnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // BtnGuardarAula
            // 
            this.BtnGuardarAula.Location = new System.Drawing.Point(307, 162);
            this.BtnGuardarAula.Name = "BtnGuardarAula";
            this.BtnGuardarAula.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardarAula.TabIndex = 27;
            this.BtnGuardarAula.Text = "Guardar";
            this.BtnGuardarAula.UseVisualStyleBackColor = true;
            this.BtnGuardarAula.Click += new System.EventHandler(this.BtnGuardarAula_Click);
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(147, 14);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(100, 20);
            this.txtAula.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tipo aula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Aula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Edificio";
            // 
            // cbxEdificio
            // 
            this.cbxEdificio.FormattingEnabled = true;
            this.cbxEdificio.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxEdificio.Location = new System.Drawing.Point(147, 40);
            this.cbxEdificio.Name = "cbxEdificio";
            this.cbxEdificio.Size = new System.Drawing.Size(100, 21);
            this.cbxEdificio.TabIndex = 36;
            // 
            // cbxTipoAula
            // 
            this.cbxTipoAula.FormattingEnabled = true;
            this.cbxTipoAula.Items.AddRange(new object[] {
            "Laboratorio",
            "Taller"});
            this.cbxTipoAula.Location = new System.Drawing.Point(147, 67);
            this.cbxTipoAula.Name = "cbxTipoAula";
            this.cbxTipoAula.Size = new System.Drawing.Size(100, 21);
            this.cbxTipoAula.TabIndex = 37;
            // 
            // AgregarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 201);
            this.Controls.Add(this.cbxTipoAula);
            this.Controls.Add(this.cbxEdificio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEstadoAulaReserv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCancelarReserva);
            this.Controls.Add(this.BtnGuardarAula);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "AgregarAula";
            this.Text = "AgregarAula";
            this.Load += new System.EventHandler(this.AgregarAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEstadoAulaReserv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCancelarReserva;
        private System.Windows.Forms.Button BtnGuardarAula;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEdificio;
        private System.Windows.Forms.ComboBox cbxTipoAula;
    }
}
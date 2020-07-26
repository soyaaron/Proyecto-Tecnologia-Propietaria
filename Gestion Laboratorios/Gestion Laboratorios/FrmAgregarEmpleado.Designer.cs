namespace Gestion_Laboratorios
{
    partial class FrmAgregarEmpleado
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
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidoEmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxTanda = new System.Windows.Forms.ComboBox();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.numIdEmp = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIdEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(124, 97);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(160, 20);
            this.txtCedula.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Tanda";
            // 
            // txtApellidoEmp
            // 
            this.txtApellidoEmp.Location = new System.Drawing.Point(124, 70);
            this.txtApellidoEmp.Name = "txtApellidoEmp";
            this.txtApellidoEmp.Size = new System.Drawing.Size(160, 20);
            this.txtApellidoEmp.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Apellido";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstado.Location = new System.Drawing.Point(124, 182);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 21);
            this.cbxEstado.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Fecha Ingreso";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(406, 16);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 63;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(320, 318);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 62;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(401, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbxTanda
            // 
            this.cbxTanda.FormattingEnabled = true;
            this.cbxTanda.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Nocturno"});
            this.cbxTanda.Location = new System.Drawing.Point(124, 124);
            this.cbxTanda.Name = "cbxTanda";
            this.cbxTanda.Size = new System.Drawing.Size(121, 21);
            this.cbxTanda.TabIndex = 60;
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new System.Drawing.Point(124, 41);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(160, 20);
            this.txtNombreEmp.TabIndex = 59;
            // 
            // numIdEmp
            // 
            this.numIdEmp.Location = new System.Drawing.Point(124, 15);
            this.numIdEmp.Name = "numIdEmp";
            this.numIdEmp.Size = new System.Drawing.Size(50, 20);
            this.numIdEmp.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nombre";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.CustomFormat = "YYYY/mm/dd";
            this.fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaIngreso.Location = new System.Drawing.Point(124, 156);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(121, 20);
            this.fechaIngreso.TabIndex = 72;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(124, 238);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(160, 20);
            this.txtContrasena.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Contrasena";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(124, 209);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(160, 20);
            this.txtUsuario.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "Usuario";
            // 
            // FrmAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 353);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fechaIngreso);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApellidoEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbxTanda);
            this.Controls.Add(this.txtNombreEmp);
            this.Controls.Add(this.numIdEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.FrmAgregarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numIdEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellidoEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxTanda;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.NumericUpDown numIdEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaIngreso;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label9;
    }
}
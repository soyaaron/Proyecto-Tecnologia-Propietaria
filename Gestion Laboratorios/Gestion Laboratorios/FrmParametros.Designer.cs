namespace Gestion_Laboratorios
{
    partial class FrmParametros
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
            this.Matricula = new System.Windows.Forms.Label();
            this.TxtCarrera = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.RbtInactivo = new System.Windows.Forms.RadioButton();
            this.txtMatriculaDesde = new System.Windows.Forms.Label();
            this.txtMatriculaHasta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Matricula
            // 
            this.Matricula.AutoSize = true;
            this.Matricula.Location = new System.Drawing.Point(56, 54);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(50, 13);
            this.Matricula.TabIndex = 0;
            this.Matricula.Text = "Matricula";
            this.Matricula.Click += new System.EventHandler(this.Matricula_Click);
            // 
            // TxtCarrera
            // 
            this.TxtCarrera.AutoSize = true;
            this.TxtCarrera.Location = new System.Drawing.Point(65, 112);
            this.TxtCarrera.Name = "TxtCarrera";
            this.TxtCarrera.Size = new System.Drawing.Size(41, 13);
            this.TxtCarrera.TabIndex = 1;
            this.TxtCarrera.Text = "Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(440, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(231, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.Location = new System.Drawing.Point(195, 154);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtActivo.TabIndex = 6;
            this.rbtActivo.TabStop = true;
            this.rbtActivo.Text = "Activo";
            this.rbtActivo.UseVisualStyleBackColor = true;
            // 
            // RbtInactivo
            // 
            this.RbtInactivo.AutoSize = true;
            this.RbtInactivo.Location = new System.Drawing.Point(308, 154);
            this.RbtInactivo.Name = "RbtInactivo";
            this.RbtInactivo.Size = new System.Drawing.Size(63, 17);
            this.RbtInactivo.TabIndex = 7;
            this.RbtInactivo.TabStop = true;
            this.RbtInactivo.Text = "Inactivo";
            this.RbtInactivo.UseVisualStyleBackColor = true;
            // 
            // txtMatriculaDesde
            // 
            this.txtMatriculaDesde.AutoSize = true;
            this.txtMatriculaDesde.Location = new System.Drawing.Point(187, 54);
            this.txtMatriculaDesde.Name = "txtMatriculaDesde";
            this.txtMatriculaDesde.Size = new System.Drawing.Size(41, 13);
            this.txtMatriculaDesde.TabIndex = 8;
            this.txtMatriculaDesde.Text = "Desde:";
            // 
            // txtMatriculaHasta
            // 
            this.txtMatriculaHasta.AutoSize = true;
            this.txtMatriculaHasta.Location = new System.Drawing.Point(388, 54);
            this.txtMatriculaHasta.Name = "txtMatriculaHasta";
            this.txtMatriculaHasta.Size = new System.Drawing.Size(38, 13);
            this.txtMatriculaHasta.TabIndex = 9;
            this.txtMatriculaHasta.Text = "Hasta:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_Laboratorios.Properties.Resources._61764;
            this.pictureBox1.Location = new System.Drawing.Point(357, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMatriculaHasta);
            this.Controls.Add(this.txtMatriculaDesde);
            this.Controls.Add(this.RbtInactivo);
            this.Controls.Add(this.rbtActivo);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCarrera);
            this.Controls.Add(this.Matricula);
            this.Name = "FrmParametros";
            this.Text = "FrmParametros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Matricula;
        private System.Windows.Forms.Label TxtCarrera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.RadioButton RbtInactivo;
        private System.Windows.Forms.Label txtMatriculaDesde;
        private System.Windows.Forms.Label txtMatriculaHasta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
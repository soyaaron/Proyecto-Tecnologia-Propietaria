namespace Gestion_Laboratorios
{
    partial class Gestion_de_Campus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_de_Campus));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAgregarCampus = new System.Windows.Forms.Button();
            this.CmdBuscar = new System.Windows.Forms.Button();
            this.dgvCampus = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqCampus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Campus:";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "campus";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "01 - Gomez",
            "02 - Cafan",
            "03 - Cibao"});
            this.comboBox1.Location = new System.Drawing.Point(272, 11);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btnAgregarCampus
            // 
            this.btnAgregarCampus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarCampus.BackgroundImage")));
            this.btnAgregarCampus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarCampus.Location = new System.Drawing.Point(540, 11);
            this.btnAgregarCampus.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCampus.Name = "btnAgregarCampus";
            this.btnAgregarCampus.Size = new System.Drawing.Size(51, 51);
            this.btnAgregarCampus.TabIndex = 12;
            this.btnAgregarCampus.UseVisualStyleBackColor = true;
            this.btnAgregarCampus.Click += new System.EventHandler(this.BtnAgregarCampus_Click);
            // 
            // CmdBuscar
            // 
            this.CmdBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CmdBuscar.BackgroundImage")));
            this.CmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CmdBuscar.Location = new System.Drawing.Point(482, 11);
            this.CmdBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.CmdBuscar.Name = "CmdBuscar";
            this.CmdBuscar.Size = new System.Drawing.Size(51, 51);
            this.CmdBuscar.TabIndex = 3;
            this.CmdBuscar.UseVisualStyleBackColor = true;
            this.CmdBuscar.Click += new System.EventHandler(this.btnBuscarCampus);
            // 
            // dgvCampus
            // 
            this.dgvCampus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampus.Location = new System.Drawing.Point(16, 104);
            this.dgvCampus.Name = "dgvCampus";
            this.dgvCampus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCampus.Size = new System.Drawing.Size(574, 287);
            this.dgvCampus.TabIndex = 14;
            this.dgvCampus.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCampusDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bsuqueda";
            // 
            // txtBusqCampus
            // 
            this.txtBusqCampus.Location = new System.Drawing.Point(74, 11);
            this.txtBusqCampus.Name = "txtBusqCampus";
            this.txtBusqCampus.Size = new System.Drawing.Size(100, 20);
            this.txtBusqCampus.TabIndex = 16;
            // 
            // Gestion_de_Campus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 403);
            this.Controls.Add(this.txtBusqCampus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCampus);
            this.Controls.Add(this.btnAgregarCampus);
            this.Controls.Add(this.CmdBuscar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gestion_de_Campus";
            this.Text = "Gestion de Campus";
            this.Activated += new System.EventHandler(this.GestionCampusAct);
            this.Load += new System.EventHandler(this.Gestion_de_Campus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CmdBuscar;
        private System.Windows.Forms.Button btnAgregarCampus;
        private System.Windows.Forms.DataGridView dgvCampus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqCampus;
    }
}
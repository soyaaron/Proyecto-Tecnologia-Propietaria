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
            this.btnAgregarCampus = new System.Windows.Forms.Button();
            this.CmdBuscar = new System.Windows.Forms.Button();
            this.dgvCampus = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqCampus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarCampus
            // 
            this.btnAgregarCampus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarCampus.BackgroundImage")));
            this.btnAgregarCampus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarCampus.Location = new System.Drawing.Point(388, 11);
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
            this.CmdBuscar.Location = new System.Drawing.Point(330, 11);
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
            this.dgvCampus.Size = new System.Drawing.Size(423, 287);
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
            this.ClientSize = new System.Drawing.Size(457, 403);
            this.Controls.Add(this.txtBusqCampus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCampus);
            this.Controls.Add(this.btnAgregarCampus);
            this.Controls.Add(this.CmdBuscar);
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
        private System.Windows.Forms.Button CmdBuscar;
        private System.Windows.Forms.Button btnAgregarCampus;
        private System.Windows.Forms.DataGridView dgvCampus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqCampus;
    }
}
namespace Gestion_Laboratorios
{
    partial class FrmGestionAulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionAulas));
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.gestion_laboratoriosDataSet = new Gestion_Laboratorios.Gestion_laboratoriosDataSet();
            this.aulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulaTableAdapter = new Gestion_Laboratorios.Gestion_laboratoriosDataSetTableAdapters.AulaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBusqAula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_laboratoriosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAulas
            // 
            this.dgvAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulas.Location = new System.Drawing.Point(12, 88);
            this.dgvAulas.Name = "dgvAulas";
            this.dgvAulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAulas.Size = new System.Drawing.Size(892, 350);
            this.dgvAulas.TabIndex = 0;
            this.dgvAulas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdoubleclick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(780, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agregar aula";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(853, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 51);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DirigirAgregarAula);
            // 
            // txtBusqAula
            // 
            this.txtBusqAula.Location = new System.Drawing.Point(12, 13);
            this.txtBusqAula.Name = "txtBusqAula";
            this.txtBusqAula.Size = new System.Drawing.Size(100, 20);
            this.txtBusqAula.TabIndex = 6;
            // 
            // FrmGestionAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.txtBusqAula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAulas);
            this.Name = "FrmGestionAulas";
            this.Text = "Gestion de aulas";
            this.Activated += new System.EventHandler(this.GestAulaAct);
            this.Load += new System.EventHandler(this.FrmGestionAulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_laboratoriosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAulas;
        private Gestion_laboratoriosDataSet gestion_laboratoriosDataSet;
        private System.Windows.Forms.BindingSource aulaBindingSource;
        private Gestion_laboratoriosDataSetTableAdapters.AulaTableAdapter aulaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBusqAula;
    }
}
namespace Gestion_Laboratorios
{
    partial class GestionEdificiosForm
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
            this.Buscar = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.txtBusqEd = new System.Windows.Forms.TextBox();
            this.gestion_laboratoriosDataSet = new Gestion_Laboratorios.Gestion_laboratoriosDataSet();
            this.gestionlaboratoriosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edificiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edificiosTableAdapter = new Gestion_Laboratorios.Gestion_laboratoriosDataSetTableAdapters.EdificiosTableAdapter();
            this.tableAdapterManager = new Gestion_Laboratorios.Gestion_laboratoriosDataSetTableAdapters.TableAdapterManager();
            this.dgvEdificios = new System.Windows.Forms.DataGridView();
            this.btnAgregarEdifico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_laboratoriosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionlaboratoriosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdificios)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Campus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado";
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Location = new System.Drawing.Point(58, 31);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(40, 13);
            this.Buscar.TabIndex = 3;
            this.Buscar.Text = "Buscar";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(151, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(401, 28);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // txtBusqEd
            // 
            this.txtBusqEd.Location = new System.Drawing.Point(151, 28);
            this.txtBusqEd.Name = "txtBusqEd";
            this.txtBusqEd.Size = new System.Drawing.Size(121, 20);
            this.txtBusqEd.TabIndex = 7;
            // 
            // gestion_laboratoriosDataSet
            // 
            this.gestion_laboratoriosDataSet.DataSetName = "Gestion_laboratoriosDataSet";
            this.gestion_laboratoriosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionlaboratoriosDataSetBindingSource
            // 
            this.gestionlaboratoriosDataSetBindingSource.DataSource = this.gestion_laboratoriosDataSet;
            this.gestionlaboratoriosDataSetBindingSource.Position = 0;
            // 
            // edificiosBindingSource
            // 
            this.edificiosBindingSource.DataMember = "Edificios";
            this.edificiosBindingSource.DataSource = this.gestion_laboratoriosDataSet;
            // 
            // edificiosTableAdapter
            // 
            this.edificiosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AulaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampusTableAdapter = null;
            this.tableAdapterManager.EdificiosTableAdapter = this.edificiosTableAdapter;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.ReservacionTableAdapter = null;
            this.tableAdapterManager.TipoAulaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gestion_Laboratorios.Gestion_laboratoriosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // dgvEdificios
            // 
            this.dgvEdificios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdificios.Location = new System.Drawing.Point(12, 165);
            this.dgvEdificios.Name = "dgvEdificios";
            this.dgvEdificios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEdificios.Size = new System.Drawing.Size(822, 290);
            this.dgvEdificios.TabIndex = 10;
            this.dgvEdificios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EdEdificio);
            // 
            // btnAgregarEdifico
            // 
            this.btnAgregarEdifico.Location = new System.Drawing.Point(759, 12);
            this.btnAgregarEdifico.Name = "btnAgregarEdifico";
            this.btnAgregarEdifico.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEdifico.TabIndex = 11;
            this.btnAgregarEdifico.Text = "Agregar";
            this.btnAgregarEdifico.UseVisualStyleBackColor = true;
            this.btnAgregarEdifico.Click += new System.EventHandler(this.btnAgregarEdificoClick);
            // 
            // GestionEdificiosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 467);
            this.Controls.Add(this.btnAgregarEdifico);
            this.Controls.Add(this.dgvEdificios);
            this.Controls.Add(this.txtBusqEd);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "GestionEdificiosForm";
            this.Text = "Gestion Edificios";
            this.Activated += new System.EventHandler(this.ActGestED);
            this.Load += new System.EventHandler(this.GestionEdificiosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_laboratoriosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionlaboratoriosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edificiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdificios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Buscar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox txtBusqEd;
        private System.Windows.Forms.BindingSource gestionlaboratoriosDataSetBindingSource;
        private Gestion_laboratoriosDataSet gestion_laboratoriosDataSet;
        private System.Windows.Forms.BindingSource edificiosBindingSource;
        private Gestion_laboratoriosDataSetTableAdapters.EdificiosTableAdapter edificiosTableAdapter;
        private Gestion_laboratoriosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvEdificios;
        private System.Windows.Forms.Button btnAgregarEdifico;
    }
}
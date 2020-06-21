namespace Gestion_Laboratorios
{
    partial class Form1
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
            this.gestion_laboratoriosDataSet = new Gestion_Laboratorios.Gestion_laboratoriosDataSet();
            this.aulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulaTableAdapter = new Gestion_Laboratorios.Gestion_laboratoriosDataSetTableAdapters.AulaTableAdapter();
            this.tableAdapterManager = new Gestion_Laboratorios.Gestion_laboratoriosDataSetTableAdapters.TableAdapterManager();
            this.Tanda = new System.Windows.Forms.Label();
            this.cbxTanda = new System.Windows.Forms.ComboBox();
            this.txtTextoABuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReservacionNueva = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_laboratoriosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AulaTableAdapter = this.aulaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CampusTableAdapter = null;
            this.tableAdapterManager.EdificiosTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.ReservacionTableAdapter = null;
            this.tableAdapterManager.TipoAulaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gestion_Laboratorios.Gestion_laboratoriosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // Tanda
            // 
            this.Tanda.AutoSize = true;
            this.Tanda.Location = new System.Drawing.Point(13, 13);
            this.Tanda.Name = "Tanda";
            this.Tanda.Size = new System.Drawing.Size(38, 13);
            this.Tanda.TabIndex = 0;
            this.Tanda.Text = "Tanda";
            // 
            // cbxTanda
            // 
            this.cbxTanda.FormattingEnabled = true;
            this.cbxTanda.Location = new System.Drawing.Point(58, 13);
            this.cbxTanda.Name = "cbxTanda";
            this.cbxTanda.Size = new System.Drawing.Size(121, 21);
            this.cbxTanda.TabIndex = 1;
            // 
            // txtTextoABuscar
            // 
            this.txtTextoABuscar.Location = new System.Drawing.Point(316, 13);
            this.txtTextoABuscar.Name = "txtTextoABuscar";
            this.txtTextoABuscar.Size = new System.Drawing.Size(100, 20);
            this.txtTextoABuscar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Busqueda";
            // 
            // BtnReservacionNueva
            // 
            this.BtnReservacionNueva.Location = new System.Drawing.Point(677, 13);
            this.BtnReservacionNueva.Name = "BtnReservacionNueva";
            this.BtnReservacionNueva.Size = new System.Drawing.Size(111, 23);
            this.BtnReservacionNueva.TabIndex = 4;
            this.BtnReservacionNueva.Text = "Reservacion nueva";
            this.BtnReservacionNueva.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(560, 13);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(111, 23);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 380);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnReservacionNueva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTextoABuscar);
            this.Controls.Add(this.cbxTanda);
            this.Controls.Add(this.Tanda);
            this.Name = "Form1";
            this.Text = "Consulta de reservas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_laboratoriosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gestion_laboratoriosDataSet gestion_laboratoriosDataSet;
        private System.Windows.Forms.BindingSource aulaBindingSource;
        private Gestion_laboratoriosDataSetTableAdapters.AulaTableAdapter aulaTableAdapter;
        private Gestion_laboratoriosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label Tanda;
        private System.Windows.Forms.ComboBox cbxTanda;
        private System.Windows.Forms.TextBox txtTextoABuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReservacionNueva;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


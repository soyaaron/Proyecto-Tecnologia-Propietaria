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
            System.Windows.Forms.Label idAulaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label idTipoAulaLabel;
            System.Windows.Forms.Label idEdificioLabel;
            System.Windows.Forms.Label capacidadLabel;
            System.Windows.Forms.Label cuposReservadosLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gestion_laboratoriosDataSet = new Gestion_Laboratorios.Gestion_laboratoriosDataSet();
            this.aulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulaTableAdapter = new Gestion_Laboratorios.Gestion_laboratoriosDataSetTableAdapters.AulaTableAdapter();
            this.tableAdapterManager = new Gestion_Laboratorios.Gestion_laboratoriosDataSetTableAdapters.TableAdapterManager();
            this.aulaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aulaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idAulaTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.idTipoAulaTextBox = new System.Windows.Forms.TextBox();
            this.idEdificioTextBox = new System.Windows.Forms.TextBox();
            this.capacidadTextBox = new System.Windows.Forms.TextBox();
            this.cuposReservadosTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            idAulaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            idTipoAulaLabel = new System.Windows.Forms.Label();
            idEdificioLabel = new System.Windows.Forms.Label();
            capacidadLabel = new System.Windows.Forms.Label();
            cuposReservadosLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_laboratoriosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingNavigator)).BeginInit();
            this.aulaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idAulaLabel
            // 
            idAulaLabel.AutoSize = true;
            idAulaLabel.Location = new System.Drawing.Point(20, 105);
            idAulaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idAulaLabel.Name = "idAulaLabel";
            idAulaLabel.Size = new System.Drawing.Size(55, 17);
            idAulaLabel.TabIndex = 1;
            idAulaLabel.Text = "Id Aula:";
            idAulaLabel.Click += new System.EventHandler(this.idAulaLabel_Click);
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(20, 137);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // idTipoAulaLabel
            // 
            idTipoAulaLabel.AutoSize = true;
            idTipoAulaLabel.Location = new System.Drawing.Point(20, 169);
            idTipoAulaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idTipoAulaLabel.Name = "idTipoAulaLabel";
            idTipoAulaLabel.Size = new System.Drawing.Size(87, 17);
            idTipoAulaLabel.TabIndex = 5;
            idTipoAulaLabel.Text = "Id Tipo Aula:";
            // 
            // idEdificioLabel
            // 
            idEdificioLabel.AutoSize = true;
            idEdificioLabel.Location = new System.Drawing.Point(20, 201);
            idEdificioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idEdificioLabel.Name = "idEdificioLabel";
            idEdificioLabel.Size = new System.Drawing.Size(72, 17);
            idEdificioLabel.TabIndex = 7;
            idEdificioLabel.Text = "Id Edificio:";
            // 
            // capacidadLabel
            // 
            capacidadLabel.AutoSize = true;
            capacidadLabel.Location = new System.Drawing.Point(20, 233);
            capacidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            capacidadLabel.Name = "capacidadLabel";
            capacidadLabel.Size = new System.Drawing.Size(79, 17);
            capacidadLabel.TabIndex = 9;
            capacidadLabel.Text = "Capacidad:";
            // 
            // cuposReservadosLabel
            // 
            cuposReservadosLabel.AutoSize = true;
            cuposReservadosLabel.Location = new System.Drawing.Point(20, 265);
            cuposReservadosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cuposReservadosLabel.Name = "cuposReservadosLabel";
            cuposReservadosLabel.Size = new System.Drawing.Size(132, 17);
            cuposReservadosLabel.TabIndex = 11;
            cuposReservadosLabel.Text = "Cupos Reservados:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(20, 297);
            estadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(56, 17);
            estadoLabel.TabIndex = 13;
            estadoLabel.Text = "Estado:";
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
            // aulaBindingNavigator
            // 
            this.aulaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aulaBindingNavigator.BindingSource = this.aulaBindingSource;
            this.aulaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aulaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aulaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.aulaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aulaBindingNavigatorSaveItem});
            this.aulaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aulaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aulaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aulaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aulaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aulaBindingNavigator.Name = "aulaBindingNavigator";
            this.aulaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aulaBindingNavigator.Size = new System.Drawing.Size(1067, 27);
            this.aulaBindingNavigator.TabIndex = 0;
            this.aulaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // aulaBindingNavigatorSaveItem
            // 
            this.aulaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aulaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aulaBindingNavigatorSaveItem.Image")));
            this.aulaBindingNavigatorSaveItem.Name = "aulaBindingNavigatorSaveItem";
            this.aulaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.aulaBindingNavigatorSaveItem.Text = "Save Data";
            this.aulaBindingNavigatorSaveItem.Click += new System.EventHandler(this.AulaBindingNavigatorSaveItem_Click_1);
            // 
            // idAulaTextBox
            // 
            this.idAulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulaBindingSource, "IdAula", true));
            this.idAulaTextBox.Location = new System.Drawing.Point(161, 101);
            this.idAulaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idAulaTextBox.Name = "idAulaTextBox";
            this.idAulaTextBox.Size = new System.Drawing.Size(132, 22);
            this.idAulaTextBox.TabIndex = 2;
            this.idAulaTextBox.TextChanged += new System.EventHandler(this.idAulaTextBox_TextChanged);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulaBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(161, 133);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(132, 22);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // idTipoAulaTextBox
            // 
            this.idTipoAulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulaBindingSource, "IdTipoAula", true));
            this.idTipoAulaTextBox.Location = new System.Drawing.Point(161, 165);
            this.idTipoAulaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTipoAulaTextBox.Name = "idTipoAulaTextBox";
            this.idTipoAulaTextBox.Size = new System.Drawing.Size(132, 22);
            this.idTipoAulaTextBox.TabIndex = 6;
            // 
            // idEdificioTextBox
            // 
            this.idEdificioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulaBindingSource, "IdEdificio", true));
            this.idEdificioTextBox.Location = new System.Drawing.Point(161, 197);
            this.idEdificioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idEdificioTextBox.Name = "idEdificioTextBox";
            this.idEdificioTextBox.Size = new System.Drawing.Size(132, 22);
            this.idEdificioTextBox.TabIndex = 8;
            // 
            // capacidadTextBox
            // 
            this.capacidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulaBindingSource, "Capacidad", true));
            this.capacidadTextBox.Location = new System.Drawing.Point(161, 229);
            this.capacidadTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.capacidadTextBox.Name = "capacidadTextBox";
            this.capacidadTextBox.Size = new System.Drawing.Size(132, 22);
            this.capacidadTextBox.TabIndex = 10;
            // 
            // cuposReservadosTextBox
            // 
            this.cuposReservadosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulaBindingSource, "CuposReservados", true));
            this.cuposReservadosTextBox.Location = new System.Drawing.Point(161, 261);
            this.cuposReservadosTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cuposReservadosTextBox.Name = "cuposReservadosTextBox";
            this.cuposReservadosTextBox.Size = new System.Drawing.Size(132, 22);
            this.cuposReservadosTextBox.TabIndex = 12;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulaBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(161, 293);
            this.estadoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(132, 22);
            this.estadoTextBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(idAulaLabel);
            this.Controls.Add(this.idAulaTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(idTipoAulaLabel);
            this.Controls.Add(this.idTipoAulaTextBox);
            this.Controls.Add(idEdificioLabel);
            this.Controls.Add(this.idEdificioTextBox);
            this.Controls.Add(capacidadLabel);
            this.Controls.Add(this.capacidadTextBox);
            this.Controls.Add(cuposReservadosLabel);
            this.Controls.Add(this.cuposReservadosTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(this.aulaBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Gestion de laboratorios";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_laboratoriosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingNavigator)).EndInit();
            this.aulaBindingNavigator.ResumeLayout(false);
            this.aulaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gestion_laboratoriosDataSet gestion_laboratoriosDataSet;
        private System.Windows.Forms.BindingSource aulaBindingSource;
        private Gestion_laboratoriosDataSetTableAdapters.AulaTableAdapter aulaTableAdapter;
        private Gestion_laboratoriosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aulaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aulaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idAulaTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox idTipoAulaTextBox;
        private System.Windows.Forms.TextBox idEdificioTextBox;
        private System.Windows.Forms.TextBox capacidadTextBox;
        private System.Windows.Forms.TextBox cuposReservadosTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
    }
}


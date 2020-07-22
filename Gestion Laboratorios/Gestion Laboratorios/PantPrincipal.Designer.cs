namespace Gestion_Laboratorios
{
    partial class PantPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionCampusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEdificiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionAulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvReservaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscarReservas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionCampusToolStripMenuItem,
            this.gestionEdificiosToolStripMenuItem,
            this.gestionAulasToolStripMenuItem,
            this.gestionUsuariosToolStripMenuItem,
            this.gestionEmpleadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionCampusToolStripMenuItem
            // 
            this.gestionCampusToolStripMenuItem.Name = "gestionCampusToolStripMenuItem";
            this.gestionCampusToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.gestionCampusToolStripMenuItem.Text = "Gestion Campus";
            this.gestionCampusToolStripMenuItem.Click += new System.EventHandler(this.ClickGestionCampus);
            // 
            // gestionEdificiosToolStripMenuItem
            // 
            this.gestionEdificiosToolStripMenuItem.Name = "gestionEdificiosToolStripMenuItem";
            this.gestionEdificiosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.gestionEdificiosToolStripMenuItem.Text = "Gestion Edificios";
            this.gestionEdificiosToolStripMenuItem.Click += new System.EventHandler(this.DirGestEmp);
            // 
            // gestionAulasToolStripMenuItem
            // 
            this.gestionAulasToolStripMenuItem.Name = "gestionAulasToolStripMenuItem";
            this.gestionAulasToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.gestionAulasToolStripMenuItem.Text = "Gestion Aulas";
            this.gestionAulasToolStripMenuItem.Click += new System.EventHandler(this.DirigirGestionAulas);
            // 
            // gestionUsuariosToolStripMenuItem
            // 
            this.gestionUsuariosToolStripMenuItem.Name = "gestionUsuariosToolStripMenuItem";
            this.gestionUsuariosToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.gestionUsuariosToolStripMenuItem.Text = "Gestion Usuarios";
            this.gestionUsuariosToolStripMenuItem.Click += new System.EventHandler(this.DirigirGestionUsuario);
            // 
            // gestionEmpleadosToolStripMenuItem
            // 
            this.gestionEmpleadosToolStripMenuItem.Name = "gestionEmpleadosToolStripMenuItem";
            this.gestionEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestionEmpleadosToolStripMenuItem.Text = "Gestion Empleados";
            this.gestionEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.DirigirGestionEmp);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dgvReservaciones
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservaciones.Location = new System.Drawing.Point(13, 103);
            this.dgvReservaciones.Name = "dgvReservaciones";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservaciones.Size = new System.Drawing.Size(854, 335);
            this.dgvReservaciones.TabIndex = 1;
            this.dgvReservaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserv_CellDobleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nueva Reservacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Criterio";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(58, 51);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 5;
            // 
            // BtnBuscarReservas
            // 
            this.BtnBuscarReservas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscarReservas.BackgroundImage")));
            this.BtnBuscarReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscarReservas.Location = new System.Drawing.Point(188, 35);
            this.BtnBuscarReservas.Name = "BtnBuscarReservas";
            this.BtnBuscarReservas.Size = new System.Drawing.Size(51, 51);
            this.BtnBuscarReservas.TabIndex = 6;
            this.BtnBuscarReservas.UseVisualStyleBackColor = true;
            this.BtnBuscarReservas.Click += new System.EventHandler(this.BtnBuscarReservas_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(816, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 51);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDirigeAgregarRes);
            // 
            // PantPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.BtnBuscarReservas);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvReservaciones);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantPrincipal";
            this.Text = "PantPrincipal";
            this.Activated += new System.EventHandler(this.PantPrincipal_Activado);
            this.Load += new System.EventHandler(this.PantPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionCampusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionEdificiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionAulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgvReservaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button BtnBuscarReservas;
    }
}
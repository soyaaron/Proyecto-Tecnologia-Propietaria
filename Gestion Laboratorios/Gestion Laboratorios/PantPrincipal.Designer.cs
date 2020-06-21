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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionCampusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEdificiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionAulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dvgReservaciones = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscarReservas = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReservaciones)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1003, 24);
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
            // 
            // gestionAulasToolStripMenuItem
            // 
            this.gestionAulasToolStripMenuItem.Name = "gestionAulasToolStripMenuItem";
            this.gestionAulasToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.gestionAulasToolStripMenuItem.Text = "Gestion Aulas";
            // 
            // gestionUsuariosToolStripMenuItem
            // 
            this.gestionUsuariosToolStripMenuItem.Name = "gestionUsuariosToolStripMenuItem";
            this.gestionUsuariosToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.gestionUsuariosToolStripMenuItem.Text = "Gestion Usuarios";
            // 
            // gestionEmpleadosToolStripMenuItem
            // 
            this.gestionEmpleadosToolStripMenuItem.Name = "gestionEmpleadosToolStripMenuItem";
            this.gestionEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestionEmpleadosToolStripMenuItem.Text = "Gestion Empleados";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dvgReservaciones
            // 
            this.dvgReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgReservaciones.Location = new System.Drawing.Point(13, 103);
            this.dvgReservaciones.Name = "dvgReservaciones";
            this.dvgReservaciones.Size = new System.Drawing.Size(978, 335);
            this.dvgReservaciones.TabIndex = 1;
            this.dvgReservaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserv_CellDobleClick);
            this.dvgReservaciones.DoubleClick += new System.EventHandler(this.dgvReserv_DobleClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(940, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 51);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDirigeAgregarRes);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(832, 54);
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
            // PantPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.BtnBuscarReservas);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dvgReservaciones);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantPrincipal";
            this.Text = "PantPrincipal";
            this.Activated += new System.EventHandler(this.PantPrincipal_Activado);
            this.Load += new System.EventHandler(this.PantPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReservaciones)).EndInit();
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
        private System.Windows.Forms.DataGridView dvgReservaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button BtnBuscarReservas;
    }
}
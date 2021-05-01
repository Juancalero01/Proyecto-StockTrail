namespace StockTrail
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.vERSTOCKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOPRODUCTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cARGARNUEVOPRODUCTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFICARPRODUCTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMINARPRODUCTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOSVENCIDOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEALIZARVENTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARVENTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vERSTOCKToolStripMenuItem,
            this.nUEVOPRODUCTOToolStripMenuItem,
            this.pRODUCTOSVENCIDOSToolStripMenuItem,
            this.rEALIZARVENTAToolStripMenuItem,
            this.cONSULTARVENTAToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.Size = new System.Drawing.Size(1067, 38);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // vERSTOCKToolStripMenuItem
            // 
            this.vERSTOCKToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.vERSTOCKToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.vERSTOCKToolStripMenuItem.Name = "vERSTOCKToolStripMenuItem";
            this.vERSTOCKToolStripMenuItem.Size = new System.Drawing.Size(130, 34);
            this.vERSTOCKToolStripMenuItem.Text = "VER STOCK";
            this.vERSTOCKToolStripMenuItem.Click += new System.EventHandler(this.vERSTOCKToolStripMenuItem_Click);
            // 
            // nUEVOPRODUCTOToolStripMenuItem
            // 
            this.nUEVOPRODUCTOToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.nUEVOPRODUCTOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cARGARNUEVOPRODUCTOToolStripMenuItem,
            this.mODIFICARPRODUCTOToolStripMenuItem,
            this.eLIMINARPRODUCTOToolStripMenuItem});
            this.nUEVOPRODUCTOToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.nUEVOPRODUCTOToolStripMenuItem.Name = "nUEVOPRODUCTOToolStripMenuItem";
            this.nUEVOPRODUCTOToolStripMenuItem.Size = new System.Drawing.Size(145, 34);
            this.nUEVOPRODUCTOToolStripMenuItem.Text = "PRODUCTOS";
            this.nUEVOPRODUCTOToolStripMenuItem.Click += new System.EventHandler(this.nUEVOPRODUCTOToolStripMenuItem_Click);
            // 
            // cARGARNUEVOPRODUCTOToolStripMenuItem
            // 
            this.cARGARNUEVOPRODUCTOToolStripMenuItem.Name = "cARGARNUEVOPRODUCTOToolStripMenuItem";
            this.cARGARNUEVOPRODUCTOToolStripMenuItem.Size = new System.Drawing.Size(357, 34);
            this.cARGARNUEVOPRODUCTOToolStripMenuItem.Text = "CARGAR NUEVO PRODUCTO";
            this.cARGARNUEVOPRODUCTOToolStripMenuItem.Click += new System.EventHandler(this.cARGARNUEVOPRODUCTOToolStripMenuItem_Click);
            // 
            // mODIFICARPRODUCTOToolStripMenuItem
            // 
            this.mODIFICARPRODUCTOToolStripMenuItem.Name = "mODIFICARPRODUCTOToolStripMenuItem";
            this.mODIFICARPRODUCTOToolStripMenuItem.Size = new System.Drawing.Size(357, 34);
            this.mODIFICARPRODUCTOToolStripMenuItem.Text = "MODIFICAR PRODUCTO";
            this.mODIFICARPRODUCTOToolStripMenuItem.Click += new System.EventHandler(this.mODIFICARPRODUCTOToolStripMenuItem_Click);
            // 
            // eLIMINARPRODUCTOToolStripMenuItem
            // 
            this.eLIMINARPRODUCTOToolStripMenuItem.Name = "eLIMINARPRODUCTOToolStripMenuItem";
            this.eLIMINARPRODUCTOToolStripMenuItem.Size = new System.Drawing.Size(357, 34);
            this.eLIMINARPRODUCTOToolStripMenuItem.Text = "ELIMINAR PRODUCTO";
            this.eLIMINARPRODUCTOToolStripMenuItem.Click += new System.EventHandler(this.eLIMINARPRODUCTOToolStripMenuItem_Click);
            // 
            // pRODUCTOSVENCIDOSToolStripMenuItem
            // 
            this.pRODUCTOSVENCIDOSToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.pRODUCTOSVENCIDOSToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pRODUCTOSVENCIDOSToolStripMenuItem.Name = "pRODUCTOSVENCIDOSToolStripMenuItem";
            this.pRODUCTOSVENCIDOSToolStripMenuItem.Size = new System.Drawing.Size(252, 34);
            this.pRODUCTOSVENCIDOSToolStripMenuItem.Text = "PRODUCTOS VENCIDOS";
            this.pRODUCTOSVENCIDOSToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTOSVENCIDOSToolStripMenuItem_Click);
            // 
            // rEALIZARVENTAToolStripMenuItem
            // 
            this.rEALIZARVENTAToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.rEALIZARVENTAToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.rEALIZARVENTAToolStripMenuItem.Name = "rEALIZARVENTAToolStripMenuItem";
            this.rEALIZARVENTAToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.rEALIZARVENTAToolStripMenuItem.Text = "REALIZAR VENTA";
            this.rEALIZARVENTAToolStripMenuItem.Click += new System.EventHandler(this.rEALIZARVENTAToolStripMenuItem_Click);
            // 
            // cONSULTARVENTAToolStripMenuItem
            // 
            this.cONSULTARVENTAToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.cONSULTARVENTAToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cONSULTARVENTAToolStripMenuItem.Name = "cONSULTARVENTAToolStripMenuItem";
            this.cONSULTARVENTAToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.cONSULTARVENTAToolStripMenuItem.Text = "CONSULTAR VENTA";
            this.cONSULTARVENTAToolStripMenuItem.Click += new System.EventHandler(this.cONSULTARVENTAToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StockTrail.Properties.Resources.thumbnail_Mesa_de_trabajo_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1067, 649);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOCK TRAIL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem vERSTOCKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOSVENCIDOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEALIZARVENTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARVENTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOPRODUCTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cARGARNUEVOPRODUCTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFICARPRODUCTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARPRODUCTOToolStripMenuItem;
    }
}




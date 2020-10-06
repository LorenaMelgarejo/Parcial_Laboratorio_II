namespace Formularios
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMItem_AgregarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarAplicacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProducto,
            this.MenuVenta,
            this.MenuCliente,
            this.CerrarAplicacion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuProducto
            // 
            this.MenuProducto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMItem_AgregarProducto});
            this.MenuProducto.Image = global::Formularios.Properties.Resources.productos;
            this.MenuProducto.Name = "MenuProducto";
            this.MenuProducto.Size = new System.Drawing.Size(84, 20);
            this.MenuProducto.Text = "Producto";
            // 
            // TSMItem_AgregarProducto
            // 
            this.TSMItem_AgregarProducto.Name = "TSMItem_AgregarProducto";
            this.TSMItem_AgregarProducto.Size = new System.Drawing.Size(168, 22);
            this.TSMItem_AgregarProducto.Text = "Agregar Producto";
            this.TSMItem_AgregarProducto.Click += new System.EventHandler(this.TSMItem_AgregarProducto_Click);
            // 
            // MenuVenta
            // 
            this.MenuVenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem});
            this.MenuVenta.Image = global::Formularios.Properties.Resources.shopping_cart_icon_icons_com_72552;
            this.MenuVenta.Name = "MenuVenta";
            this.MenuVenta.Size = new System.Drawing.Size(69, 20);
            this.MenuVenta.Text = "Ventas";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Image = global::Formularios.Properties.Resources.shopping_cart_add_button_icon_icons_com_56132;
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // MenuCliente
            // 
            this.MenuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaCliente});
            this.MenuCliente.Image = ((System.Drawing.Image)(resources.GetObject("MenuCliente.Image")));
            this.MenuCliente.Name = "MenuCliente";
            this.MenuCliente.Size = new System.Drawing.Size(77, 20);
            this.MenuCliente.Text = "Clientes";
            // 
            // AltaCliente
            // 
            this.AltaCliente.Image = ((System.Drawing.Image)(resources.GetObject("AltaCliente.Image")));
            this.AltaCliente.Name = "AltaCliente";
            this.AltaCliente.Size = new System.Drawing.Size(180, 22);
            this.AltaCliente.Text = "Alta Cliente";
            this.AltaCliente.Click += new System.EventHandler(this.AltaCliente_Click);
            // 
            // CerrarAplicacion
            // 
            this.CerrarAplicacion.Image = ((System.Drawing.Image)(resources.GetObject("CerrarAplicacion.Image")));
            this.CerrarAplicacion.Name = "CerrarAplicacion";
            this.CerrarAplicacion.Size = new System.Drawing.Size(57, 20);
            this.CerrarAplicacion.Text = "Salir";
            this.CerrarAplicacion.Click += new System.EventHandler(this.CerrarAplicacion_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Kwik -E-Mart";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuProducto;
        private System.Windows.Forms.ToolStripMenuItem TSMItem_AgregarProducto;
        private System.Windows.Forms.ToolStripMenuItem MenuVenta;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCliente;
        private System.Windows.Forms.ToolStripMenuItem AltaCliente;
        private System.Windows.Forms.ToolStripMenuItem CerrarAplicacion;
    }
}
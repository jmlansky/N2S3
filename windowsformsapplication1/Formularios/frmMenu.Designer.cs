namespace NoHay2Sin3
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPedido = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEstadoPedido = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProducto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrecioDelivery = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnInformes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(45, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPedido,
            this.toolStripSeparator1,
            this.btnEstadoPedido,
            this.toolStripSeparator4,
            this.btnProducto,
            this.toolStripSeparator6,
            this.btnClientes,
            this.toolStripSeparator2,
            this.btnPrecioDelivery,
            this.toolStripSeparator3,
            this.btnInformes,
            this.toolStripSeparator5,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(844, 83);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnPedido
            // 
            this.btnPedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPedido.Image = global::NoHay2Sin3.Properties.Resources.pedido1;
            this.btnPedido.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPedido.Margin = new System.Windows.Forms.Padding(3, 1, 5, 2);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(49, 80);
            this.btnPedido.Text = "Pedidos";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 83);
            this.toolStripSeparator1.Visible = false;
            // 
            // btnEstadoPedido
            // 
            this.btnEstadoPedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEstadoPedido.Image = global::NoHay2Sin3.Properties.Resources.reloj_arena1;
            this.btnEstadoPedido.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEstadoPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEstadoPedido.Name = "btnEstadoPedido";
            this.btnEstadoPedido.Size = new System.Drawing.Size(32, 80);
            this.btnEstadoPedido.Text = "Estado de pedidos";
            this.btnEstadoPedido.Visible = false;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 83);
            // 
            // btnProducto
            // 
            this.btnProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProducto.Image = global::NoHay2Sin3.Properties.Resources.lomito;
            this.btnProducto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProducto.Margin = new System.Windows.Forms.Padding(3, 1, 5, 2);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(49, 80);
            this.btnProducto.Text = "Productos";
            this.btnProducto.ToolTipText = "Productos";
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 83);
            // 
            // btnClientes
            // 
            this.btnClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClientes.Image = global::NoHay2Sin3.Properties.Resources.Existing_Customer;
            this.btnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(49, 80);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 83);
            // 
            // btnPrecioDelivery
            // 
            this.btnPrecioDelivery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrecioDelivery.Image = global::NoHay2Sin3.Properties.Resources.delivery;
            this.btnPrecioDelivery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrecioDelivery.Name = "btnPrecioDelivery";
            this.btnPrecioDelivery.Size = new System.Drawing.Size(49, 80);
            this.btnPrecioDelivery.Text = "Delivery";
            this.btnPrecioDelivery.ToolTipText = "Precio de Delivery";
            this.btnPrecioDelivery.Click += new System.EventHandler(this.btnPrecioDelivery_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 83);
            // 
            // btnInformes
            // 
            this.btnInformes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInformes.Image = global::NoHay2Sin3.Properties.Resources.report__1_;
            this.btnInformes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(49, 80);
            this.btnInformes.Text = "Informes";
            this.btnInformes.ToolTipText = "Informes";
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 83);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 80);
            this.toolStripButton1.Text = "Info";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(844, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tsslEstado
            // 
            this.tsslEstado.BackColor = System.Drawing.Color.White;
            this.tsslEstado.Image = ((System.Drawing.Image)(resources.GetObject("tsslEstado.Image")));
            this.tsslEstado.Name = "tsslEstado";
            this.tsslEstado.Size = new System.Drawing.Size(305, 17);
            this.tsslEstado.Text = "Bienvenido al Sistema de Pedidos de \"No Hay 2 Sin 3\"";
            this.tsslEstado.Click += new System.EventHandler(this.tsslEstado_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::NoHay2Sin3.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 447);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(860, 485);
            this.MinimumSize = new System.Drawing.Size(860, 485);
            this.Name = "frmMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMenu_KeyUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPedido;
        private System.Windows.Forms.ToolStripButton btnProducto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslEstado;
        private System.Windows.Forms.ToolStripButton btnPrecioDelivery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnInformes;
        private System.Windows.Forms.ToolStripButton btnEstadoPedido;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnClientes;
    }
}




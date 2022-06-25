namespace NoHay2Sin3.Formularios
{
    partial class frmModifPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtObservacionPedido = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNuevaPromocion = new System.Windows.Forms.Button();
            this.dgvItemsPedido = new System.Windows.Forms.DataGridView();
            this.Seleccionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDetallePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioX3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelPago = new System.Windows.Forms.Panel();
            this.txtDto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDemora = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnvioPedido = new System.Windows.Forms.TextBox();
            this.txtMontoAbono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontoTotalPedido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcularMontoTotalPedido = new System.Windows.Forms.Button();
            this.btnImprimirPedido = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPromociones = new System.Windows.Forms.DataGridView();
            this.eliminarPromo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbMostrador = new System.Windows.Forms.RadioButton();
            this.rbDelivery = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.panelEncabezadoPedido = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDomicilioEntrega = new System.Windows.Forms.CheckBox();
            this.txtTelefonoClientePedido = new System.Windows.Forms.TextBox();
            this.btnBuscarClientePedido = new System.Windows.Forms.Button();
            this.txtNombreClientePedido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDomicilioAlternativo = new System.Windows.Forms.TextBox();
            this.txtDomicilioClientePedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_BuscarPedidosDelDia = new System.Windows.Forms.TextBox();
            this.dgvPedidosDelDia = new System.Windows.Forms.DataGridView();
            this.ModificarPedido = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomicilioPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsPedido)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelPago.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromociones)).BeginInit();
            this.panel5.SuspendLayout();
            this.panelEncabezadoPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosDelDia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtObservacionPedido
            // 
            this.txtObservacionPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacionPedido.Location = new System.Drawing.Point(271, 63);
            this.txtObservacionPedido.MaxLength = 150;
            this.txtObservacionPedido.Name = "txtObservacionPedido";
            this.txtObservacionPedido.Size = new System.Drawing.Size(120, 20);
            this.txtObservacionPedido.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Sienna;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnNuevaPromocion);
            this.panel2.Controls.Add(this.dgvItemsPedido);
            this.panel2.Location = new System.Drawing.Point(7, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 230);
            this.panel2.TabIndex = 9;
            // 
            // btnNuevaPromocion
            // 
            this.btnNuevaPromocion.Location = new System.Drawing.Point(3, 196);
            this.btnNuevaPromocion.Name = "btnNuevaPromocion";
            this.btnNuevaPromocion.Size = new System.Drawing.Size(279, 23);
            this.btnNuevaPromocion.TabIndex = 1;
            this.btnNuevaPromocion.Text = "Confirmar Promoción (F12)";
            this.btnNuevaPromocion.UseVisualStyleBackColor = true;
            this.btnNuevaPromocion.Click += new System.EventHandler(this.btnNuevaPromocion_Click);
            // 
            // dgvItemsPedido
            // 
            this.dgvItemsPedido.AllowUserToAddRows = false;
            this.dgvItemsPedido.AllowUserToDeleteRows = false;
            this.dgvItemsPedido.AllowUserToResizeColumns = false;
            this.dgvItemsPedido.AllowUserToResizeRows = false;
            this.dgvItemsPedido.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvItemsPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionado,
            this.idProducto,
            this.nombreProducto,
            this.cantidadProducto,
            this.observacionDetallePedido,
            this.observacionProducto,
            this.precioX3,
            this.precioX2,
            this.precioX1});
            this.dgvItemsPedido.Location = new System.Drawing.Point(3, 3);
            this.dgvItemsPedido.MultiSelect = false;
            this.dgvItemsPedido.Name = "dgvItemsPedido";
            this.dgvItemsPedido.RowHeadersVisible = false;
            this.dgvItemsPedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItemsPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvItemsPedido.Size = new System.Drawing.Size(279, 187);
            this.dgvItemsPedido.TabIndex = 0;
            // 
            // Seleccionado
            // 
            this.Seleccionado.FalseValue = "0";
            this.Seleccionado.HeaderText = "";
            this.Seleccionado.Name = "Seleccionado";
            this.Seleccionado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Seleccionado.TrueValue = "1";
            this.Seleccionado.Width = 30;
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idProducto.Visible = false;
            // 
            // nombreProducto
            // 
            this.nombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nombreProducto.DataPropertyName = "nombreProducto";
            this.nombreProducto.HeaderText = "Producto";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            this.nombreProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cantidadProducto.HeaderText = "Cantidad";
            this.cantidadProducto.MaxInputLength = 3;
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cantidadProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cantidadProducto.Width = 50;
            // 
            // observacionDetallePedido
            // 
            this.observacionDetallePedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.observacionDetallePedido.HeaderText = "Observacion";
            this.observacionDetallePedido.MaxInputLength = 50;
            this.observacionDetallePedido.Name = "observacionDetallePedido";
            this.observacionDetallePedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.observacionDetallePedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.observacionDetallePedido.Width = 180;
            // 
            // observacionProducto
            // 
            this.observacionProducto.DataPropertyName = "observacionProducto";
            this.observacionProducto.HeaderText = "observacionProducto";
            this.observacionProducto.Name = "observacionProducto";
            this.observacionProducto.ReadOnly = true;
            this.observacionProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.observacionProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.observacionProducto.Visible = false;
            // 
            // precioX3
            // 
            this.precioX3.DataPropertyName = "precioX3";
            this.precioX3.HeaderText = "precioX3";
            this.precioX3.Name = "precioX3";
            this.precioX3.ReadOnly = true;
            this.precioX3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioX3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precioX3.Visible = false;
            // 
            // precioX2
            // 
            this.precioX2.DataPropertyName = "precioX2";
            this.precioX2.HeaderText = "precioX2";
            this.precioX2.Name = "precioX2";
            this.precioX2.ReadOnly = true;
            this.precioX2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioX2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precioX2.Visible = false;
            // 
            // precioX1
            // 
            this.precioX1.DataPropertyName = "precioX1";
            this.precioX1.HeaderText = "precioX1";
            this.precioX1.Name = "precioX1";
            this.precioX1.ReadOnly = true;
            this.precioX1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioX1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precioX1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Sienna;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panelPago);
            this.panel3.Controls.Add(this.btnCalcularMontoTotalPedido);
            this.panel3.Controls.Add(this.btnImprimirPedido);
            this.panel3.Location = new System.Drawing.Point(585, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 331);
            this.panel3.TabIndex = 10;
            // 
            // panelPago
            // 
            this.panelPago.BackColor = System.Drawing.Color.BurlyWood;
            this.panelPago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPago.Controls.Add(this.txtDto);
            this.panelPago.Controls.Add(this.label11);
            this.panelPago.Controls.Add(this.txtDemora);
            this.panelPago.Controls.Add(this.label9);
            this.panelPago.Controls.Add(this.txtVuelto);
            this.panelPago.Controls.Add(this.label8);
            this.panelPago.Controls.Add(this.txtEnvioPedido);
            this.panelPago.Controls.Add(this.txtMontoAbono);
            this.panelPago.Controls.Add(this.label5);
            this.panelPago.Controls.Add(this.txtMontoTotalPedido);
            this.panelPago.Controls.Add(this.label7);
            this.panelPago.Controls.Add(this.label4);
            this.panelPago.Location = new System.Drawing.Point(3, 3);
            this.panelPago.Name = "panelPago";
            this.panelPago.Size = new System.Drawing.Size(88, 150);
            this.panelPago.TabIndex = 0;
            // 
            // txtDto
            // 
            this.txtDto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDto.Location = new System.Drawing.Point(46, 25);
            this.txtDto.MaxLength = 5;
            this.txtDto.Name = "txtDto";
            this.txtDto.Size = new System.Drawing.Size(33, 20);
            this.txtDto.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Dto (%)";
            // 
            // txtDemora
            // 
            this.txtDemora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDemora.Location = new System.Drawing.Point(46, 121);
            this.txtDemora.MaxLength = 3;
            this.txtDemora.Name = "txtDemora";
            this.txtDemora.Size = new System.Drawing.Size(33, 20);
            this.txtDemora.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Demora";
            // 
            // txtVuelto
            // 
            this.txtVuelto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVuelto.Location = new System.Drawing.Point(46, 97);
            this.txtVuelto.MaxLength = 5;
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.ReadOnly = true;
            this.txtVuelto.Size = new System.Drawing.Size(33, 20);
            this.txtVuelto.TabIndex = 3;
            this.txtVuelto.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Vuelto";
            // 
            // txtEnvioPedido
            // 
            this.txtEnvioPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnvioPedido.Location = new System.Drawing.Point(46, 3);
            this.txtEnvioPedido.MaxLength = 5;
            this.txtEnvioPedido.Name = "txtEnvioPedido";
            this.txtEnvioPedido.Size = new System.Drawing.Size(33, 20);
            this.txtEnvioPedido.TabIndex = 0;
            // 
            // txtMontoAbono
            // 
            this.txtMontoAbono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoAbono.Location = new System.Drawing.Point(46, 74);
            this.txtMontoAbono.MaxLength = 4;
            this.txtMontoAbono.Name = "txtMontoAbono";
            this.txtMontoAbono.Size = new System.Drawing.Size(33, 20);
            this.txtMontoAbono.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Abono";
            // 
            // txtMontoTotalPedido
            // 
            this.txtMontoTotalPedido.BackColor = System.Drawing.Color.Chocolate;
            this.txtMontoTotalPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoTotalPedido.Location = new System.Drawing.Point(46, 48);
            this.txtMontoTotalPedido.Name = "txtMontoTotalPedido";
            this.txtMontoTotalPedido.ReadOnly = true;
            this.txtMontoTotalPedido.Size = new System.Drawing.Size(33, 20);
            this.txtMontoTotalPedido.TabIndex = 2;
            this.txtMontoTotalPedido.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Envío";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total";
            // 
            // btnCalcularMontoTotalPedido
            // 
            this.btnCalcularMontoTotalPedido.BackColor = System.Drawing.Color.MistyRose;
            this.btnCalcularMontoTotalPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularMontoTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularMontoTotalPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularMontoTotalPedido.Image")));
            this.btnCalcularMontoTotalPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalcularMontoTotalPedido.Location = new System.Drawing.Point(3, 159);
            this.btnCalcularMontoTotalPedido.Name = "btnCalcularMontoTotalPedido";
            this.btnCalcularMontoTotalPedido.Size = new System.Drawing.Size(88, 84);
            this.btnCalcularMontoTotalPedido.TabIndex = 1;
            this.btnCalcularMontoTotalPedido.Text = "Calcular";
            this.btnCalcularMontoTotalPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcularMontoTotalPedido.UseVisualStyleBackColor = false;
            // 
            // btnImprimirPedido
            // 
            this.btnImprimirPedido.BackColor = System.Drawing.Color.MistyRose;
            this.btnImprimirPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirPedido.Image = global::NoHay2Sin3.Properties.Resources.print1;
            this.btnImprimirPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimirPedido.Location = new System.Drawing.Point(3, 249);
            this.btnImprimirPedido.Name = "btnImprimirPedido";
            this.btnImprimirPedido.Size = new System.Drawing.Size(88, 71);
            this.btnImprimirPedido.TabIndex = 2;
            this.btnImprimirPedido.Text = "Impr. (F11)";
            this.btnImprimirPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimirPedido.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvPromociones);
            this.panel1.Location = new System.Drawing.Point(297, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 230);
            this.panel1.TabIndex = 12;
            // 
            // dgvPromociones
            // 
            this.dgvPromociones.AllowUserToAddRows = false;
            this.dgvPromociones.AllowUserToDeleteRows = false;
            this.dgvPromociones.AllowUserToResizeColumns = false;
            this.dgvPromociones.AllowUserToResizeRows = false;
            this.dgvPromociones.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvPromociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromociones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminarPromo,
            this.cantidad,
            this.Descripcion});
            this.dgvPromociones.Location = new System.Drawing.Point(3, 3);
            this.dgvPromociones.MultiSelect = false;
            this.dgvPromociones.Name = "dgvPromociones";
            this.dgvPromociones.ReadOnly = true;
            this.dgvPromociones.RowHeadersVisible = false;
            this.dgvPromociones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPromociones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromociones.Size = new System.Drawing.Size(270, 220);
            this.dgvPromociones.TabIndex = 1;
            // 
            // eliminarPromo
            // 
            this.eliminarPromo.HeaderText = "";
            this.eliminarPromo.Name = "eliminarPromo";
            this.eliminarPromo.ReadOnly = true;
            this.eliminarPromo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.eliminarPromo.Text = "Eliminar";
            this.eliminarPromo.ToolTipText = "Eliminar Promo";
            this.eliminarPromo.UseColumnTextForButtonValue = true;
            this.eliminarPromo.Width = 50;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cantidad.Visible = false;
            this.cantidad.Width = 60;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Descripcion.Width = 69;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.rbMostrador);
            this.panel5.Controls.Add(this.rbDelivery);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(161, 41);
            this.panel5.TabIndex = 8;
            // 
            // rbMostrador
            // 
            this.rbMostrador.AutoSize = true;
            this.rbMostrador.Location = new System.Drawing.Point(82, 10);
            this.rbMostrador.Name = "rbMostrador";
            this.rbMostrador.Size = new System.Drawing.Size(72, 17);
            this.rbMostrador.TabIndex = 1;
            this.rbMostrador.Text = "Mostrador";
            this.rbMostrador.UseVisualStyleBackColor = true;
            // 
            // rbDelivery
            // 
            this.rbDelivery.AutoSize = true;
            this.rbDelivery.Checked = true;
            this.rbDelivery.Location = new System.Drawing.Point(3, 10);
            this.rbDelivery.Name = "rbDelivery";
            this.rbDelivery.Size = new System.Drawing.Size(63, 17);
            this.rbDelivery.TabIndex = 0;
            this.rbDelivery.TabStop = true;
            this.rbDelivery.Text = "Delivery";
            this.rbDelivery.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Observacion:";
            // 
            // panelEncabezadoPedido
            // 
            this.panelEncabezadoPedido.BackColor = System.Drawing.Color.BurlyWood;
            this.panelEncabezadoPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEncabezadoPedido.Controls.Add(this.label10);
            this.panelEncabezadoPedido.Controls.Add(this.txtObservacionPedido);
            this.panelEncabezadoPedido.Controls.Add(this.label1);
            this.panelEncabezadoPedido.Controls.Add(this.chkDomicilioEntrega);
            this.panelEncabezadoPedido.Controls.Add(this.txtTelefonoClientePedido);
            this.panelEncabezadoPedido.Controls.Add(this.btnBuscarClientePedido);
            this.panelEncabezadoPedido.Controls.Add(this.txtNombreClientePedido);
            this.panelEncabezadoPedido.Controls.Add(this.label6);
            this.panelEncabezadoPedido.Controls.Add(this.label2);
            this.panelEncabezadoPedido.Controls.Add(this.txtDomicilioAlternativo);
            this.panelEncabezadoPedido.Controls.Add(this.txtDomicilioClientePedido);
            this.panelEncabezadoPedido.Controls.Add(this.label3);
            this.panelEncabezadoPedido.Location = new System.Drawing.Point(179, 12);
            this.panelEncabezadoPedido.Name = "panelEncabezadoPedido";
            this.panelEncabezadoPedido.Size = new System.Drawing.Size(400, 95);
            this.panelEncabezadoPedido.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teléfono";
            // 
            // chkDomicilioEntrega
            // 
            this.chkDomicilioEntrega.AutoSize = true;
            this.chkDomicilioEntrega.Checked = true;
            this.chkDomicilioEntrega.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDomicilioEntrega.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.chkDomicilioEntrega.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chkDomicilioEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkDomicilioEntrega.Location = new System.Drawing.Point(198, 40);
            this.chkDomicilioEntrega.Name = "chkDomicilioEntrega";
            this.chkDomicilioEntrega.Size = new System.Drawing.Size(138, 17);
            this.chkDomicilioEntrega.TabIndex = 4;
            this.chkDomicilioEntrega.Text = "Usar domicilio registrado";
            this.chkDomicilioEntrega.UseVisualStyleBackColor = true;
            // 
            // txtTelefonoClientePedido
            // 
            this.txtTelefonoClientePedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonoClientePedido.Location = new System.Drawing.Point(54, 10);
            this.txtTelefonoClientePedido.MaxLength = 13;
            this.txtTelefonoClientePedido.Name = "txtTelefonoClientePedido";
            this.txtTelefonoClientePedido.Size = new System.Drawing.Size(104, 20);
            this.txtTelefonoClientePedido.TabIndex = 0;
            // 
            // btnBuscarClientePedido
            // 
            this.btnBuscarClientePedido.Image = global::NoHay2Sin3.Properties.Resources.find1;
            this.btnBuscarClientePedido.Location = new System.Drawing.Point(164, 5);
            this.btnBuscarClientePedido.Name = "btnBuscarClientePedido";
            this.btnBuscarClientePedido.Size = new System.Drawing.Size(28, 26);
            this.btnBuscarClientePedido.TabIndex = 1;
            this.btnBuscarClientePedido.UseVisualStyleBackColor = true;
            this.btnBuscarClientePedido.Click += new System.EventHandler(this.btnBuscarClientePedido_Click);
            // 
            // txtNombreClientePedido
            // 
            this.txtNombreClientePedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreClientePedido.Location = new System.Drawing.Point(253, 10);
            this.txtNombreClientePedido.MaxLength = 50;
            this.txtNombreClientePedido.Name = "txtNombreClientePedido";
            this.txtNombreClientePedido.Size = new System.Drawing.Size(138, 20);
            this.txtNombreClientePedido.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Domicilio 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // txtDomicilioAlternativo
            // 
            this.txtDomicilioAlternativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDomicilioAlternativo.Location = new System.Drawing.Point(65, 63);
            this.txtDomicilioAlternativo.MaxLength = 50;
            this.txtDomicilioAlternativo.Name = "txtDomicilioAlternativo";
            this.txtDomicilioAlternativo.Size = new System.Drawing.Size(127, 20);
            this.txtDomicilioAlternativo.TabIndex = 5;
            // 
            // txtDomicilioClientePedido
            // 
            this.txtDomicilioClientePedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDomicilioClientePedido.Location = new System.Drawing.Point(54, 37);
            this.txtDomicilioClientePedido.MaxLength = 50;
            this.txtDomicilioClientePedido.Name = "txtDomicilioClientePedido";
            this.txtDomicilioClientePedido.Size = new System.Drawing.Size(138, 20);
            this.txtDomicilioClientePedido.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Domicilio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoHay2Sin3.Properties.Resources.logo_chico;
            this.pictureBox1.Location = new System.Drawing.Point(41, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Sienna;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txt_BuscarPedidosDelDia);
            this.panel4.Controls.Add(this.dgvPedidosDelDia);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(685, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(131, 331);
            this.panel4.TabIndex = 15;
            // 
            // txt_BuscarPedidosDelDia
            // 
            this.txt_BuscarPedidosDelDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BuscarPedidosDelDia.Location = new System.Drawing.Point(3, 301);
            this.txt_BuscarPedidosDelDia.MaxLength = 50;
            this.txt_BuscarPedidosDelDia.Name = "txt_BuscarPedidosDelDia";
            this.txt_BuscarPedidosDelDia.Size = new System.Drawing.Size(120, 20);
            this.txt_BuscarPedidosDelDia.TabIndex = 17;
            // 
            // dgvPedidosDelDia
            // 
            this.dgvPedidosDelDia.AllowUserToAddRows = false;
            this.dgvPedidosDelDia.AllowUserToDeleteRows = false;
            this.dgvPedidosDelDia.AllowUserToResizeColumns = false;
            this.dgvPedidosDelDia.AllowUserToResizeRows = false;
            this.dgvPedidosDelDia.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvPedidosDelDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosDelDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModificarPedido,
            this.idPedido,
            this.TelefonoPedido,
            this.DomicilioPedido});
            this.dgvPedidosDelDia.Location = new System.Drawing.Point(3, 24);
            this.dgvPedidosDelDia.MultiSelect = false;
            this.dgvPedidosDelDia.Name = "dgvPedidosDelDia";
            this.dgvPedidosDelDia.ReadOnly = true;
            this.dgvPedidosDelDia.RowHeadersVisible = false;
            this.dgvPedidosDelDia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPedidosDelDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPedidosDelDia.Size = new System.Drawing.Size(120, 271);
            this.dgvPedidosDelDia.TabIndex = 16;
            // 
            // ModificarPedido
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ModificarPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.ModificarPedido.HeaderText = "X";
            this.ModificarPedido.Name = "ModificarPedido";
            this.ModificarPedido.ReadOnly = true;
            this.ModificarPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ModificarPedido.Text = "X";
            this.ModificarPedido.ToolTipText = "Modificar o Anular Pedido";
            this.ModificarPedido.UseColumnTextForButtonValue = true;
            this.ModificarPedido.Width = 30;
            // 
            // idPedido
            // 
            this.idPedido.DataPropertyName = "idPedido";
            this.idPedido.HeaderText = "idPedido";
            this.idPedido.Name = "idPedido";
            this.idPedido.ReadOnly = true;
            this.idPedido.Visible = false;
            // 
            // TelefonoPedido
            // 
            this.TelefonoPedido.DataPropertyName = "telefonoCliente";
            this.TelefonoPedido.HeaderText = "Teléfono";
            this.TelefonoPedido.Name = "TelefonoPedido";
            this.TelefonoPedido.ReadOnly = true;
            this.TelefonoPedido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TelefonoPedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TelefonoPedido.Width = 86;
            // 
            // DomicilioPedido
            // 
            this.DomicilioPedido.DataPropertyName = "domiciliocliente";
            this.DomicilioPedido.HeaderText = "Domicilio";
            this.DomicilioPedido.Name = "DomicilioPedido";
            this.DomicilioPedido.ReadOnly = true;
            this.DomicilioPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DomicilioPedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DomicilioPedido.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.BurlyWood;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "PEDIDOS DEL DIA:";
            // 
            // frmModifPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 346);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelEncabezadoPedido);
            this.Name = "frmModifPedido";
            this.Text = "Modificar Pedido";
            this.Load += new System.EventHandler(this.frmModifDelivery_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsPedido)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelPago.ResumeLayout(false);
            this.panelPago.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromociones)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelEncabezadoPedido.ResumeLayout(false);
            this.panelEncabezadoPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosDelDia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtObservacionPedido;
        private System.Windows.Forms.Button btnBuscarClientePedido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNuevaPromocion;
        private System.Windows.Forms.DataGridView dgvItemsPedido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDetallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioX1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelPago;
        private System.Windows.Forms.TextBox txtDto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDemora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEnvioPedido;
        private System.Windows.Forms.TextBox txtMontoAbono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMontoTotalPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcularMontoTotalPedido;
        private System.Windows.Forms.Button btnImprimirPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPromociones;
        private System.Windows.Forms.DataGridViewButtonColumn eliminarPromo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbMostrador;
        private System.Windows.Forms.RadioButton rbDelivery;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelEncabezadoPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDomicilioEntrega;
        private System.Windows.Forms.TextBox txtTelefonoClientePedido;
        private System.Windows.Forms.TextBox txtNombreClientePedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDomicilioAlternativo;
        private System.Windows.Forms.TextBox txtDomicilioClientePedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_BuscarPedidosDelDia;
        private System.Windows.Forms.DataGridView dgvPedidosDelDia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewButtonColumn ModificarPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomicilioPedido;
    }
}
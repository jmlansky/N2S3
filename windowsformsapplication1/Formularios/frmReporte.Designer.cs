namespace NoHay2Sin3
{
    partial class frmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbInformeVentas = new System.Windows.Forms.RadioButton();
            this.rbCajaDiaria = new System.Windows.Forms.RadioButton();
            this.panelFechasInforme = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaHastaInforme = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaDesdeInforme = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVerInforme = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvCantidadesVendidas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.txtCantidadPedidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvInformeDetallePedido = new System.Windows.Forms.DataGridView();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProductoDetallePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDetallePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvInformePedido = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imprimirPedido = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Anular = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelFechasInforme.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidadesVendidas)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeDetallePedido)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbInformeVentas);
            this.panel1.Controls.Add(this.rbCajaDiaria);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 57);
            this.panel1.TabIndex = 0;
            // 
            // rbInformeVentas
            // 
            this.rbInformeVentas.AutoSize = true;
            this.rbInformeVentas.Location = new System.Drawing.Point(4, 27);
            this.rbInformeVentas.Name = "rbInformeVentas";
            this.rbInformeVentas.Size = new System.Drawing.Size(111, 17);
            this.rbInformeVentas.TabIndex = 1;
            this.rbInformeVentas.TabStop = true;
            this.rbInformeVentas.Text = "Informe de Ventas";
            this.rbInformeVentas.UseVisualStyleBackColor = true;
            this.rbInformeVentas.CheckedChanged += new System.EventHandler(this.rbInformeVentas_CheckedChanged);
            // 
            // rbCajaDiaria
            // 
            this.rbCajaDiaria.AutoSize = true;
            this.rbCajaDiaria.Location = new System.Drawing.Point(4, 4);
            this.rbCajaDiaria.Name = "rbCajaDiaria";
            this.rbCajaDiaria.Size = new System.Drawing.Size(74, 17);
            this.rbCajaDiaria.TabIndex = 0;
            this.rbCajaDiaria.TabStop = true;
            this.rbCajaDiaria.Text = "Caja diaria";
            this.rbCajaDiaria.UseVisualStyleBackColor = true;
            this.rbCajaDiaria.CheckedChanged += new System.EventHandler(this.rbCajaDiaria_CheckedChanged);
            // 
            // panelFechasInforme
            // 
            this.panelFechasInforme.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelFechasInforme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFechasInforme.Controls.Add(this.label2);
            this.panelFechasInforme.Controls.Add(this.dtpFechaHastaInforme);
            this.panelFechasInforme.Controls.Add(this.label1);
            this.panelFechasInforme.Controls.Add(this.dtpFechaDesdeInforme);
            this.panelFechasInforme.Location = new System.Drawing.Point(12, 75);
            this.panelFechasInforme.Name = "panelFechasInforme";
            this.panelFechasInforme.Size = new System.Drawing.Size(155, 60);
            this.panelFechasInforme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta:";
            // 
            // dtpFechaHastaInforme
            // 
            this.dtpFechaHastaInforme.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHastaInforme.Location = new System.Drawing.Point(45, 29);
            this.dtpFechaHastaInforme.Name = "dtpFechaHastaInforme";
            this.dtpFechaHastaInforme.Size = new System.Drawing.Size(94, 20);
            this.dtpFechaHastaInforme.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dede:";
            // 
            // dtpFechaDesdeInforme
            // 
            this.dtpFechaDesdeInforme.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesdeInforme.Location = new System.Drawing.Point(45, 3);
            this.dtpFechaDesdeInforme.Name = "dtpFechaDesdeInforme";
            this.dtpFechaDesdeInforme.Size = new System.Drawing.Size(94, 20);
            this.dtpFechaDesdeInforme.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnVerInforme);
            this.panel4.Location = new System.Drawing.Point(12, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 72);
            this.panel4.TabIndex = 2;
            // 
            // btnVerInforme
            // 
            this.btnVerInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerInforme.Image = global::NoHay2Sin3.Properties.Resources.ver_informe;
            this.btnVerInforme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVerInforme.Location = new System.Drawing.Point(6, 3);
            this.btnVerInforme.Name = "btnVerInforme";
            this.btnVerInforme.Size = new System.Drawing.Size(133, 62);
            this.btnVerInforme.TabIndex = 0;
            this.btnVerInforme.Text = "Ver";
            this.btnVerInforme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVerInforme.UseVisualStyleBackColor = true;
            this.btnVerInforme.Click += new System.EventHandler(this.btnVerInforme_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(173, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(592, 313);
            this.panel3.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.dgvCantidadesVendidas);
            this.panel7.Location = new System.Drawing.Point(379, 75);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(204, 235);
            this.panel7.TabIndex = 7;
            // 
            // dgvCantidadesVendidas
            // 
            this.dgvCantidadesVendidas.AllowUserToAddRows = false;
            this.dgvCantidadesVendidas.AllowUserToDeleteRows = false;
            this.dgvCantidadesVendidas.AllowUserToResizeColumns = false;
            this.dgvCantidadesVendidas.AllowUserToResizeRows = false;
            this.dgvCantidadesVendidas.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvCantidadesVendidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCantidadesVendidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvCantidadesVendidas.Location = new System.Drawing.Point(3, 3);
            this.dgvCantidadesVendidas.MultiSelect = false;
            this.dgvCantidadesVendidas.Name = "dgvCantidadesVendidas";
            this.dgvCantidadesVendidas.ReadOnly = true;
            this.dgvCantidadesVendidas.RowHeadersVisible = false;
            this.dgvCantidadesVendidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCantidadesVendidas.Size = new System.Drawing.Size(190, 225);
            this.dgvCantidadesVendidas.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nombreProducto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cantidadProducto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Vendidos";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 57;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.txtIngresos);
            this.panel6.Controls.Add(this.txtCantidadPedidos);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(379, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(204, 66);
            this.panel6.TabIndex = 6;
            // 
            // txtIngresos
            // 
            this.txtIngresos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngresos.Location = new System.Drawing.Point(116, 35);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.ReadOnly = true;
            this.txtIngresos.Size = new System.Drawing.Size(77, 20);
            this.txtIngresos.TabIndex = 3;
            this.txtIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCantidadPedidos
            // 
            this.txtCantidadPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadPedidos.Location = new System.Drawing.Point(116, 9);
            this.txtCantidadPedidos.Name = "txtCantidadPedidos";
            this.txtCantidadPedidos.ReadOnly = true;
            this.txtCantidadPedidos.Size = new System.Drawing.Size(77, 20);
            this.txtCantidadPedidos.TabIndex = 2;
            this.txtCantidadPedidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ingresos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad pedidos:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.dgvInformeDetallePedido);
            this.panel5.Location = new System.Drawing.Point(3, 168);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(370, 148);
            this.panel5.TabIndex = 5;
            // 
            // dgvInformeDetallePedido
            // 
            this.dgvInformeDetallePedido.AllowUserToAddRows = false;
            this.dgvInformeDetallePedido.AllowUserToDeleteRows = false;
            this.dgvInformeDetallePedido.AllowUserToResizeColumns = false;
            this.dgvInformeDetallePedido.AllowUserToResizeRows = false;
            this.dgvInformeDetallePedido.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvInformeDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformeDetallePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreProducto,
            this.cantidadProductoDetallePedido,
            this.PrecioProducto,
            this.observacionDetallePedido});
            this.dgvInformeDetallePedido.Location = new System.Drawing.Point(3, 2);
            this.dgvInformeDetallePedido.MultiSelect = false;
            this.dgvInformeDetallePedido.Name = "dgvInformeDetallePedido";
            this.dgvInformeDetallePedido.ReadOnly = true;
            this.dgvInformeDetallePedido.RowHeadersVisible = false;
            this.dgvInformeDetallePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInformeDetallePedido.Size = new System.Drawing.Size(360, 134);
            this.dgvInformeDetallePedido.TabIndex = 1;
            // 
            // nombreProducto
            // 
            this.nombreProducto.DataPropertyName = "nombreProducto";
            this.nombreProducto.HeaderText = "Producto";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            this.nombreProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cantidadProductoDetallePedido
            // 
            this.cantidadProductoDetallePedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cantidadProductoDetallePedido.DataPropertyName = "cantidadProductoDetallePedido";
            this.cantidadProductoDetallePedido.HeaderText = "Cantidad";
            this.cantidadProductoDetallePedido.Name = "cantidadProductoDetallePedido";
            this.cantidadProductoDetallePedido.ReadOnly = true;
            this.cantidadProductoDetallePedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cantidadProductoDetallePedido.Width = 74;
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PrecioProducto.DataPropertyName = "precioProducto";
            this.PrecioProducto.HeaderText = "Precio";
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.ReadOnly = true;
            this.PrecioProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrecioProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PrecioProducto.Width = 43;
            // 
            // observacionDetallePedido
            // 
            this.observacionDetallePedido.DataPropertyName = "observacionDetallePedido";
            this.observacionDetallePedido.HeaderText = "Observaciones";
            this.observacionDetallePedido.Name = "observacionDetallePedido";
            this.observacionDetallePedido.ReadOnly = true;
            this.observacionDetallePedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.observacionDetallePedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.observacionDetallePedido.Width = 200;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgvInformePedido);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 165);
            this.panel2.TabIndex = 4;
            // 
            // dgvInformePedido
            // 
            this.dgvInformePedido.AllowUserToAddRows = false;
            this.dgvInformePedido.AllowUserToDeleteRows = false;
            this.dgvInformePedido.AllowUserToResizeColumns = false;
            this.dgvInformePedido.AllowUserToResizeRows = false;
            this.dgvInformePedido.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvInformePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imprimirPedido,
            this.Anular,
            this.idPedido,
            this.fechaPedido,
            this.horaPedido,
            this.domicilioPedido,
            this.montoTotal});
            this.dgvInformePedido.Location = new System.Drawing.Point(3, 3);
            this.dgvInformePedido.MultiSelect = false;
            this.dgvInformePedido.Name = "dgvInformePedido";
            this.dgvInformePedido.ReadOnly = true;
            this.dgvInformePedido.RowHeadersVisible = false;
            this.dgvInformePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInformePedido.Size = new System.Drawing.Size(360, 154);
            this.dgvInformePedido.TabIndex = 0;
            this.dgvInformePedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInformePedido_CellContentClick);
            this.dgvInformePedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInformePedido_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.Image = global::NoHay2Sin3.Properties.Resources.logo_chico;
            this.pictureBox1.Location = new System.Drawing.Point(12, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // imprimirPedido
            // 
            this.imprimirPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.imprimirPedido.HeaderText = "Imprimir";
            this.imprimirPedido.Name = "imprimirPedido";
            this.imprimirPedido.ReadOnly = true;
            this.imprimirPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.imprimirPedido.Text = "Imprimir";
            this.imprimirPedido.UseColumnTextForButtonValue = true;
            this.imprimirPedido.Visible = false;
            this.imprimirPedido.Width = 48;
            // 
            // Anular
            // 
            this.Anular.HeaderText = "Anular";
            this.Anular.Name = "Anular";
            this.Anular.ReadOnly = true;
            this.Anular.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Anular.Text = "Anular";
            this.Anular.UseColumnTextForButtonValue = true;
            this.Anular.Width = 60;
            // 
            // idPedido
            // 
            this.idPedido.DataPropertyName = "idPedido";
            this.idPedido.HeaderText = "idPedido";
            this.idPedido.Name = "idPedido";
            this.idPedido.ReadOnly = true;
            this.idPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idPedido.Visible = false;
            // 
            // fechaPedido
            // 
            this.fechaPedido.DataPropertyName = "fechaPedido";
            this.fechaPedido.HeaderText = "Fecha";
            this.fechaPedido.Name = "fechaPedido";
            this.fechaPedido.ReadOnly = true;
            this.fechaPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fechaPedido.Width = 70;
            // 
            // horaPedido
            // 
            this.horaPedido.DataPropertyName = "horaPedido";
            this.horaPedido.HeaderText = "Hora";
            this.horaPedido.Name = "horaPedido";
            this.horaPedido.ReadOnly = true;
            this.horaPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.horaPedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.horaPedido.Width = 40;
            // 
            // domicilioPedido
            // 
            this.domicilioPedido.DataPropertyName = "domicilioEntregaPedido";
            this.domicilioPedido.HeaderText = "Domicilio";
            this.domicilioPedido.Name = "domicilioPedido";
            this.domicilioPedido.ReadOnly = true;
            this.domicilioPedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.domicilioPedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.domicilioPedido.Width = 120;
            // 
            // montoTotal
            // 
            this.montoTotal.DataPropertyName = "montoTotalPedido";
            this.montoTotal.HeaderText = "Monto";
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.ReadOnly = true;
            this.montoTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.montoTotal.Width = 55;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(776, 337);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelFechasInforme);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmReporte";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReporte_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFechasInforme.ResumeLayout(false);
            this.panelFechasInforme.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCantidadesVendidas)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeDetallePedido)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFechasInforme;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbInformeVentas;
        private System.Windows.Forms.RadioButton rbCajaDiaria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaHastaInforme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeInforme;
        private System.Windows.Forms.Button btnVerInforme;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.TextBox txtCantidadPedidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvInformeDetallePedido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvInformePedido;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvCantidadesVendidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductoDetallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDetallePedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewButtonColumn imprimirPedido;
        private System.Windows.Forms.DataGridViewButtonColumn Anular;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
    }
}
namespace NoHay2Sin3
{
    partial class frmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grupoPrecio = new System.Windows.Forms.GroupBox();
            this.txtX3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciox2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciox3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarProduto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grupoPrecio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Location = new System.Drawing.Point(75, 9);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProducto.MaxLength = 20;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(133, 22);
            this.txtProducto.TabIndex = 0;
            // 
            // txtX1
            // 
            this.txtX1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtX1.Location = new System.Drawing.Point(8, 39);
            this.txtX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtX1.MaxLength = 7;
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(54, 22);
            this.txtX1.TabIndex = 0;
            this.txtX1.TextChanged += new System.EventHandler(this.txtX1_TextChanged);
            this.txtX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX1_KeyPress);
            this.txtX1.Leave += new System.EventHandler(this.txtX1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "X1";
            // 
            // grupoPrecio
            // 
            this.grupoPrecio.BackColor = System.Drawing.Color.Tan;
            this.grupoPrecio.Controls.Add(this.txtX3);
            this.grupoPrecio.Controls.Add(this.label4);
            this.grupoPrecio.Controls.Add(this.txtX2);
            this.grupoPrecio.Controls.Add(this.label3);
            this.grupoPrecio.Controls.Add(this.txtX1);
            this.grupoPrecio.Controls.Add(this.label2);
            this.grupoPrecio.Location = new System.Drawing.Point(8, 55);
            this.grupoPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grupoPrecio.Name = "grupoPrecio";
            this.grupoPrecio.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grupoPrecio.Size = new System.Drawing.Size(216, 81);
            this.grupoPrecio.TabIndex = 1;
            this.grupoPrecio.TabStop = false;
            this.grupoPrecio.Text = "Precio";
            // 
            // txtX3
            // 
            this.txtX3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtX3.Location = new System.Drawing.Point(153, 39);
            this.txtX3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtX3.MaxLength = 7;
            this.txtX3.Name = "txtX3";
            this.txtX3.Size = new System.Drawing.Size(54, 22);
            this.txtX3.TabIndex = 2;
            this.txtX3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX3_KeyPress);
            this.txtX3.Leave += new System.EventHandler(this.txtX3_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "X3";
            // 
            // txtX2
            // 
            this.txtX2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtX2.Location = new System.Drawing.Point(83, 39);
            this.txtX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtX2.MaxLength = 7;
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(54, 22);
            this.txtX2.TabIndex = 1;
            this.txtX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX2_KeyPress);
            this.txtX2.Leave += new System.EventHandler(this.txtX2_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "X2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Location = new System.Drawing.Point(4, 26);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtObservaciones.MaxLength = 100;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(201, 86);
            this.txtObservaciones.TabIndex = 0;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.Tan;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEliminar,
            this.idProducto,
            this.nombreProducto,
            this.precioX1,
            this.preciox2,
            this.preciox3,
            this.observacionProducto});
            this.dgvProductos.Location = new System.Drawing.Point(7, 6);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(663, 340);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.MinimumWidth = 6;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            this.btnEliminar.Width = 61;
            // 
            // idProducto
            // 
            this.idProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.MinimumWidth = 6;
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            this.idProducto.Width = 125;
            // 
            // nombreProducto
            // 
            this.nombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreProducto.DataPropertyName = "nombreProducto";
            this.nombreProducto.HeaderText = "Producto";
            this.nombreProducto.MinimumWidth = 6;
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            this.nombreProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombreProducto.Width = 90;
            // 
            // precioX1
            // 
            this.precioX1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.precioX1.DataPropertyName = "precioX1";
            this.precioX1.HeaderText = "Precio X1";
            this.precioX1.MinimumWidth = 6;
            this.precioX1.Name = "precioX1";
            this.precioX1.ReadOnly = true;
            this.precioX1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precioX1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.precioX1.Width = 70;
            // 
            // preciox2
            // 
            this.preciox2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.preciox2.DataPropertyName = "precioX2";
            this.preciox2.HeaderText = "Precio X2";
            this.preciox2.MinimumWidth = 6;
            this.preciox2.Name = "preciox2";
            this.preciox2.ReadOnly = true;
            this.preciox2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.preciox2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.preciox2.Width = 70;
            // 
            // preciox3
            // 
            this.preciox3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.preciox3.DataPropertyName = "precioX3";
            this.preciox3.HeaderText = "Precio X3";
            this.preciox3.MinimumWidth = 6;
            this.preciox3.Name = "preciox3";
            this.preciox3.ReadOnly = true;
            this.preciox3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.preciox3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.preciox3.Width = 70;
            // 
            // observacionProducto
            // 
            this.observacionProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.observacionProducto.DataPropertyName = "observacionProducto";
            this.observacionProducto.HeaderText = "Observacion";
            this.observacionProducto.MinimumWidth = 6;
            this.observacionProducto.Name = "observacionProducto";
            this.observacionProducto.ReadOnly = true;
            this.observacionProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.observacionProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.observacionProducto.Width = 190;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(8, 7);
            this.lblIdProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(0, 16);
            this.lblIdProducto.TabIndex = 9;
            this.lblIdProducto.Visible = false;
            // 
            // button1
            // 
            this.button1.Image = global::NoHay2Sin3.Properties.Resources.cancel;
            this.button1.Location = new System.Drawing.Point(153, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 49);
            this.button1.TabIndex = 2;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::NoHay2Sin3.Properties.Resources.clean;
            this.btnCancelar.Location = new System.Drawing.Point(83, 11);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 49);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarProduto
            // 
            this.btnGuardarProduto.Image = global::NoHay2Sin3.Properties.Resources.guardar;
            this.btnGuardarProduto.Location = new System.Drawing.Point(8, 11);
            this.btnGuardarProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarProduto.Name = "btnGuardarProduto";
            this.btnGuardarProduto.Size = new System.Drawing.Size(63, 49);
            this.btnGuardarProduto.TabIndex = 0;
            this.btnGuardarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarProduto.UseVisualStyleBackColor = true;
            this.btnGuardarProduto.Click += new System.EventHandler(this.btnGuardarProduto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvProductos);
            this.panel1.Location = new System.Drawing.Point(261, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 361);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.grupoPrecio);
            this.panel2.Controls.Add(this.lblIdProducto);
            this.panel2.Location = new System.Drawing.Point(16, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 277);
            this.panel2.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tan;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtObservaciones);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(8, 144);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 121);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtProducto);
            this.panel3.Location = new System.Drawing.Point(8, 7);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 41);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnGuardarProduto);
            this.panel5.Controls.Add(this.btnCancelar);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(16, 300);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 75);
            this.panel5.TabIndex = 3;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(953, 385);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProducto";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProducto_KeyDown);
            this.grupoPrecio.ResumeLayout(false);
            this.grupoPrecio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grupoPrecio;
        private System.Windows.Forms.TextBox txtX3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnGuardarProduto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionProducto;
    }
}
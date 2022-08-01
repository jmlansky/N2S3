namespace NoHay2Sin3
{
    partial class frmDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelivery));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardarPrecioDelivery = new System.Windows.Forms.Button();
            this.txtPrecioDelivery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnGuardarPrecioDelivery);
            this.panel1.Controls.Add(this.txtPrecioDelivery);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 94);
            this.panel1.TabIndex = 0;
            // 
            // btnGuardarPrecioDelivery
            // 
            this.btnGuardarPrecioDelivery.Location = new System.Drawing.Point(56, 47);
            this.btnGuardarPrecioDelivery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarPrecioDelivery.Name = "btnGuardarPrecioDelivery";
            this.btnGuardarPrecioDelivery.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarPrecioDelivery.TabIndex = 2;
            this.btnGuardarPrecioDelivery.Text = "&Guardar";
            this.btnGuardarPrecioDelivery.UseVisualStyleBackColor = true;
            this.btnGuardarPrecioDelivery.Click += new System.EventHandler(this.btnGuardarPrecioDelivery_Click);
            // 
            // txtPrecioDelivery
            // 
            this.txtPrecioDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioDelivery.Location = new System.Drawing.Point(139, 15);
            this.txtPrecioDelivery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioDelivery.MaxLength = 7;
            this.txtPrecioDelivery.Name = "txtPrecioDelivery";
            this.txtPrecioDelivery.Size = new System.Drawing.Size(77, 22);
            this.txtPrecioDelivery.TabIndex = 1;
            this.txtPrecioDelivery.TextChanged += new System.EventHandler(this.txtPrecioDelivery_TextChanged);
            this.txtPrecioDelivery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioDelivery_KeyPress);
            this.txtPrecioDelivery.Leave += new System.EventHandler(this.txtPrecioDelivery_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio del Delivery";
            // 
            // frmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(260, 124);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDelivery";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.frmDelivery_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDelivery_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarPrecioDelivery;
        private System.Windows.Forms.TextBox txtPrecioDelivery;
        private System.Windows.Forms.Label label1;
    }
}
namespace NoHay2Sin3
{
    partial class Seguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seguridad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardarPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassowrd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.btnGuardarPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPassowrd);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 81);
            this.panel1.TabIndex = 0;
            // 
            // btnGuardarPassword
            // 
            this.btnGuardarPassword.Image = global::NoHay2Sin3.Properties.Resources.guardar;
            this.btnGuardarPassword.Location = new System.Drawing.Point(71, 38);
            this.btnGuardarPassword.Name = "btnGuardarPassword";
            this.btnGuardarPassword.Size = new System.Drawing.Size(52, 40);
            this.btnGuardarPassword.TabIndex = 2;
            this.btnGuardarPassword.UseVisualStyleBackColor = true;
            this.btnGuardarPassword.Click += new System.EventHandler(this.btnGuardarPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // txtPassowrd
            // 
            this.txtPassowrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassowrd.Location = new System.Drawing.Point(71, 12);
            this.txtPassowrd.MaxLength = 20;
            this.txtPassowrd.Name = "txtPassowrd";
            this.txtPassowrd.PasswordChar = '*';
            this.txtPassowrd.Size = new System.Drawing.Size(122, 20);
            this.txtPassowrd.TabIndex = 0;
            // 
            // Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(228, 104);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Seguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguridad";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Seguridad_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassowrd;
    }
}
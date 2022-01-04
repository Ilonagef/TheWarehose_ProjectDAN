namespace TheWarehose
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btrClear = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btrlogin = new System.Windows.Forms.Button();
            this.linkLabelSingUP = new System.Windows.Forms.LinkLabel();
            this.btradmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtName
            // 
            this.txtName.AcceptsTab = true;
            this.txtName.Location = new System.Drawing.Point(358, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 22);
            this.txtName.TabIndex = 2;
            // 
            // btrClear
            // 
            this.btrClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btrClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btrClear.Location = new System.Drawing.Point(182, 287);
            this.btrClear.Name = "btrClear";
            this.btrClear.Size = new System.Drawing.Size(121, 49);
            this.btrClear.TabIndex = 3;
            this.btrClear.Text = "Clear";
            this.btrClear.UseVisualStyleBackColor = false;
            this.btrClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(358, 204);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(190, 22);
            this.txtpass.TabIndex = 2;
            // 
            // btrlogin
            // 
            this.btrlogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btrlogin.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btrlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btrlogin.Location = new System.Drawing.Point(473, 287);
            this.btrlogin.Name = "btrlogin";
            this.btrlogin.Size = new System.Drawing.Size(121, 49);
            this.btrlogin.TabIndex = 3;
            this.btrlogin.Text = "Login";
            this.btrlogin.UseVisualStyleBackColor = false;
            this.btrlogin.Click += new System.EventHandler(this.btrlogin_Click);
            // 
            // linkLabelSingUP
            // 
            this.linkLabelSingUP.AutoSize = true;
            this.linkLabelSingUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSingUP.Location = new System.Drawing.Point(651, 389);
            this.linkLabelSingUP.Name = "linkLabelSingUP";
            this.linkLabelSingUP.Size = new System.Drawing.Size(86, 25);
            this.linkLabelSingUP.TabIndex = 4;
            this.linkLabelSingUP.TabStop = true;
            this.linkLabelSingUP.Text = "Sign up";
            this.linkLabelSingUP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btradmin
            // 
            this.btradmin.Location = new System.Drawing.Point(358, 389);
            this.btradmin.Name = "btradmin";
            this.btradmin.Size = new System.Drawing.Size(100, 34);
            this.btradmin.TabIndex = 5;
            this.btradmin.Text = "Admin";
            this.btradmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btradmin.UseVisualStyleBackColor = true;
            this.btradmin.Click += new System.EventHandler(this.btradmin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(845, 516);
            this.Controls.Add(this.btradmin);
            this.Controls.Add(this.linkLabelSingUP);
            this.Controls.Add(this.btrlogin);
            this.Controls.Add(this.btrClear);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "The Warehose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btrClear;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btrlogin;
        private System.Windows.Forms.LinkLabel linkLabelSingUP;
        private System.Windows.Forms.Button btradmin;
    }
}


namespace TheWarehose
{
    partial class Productchooser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productchooser));
            this.lblphon = new System.Windows.Forms.Label();
            this.lblacces = new System.Windows.Forms.Label();
            this.lblgad = new System.Windows.Forms.Label();
            this.picphon = new System.Windows.Forms.PictureBox();
            this.picacces = new System.Windows.Forms.PictureBox();
            this.picgad = new System.Windows.Forms.PictureBox();
            this.btrTocart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picphon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picacces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblphon
            // 
            this.lblphon.AutoSize = true;
            this.lblphon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphon.Location = new System.Drawing.Point(610, 48);
            this.lblphon.Name = "lblphon";
            this.lblphon.Size = new System.Drawing.Size(83, 29);
            this.lblphon.TabIndex = 0;
            this.lblphon.Text = "Phone";
            // 
            // lblacces
            // 
            this.lblacces.AutoSize = true;
            this.lblacces.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacces.Location = new System.Drawing.Point(333, 48);
            this.lblacces.Name = "lblacces";
            this.lblacces.Size = new System.Drawing.Size(144, 29);
            this.lblacces.TabIndex = 1;
            this.lblacces.Text = "Accessories";
            // 
            // lblgad
            // 
            this.lblgad.AutoSize = true;
            this.lblgad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgad.Location = new System.Drawing.Point(89, 48);
            this.lblgad.Name = "lblgad";
            this.lblgad.Size = new System.Drawing.Size(104, 29);
            this.lblgad.TabIndex = 2;
            this.lblgad.Text = "Gadgets";
            // 
            // picphon
            // 
            this.picphon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picphon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picphon.Image = ((System.Drawing.Image)(resources.GetObject("picphon.Image")));
            this.picphon.Location = new System.Drawing.Point(550, 159);
            this.picphon.Name = "picphon";
            this.picphon.Size = new System.Drawing.Size(202, 192);
            this.picphon.TabIndex = 3;
            this.picphon.TabStop = false;
            this.picphon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picacces
            // 
            this.picacces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picacces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picacces.Image = ((System.Drawing.Image)(resources.GetObject("picacces.Image")));
            this.picacces.Location = new System.Drawing.Point(298, 159);
            this.picacces.Name = "picacces";
            this.picacces.Size = new System.Drawing.Size(209, 192);
            this.picacces.TabIndex = 4;
            this.picacces.TabStop = false;
            this.picacces.Click += new System.EventHandler(this.picacces_Click);
            // 
            // picgad
            // 
            this.picgad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picgad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picgad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picgad.Image = ((System.Drawing.Image)(resources.GetObject("picgad.Image")));
            this.picgad.Location = new System.Drawing.Point(25, 159);
            this.picgad.Name = "picgad";
            this.picgad.Size = new System.Drawing.Size(231, 192);
            this.picgad.TabIndex = 5;
            this.picgad.TabStop = false;
            this.picgad.Click += new System.EventHandler(this.picgad_Click);
            // 
            // btrTocart
            // 
            this.btrTocart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btrTocart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrTocart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btrTocart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btrTocart.Location = new System.Drawing.Point(677, 400);
            this.btrTocart.Name = "btrTocart";
            this.btrTocart.Size = new System.Drawing.Size(75, 23);
            this.btrTocart.TabIndex = 6;
            this.btrTocart.Text = "To Cart";
            this.btrTocart.UseVisualStyleBackColor = true;
            this.btrTocart.Click += new System.EventHandler(this.btrTocart_Click);
            // 
            // Productchooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btrTocart);
            this.Controls.Add(this.picgad);
            this.Controls.Add(this.picacces);
            this.Controls.Add(this.picphon);
            this.Controls.Add(this.lblgad);
            this.Controls.Add(this.lblacces);
            this.Controls.Add(this.lblphon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productchooser";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.picphon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picacces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picgad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblphon;
        private System.Windows.Forms.Label lblacces;
        private System.Windows.Forms.Label lblgad;
        private System.Windows.Forms.PictureBox picphon;
        private System.Windows.Forms.PictureBox picacces;
        private System.Windows.Forms.PictureBox picgad;
        private System.Windows.Forms.Button btrTocart;
    }
}
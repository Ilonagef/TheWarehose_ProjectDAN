namespace TheWarehose.GuiClasses
{
    partial class CarttVeiw
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
            this.button1 = new System.Windows.Forms.Button();
            this.btrclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUserItems = new System.Windows.Forms.DataGridView();
            this.labeltotalPrice = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserItems)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(641, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "go to payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btrclear
            // 
            this.btrclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btrclear.Location = new System.Drawing.Point(12, 394);
            this.btrclear.Name = "btrclear";
            this.btrclear.Size = new System.Drawing.Size(110, 44);
            this.btrclear.TabIndex = 2;
            this.btrclear.Text = "Clear";
            this.btrclear.UseVisualStyleBackColor = true;
            this.btrclear.Click += new System.EventHandler(this.btrclear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "סה\"כ לתשלום:";
            // 
            // dataGridViewUserItems
            // 
            this.dataGridViewUserItems.AllowUserToAddRows = false;
            this.dataGridViewUserItems.AllowUserToResizeColumns = false;
            this.dataGridViewUserItems.AllowUserToResizeRows = false;
            this.dataGridViewUserItems.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewUserItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewUserItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserItems.Location = new System.Drawing.Point(-1, 1);
            this.dataGridViewUserItems.Name = "dataGridViewUserItems";
            this.dataGridViewUserItems.ReadOnly = true;
            this.dataGridViewUserItems.RowHeadersWidth = 51;
            this.dataGridViewUserItems.RowTemplate.Height = 24;
            this.dataGridViewUserItems.Size = new System.Drawing.Size(801, 292);
            this.dataGridViewUserItems.TabIndex = 7;
            this.dataGridViewUserItems.SelectionChanged += new System.EventHandler(this.dataGridViewUserItems_SelectionChanged);
            // 
            // labeltotalPrice
            // 
            this.labeltotalPrice.AutoSize = true;
            this.labeltotalPrice.Location = new System.Drawing.Point(364, 323);
            this.labeltotalPrice.Name = "labeltotalPrice";
            this.labeltotalPrice.Size = new System.Drawing.Size(46, 17);
            this.labeltotalPrice.TabIndex = 8;
            this.labeltotalPrice.Text = "label2";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(336, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Back To Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 51);
            this.label2.TabIndex = 10;
            this.label2.Text = "IMPORTANT: Once pressing \"Clear\",\r\nClose and re-open the window to see the\r\nnew s" +
    "um total.";
            // 
            // CarttVeiw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labeltotalPrice);
            this.Controls.Add(this.dataGridViewUserItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btrclear);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarttVeiw";
            this.Text = "CarttVeiw";
            this.Load += new System.EventHandler(this.CarttVeiw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btrclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUserItems;
        private System.Windows.Forms.Label labeltotalPrice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}
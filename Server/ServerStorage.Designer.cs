namespace Server
{
    partial class ServerStorage
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
            this.label1 = new System.Windows.Forms.Label();
            this.StorageBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumStorage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Storage";
            // 
            // StorageBox
            // 
            this.StorageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorageBox.FormattingEnabled = true;
            this.StorageBox.ItemHeight = 16;
            this.StorageBox.Location = new System.Drawing.Point(16, 38);
            this.StorageBox.Name = "StorageBox";
            this.StorageBox.Size = new System.Drawing.Size(629, 676);
            this.StorageBox.TabIndex = 1;
            this.StorageBox.SelectedIndexChanged += new System.EventHandler(this.StorageBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Items in Storage:";
            // 
            // NumStorage
            // 
            this.NumStorage.AutoSize = true;
            this.NumStorage.Location = new System.Drawing.Point(193, 20);
            this.NumStorage.Name = "NumStorage";
            this.NumStorage.Size = new System.Drawing.Size(35, 13);
            this.NumStorage.TabIndex = 3;
            this.NumStorage.Text = "label3";
            // 
            // ServerStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(672, 730);
            this.Controls.Add(this.NumStorage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StorageBox);
            this.Controls.Add(this.label1);
            this.Name = "ServerStorage";
            this.Text = "ServerStorage";
            this.Load += new System.EventHandler(this.ServerStorage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox StorageBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NumStorage;
    }
}
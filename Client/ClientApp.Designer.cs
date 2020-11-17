namespace Client
{
    partial class ClientApp
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
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SendTxt = new System.Windows.Forms.TextBox();
            this.ModUserNameBox = new System.Windows.Forms.TextBox();
            this.ModItemNameBox = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchBoxRes = new System.Windows.Forms.ListBox();
            this.StorageBox = new System.Windows.Forms.ListBox();
            this.StoreBTN = new System.Windows.Forms.Button();
            this.SimulateBTN = new System.Windows.Forms.Button();
            this.ModBTN = new System.Windows.Forms.Button();
            this.RetrieveBTN = new System.Windows.Forms.Button();
            this.NumItemLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(40, 53);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(173, 20);
            this.NameTxt.TabIndex = 0;
            this.NameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTxt_KeyDown);
            // 
            // SendTxt
            // 
            this.SendTxt.Location = new System.Drawing.Point(40, 97);
            this.SendTxt.Name = "SendTxt";
            this.SendTxt.Size = new System.Drawing.Size(173, 20);
            this.SendTxt.TabIndex = 1;
            this.SendTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendTxt_KeyDown);
            // 
            // ModUserNameBox
            // 
            this.ModUserNameBox.Location = new System.Drawing.Point(40, 258);
            this.ModUserNameBox.Name = "ModUserNameBox";
            this.ModUserNameBox.Size = new System.Drawing.Size(173, 20);
            this.ModUserNameBox.TabIndex = 2;
            this.ModUserNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModUserNameBox_KeyDown);
            // 
            // ModItemNameBox
            // 
            this.ModItemNameBox.Location = new System.Drawing.Point(40, 313);
            this.ModItemNameBox.Name = "ModItemNameBox";
            this.ModItemNameBox.Size = new System.Drawing.Size(173, 20);
            this.ModItemNameBox.TabIndex = 3;
            this.ModItemNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModItemNameBox_KeyDown);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(316, 35);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(237, 20);
            this.SearchBox.TabIndex = 4;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // SearchBoxRes
            // 
            this.SearchBoxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBoxRes.FormattingEnabled = true;
            this.SearchBoxRes.ItemHeight = 16;
            this.SearchBoxRes.Location = new System.Drawing.Point(316, 79);
            this.SearchBoxRes.Name = "SearchBoxRes";
            this.SearchBoxRes.Size = new System.Drawing.Size(237, 516);
            this.SearchBoxRes.TabIndex = 5;
            // 
            // StorageBox
            // 
            this.StorageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorageBox.FormattingEnabled = true;
            this.StorageBox.ItemHeight = 16;
            this.StorageBox.Location = new System.Drawing.Point(601, 47);
            this.StorageBox.Name = "StorageBox";
            this.StorageBox.Size = new System.Drawing.Size(374, 548);
            this.StorageBox.TabIndex = 6;
            // 
            // StoreBTN
            // 
            this.StoreBTN.Location = new System.Drawing.Point(40, 123);
            this.StoreBTN.Name = "StoreBTN";
            this.StoreBTN.Size = new System.Drawing.Size(75, 37);
            this.StoreBTN.TabIndex = 7;
            this.StoreBTN.Text = "Store Item";
            this.StoreBTN.UseVisualStyleBackColor = true;
            this.StoreBTN.Click += new System.EventHandler(this.StoreBTN_Click);
            // 
            // SimulateBTN
            // 
            this.SimulateBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SimulateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimulateBTN.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SimulateBTN.Location = new System.Drawing.Point(138, 123);
            this.SimulateBTN.Name = "SimulateBTN";
            this.SimulateBTN.Size = new System.Drawing.Size(75, 37);
            this.SimulateBTN.TabIndex = 8;
            this.SimulateBTN.Text = "Simulate! (100)";
            this.SimulateBTN.UseVisualStyleBackColor = false;
            this.SimulateBTN.Click += new System.EventHandler(this.SimulateBTN_Click);
            // 
            // ModBTN
            // 
            this.ModBTN.Location = new System.Drawing.Point(40, 339);
            this.ModBTN.Name = "ModBTN";
            this.ModBTN.Size = new System.Drawing.Size(89, 29);
            this.ModBTN.TabIndex = 9;
            this.ModBTN.Text = "Modify";
            this.ModBTN.UseVisualStyleBackColor = true;
            this.ModBTN.Click += new System.EventHandler(this.ModBTN_Click);
            // 
            // RetrieveBTN
            // 
            this.RetrieveBTN.Location = new System.Drawing.Point(40, 460);
            this.RetrieveBTN.Name = "RetrieveBTN";
            this.RetrieveBTN.Size = new System.Drawing.Size(173, 36);
            this.RetrieveBTN.TabIndex = 10;
            this.RetrieveBTN.Text = "Retrieve Item";
            this.RetrieveBTN.UseVisualStyleBackColor = true;
            this.RetrieveBTN.Click += new System.EventHandler(this.RetrieveBTN_Click);
            // 
            // NumItemLbl
            // 
            this.NumItemLbl.AutoSize = true;
            this.NumItemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumItemLbl.Location = new System.Drawing.Point(769, 24);
            this.NumItemLbl.Name = "NumItemLbl";
            this.NumItemLbl.Size = new System.Drawing.Size(13, 13);
            this.NumItemLbl.TabIndex = 11;
            this.NumItemLbl.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Store an Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Your Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Item You Are Storing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Modify an Existing Item";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "To Modify: Select an Item from Storage and";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fill in the Field you want to change then press \'Modify\'";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Change Name To:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Change Item Name To:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Retrieve a Stored Item";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "To Retrieve an Item: Please Select the Item";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 434);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "from Storage and press \'Retrieve Item\' below";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(9, 537);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Storage Management System";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(9, 550);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Developer: Adnan Azad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(9, 563);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Course: PRG 650 Final Project";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(9, 576);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(233, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Seneca College of Applied Arts and Technology";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(313, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(232, 20);
            this.label17.TabIndex = 27;
            this.label17.Text = "Search for an Existing Item:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(313, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 16);
            this.label18.TabIndex = 28;
            this.label18.Text = "Search Results:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(597, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 20);
            this.label19.TabIndex = 29;
            this.label19.Text = "Storage";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(676, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "Number of Items:";
            // 
            // ClientApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(996, 598);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumItemLbl);
            this.Controls.Add(this.RetrieveBTN);
            this.Controls.Add(this.ModBTN);
            this.Controls.Add(this.SimulateBTN);
            this.Controls.Add(this.StoreBTN);
            this.Controls.Add(this.StorageBox);
            this.Controls.Add(this.SearchBoxRes);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ModItemNameBox);
            this.Controls.Add(this.ModUserNameBox);
            this.Controls.Add(this.SendTxt);
            this.Controls.Add(this.NameTxt);
            this.Name = "ClientApp";
            this.Text = "ClientApp";
            this.Load += new System.EventHandler(this.ClientApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox SendTxt;
        private System.Windows.Forms.TextBox ModUserNameBox;
        private System.Windows.Forms.TextBox ModItemNameBox;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ListBox SearchBoxRes;
        private System.Windows.Forms.ListBox StorageBox;
        private System.Windows.Forms.Button StoreBTN;
        private System.Windows.Forms.Button SimulateBTN;
        private System.Windows.Forms.Button ModBTN;
        private System.Windows.Forms.Button RetrieveBTN;
        private System.Windows.Forms.Label NumItemLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}
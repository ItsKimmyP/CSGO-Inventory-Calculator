namespace Inventory_Calculator
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblInventoryValue = new System.Windows.Forms.Label();
            this.btnGetProfile = new System.Windows.Forms.Button();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.lbPossibleRevenue = new System.Windows.Forms.Label();
            this.lblInTotal = new System.Windows.Forms.Label();
            this.lblItemsValue = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblValue3 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblValue4 = new System.Windows.Forms.Label();
            this.lblTitle4 = new System.Windows.Forms.Label();
            this.lblSellValue = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNickname = new System.Windows.Forms.Label();
            this.prgLoading = new System.Windows.Forms.ProgressBar();
            this.marqueeTimer = new System.Windows.Forms.Timer(this.components);
            this.lblValue5 = new System.Windows.Forms.Label();
            this.lblTitle5 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInventoryValue
            // 
            this.lblInventoryValue.AutoSize = true;
            this.lblInventoryValue.BackColor = System.Drawing.Color.Transparent;
            this.lblInventoryValue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryValue.ForeColor = System.Drawing.Color.White;
            this.lblInventoryValue.Location = new System.Drawing.Point(9, 179);
            this.lblInventoryValue.Name = "lblInventoryValue";
            this.lblInventoryValue.Size = new System.Drawing.Size(48, 22);
            this.lblInventoryValue.TabIndex = 0;
            this.lblInventoryValue.Text = "0.00";
            // 
            // btnGetProfile
            // 
            this.btnGetProfile.Font = new System.Drawing.Font("Arial", 12F);
            this.btnGetProfile.Location = new System.Drawing.Point(157, 84);
            this.btnGetProfile.Name = "btnGetProfile";
            this.btnGetProfile.Size = new System.Drawing.Size(100, 28);
            this.btnGetProfile.TabIndex = 1;
            this.btnGetProfile.Text = "Get Profile";
            this.btnGetProfile.UseVisualStyleBackColor = true;
            this.btnGetProfile.Click += new System.EventHandler(this.btnGetProfile_Click);
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.pbProfilePicture.BackgroundImage = global::Inventory_Calculator.Properties.Resources.DefaultAvatar;
            this.pbProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbProfilePicture.Location = new System.Drawing.Point(12, 12);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(128, 128);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicture.TabIndex = 2;
            this.pbProfilePicture.TabStop = false;
            // 
            // lbPossibleRevenue
            // 
            this.lbPossibleRevenue.AutoSize = true;
            this.lbPossibleRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lbPossibleRevenue.Font = new System.Drawing.Font("Arial", 16.25F);
            this.lbPossibleRevenue.ForeColor = System.Drawing.Color.White;
            this.lbPossibleRevenue.Location = new System.Drawing.Point(8, 496);
            this.lbPossibleRevenue.Name = "lbPossibleRevenue";
            this.lbPossibleRevenue.Size = new System.Drawing.Size(186, 25);
            this.lbPossibleRevenue.TabIndex = 0;
            this.lbPossibleRevenue.Text = "Possible Revenue";
            // 
            // lblInTotal
            // 
            this.lblInTotal.AutoSize = true;
            this.lblInTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblInTotal.Font = new System.Drawing.Font("Arial", 16.25F);
            this.lblInTotal.ForeColor = System.Drawing.Color.White;
            this.lblInTotal.Location = new System.Drawing.Point(8, 154);
            this.lblInTotal.Name = "lblInTotal";
            this.lblInTotal.Size = new System.Drawing.Size(82, 25);
            this.lblInTotal.TabIndex = 0;
            this.lblInTotal.Text = "In Total";
            // 
            // lblItemsValue
            // 
            this.lblItemsValue.AutoSize = true;
            this.lblItemsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblItemsValue.Font = new System.Drawing.Font("Arial", 11F);
            this.lblItemsValue.ForeColor = System.Drawing.Color.White;
            this.lblItemsValue.Location = new System.Drawing.Point(10, 228);
            this.lblItemsValue.Name = "lblItemsValue";
            this.lblItemsValue.Size = new System.Drawing.Size(36, 17);
            this.lblItemsValue.TabIndex = 0;
            this.lblItemsValue.Text = "0.00";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.BackColor = System.Drawing.Color.Transparent;
            this.lblItems.Font = new System.Drawing.Font("Arial", 16.25F);
            this.lblItems.ForeColor = System.Drawing.Color.White;
            this.lblItems.Location = new System.Drawing.Point(8, 203);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(65, 25);
            this.lblItems.TabIndex = 0;
            this.lblItems.Text = "Items";
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.BackColor = System.Drawing.Color.Transparent;
            this.lblValue1.Font = new System.Drawing.Font("Arial", 11F);
            this.lblValue1.ForeColor = System.Drawing.Color.White;
            this.lblValue1.Location = new System.Drawing.Point(10, 277);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(36, 17);
            this.lblValue1.TabIndex = 0;
            this.lblValue1.Text = "0.00";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle1.Font = new System.Drawing.Font("Arial", 16.25F);
            this.lblTitle1.ForeColor = System.Drawing.Color.White;
            this.lblTitle1.Location = new System.Drawing.Point(8, 252);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(49, 25);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "N/A";
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.BackColor = System.Drawing.Color.Transparent;
            this.lblValue2.Font = new System.Drawing.Font("Arial", 11F);
            this.lblValue2.ForeColor = System.Drawing.Color.White;
            this.lblValue2.Location = new System.Drawing.Point(10, 326);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(36, 17);
            this.lblValue2.TabIndex = 0;
            this.lblValue2.Text = "0.00";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Arial", 16.25F);
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(8, 301);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(49, 25);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "N/A";
            // 
            // lblValue3
            // 
            this.lblValue3.AutoSize = true;
            this.lblValue3.BackColor = System.Drawing.Color.Transparent;
            this.lblValue3.Font = new System.Drawing.Font("Arial", 11F);
            this.lblValue3.ForeColor = System.Drawing.Color.White;
            this.lblValue3.Location = new System.Drawing.Point(10, 375);
            this.lblValue3.Name = "lblValue3";
            this.lblValue3.Size = new System.Drawing.Size(36, 17);
            this.lblValue3.TabIndex = 0;
            this.lblValue3.Text = "0.00";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle3.Font = new System.Drawing.Font("Arial", 16.25F);
            this.lblTitle3.ForeColor = System.Drawing.Color.White;
            this.lblTitle3.Location = new System.Drawing.Point(8, 350);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(49, 25);
            this.lblTitle3.TabIndex = 0;
            this.lblTitle3.Text = "N/A";
            // 
            // lblValue4
            // 
            this.lblValue4.AutoSize = true;
            this.lblValue4.BackColor = System.Drawing.Color.Transparent;
            this.lblValue4.Font = new System.Drawing.Font("Arial", 11F);
            this.lblValue4.ForeColor = System.Drawing.Color.White;
            this.lblValue4.Location = new System.Drawing.Point(10, 424);
            this.lblValue4.Name = "lblValue4";
            this.lblValue4.Size = new System.Drawing.Size(36, 17);
            this.lblValue4.TabIndex = 0;
            this.lblValue4.Text = "0.00";
            // 
            // lblTitle4
            // 
            this.lblTitle4.AutoSize = true;
            this.lblTitle4.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle4.Font = new System.Drawing.Font("Arial", 16.25F);
            this.lblTitle4.ForeColor = System.Drawing.Color.White;
            this.lblTitle4.Location = new System.Drawing.Point(8, 399);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(49, 25);
            this.lblTitle4.TabIndex = 0;
            this.lblTitle4.Text = "N/A";
            // 
            // lblSellValue
            // 
            this.lblSellValue.AutoSize = true;
            this.lblSellValue.BackColor = System.Drawing.Color.Transparent;
            this.lblSellValue.Font = new System.Drawing.Font("Arial", 11F);
            this.lblSellValue.ForeColor = System.Drawing.Color.White;
            this.lblSellValue.Location = new System.Drawing.Point(10, 521);
            this.lblSellValue.Name = "lblSellValue";
            this.lblSellValue.Size = new System.Drawing.Size(36, 17);
            this.lblSellValue.TabIndex = 0;
            this.lblSellValue.Text = "0.00";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F);
            this.btnExit.Location = new System.Drawing.Point(295, 84);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtID.Font = new System.Drawing.Font("Arial", 10.25F);
            this.txtID.Location = new System.Drawing.Point(194, 117);
            this.txtID.MaxLength = 32;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(201, 23);
            this.txtID.TabIndex = 3;
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(153, 118);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 22);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblNickname
            // 
            this.lblNickname.BackColor = System.Drawing.Color.Transparent;
            this.lblNickname.Font = new System.Drawing.Font("Arial", 18.25F);
            this.lblNickname.ForeColor = System.Drawing.Color.White;
            this.lblNickname.Location = new System.Drawing.Point(152, 13);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(248, 28);
            this.lblNickname.TabIndex = 4;
            this.lblNickname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prgLoading
            // 
            this.prgLoading.Enabled = false;
            this.prgLoading.Location = new System.Drawing.Point(12, 543);
            this.prgLoading.Name = "prgLoading";
            this.prgLoading.Size = new System.Drawing.Size(388, 23);
            this.prgLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgLoading.TabIndex = 5;
            this.prgLoading.Visible = false;
            // 
            // marqueeTimer
            // 
            this.marqueeTimer.Tick += new System.EventHandler(this.marqueeTimer_Tick);
            // 
            // lblValue5
            // 
            this.lblValue5.AutoSize = true;
            this.lblValue5.BackColor = System.Drawing.Color.Transparent;
            this.lblValue5.Font = new System.Drawing.Font("Arial", 11F);
            this.lblValue5.ForeColor = System.Drawing.Color.White;
            this.lblValue5.Location = new System.Drawing.Point(10, 473);
            this.lblValue5.Name = "lblValue5";
            this.lblValue5.Size = new System.Drawing.Size(36, 17);
            this.lblValue5.TabIndex = 0;
            this.lblValue5.Text = "0.00";
            // 
            // lblTitle5
            // 
            this.lblTitle5.AutoSize = true;
            this.lblTitle5.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle5.Font = new System.Drawing.Font("Arial", 16.25F);
            this.lblTitle5.ForeColor = System.Drawing.Color.White;
            this.lblTitle5.Location = new System.Drawing.Point(8, 448);
            this.lblTitle5.Name = "lblTitle5";
            this.lblTitle5.Size = new System.Drawing.Size(49, 25);
            this.lblTitle5.TabIndex = 0;
            this.lblTitle5.Text = "N/A";
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImage = global::Inventory_Calculator.Properties.Resources.InfoIcon;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.Location = new System.Drawing.Point(263, 86);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(25, 25);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_Calculator.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(412, 576);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.prgLoading);
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.pbProfilePicture);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetProfile);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblSellValue);
            this.Controls.Add(this.lbPossibleRevenue);
            this.Controls.Add(this.lblTitle5);
            this.Controls.Add(this.lblTitle4);
            this.Controls.Add(this.lblTitle3);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblValue5);
            this.Controls.Add(this.lblInTotal);
            this.Controls.Add(this.lblValue4);
            this.Controls.Add(this.lblValue3);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.lblValue1);
            this.Controls.Add(this.lblItemsValue);
            this.Controls.Add(this.lblInventoryValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CS:GO Inventory Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventoryValue;
        private System.Windows.Forms.Button btnGetProfile;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Label lbPossibleRevenue;
        private System.Windows.Forms.Label lblInTotal;
        private System.Windows.Forms.Label lblItemsValue;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblValue3;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lblValue4;
        private System.Windows.Forms.Label lblTitle4;
        private System.Windows.Forms.Label lblSellValue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.ProgressBar prgLoading;
        private System.Windows.Forms.Timer marqueeTimer;
        private System.Windows.Forms.Label lblValue5;
        private System.Windows.Forms.Label lblTitle5;
        private System.Windows.Forms.Button btnInfo;
    }
}


namespace GroupProject1
{
    partial class FRMVendor
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
            this.BTNReadNextDataRecord = new System.Windows.Forms.Button();
            this.BTNReadPreviousDataRecord = new System.Windows.Forms.Button();
            this.BTNSaveDataRecord = new System.Windows.Forms.Button();
            this.BTNClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTVendorName = new System.Windows.Forms.TextBox();
            this.TXTAddress = new System.Windows.Forms.TextBox();
            this.TXTCity = new System.Windows.Forms.TextBox();
            this.TXTState = new System.Windows.Forms.TextBox();
            this.TXTZipcode = new System.Windows.Forms.TextBox();
            this.TXTPhoneNumber = new System.Windows.Forms.TextBox();
            this.TXTSalesYearToDate = new System.Windows.Forms.TextBox();
            this.TXTSalesRepName = new System.Windows.Forms.TextBox();
            this.TXTComments = new System.Windows.Forms.TextBox();
            this.GBXVendorInformation = new System.Windows.Forms.GroupBox();
            this.CBODefaultDiscount = new System.Windows.Forms.ComboBox();
            this.GBXVendorInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNReadNextDataRecord
            // 
            this.BTNReadNextDataRecord.Location = new System.Drawing.Point(610, 31);
            this.BTNReadNextDataRecord.Name = "BTNReadNextDataRecord";
            this.BTNReadNextDataRecord.Size = new System.Drawing.Size(186, 31);
            this.BTNReadNextDataRecord.TabIndex = 1;
            this.BTNReadNextDataRecord.Text = "Read Next Data Record";
            this.BTNReadNextDataRecord.UseVisualStyleBackColor = true;
            this.BTNReadNextDataRecord.Click += new System.EventHandler(this.BTNReadNextDataRecord_Click);
            // 
            // BTNReadPreviousDataRecord
            // 
            this.BTNReadPreviousDataRecord.Location = new System.Drawing.Point(610, 85);
            this.BTNReadPreviousDataRecord.Name = "BTNReadPreviousDataRecord";
            this.BTNReadPreviousDataRecord.Size = new System.Drawing.Size(186, 34);
            this.BTNReadPreviousDataRecord.TabIndex = 2;
            this.BTNReadPreviousDataRecord.Text = "Read Previous Data Record";
            this.BTNReadPreviousDataRecord.UseVisualStyleBackColor = true;
            this.BTNReadPreviousDataRecord.Click += new System.EventHandler(this.BTNReadPreviousDataRecord_Click);
            // 
            // BTNSaveDataRecord
            // 
            this.BTNSaveDataRecord.Location = new System.Drawing.Point(610, 134);
            this.BTNSaveDataRecord.Name = "BTNSaveDataRecord";
            this.BTNSaveDataRecord.Size = new System.Drawing.Size(186, 36);
            this.BTNSaveDataRecord.TabIndex = 3;
            this.BTNSaveDataRecord.Text = "Save Data Record";
            this.BTNSaveDataRecord.UseVisualStyleBackColor = true;
            this.BTNSaveDataRecord.Click += new System.EventHandler(this.BTNSaveDataRecord_Click);
            // 
            // BTNClose
            // 
            this.BTNClose.Location = new System.Drawing.Point(610, 187);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(186, 32);
            this.BTNClose.TabIndex = 4;
            this.BTNClose.Text = "Close";
            this.BTNClose.UseVisualStyleBackColor = true;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vendor Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Zipcode:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sales Year to Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sales Representative Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Comments:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(129, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Default Discount:";
            // 
            // TXTVendorName
            // 
            this.TXTVendorName.Location = new System.Drawing.Point(257, 43);
            this.TXTVendorName.Name = "TXTVendorName";
            this.TXTVendorName.Size = new System.Drawing.Size(211, 22);
            this.TXTVendorName.TabIndex = 15;
            this.TXTVendorName.Tag = "Vendor Name";
            // 
            // TXTAddress
            // 
            this.TXTAddress.Location = new System.Drawing.Point(257, 72);
            this.TXTAddress.Name = "TXTAddress";
            this.TXTAddress.Size = new System.Drawing.Size(211, 22);
            this.TXTAddress.TabIndex = 16;
            this.TXTAddress.Tag = "Vendor Address";
            // 
            // TXTCity
            // 
            this.TXTCity.Location = new System.Drawing.Point(257, 110);
            this.TXTCity.Name = "TXTCity";
            this.TXTCity.Size = new System.Drawing.Size(211, 22);
            this.TXTCity.TabIndex = 17;
            this.TXTCity.Tag = "Vendor City";
            // 
            // TXTState
            // 
            this.TXTState.Location = new System.Drawing.Point(257, 144);
            this.TXTState.Name = "TXTState";
            this.TXTState.Size = new System.Drawing.Size(211, 22);
            this.TXTState.TabIndex = 18;
            this.TXTState.Tag = "Vendor State";
            // 
            // TXTZipcode
            // 
            this.TXTZipcode.Location = new System.Drawing.Point(257, 178);
            this.TXTZipcode.Name = "TXTZipcode";
            this.TXTZipcode.Size = new System.Drawing.Size(211, 22);
            this.TXTZipcode.TabIndex = 19;
            this.TXTZipcode.Tag = "Vendor Zip Code";
            // 
            // TXTPhoneNumber
            // 
            this.TXTPhoneNumber.Location = new System.Drawing.Point(257, 214);
            this.TXTPhoneNumber.Name = "TXTPhoneNumber";
            this.TXTPhoneNumber.Size = new System.Drawing.Size(211, 22);
            this.TXTPhoneNumber.TabIndex = 20;
            this.TXTPhoneNumber.Tag = "Vendor Phone Number";
            // 
            // TXTSalesYearToDate
            // 
            this.TXTSalesYearToDate.Location = new System.Drawing.Point(257, 251);
            this.TXTSalesYearToDate.Name = "TXTSalesYearToDate";
            this.TXTSalesYearToDate.Size = new System.Drawing.Size(211, 22);
            this.TXTSalesYearToDate.TabIndex = 21;
            this.TXTSalesYearToDate.Tag = "Vendor Sales Year To Date";
            // 
            // TXTSalesRepName
            // 
            this.TXTSalesRepName.Location = new System.Drawing.Point(257, 294);
            this.TXTSalesRepName.Name = "TXTSalesRepName";
            this.TXTSalesRepName.Size = new System.Drawing.Size(211, 22);
            this.TXTSalesRepName.TabIndex = 22;
            this.TXTSalesRepName.Tag = "Vendor Sales Representative Name";
            // 
            // TXTComments
            // 
            this.TXTComments.Location = new System.Drawing.Point(257, 338);
            this.TXTComments.Name = "TXTComments";
            this.TXTComments.Size = new System.Drawing.Size(211, 22);
            this.TXTComments.TabIndex = 23;
            // 
            // GBXVendorInformation
            // 
            this.GBXVendorInformation.Controls.Add(this.CBODefaultDiscount);
            this.GBXVendorInformation.Controls.Add(this.TXTVendorName);
            this.GBXVendorInformation.Controls.Add(this.label1);
            this.GBXVendorInformation.Controls.Add(this.TXTComments);
            this.GBXVendorInformation.Controls.Add(this.label2);
            this.GBXVendorInformation.Controls.Add(this.TXTSalesRepName);
            this.GBXVendorInformation.Controls.Add(this.label3);
            this.GBXVendorInformation.Controls.Add(this.TXTSalesYearToDate);
            this.GBXVendorInformation.Controls.Add(this.label4);
            this.GBXVendorInformation.Controls.Add(this.TXTPhoneNumber);
            this.GBXVendorInformation.Controls.Add(this.label5);
            this.GBXVendorInformation.Controls.Add(this.TXTZipcode);
            this.GBXVendorInformation.Controls.Add(this.label6);
            this.GBXVendorInformation.Controls.Add(this.TXTState);
            this.GBXVendorInformation.Controls.Add(this.label7);
            this.GBXVendorInformation.Controls.Add(this.TXTCity);
            this.GBXVendorInformation.Controls.Add(this.label8);
            this.GBXVendorInformation.Controls.Add(this.TXTAddress);
            this.GBXVendorInformation.Controls.Add(this.label9);
            this.GBXVendorInformation.Controls.Add(this.label10);
            this.GBXVendorInformation.Location = new System.Drawing.Point(41, 31);
            this.GBXVendorInformation.Name = "GBXVendorInformation";
            this.GBXVendorInformation.Size = new System.Drawing.Size(510, 441);
            this.GBXVendorInformation.TabIndex = 25;
            this.GBXVendorInformation.TabStop = false;
            this.GBXVendorInformation.Tag = "";
            this.GBXVendorInformation.Text = "Vendor Information";
            // 
            // CBODefaultDiscount
            // 
            this.CBODefaultDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBODefaultDiscount.FormattingEnabled = true;
            this.CBODefaultDiscount.Location = new System.Drawing.Point(257, 384);
            this.CBODefaultDiscount.Name = "CBODefaultDiscount";
            this.CBODefaultDiscount.Size = new System.Drawing.Size(83, 24);
            this.CBODefaultDiscount.TabIndex = 26;
            // 
            // FRMVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 579);
            this.Controls.Add(this.GBXVendorInformation);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.BTNSaveDataRecord);
            this.Controls.Add(this.BTNReadPreviousDataRecord);
            this.Controls.Add(this.BTNReadNextDataRecord);
            this.Name = "FRMVendor";
            this.Text = "Vendor Form";
            this.Load += new System.EventHandler(this.FRMVendor_Load);
            this.GBXVendorInformation.ResumeLayout(false);
            this.GBXVendorInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNReadNextDataRecord;
        private System.Windows.Forms.Button BTNReadPreviousDataRecord;
        private System.Windows.Forms.Button BTNSaveDataRecord;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXTVendorName;
        private System.Windows.Forms.TextBox TXTAddress;
        private System.Windows.Forms.TextBox TXTCity;
        private System.Windows.Forms.TextBox TXTState;
        private System.Windows.Forms.TextBox TXTZipcode;
        private System.Windows.Forms.TextBox TXTPhoneNumber;
        private System.Windows.Forms.TextBox TXTSalesYearToDate;
        private System.Windows.Forms.TextBox TXTSalesRepName;
        private System.Windows.Forms.TextBox TXTComments;
        private System.Windows.Forms.GroupBox GBXVendorInformation;
        private System.Windows.Forms.ComboBox CBODefaultDiscount;
    }
}
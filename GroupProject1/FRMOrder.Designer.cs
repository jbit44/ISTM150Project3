namespace GroupProject1
{
    partial class FRMOrder
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
            this.PBXFoodOrder = new System.Windows.Forms.PictureBox();
            this.CBOFoodType = new System.Windows.Forms.ComboBox();
            this.CBOBreadOrCrustType = new System.Windows.Forms.ComboBox();
            this.TXTQuantity = new System.Windows.Forms.TextBox();
            this.TXTSubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNAddItemToOrder = new System.Windows.Forms.Button();
            this.LBXOrders = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTTotal = new System.Windows.Forms.TextBox();
            this.BTNClearForm = new System.Windows.Forms.Button();
            this.GBXCustomerInformation = new System.Windows.Forms.GroupBox();
            this.CBOBililngState = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXTBillingSubdivision = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TXTBillingZipCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TXTBillingCity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTBillingStreetAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTBillingPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTBillingName = new System.Windows.Forms.TextBox();
            this.GBXDeliveryInformation = new System.Windows.Forms.GroupBox();
            this.CBODeliveryState = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TXTDeliveryPhoneNumber = new System.Windows.Forms.TextBox();
            this.TXTDeliveryStreetAddress = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TXTDeliverySubdivision = new System.Windows.Forms.TextBox();
            this.TXTDeliveryName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TXTDeliveryCity = new System.Windows.Forms.TextBox();
            this.TXTDeliveryZipCode = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CHKDelivery = new System.Windows.Forms.CheckBox();
            this.BTNCancelOrder = new System.Windows.Forms.Button();
            this.BTNProcessOrder = new System.Windows.Forms.Button();
            this.BTNViewInventory = new System.Windows.Forms.Button();
            this.BTNOpenVendorForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBXFoodOrder)).BeginInit();
            this.GBXCustomerInformation.SuspendLayout();
            this.GBXDeliveryInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBXFoodOrder
            // 
            this.PBXFoodOrder.Image = global::GroupProject1.Properties.Resources.Sandwhich;
            this.PBXFoodOrder.InitialImage = null;
            this.PBXFoodOrder.Location = new System.Drawing.Point(74, 10);
            this.PBXFoodOrder.Margin = new System.Windows.Forms.Padding(1);
            this.PBXFoodOrder.Name = "PBXFoodOrder";
            this.PBXFoodOrder.Size = new System.Drawing.Size(311, 148);
            this.PBXFoodOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBXFoodOrder.TabIndex = 0;
            this.PBXFoodOrder.TabStop = false;
            // 
            // CBOFoodType
            // 
            this.CBOFoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOFoodType.FormattingEnabled = true;
            this.CBOFoodType.Location = new System.Drawing.Point(164, 167);
            this.CBOFoodType.Margin = new System.Windows.Forms.Padding(4);
            this.CBOFoodType.Name = "CBOFoodType";
            this.CBOFoodType.Size = new System.Drawing.Size(224, 24);
            this.CBOFoodType.TabIndex = 0;
            this.CBOFoodType.SelectedIndexChanged += new System.EventHandler(this.CBOFoodType_SelectedIndexChanged);
            // 
            // CBOBreadOrCrustType
            // 
            this.CBOBreadOrCrustType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOBreadOrCrustType.FormattingEnabled = true;
            this.CBOBreadOrCrustType.Location = new System.Drawing.Point(165, 200);
            this.CBOBreadOrCrustType.Margin = new System.Windows.Forms.Padding(4);
            this.CBOBreadOrCrustType.Name = "CBOBreadOrCrustType";
            this.CBOBreadOrCrustType.Size = new System.Drawing.Size(223, 24);
            this.CBOBreadOrCrustType.TabIndex = 1;
            this.CBOBreadOrCrustType.SelectedIndexChanged += new System.EventHandler(this.CalculateSubtotal);
            // 
            // TXTQuantity
            // 
            this.TXTQuantity.Location = new System.Drawing.Point(165, 233);
            this.TXTQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.TXTQuantity.Name = "TXTQuantity";
            this.TXTQuantity.Size = new System.Drawing.Size(151, 22);
            this.TXTQuantity.TabIndex = 2;
            this.TXTQuantity.TextChanged += new System.EventHandler(this.CalculateSubtotal);
            // 
            // TXTSubtotal
            // 
            this.TXTSubtotal.Location = new System.Drawing.Point(165, 265);
            this.TXTSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.TXTSubtotal.Name = "TXTSubtotal";
            this.TXTSubtotal.ReadOnly = true;
            this.TXTSubtotal.Size = new System.Drawing.Size(151, 22);
            this.TXTSubtotal.TabIndex = 3;
            this.TXTSubtotal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Food Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bread/Crust Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subtotal:";
            // 
            // BTNAddItemToOrder
            // 
            this.BTNAddItemToOrder.Location = new System.Drawing.Point(139, 296);
            this.BTNAddItemToOrder.Margin = new System.Windows.Forms.Padding(4);
            this.BTNAddItemToOrder.Name = "BTNAddItemToOrder";
            this.BTNAddItemToOrder.Size = new System.Drawing.Size(153, 28);
            this.BTNAddItemToOrder.TabIndex = 4;
            this.BTNAddItemToOrder.Text = "Add Item to Order";
            this.BTNAddItemToOrder.UseVisualStyleBackColor = true;
            this.BTNAddItemToOrder.Click += new System.EventHandler(this.BTNAddItemToOrder_Click);
            // 
            // LBXOrders
            // 
            this.LBXOrders.FormattingEnabled = true;
            this.LBXOrders.ItemHeight = 16;
            this.LBXOrders.Location = new System.Drawing.Point(453, 20);
            this.LBXOrders.Margin = new System.Windows.Forms.Padding(4);
            this.LBXOrders.Name = "LBXOrders";
            this.LBXOrders.Size = new System.Drawing.Size(500, 276);
            this.LBXOrders.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total:";
            // 
            // TXTTotal
            // 
            this.TXTTotal.Location = new System.Drawing.Point(604, 297);
            this.TXTTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TXTTotal.Name = "TXTTotal";
            this.TXTTotal.ReadOnly = true;
            this.TXTTotal.Size = new System.Drawing.Size(132, 22);
            this.TXTTotal.TabIndex = 11;
            this.TXTTotal.TabStop = false;
            // 
            // BTNClearForm
            // 
            this.BTNClearForm.Location = new System.Drawing.Point(650, 636);
            this.BTNClearForm.Margin = new System.Windows.Forms.Padding(4);
            this.BTNClearForm.Name = "BTNClearForm";
            this.BTNClearForm.Size = new System.Drawing.Size(100, 28);
            this.BTNClearForm.TabIndex = 13;
            this.BTNClearForm.TabStop = false;
            this.BTNClearForm.Text = "Clear Form";
            this.BTNClearForm.UseVisualStyleBackColor = true;
            this.BTNClearForm.Click += new System.EventHandler(this.BTNClearForm_Click);
            // 
            // GBXCustomerInformation
            // 
            this.GBXCustomerInformation.Controls.Add(this.CBOBililngState);
            this.GBXCustomerInformation.Controls.Add(this.label12);
            this.GBXCustomerInformation.Controls.Add(this.TXTBillingSubdivision);
            this.GBXCustomerInformation.Controls.Add(this.label13);
            this.GBXCustomerInformation.Controls.Add(this.TXTBillingZipCode);
            this.GBXCustomerInformation.Controls.Add(this.label10);
            this.GBXCustomerInformation.Controls.Add(this.label11);
            this.GBXCustomerInformation.Controls.Add(this.TXTBillingCity);
            this.GBXCustomerInformation.Controls.Add(this.label9);
            this.GBXCustomerInformation.Controls.Add(this.label8);
            this.GBXCustomerInformation.Controls.Add(this.TXTBillingStreetAddress);
            this.GBXCustomerInformation.Controls.Add(this.label7);
            this.GBXCustomerInformation.Controls.Add(this.TXTBillingPhoneNumber);
            this.GBXCustomerInformation.Controls.Add(this.label6);
            this.GBXCustomerInformation.Controls.Add(this.TXTBillingName);
            this.GBXCustomerInformation.Location = new System.Drawing.Point(16, 347);
            this.GBXCustomerInformation.Margin = new System.Windows.Forms.Padding(4);
            this.GBXCustomerInformation.Name = "GBXCustomerInformation";
            this.GBXCustomerInformation.Padding = new System.Windows.Forms.Padding(4);
            this.GBXCustomerInformation.Size = new System.Drawing.Size(432, 276);
            this.GBXCustomerInformation.TabIndex = 5;
            this.GBXCustomerInformation.TabStop = false;
            this.GBXCustomerInformation.Text = "Customer Information";
            // 
            // CBOBililngState
            // 
            this.CBOBililngState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOBililngState.FormattingEnabled = true;
            this.CBOBililngState.Location = new System.Drawing.Point(132, 172);
            this.CBOBililngState.Margin = new System.Windows.Forms.Padding(4);
            this.CBOBililngState.Name = "CBOBililngState";
            this.CBOBililngState.Size = new System.Drawing.Size(168, 24);
            this.CBOBililngState.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 240);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Subdivision:";
            // 
            // TXTBillingSubdivision
            // 
            this.TXTBillingSubdivision.Location = new System.Drawing.Point(133, 236);
            this.TXTBillingSubdivision.Margin = new System.Windows.Forms.Padding(4);
            this.TXTBillingSubdivision.Name = "TXTBillingSubdivision";
            this.TXTBillingSubdivision.Size = new System.Drawing.Size(264, 22);
            this.TXTBillingSubdivision.TabIndex = 6;
            this.TXTBillingSubdivision.Tag = "Billing Subdivision";
            this.TXTBillingSubdivision.Text = "The Quad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 208);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Zip Code:";
            // 
            // TXTBillingZipCode
            // 
            this.TXTBillingZipCode.Location = new System.Drawing.Point(133, 204);
            this.TXTBillingZipCode.Margin = new System.Windows.Forms.Padding(4);
            this.TXTBillingZipCode.Name = "TXTBillingZipCode";
            this.TXTBillingZipCode.Size = new System.Drawing.Size(167, 22);
            this.TXTBillingZipCode.TabIndex = 5;
            this.TXTBillingZipCode.Tag = "Billing Zip Code";
            this.TXTBillingZipCode.Text = "77840";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "State:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 144);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "City:";
            // 
            // TXTBillingCity
            // 
            this.TXTBillingCity.Location = new System.Drawing.Point(132, 140);
            this.TXTBillingCity.Margin = new System.Windows.Forms.Padding(4);
            this.TXTBillingCity.Name = "TXTBillingCity";
            this.TXTBillingCity.Size = new System.Drawing.Size(168, 22);
            this.TXTBillingCity.TabIndex = 3;
            this.TXTBillingCity.Tag = "Billing City";
            this.TXTBillingCity.Text = "College Station";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Billing Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Street Address:";
            // 
            // TXTBillingStreetAddress
            // 
            this.TXTBillingStreetAddress.Location = new System.Drawing.Point(132, 108);
            this.TXTBillingStreetAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TXTBillingStreetAddress.Name = "TXTBillingStreetAddress";
            this.TXTBillingStreetAddress.Size = new System.Drawing.Size(265, 22);
            this.TXTBillingStreetAddress.TabIndex = 2;
            this.TXTBillingStreetAddress.Tag = "Billing Street Address";
            this.TXTBillingStreetAddress.Text = "1227 Coke St";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Phone Number:";
            // 
            // TXTBillingPhoneNumber
            // 
            this.TXTBillingPhoneNumber.Location = new System.Drawing.Point(133, 55);
            this.TXTBillingPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TXTBillingPhoneNumber.Name = "TXTBillingPhoneNumber";
            this.TXTBillingPhoneNumber.Size = new System.Drawing.Size(223, 22);
            this.TXTBillingPhoneNumber.TabIndex = 1;
            this.TXTBillingPhoneNumber.Tag = "Customer Phone Number";
            this.TXTBillingPhoneNumber.Text = "(979)-845-6789";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Name:";
            // 
            // TXTBillingName
            // 
            this.TXTBillingName.Location = new System.Drawing.Point(133, 23);
            this.TXTBillingName.Margin = new System.Windows.Forms.Padding(4);
            this.TXTBillingName.Name = "TXTBillingName";
            this.TXTBillingName.Size = new System.Drawing.Size(264, 22);
            this.TXTBillingName.TabIndex = 0;
            this.TXTBillingName.Tag = "Customer Name";
            this.TXTBillingName.Text = "Reveille";
            // 
            // GBXDeliveryInformation
            // 
            this.GBXDeliveryInformation.Controls.Add(this.CBODeliveryState);
            this.GBXDeliveryInformation.Controls.Add(this.label21);
            this.GBXDeliveryInformation.Controls.Add(this.label19);
            this.GBXDeliveryInformation.Controls.Add(this.label14);
            this.GBXDeliveryInformation.Controls.Add(this.TXTDeliveryPhoneNumber);
            this.GBXDeliveryInformation.Controls.Add(this.TXTDeliveryStreetAddress);
            this.GBXDeliveryInformation.Controls.Add(this.label20);
            this.GBXDeliveryInformation.Controls.Add(this.TXTDeliverySubdivision);
            this.GBXDeliveryInformation.Controls.Add(this.TXTDeliveryName);
            this.GBXDeliveryInformation.Controls.Add(this.label18);
            this.GBXDeliveryInformation.Controls.Add(this.label15);
            this.GBXDeliveryInformation.Controls.Add(this.TXTDeliveryCity);
            this.GBXDeliveryInformation.Controls.Add(this.TXTDeliveryZipCode);
            this.GBXDeliveryInformation.Controls.Add(this.label17);
            this.GBXDeliveryInformation.Controls.Add(this.label16);
            this.GBXDeliveryInformation.Location = new System.Drawing.Point(453, 347);
            this.GBXDeliveryInformation.Margin = new System.Windows.Forms.Padding(4);
            this.GBXDeliveryInformation.Name = "GBXDeliveryInformation";
            this.GBXDeliveryInformation.Padding = new System.Windows.Forms.Padding(4);
            this.GBXDeliveryInformation.Size = new System.Drawing.Size(501, 276);
            this.GBXDeliveryInformation.TabIndex = 15;
            this.GBXDeliveryInformation.TabStop = false;
            this.GBXDeliveryInformation.Text = "Delivery Information";
            // 
            // CBODeliveryState
            // 
            this.CBODeliveryState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBODeliveryState.FormattingEnabled = true;
            this.CBODeliveryState.Location = new System.Drawing.Point(135, 172);
            this.CBODeliveryState.Margin = new System.Windows.Forms.Padding(4);
            this.CBODeliveryState.Name = "CBODeliveryState";
            this.CBODeliveryState.Size = new System.Drawing.Size(168, 24);
            this.CBODeliveryState.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(169, 89);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 16);
            this.label21.TabIndex = 31;
            this.label21.Text = "Delivery Address";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 59);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 16);
            this.label19.TabIndex = 34;
            this.label19.Text = "Phone Number:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 240);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "Subdivision:";
            // 
            // TXTDeliveryPhoneNumber
            // 
            this.TXTDeliveryPhoneNumber.Location = new System.Drawing.Point(133, 55);
            this.TXTDeliveryPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TXTDeliveryPhoneNumber.Name = "TXTDeliveryPhoneNumber";
            this.TXTDeliveryPhoneNumber.Size = new System.Drawing.Size(223, 22);
            this.TXTDeliveryPhoneNumber.TabIndex = 13;
            this.TXTDeliveryPhoneNumber.Tag = "Delivery Phone Number";
            // 
            // TXTDeliveryStreetAddress
            // 
            this.TXTDeliveryStreetAddress.Location = new System.Drawing.Point(133, 108);
            this.TXTDeliveryStreetAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TXTDeliveryStreetAddress.Name = "TXTDeliveryStreetAddress";
            this.TXTDeliveryStreetAddress.Size = new System.Drawing.Size(295, 22);
            this.TXTDeliveryStreetAddress.TabIndex = 14;
            this.TXTDeliveryStreetAddress.Tag = "Delivery Street Address";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(73, 27);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 16);
            this.label20.TabIndex = 33;
            this.label20.Text = "Name:";
            // 
            // TXTDeliverySubdivision
            // 
            this.TXTDeliverySubdivision.Location = new System.Drawing.Point(135, 236);
            this.TXTDeliverySubdivision.Margin = new System.Windows.Forms.Padding(4);
            this.TXTDeliverySubdivision.Name = "TXTDeliverySubdivision";
            this.TXTDeliverySubdivision.Size = new System.Drawing.Size(293, 22);
            this.TXTDeliverySubdivision.TabIndex = 18;
            this.TXTDeliverySubdivision.Tag = "Delivery Subdivision";
            // 
            // TXTDeliveryName
            // 
            this.TXTDeliveryName.Location = new System.Drawing.Point(133, 23);
            this.TXTDeliveryName.Margin = new System.Windows.Forms.Padding(4);
            this.TXTDeliveryName.Name = "TXTDeliveryName";
            this.TXTDeliveryName.Size = new System.Drawing.Size(300, 22);
            this.TXTDeliveryName.TabIndex = 12;
            this.TXTDeliveryName.Tag = "Delivery Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 112);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 16);
            this.label18.TabIndex = 32;
            this.label18.Text = "Street Address:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 208);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 16);
            this.label15.TabIndex = 38;
            this.label15.Text = "Zip Code:";
            // 
            // TXTDeliveryCity
            // 
            this.TXTDeliveryCity.Location = new System.Drawing.Point(133, 140);
            this.TXTDeliveryCity.Margin = new System.Windows.Forms.Padding(4);
            this.TXTDeliveryCity.Name = "TXTDeliveryCity";
            this.TXTDeliveryCity.Size = new System.Drawing.Size(170, 22);
            this.TXTDeliveryCity.TabIndex = 15;
            this.TXTDeliveryCity.Tag = "Delivery City";
            // 
            // TXTDeliveryZipCode
            // 
            this.TXTDeliveryZipCode.Location = new System.Drawing.Point(135, 204);
            this.TXTDeliveryZipCode.Margin = new System.Windows.Forms.Padding(4);
            this.TXTDeliveryZipCode.Name = "TXTDeliveryZipCode";
            this.TXTDeliveryZipCode.Size = new System.Drawing.Size(167, 22);
            this.TXTDeliveryZipCode.TabIndex = 17;
            this.TXTDeliveryZipCode.Tag = "Delivery Zip Code";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(89, 144);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 16);
            this.label17.TabIndex = 34;
            this.label17.Text = "City:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(79, 176);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 16);
            this.label16.TabIndex = 36;
            this.label16.Text = "State:";
            // 
            // CHKDelivery
            // 
            this.CHKDelivery.AutoSize = true;
            this.CHKDelivery.Location = new System.Drawing.Point(16, 641);
            this.CHKDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.CHKDelivery.Name = "CHKDelivery";
            this.CHKDelivery.Size = new System.Drawing.Size(349, 20);
            this.CHKDelivery.TabIndex = 11;
            this.CHKDelivery.Text = "Delivery (we only deliver to Bryan/College Station, TX)";
            this.CHKDelivery.UseVisualStyleBackColor = true;
            this.CHKDelivery.CheckedChanged += new System.EventHandler(this.CHKDelivery_CheckedChanged);
            // 
            // BTNCancelOrder
            // 
            this.BTNCancelOrder.Location = new System.Drawing.Point(758, 636);
            this.BTNCancelOrder.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCancelOrder.Name = "BTNCancelOrder";
            this.BTNCancelOrder.Size = new System.Drawing.Size(100, 28);
            this.BTNCancelOrder.TabIndex = 17;
            this.BTNCancelOrder.TabStop = false;
            this.BTNCancelOrder.Text = "Cancel Order";
            this.BTNCancelOrder.UseVisualStyleBackColor = true;
            this.BTNCancelOrder.Click += new System.EventHandler(this.BTNCancelOrder_Click);
            // 
            // BTNProcessOrder
            // 
            this.BTNProcessOrder.Location = new System.Drawing.Point(866, 636);
            this.BTNProcessOrder.Margin = new System.Windows.Forms.Padding(4);
            this.BTNProcessOrder.Name = "BTNProcessOrder";
            this.BTNProcessOrder.Size = new System.Drawing.Size(103, 28);
            this.BTNProcessOrder.TabIndex = 19;
            this.BTNProcessOrder.Text = "Process Order";
            this.BTNProcessOrder.UseVisualStyleBackColor = true;
            this.BTNProcessOrder.Click += new System.EventHandler(this.BTNProcessOrder_Click);
            // 
            // BTNViewInventory
            // 
            this.BTNViewInventory.Location = new System.Drawing.Point(529, 636);
            this.BTNViewInventory.Margin = new System.Windows.Forms.Padding(4);
            this.BTNViewInventory.Name = "BTNViewInventory";
            this.BTNViewInventory.Size = new System.Drawing.Size(114, 28);
            this.BTNViewInventory.TabIndex = 20;
            this.BTNViewInventory.Text = "View Inventory";
            this.BTNViewInventory.UseVisualStyleBackColor = true;
            this.BTNViewInventory.Click += new System.EventHandler(this.BTNViewInventory_Click_1);
            // 
            // BTNOpenVendorForm
            // 
            this.BTNOpenVendorForm.Location = new System.Drawing.Point(372, 636);
            this.BTNOpenVendorForm.Name = "BTNOpenVendorForm";
            this.BTNOpenVendorForm.Size = new System.Drawing.Size(150, 28);
            this.BTNOpenVendorForm.TabIndex = 21;
            this.BTNOpenVendorForm.Text = "Open Vendor Form";
            this.BTNOpenVendorForm.UseVisualStyleBackColor = true;
            this.BTNOpenVendorForm.Click += new System.EventHandler(this.BTNOpenVendorForm_Click);
            // 
            // FRMOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 674);
            this.Controls.Add(this.BTNOpenVendorForm);
            this.Controls.Add(this.BTNViewInventory);
            this.Controls.Add(this.BTNProcessOrder);
            this.Controls.Add(this.BTNCancelOrder);
            this.Controls.Add(this.CHKDelivery);
            this.Controls.Add(this.GBXDeliveryInformation);
            this.Controls.Add(this.GBXCustomerInformation);
            this.Controls.Add(this.BTNClearForm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTTotal);
            this.Controls.Add(this.LBXOrders);
            this.Controls.Add(this.BTNAddItemToOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTSubtotal);
            this.Controls.Add(this.TXTQuantity);
            this.Controls.Add(this.CBOBreadOrCrustType);
            this.Controls.Add(this.CBOFoodType);
            this.Controls.Add(this.PBXFoodOrder);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(547, 100);
            this.Name = "FRMOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.FRMOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBXFoodOrder)).EndInit();
            this.GBXCustomerInformation.ResumeLayout(false);
            this.GBXCustomerInformation.PerformLayout();
            this.GBXDeliveryInformation.ResumeLayout(false);
            this.GBXDeliveryInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBXFoodOrder;
        private System.Windows.Forms.ComboBox CBOFoodType;
        private System.Windows.Forms.ComboBox CBOBreadOrCrustType;
        private System.Windows.Forms.TextBox TXTQuantity;
        private System.Windows.Forms.TextBox TXTSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNAddItemToOrder;
        private System.Windows.Forms.ListBox LBXOrders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTTotal;
        private System.Windows.Forms.Button BTNClearForm;
        private System.Windows.Forms.GroupBox GBXCustomerInformation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXTBillingSubdivision;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXTBillingZipCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXTBillingCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXTBillingStreetAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTBillingPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTBillingName;
        private System.Windows.Forms.GroupBox GBXDeliveryInformation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TXTDeliveryStreetAddress;
        private System.Windows.Forms.TextBox TXTDeliverySubdivision;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TXTDeliveryCity;
        private System.Windows.Forms.TextBox TXTDeliveryZipCode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox CHKDelivery;
        private System.Windows.Forms.Button BTNCancelOrder;
        private System.Windows.Forms.Button BTNProcessOrder;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TXTDeliveryPhoneNumber;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TXTDeliveryName;
        private System.Windows.Forms.ComboBox CBOBililngState;
        private System.Windows.Forms.ComboBox CBODeliveryState;
        private System.Windows.Forms.Button BTNViewInventory;
        private System.Windows.Forms.Button BTNOpenVendorForm;
    }
}


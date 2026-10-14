namespace Project_1_Rashik_Pathak
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            btnDisplayName = new Button();
            lblCustomerName = new Label();
            lblMenu = new Label();
            cboMenu = new ComboBox();
            lblQty = new Label();
            nudQuantity = new NumericUpDown();
            btnAddItem = new Button();
            grpSize = new GroupBox();
            rdoSmall = new RadioButton();
            rdoMedium = new RadioButton();
            rdoLarge = new RadioButton();
            grpExtras = new GroupBox();
            chkExtraShot = new CheckBox();
            chkWhippedCream = new CheckBox();
            chkOatMilk = new CheckBox();
            grpService = new GroupBox();
            rdoDineIn = new RadioButton();
            rdoDelivery = new RadioButton();
            rdoFreeDelivery = new RadioButton();
            lblPromo = new Label();
            txtPromo = new TextBox();
            lblOrder = new Label();
            lstOrder = new ListBox();
            btnRemoveItem = new Button();
            lblRunningTotal = new Label();
            lblHistory = new Label();
            lstHistory = new ListBox();
            btnSubmit = new Button();
            btnShowSales = new Button();
            btnAbout = new Button();
            cafe_Logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            grpSize.SuspendLayout();
            grpExtras.SuspendLayout();
            grpService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cafe_Logo).BeginInit();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(17, 25);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(97, 20);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(119, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(232, 25);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(311, 20);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(119, 27);
            txtLastName.TabIndex = 3;
            // 
            // btnDisplayName
            // 
            btnDisplayName.Location = new Point(446, 17);
            btnDisplayName.Margin = new Padding(3, 4, 3, 4);
            btnDisplayName.Name = "btnDisplayName";
            btnDisplayName.Size = new Size(120, 36);
            btnDisplayName.TabIndex = 4;
            btnDisplayName.Text = "Display name";
            btnDisplayName.UseVisualStyleBackColor = true;
            btnDisplayName.Click += btnDisplayName_Click;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerName.Location = new Point(589, 25);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(147, 20);
            lblCustomerName.TabIndex = 5;
            lblCustomerName.Text = "Customer: (not set)";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Location = new Point(17, 87);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(83, 20);
            lblMenu.TabIndex = 6;
            lblMenu.Text = "Menu item:";
            // 
            // cboMenu
            // 
            cboMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMenu.FormattingEnabled = true;
            cboMenu.Location = new Point(103, 81);
            cboMenu.Margin = new Padding(3, 4, 3, 4);
            cboMenu.Name = "cboMenu";
            cboMenu.Size = new Size(217, 28);
            cboMenu.Sorted = true;
            cboMenu.TabIndex = 7;
            cboMenu.KeyDown += cboMenu_KeyDown;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(337, 87);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(35, 20);
            lblQty.TabIndex = 8;
            lblQty.Text = "Qty:";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(375, 81);
            nudQuantity.Margin = new Padding(3, 4, 3, 4);
            nudQuantity.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(69, 27);
            nudQuantity.TabIndex = 9;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(17, 127);
            btnAddItem.Margin = new Padding(3, 4, 3, 4);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(426, 40);
            btnAddItem.TabIndex = 10;
            btnAddItem.Text = "Add to order";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // grpSize
            // 
            grpSize.Controls.Add(rdoSmall);
            grpSize.Controls.Add(rdoMedium);
            grpSize.Controls.Add(rdoLarge);
            grpSize.Location = new Point(17, 184);
            grpSize.Margin = new Padding(3, 4, 3, 4);
            grpSize.Name = "grpSize";
            grpSize.Padding = new Padding(3, 4, 3, 4);
            grpSize.Size = new Size(426, 73);
            grpSize.TabIndex = 11;
            grpSize.TabStop = false;
            grpSize.Text = "Size (drinks only: Medium +$0.50, Large +$1.00)";
            // 
            // rdoSmall
            // 
            rdoSmall.AutoSize = true;
            rdoSmall.Location = new Point(17, 32);
            rdoSmall.Margin = new Padding(3, 4, 3, 4);
            rdoSmall.Name = "rdoSmall";
            rdoSmall.Size = new Size(67, 24);
            rdoSmall.TabIndex = 0;
            rdoSmall.Text = "Small";
            rdoSmall.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            rdoMedium.AutoSize = true;
            rdoMedium.Checked = true;
            rdoMedium.Location = new Point(154, 32);
            rdoMedium.Margin = new Padding(3, 4, 3, 4);
            rdoMedium.Name = "rdoMedium";
            rdoMedium.Size = new Size(85, 24);
            rdoMedium.TabIndex = 1;
            rdoMedium.TabStop = true;
            rdoMedium.Text = "Medium";
            rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoLarge
            // 
            rdoLarge.AutoSize = true;
            rdoLarge.Location = new Point(291, 32);
            rdoLarge.Margin = new Padding(3, 4, 3, 4);
            rdoLarge.Name = "rdoLarge";
            rdoLarge.Size = new Size(67, 24);
            rdoLarge.TabIndex = 2;
            rdoLarge.Text = "Large";
            rdoLarge.UseVisualStyleBackColor = true;
            // 
            // grpExtras
            // 
            grpExtras.Controls.Add(chkExtraShot);
            grpExtras.Controls.Add(chkWhippedCream);
            grpExtras.Controls.Add(chkOatMilk);
            grpExtras.Location = new Point(17, 271);
            grpExtras.Margin = new Padding(3, 4, 3, 4);
            grpExtras.Name = "grpExtras";
            grpExtras.Padding = new Padding(3, 4, 3, 4);
            grpExtras.Size = new Size(426, 140);
            grpExtras.TabIndex = 12;
            grpExtras.TabStop = false;
            grpExtras.Text = "Extras";
            // 
            // chkExtraShot
            // 
            chkExtraShot.AutoSize = true;
            chkExtraShot.Location = new Point(17, 32);
            chkExtraShot.Margin = new Padding(3, 4, 3, 4);
            chkExtraShot.Name = "chkExtraShot";
            chkExtraShot.Size = new Size(155, 24);
            chkExtraShot.TabIndex = 0;
            chkExtraShot.Text = "Extra shot (+$0.75)";
            chkExtraShot.UseVisualStyleBackColor = true;
            // 
            // chkWhippedCream
            // 
            chkWhippedCream.AutoSize = true;
            chkWhippedCream.Location = new Point(17, 65);
            chkWhippedCream.Margin = new Padding(3, 4, 3, 4);
            chkWhippedCream.Name = "chkWhippedCream";
            chkWhippedCream.Size = new Size(196, 24);
            chkWhippedCream.TabIndex = 1;
            chkWhippedCream.Text = "Whipped cream (+$0.50)";
            chkWhippedCream.UseVisualStyleBackColor = true;
            // 
            // chkOatMilk
            // 
            chkOatMilk.AutoSize = true;
            chkOatMilk.Location = new Point(17, 99);
            chkOatMilk.Margin = new Padding(3, 4, 3, 4);
            chkOatMilk.Name = "chkOatMilk";
            chkOatMilk.Size = new Size(146, 24);
            chkOatMilk.TabIndex = 2;
            chkOatMilk.Text = "Oat milk (+$0.60)";
            chkOatMilk.UseVisualStyleBackColor = true;
            // 
            // grpService
            // 
            grpService.Controls.Add(rdoDineIn);
            grpService.Controls.Add(rdoDelivery);
            grpService.Controls.Add(rdoFreeDelivery);
            grpService.Location = new Point(17, 424);
            grpService.Margin = new Padding(3, 4, 3, 4);
            grpService.Name = "grpService";
            grpService.Padding = new Padding(3, 4, 3, 4);
            grpService.Size = new Size(426, 140);
            grpService.TabIndex = 13;
            grpService.TabStop = false;
            grpService.Text = "Service";
            // 
            // rdoDineIn
            // 
            rdoDineIn.AutoSize = true;
            rdoDineIn.Checked = true;
            rdoDineIn.Location = new Point(17, 32);
            rdoDineIn.Margin = new Padding(3, 4, 3, 4);
            rdoDineIn.Name = "rdoDineIn";
            rdoDineIn.Size = new Size(77, 24);
            rdoDineIn.TabIndex = 0;
            rdoDineIn.TabStop = true;
            rdoDineIn.Text = "Dine in";
            rdoDineIn.UseVisualStyleBackColor = true;
            // 
            // rdoDelivery
            // 
            rdoDelivery.AutoSize = true;
            rdoDelivery.Location = new Point(17, 65);
            rdoDelivery.Margin = new Padding(3, 4, 3, 4);
            rdoDelivery.Name = "rdoDelivery";
            rdoDelivery.Size = new Size(133, 24);
            rdoDelivery.TabIndex = 1;
            rdoDelivery.Text = "Delivery ($3.00)";
            rdoDelivery.UseVisualStyleBackColor = true;
            // 
            // rdoFreeDelivery
            // 
            rdoFreeDelivery.AutoSize = true;
            rdoFreeDelivery.Location = new Point(17, 99);
            rdoFreeDelivery.Margin = new Padding(3, 4, 3, 4);
            rdoFreeDelivery.Name = "rdoFreeDelivery";
            rdoFreeDelivery.Size = new Size(185, 24);
            rdoFreeDelivery.TabIndex = 2;
            rdoFreeDelivery.Text = "Free delivery (over $20)";
            rdoFreeDelivery.UseVisualStyleBackColor = true;
            // 
            // lblPromo
            // 
            lblPromo.AutoSize = true;
            lblPromo.Location = new Point(17, 596);
            lblPromo.Name = "lblPromo";
            lblPromo.Size = new Size(93, 20);
            lblPromo.TabIndex = 14;
            lblPromo.Text = "Promo code:";
            // 
            // txtPromo
            // 
            txtPromo.Location = new Point(109, 591);
            txtPromo.Margin = new Padding(3, 4, 3, 4);
            txtPromo.Name = "txtPromo";
            txtPromo.Size = new Size(137, 27);
            txtPromo.TabIndex = 15;
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Location = new Point(474, 87);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(100, 20);
            lblOrder.TabIndex = 16;
            lblOrder.Text = "Current order:";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.IntegralHeight = false;
            lstOrder.Location = new Point(474, 113);
            lstOrder.Margin = new Padding(3, 4, 3, 4);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(422, 212);
            lstOrder.TabIndex = 17;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(474, 337);
            btnRemoveItem.Margin = new Padding(3, 4, 3, 4);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(149, 37);
            btnRemoveItem.TabIndex = 18;
            btnRemoveItem.Text = "Remove selected";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // lblRunningTotal
            // 
            lblRunningTotal.AutoSize = true;
            lblRunningTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRunningTotal.Location = new Point(709, 345);
            lblRunningTotal.Name = "lblRunningTotal";
            lblRunningTotal.Size = new Size(136, 20);
            lblRunningTotal.TabIndex = 19;
            lblRunningTotal.Text = "Items Total: $0.00";
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Location = new Point(474, 397);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(84, 20);
            lblHistory.TabIndex = 20;
            lblHistory.Text = "Past orders:";
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.HorizontalScrollbar = true;
            lstHistory.IntegralHeight = false;
            lstHistory.Location = new Point(474, 424);
            lstHistory.Margin = new Padding(3, 4, 3, 4);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(422, 139);
            lstHistory.TabIndex = 21;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(474, 584);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(143, 43);
            btnSubmit.TabIndex = 22;
            btnSubmit.Text = "Submit order";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnShowSales
            // 
            btnShowSales.Location = new Point(629, 584);
            btnShowSales.Margin = new Padding(3, 4, 3, 4);
            btnShowSales.Name = "btnShowSales";
            btnShowSales.Size = new Size(131, 43);
            btnShowSales.TabIndex = 23;
            btnShowSales.Text = "Sales report";
            btnShowSales.UseVisualStyleBackColor = true;
            btnShowSales.Click += btnShowSales_Click;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(771, 584);
            btnAbout.Margin = new Padding(3, 4, 3, 4);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(126, 43);
            btnAbout.TabIndex = 24;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // cafe_Logo
            // 
            cafe_Logo.Image = (Image)resources.GetObject("cafe_Logo.Image");
            cafe_Logo.Location = new Point(777, 25);
            cafe_Logo.Name = "cafe_Logo";
            cafe_Logo.Size = new Size(125, 62);
            cafe_Logo.TabIndex = 25;
            cafe_Logo.TabStop = false;
            //cafe_Logo.Click += cafe_Logo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 653);
            Controls.Add(cafe_Logo);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(btnDisplayName);
            Controls.Add(lblCustomerName);
            Controls.Add(lblMenu);
            Controls.Add(cboMenu);
            Controls.Add(lblQty);
            Controls.Add(nudQuantity);
            Controls.Add(btnAddItem);
            Controls.Add(grpSize);
            Controls.Add(grpExtras);
            Controls.Add(grpService);
            Controls.Add(lblPromo);
            Controls.Add(txtPromo);
            Controls.Add(lblOrder);
            Controls.Add(lstOrder);
            Controls.Add(btnRemoveItem);
            Controls.Add(lblRunningTotal);
            Controls.Add(lblHistory);
            Controls.Add(lstHistory);
            Controls.Add(btnSubmit);
            Controls.Add(btnShowSales);
            Controls.Add(btnAbout);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UCO CAMPUS CAFE";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            grpSize.ResumeLayout(false);
            grpSize.PerformLayout();
            grpExtras.ResumeLayout(false);
            grpExtras.PerformLayout();
            grpService.ResumeLayout(false);
            grpService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cafe_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Button btnDisplayName;
        private Label lblCustomerName;
        private Label lblMenu;
        private ComboBox cboMenu;
        private Label lblQty;
        private NumericUpDown nudQuantity;
        private Button btnAddItem;
        private GroupBox grpSize;
        private RadioButton rdoSmall;
        private RadioButton rdoMedium;
        private RadioButton rdoLarge;
        private GroupBox grpExtras;
        private CheckBox chkExtraShot;
        private CheckBox chkWhippedCream;
        private CheckBox chkOatMilk;
        private GroupBox grpService;
        private RadioButton rdoDineIn;
        private RadioButton rdoDelivery;
        private RadioButton rdoFreeDelivery;
        private Label lblPromo;
        private TextBox txtPromo;
        private Label lblOrder;
        private ListBox lstOrder;
        private Button btnRemoveItem;
        private Label lblRunningTotal;
        private Label lblHistory;
        private ListBox lstHistory;
        private Button btnSubmit;
        private Button btnShowSales;
        private Button btnAbout;
        private PictureBox cafe_Logo;
    }
}
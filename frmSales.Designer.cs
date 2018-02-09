namespace StockManagementSystem
{
    partial class frmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelMainSales = new System.Windows.Forms.Panel();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblCaptionTot = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.btnDeleteSales = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.panelArticle = new System.Windows.Forms.Panel();
            this.labelTest = new System.Windows.Forms.Label();
            this.btnAddPurchase = new System.Windows.Forms.Button();
            this.listProdName = new System.Windows.Forms.ListBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtPickerBillDate = new System.Windows.Forms.DateTimePicker();
            this.cboBillType = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBillType = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.toolTipSales = new System.Windows.Forms.ToolTip(this.components);
            this.PanelMainSales.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.panelArticle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMainSales
            // 
            this.PanelMainSales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMainSales.BackgroundImage")));
            this.PanelMainSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMainSales.Controls.Add(this.lblCopyRight);
            this.PanelMainSales.Controls.Add(this.panelTotal);
            this.PanelMainSales.Controls.Add(this.panelGrid);
            this.PanelMainSales.Controls.Add(this.panelArticle);
            this.PanelMainSales.Controls.Add(this.dtPickerBillDate);
            this.PanelMainSales.Controls.Add(this.cboBillType);
            this.PanelMainSales.Controls.Add(this.lblFirstName);
            this.PanelMainSales.Controls.Add(this.lblLastName);
            this.PanelMainSales.Controls.Add(this.lblBillType);
            this.PanelMainSales.Controls.Add(this.lblBillDate);
            this.PanelMainSales.Controls.Add(this.txtFirstName);
            this.PanelMainSales.Controls.Add(this.txtLastName);
            this.PanelMainSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMainSales.Location = new System.Drawing.Point(0, 0);
            this.PanelMainSales.Name = "PanelMainSales";
            this.PanelMainSales.Size = new System.Drawing.Size(1159, 673);
            this.PanelMainSales.TabIndex = 0;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCopyRight.Location = new System.Drawing.Point(63, 537);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(109, 13);
            this.lblCopyRight.TabIndex = 18;
            this.lblCopyRight.Text = "© 2017 Azim Litanga.";
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.Transparent;
            this.panelTotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTotal.BackgroundImage")));
            this.panelTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTotal.Controls.Add(this.panel5);
            this.panelTotal.Controls.Add(this.btnSave);
            this.panelTotal.Controls.Add(this.BtnPrint);
            this.panelTotal.Controls.Add(this.btnDeleteSales);
            this.panelTotal.Location = new System.Drawing.Point(848, 257);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(260, 266);
            this.panelTotal.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.lblTotalSales);
            this.panel5.Controls.Add(this.lblCaptionTot);
            this.panel5.Location = new System.Drawing.Point(45, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(179, 90);
            this.panel5.TabIndex = 17;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.BackColor = System.Drawing.Color.Black;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTotalSales.Location = new System.Drawing.Point(73, 39);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(44, 20);
            this.lblTotalSales.TabIndex = 20;
            this.lblTotalSales.Text = "0.00";
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCaptionTot
            // 
            this.lblCaptionTot.AutoSize = true;
            this.lblCaptionTot.BackColor = System.Drawing.Color.Transparent;
            this.lblCaptionTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionTot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCaptionTot.Location = new System.Drawing.Point(16, 39);
            this.lblCaptionTot.Name = "lblCaptionTot";
            this.lblCaptionTot.Size = new System.Drawing.Size(56, 18);
            this.lblCaptionTot.TabIndex = 19;
            this.lblCaptionTot.Text = "Total :";
            this.lblCaptionTot.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(165, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 61);
            this.btnSave.TabIndex = 10;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPrint.BackgroundImage")));
            this.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrint.Location = new System.Drawing.Point(97, 164);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(66, 59);
            this.BtnPrint.TabIndex = 9;
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnDeleteSales
            // 
            this.btnDeleteSales.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteSales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteSales.BackgroundImage")));
            this.btnDeleteSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteSales.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSales.Location = new System.Drawing.Point(29, 164);
            this.btnDeleteSales.Name = "btnDeleteSales";
            this.btnDeleteSales.Size = new System.Drawing.Size(66, 59);
            this.btnDeleteSales.TabIndex = 9;
            this.btnDeleteSales.UseVisualStyleBackColor = false;
            this.btnDeleteSales.Click += new System.EventHandler(this.btnDeleteSales_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.Transparent;
            this.panelGrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGrid.BackgroundImage")));
            this.panelGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGrid.Controls.Add(this.dataGridViewSales);
            this.panelGrid.Location = new System.Drawing.Point(46, 257);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(798, 266);
            this.panelGrid.TabIndex = 15;
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewSales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewSales.Location = new System.Drawing.Point(42, 41);
            this.dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSales.Size = new System.Drawing.Size(715, 183);
            this.dataGridViewSales.TabIndex = 9;
            // 
            // panelArticle
            // 
            this.panelArticle.BackColor = System.Drawing.Color.Transparent;
            this.panelArticle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelArticle.BackgroundImage")));
            this.panelArticle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelArticle.Controls.Add(this.labelTest);
            this.panelArticle.Controls.Add(this.btnAddPurchase);
            this.panelArticle.Controls.Add(this.listProdName);
            this.panelArticle.Controls.Add(this.lblQty);
            this.panelArticle.Controls.Add(this.lblProduct);
            this.panelArticle.Controls.Add(this.lblTotal);
            this.panelArticle.Controls.Add(this.lblPrice);
            this.panelArticle.Controls.Add(this.txtQty);
            this.panelArticle.Controls.Add(this.txtTotal);
            this.panelArticle.Controls.Add(this.txtProduct);
            this.panelArticle.Controls.Add(this.txtPrice);
            this.panelArticle.Location = new System.Drawing.Point(46, 143);
            this.panelArticle.Name = "panelArticle";
            this.panelArticle.Size = new System.Drawing.Size(1069, 108);
            this.panelArticle.TabIndex = 15;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTest.ForeColor = System.Drawing.Color.Red;
            this.labelTest.Location = new System.Drawing.Point(764, 44);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(19, 20);
            this.labelTest.TabIndex = 21;
            this.labelTest.Text = "0";
            this.labelTest.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAddPurchase
            // 
            this.btnAddPurchase.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddPurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPurchase.BackgroundImage")));
            this.btnAddPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPurchase.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPurchase.Location = new System.Drawing.Point(963, 26);
            this.btnAddPurchase.Name = "btnAddPurchase";
            this.btnAddPurchase.Size = new System.Drawing.Size(66, 58);
            this.btnAddPurchase.TabIndex = 8;
            this.btnAddPurchase.UseVisualStyleBackColor = false;
            this.btnAddPurchase.Click += new System.EventHandler(this.btnAddPurchase_Click);
            // 
            // listProdName
            // 
            this.listProdName.FormattingEnabled = true;
            this.listProdName.Location = new System.Drawing.Point(120, 63);
            this.listProdName.Name = "listProdName";
            this.listProdName.Size = new System.Drawing.Size(134, 69);
            this.listProdName.TabIndex = 0;
            this.listProdName.Visible = false;
            this.listProdName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listProdName_KeyDown);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblQty.Location = new System.Drawing.Point(635, 45);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(43, 17);
            this.lblQty.TabIndex = 15;
            this.lblQty.Text = "Qty :";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblProduct.Location = new System.Drawing.Point(40, 45);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(74, 17);
            this.lblProduct.TabIndex = 16;
            this.lblProduct.Text = "Product :";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(814, 45);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 17);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total :";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(435, 45);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 17);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Price :";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(677, 43);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(81, 20);
            this.txtQty.TabIndex = 6;
            this.txtQty.Leave += new System.EventHandler(this.txtQty_Leave);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(868, 43);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(81, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(120, 43);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(134, 20);
            this.txtProduct.TabIndex = 4;
            this.txtProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduct_KeyDown);
            this.txtProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProduct_KeyUp);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(490, 43);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(81, 20);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            // 
            // dtPickerBillDate
            // 
            this.dtPickerBillDate.Location = new System.Drawing.Point(872, 55);
            this.dtPickerBillDate.Name = "dtPickerBillDate";
            this.dtPickerBillDate.Size = new System.Drawing.Size(211, 20);
            this.dtPickerBillDate.TabIndex = 3;
            // 
            // cboBillType
            // 
            this.cboBillType.FormattingEnabled = true;
            this.cboBillType.Items.AddRange(new object[] {
            "CASH",
            "DEBIT"});
            this.cboBillType.Location = new System.Drawing.Point(614, 55);
            this.cboBillType.Name = "cboBillType";
            this.cboBillType.Size = new System.Drawing.Size(123, 21);
            this.cboBillType.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFirstName.Location = new System.Drawing.Point(63, 58);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(96, 17);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name :";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLastName.Location = new System.Drawing.Point(332, 58);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(95, 17);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name :";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBillType
            // 
            this.lblBillType.AutoSize = true;
            this.lblBillType.BackColor = System.Drawing.Color.Transparent;
            this.lblBillType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBillType.Location = new System.Drawing.Point(531, 56);
            this.lblBillType.Name = "lblBillType";
            this.lblBillType.Size = new System.Drawing.Size(81, 17);
            this.lblBillType.TabIndex = 6;
            this.lblBillType.Text = "Bill Type :";
            this.lblBillType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBillDate.Location = new System.Drawing.Point(791, 57);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(79, 17);
            this.lblBillDate.TabIndex = 6;
            this.lblBillDate.Text = "Bill Date :";
            this.lblBillDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(163, 56);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(137, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(428, 57);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(81, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // toolTipSales
            // 
            this.toolTipSales.IsBalloon = true;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 673);
            this.Controls.Add(this.PanelMainSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.PanelMainSales.ResumeLayout(false);
            this.PanelMainSales.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.panelArticle.ResumeLayout(false);
            this.panelArticle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMainSales;
        private System.Windows.Forms.DateTimePicker dtPickerBillDate;
        private System.Windows.Forms.ComboBox cboBillType;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBillType;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Panel panelArticle;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox listProdName;
        private System.Windows.Forms.Button btnAddPurchase;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteSales;
        private System.Windows.Forms.ToolTip toolTipSales;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblCaptionTot;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Label labelTest;
    }
}
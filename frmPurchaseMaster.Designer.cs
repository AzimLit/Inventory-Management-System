namespace StockManagementSystem
{
    partial class frmPurchaseMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseMaster));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.btnAddPurchase = new System.Windows.Forms.Button();
            this.btnCancelPurchase = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cboPurchaseType = new System.Windows.Forms.ComboBox();
            this.cboDealerName = new System.Windows.Forms.ComboBox();
            this.dtPickerExpDate = new System.Windows.Forms.DateTimePicker();
            this.dtPickerPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdictPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTipPurchase = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblCopyRight);
            this.panel1.Controls.Add(this.btnAddPurchase);
            this.panel1.Controls.Add(this.btnCancelPurchase);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 467);
            this.panel1.TabIndex = 8;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCopyRight.Location = new System.Drawing.Point(55, 386);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(109, 13);
            this.lblCopyRight.TabIndex = 8;
            this.lblCopyRight.Text = "© 2017 Azim Litanga.";
            // 
            // btnAddPurchase
            // 
            this.btnAddPurchase.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddPurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPurchase.BackgroundImage")));
            this.btnAddPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPurchase.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPurchase.Location = new System.Drawing.Point(452, 382);
            this.btnAddPurchase.Name = "btnAddPurchase";
            this.btnAddPurchase.Size = new System.Drawing.Size(66, 58);
            this.btnAddPurchase.TabIndex = 9;
            this.btnAddPurchase.UseVisualStyleBackColor = false;
            this.btnAddPurchase.Click += new System.EventHandler(this.btnAddPurchase_Click);
            // 
            // btnCancelPurchase
            // 
            this.btnCancelPurchase.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelPurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelPurchase.BackgroundImage")));
            this.btnCancelPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelPurchase.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCancelPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPurchase.Location = new System.Drawing.Point(380, 383);
            this.btnCancelPurchase.Name = "btnCancelPurchase";
            this.btnCancelPurchase.Size = new System.Drawing.Size(66, 58);
            this.btnCancelPurchase.TabIndex = 10;
            this.btnCancelPurchase.UseVisualStyleBackColor = false;
            this.btnCancelPurchase.Click += new System.EventHandler(this.btnCancelPurchase_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblUnit);
            this.panel2.Controls.Add(this.cboPurchaseType);
            this.panel2.Controls.Add(this.cboDealerName);
            this.panel2.Controls.Add(this.dtPickerExpDate);
            this.panel2.Controls.Add(this.dtPickerPurchaseDate);
            this.panel2.Controls.Add(this.cboProductName);
            this.panel2.Controls.Add(this.txtProfit);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtProductTotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtProdictPrice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtProductQuantity);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(36, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 340);
            this.panel2.TabIndex = 0;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblUnit.Location = new System.Drawing.Point(350, 62);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(42, 20);
            this.lblUnit.TabIndex = 9;
            this.lblUnit.Text = "Unit";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboPurchaseType
            // 
            this.cboPurchaseType.FormattingEnabled = true;
            this.cboPurchaseType.Items.AddRange(new object[] {
            "CASH",
            "DEBIT"});
            this.cboPurchaseType.Location = new System.Drawing.Point(177, 220);
            this.cboPurchaseType.Name = "cboPurchaseType";
            this.cboPurchaseType.Size = new System.Drawing.Size(163, 24);
            this.cboPurchaseType.TabIndex = 6;
            // 
            // cboDealerName
            // 
            this.cboDealerName.FormattingEnabled = true;
            this.cboDealerName.Location = new System.Drawing.Point(177, 187);
            this.cboDealerName.Name = "cboDealerName";
            this.cboDealerName.Size = new System.Drawing.Size(163, 24);
            this.cboDealerName.TabIndex = 5;
            // 
            // dtPickerExpDate
            // 
            this.dtPickerExpDate.Location = new System.Drawing.Point(177, 253);
            this.dtPickerExpDate.Name = "dtPickerExpDate";
            this.dtPickerExpDate.Size = new System.Drawing.Size(280, 23);
            this.dtPickerExpDate.TabIndex = 7;
            // 
            // dtPickerPurchaseDate
            // 
            this.dtPickerPurchaseDate.Location = new System.Drawing.Point(177, 155);
            this.dtPickerPurchaseDate.Name = "dtPickerPurchaseDate";
            this.dtPickerPurchaseDate.Size = new System.Drawing.Size(280, 23);
            this.dtPickerPurchaseDate.TabIndex = 4;
            // 
            // cboProductName
            // 
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(177, 26);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(167, 24);
            this.cboProductName.TabIndex = 0;
            this.cboProductName.SelectedIndexChanged += new System.EventHandler(this.cboProductName_SelectedIndexChanged);
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(177, 285);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(167, 23);
            this.txtProfit.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(96, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Profit % :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(44, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Purchase Type :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(83, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Exp. Date :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(59, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dealer Name :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(46, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Purchase Date :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtProductTotal
            // 
            this.txtProductTotal.Location = new System.Drawing.Point(177, 123);
            this.txtProductTotal.Name = "txtProductTotal";
            this.txtProductTotal.Size = new System.Drawing.Size(167, 23);
            this.txtProductTotal.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(55, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product Total :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtProdictPrice
            // 
            this.txtProdictPrice.Location = new System.Drawing.Point(177, 91);
            this.txtProdictPrice.Name = "txtProdictPrice";
            this.txtProdictPrice.Size = new System.Drawing.Size(167, 23);
            this.txtProdictPrice.TabIndex = 2;
            this.txtProdictPrice.Leave += new System.EventHandler(this.txtProdictPrice_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(55, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product Price :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(177, 59);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(167, 23);
            this.txtProductQuantity.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(31, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Quantity :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(8, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 79);
            this.panel3.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(17, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Purchase Master";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toolTipPurchase
            // 
            this.toolTipPurchase.IsBalloon = true;
            // 
            // frmPurchaseMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(574, 566);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPurchaseMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPurchaseMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.Button btnAddPurchase;
        private System.Windows.Forms.Button btnCancelPurchase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdictPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboPurchaseType;
        private System.Windows.Forms.ComboBox cboDealerName;
        private System.Windows.Forms.DateTimePicker dtPickerExpDate;
        private System.Windows.Forms.DateTimePicker dtPickerPurchaseDate;
        private System.Windows.Forms.ToolTip toolTipPurchase;
        private System.Windows.Forms.Label lblUnit;
    }
}
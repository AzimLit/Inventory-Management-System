namespace StockManagementSystem
{
    partial class frmDealerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDealerInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteDealer = new System.Windows.Forms.Button();
            this.btnUpdateDealer = new System.Windows.Forms.Button();
            this.btnAddNewDealer = new System.Windows.Forms.Button();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDealerContact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.toolTipDealer = new System.Windows.Forms.ToolTip(this.components);
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridViewDealer = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDealer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(5, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 61);
            this.panel3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(217, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Add / Update Dealer";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnDeleteDealer);
            this.panel1.Controls.Add(this.btnUpdateDealer);
            this.panel1.Controls.Add(this.btnAddNewDealer);
            this.panel1.Controls.Add(this.btnCancelOperation);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 298);
            this.panel1.TabIndex = 4;
            // 
            // btnDeleteDealer
            // 
            this.btnDeleteDealer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteDealer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteDealer.BackgroundImage")));
            this.btnDeleteDealer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteDealer.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteDealer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDealer.Location = new System.Drawing.Point(120, 213);
            this.btnDeleteDealer.Name = "btnDeleteDealer";
            this.btnDeleteDealer.Size = new System.Drawing.Size(66, 59);
            this.btnDeleteDealer.TabIndex = 7;
            this.btnDeleteDealer.UseVisualStyleBackColor = false;
            this.btnDeleteDealer.Click += new System.EventHandler(this.btnDeleteDealer_Click);
            // 
            // btnUpdateDealer
            // 
            this.btnUpdateDealer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateDealer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateDealer.BackgroundImage")));
            this.btnUpdateDealer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateDealer.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateDealer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDealer.Location = new System.Drawing.Point(214, 214);
            this.btnUpdateDealer.Name = "btnUpdateDealer";
            this.btnUpdateDealer.Size = new System.Drawing.Size(66, 57);
            this.btnUpdateDealer.TabIndex = 6;
            this.btnUpdateDealer.UseVisualStyleBackColor = false;
            this.btnUpdateDealer.Click += new System.EventHandler(this.btnUpdateDealer_Click);
            // 
            // btnAddNewDealer
            // 
            this.btnAddNewDealer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewDealer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewDealer.BackgroundImage")));
            this.btnAddNewDealer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewDealer.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewDealer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewDealer.Location = new System.Drawing.Point(311, 213);
            this.btnAddNewDealer.Name = "btnAddNewDealer";
            this.btnAddNewDealer.Size = new System.Drawing.Size(66, 57);
            this.btnAddNewDealer.TabIndex = 5;
            this.btnAddNewDealer.UseVisualStyleBackColor = false;
            this.btnAddNewDealer.Click += new System.EventHandler(this.btnAddNewDealer_Click);
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelOperation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelOperation.BackgroundImage")));
            this.btnCancelOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelOperation.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCancelOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOperation.Location = new System.Drawing.Point(25, 213);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(65, 57);
            this.btnCancelOperation.TabIndex = 8;
            this.btnCancelOperation.UseVisualStyleBackColor = false;
            this.btnCancelOperation.Click += new System.EventHandler(this.btnCancelOperation_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txtCity);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDealerContact);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCompanyName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDealerName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(22, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 184);
            this.panel2.TabIndex = 0;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(149, 140);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(180, 15);
            this.txtCity.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(72, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "City :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(149, 112);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(180, 15);
            this.txtAddress.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(67, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDealerContact
            // 
            this.txtDealerContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDealerContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerContact.Location = new System.Drawing.Point(149, 84);
            this.txtDealerContact.Name = "txtDealerContact";
            this.txtDealerContact.Size = new System.Drawing.Size(180, 15);
            this.txtDealerContact.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(64, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contacts :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(149, 56);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(180, 15);
            this.txtCompanyName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Company Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDealerName
            // 
            this.txtDealerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDealerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerName.Location = new System.Drawing.Point(149, 28);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(180, 15);
            this.txtDealerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dealer Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCopyRight.Location = new System.Drawing.Point(16, 540);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(109, 13);
            this.lblCopyRight.TabIndex = 8;
            this.lblCopyRight.Text = "© 2017 Azim Litanga.";
            // 
            // toolTipDealer
            // 
            this.toolTipDealer.IsBalloon = true;
            // 
            // panelGrid
            // 
            this.panelGrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGrid.BackgroundImage")));
            this.panelGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGrid.Controls.Add(this.dataGridViewDealer);
            this.panelGrid.Location = new System.Drawing.Point(19, 372);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(379, 161);
            this.panelGrid.TabIndex = 11;
            // 
            // dataGridViewDealer
            // 
            this.dataGridViewDealer.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewDealer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDealer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDealer.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewDealer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewDealer.Location = new System.Drawing.Point(14, 16);
            this.dataGridViewDealer.Name = "dataGridViewDealer";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDealer.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDealer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDealer.Size = new System.Drawing.Size(343, 131);
            this.dataGridViewDealer.TabIndex = 9;
            this.dataGridViewDealer.DoubleClick += new System.EventHandler(this.dataGridViewDealer_DoubleClick);
            // 
            // frmDealerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(416, 561);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDealerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDealerInfo";
            this.Load += new System.EventHandler(this.frmDealerInfo_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDealer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.Button btnAddNewDealer;
        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDealerContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipDealer;
        private System.Windows.Forms.Button btnDeleteDealer;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridViewDealer;
        private System.Windows.Forms.Button btnUpdateDealer;
    }
}
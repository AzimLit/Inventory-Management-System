namespace StockManagementSystem
{
    partial class frmUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelGridUnit = new System.Windows.Forms.Panel();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.btnDeleteUnit = new System.Windows.Forms.Button();
            this.dataGridViewUNIT = new System.Windows.Forms.DataGridView();
            this.panelAddUnit = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAddUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewUnit = new System.Windows.Forms.Button();
            this.btnCancelUnitAdd = new System.Windows.Forms.Button();
            this.toolTipUnits = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            this.panelGridUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUNIT)).BeginInit();
            this.panelAddUnit.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(9, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 61);
            this.panel3.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(37, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Add Unit";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelGridUnit
            // 
            this.panelGridUnit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGridUnit.BackgroundImage")));
            this.panelGridUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGridUnit.Controls.Add(this.lblCopyRight);
            this.panelGridUnit.Controls.Add(this.btnDeleteUnit);
            this.panelGridUnit.Controls.Add(this.dataGridViewUNIT);
            this.panelGridUnit.Location = new System.Drawing.Point(12, 263);
            this.panelGridUnit.Name = "panelGridUnit";
            this.panelGridUnit.Size = new System.Drawing.Size(330, 267);
            this.panelGridUnit.TabIndex = 5;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCopyRight.Location = new System.Drawing.Point(32, 212);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(109, 13);
            this.lblCopyRight.TabIndex = 8;
            this.lblCopyRight.Text = "© 2017 Azim Litanga.";
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteUnit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteUnit.BackgroundImage")));
            this.btnDeleteUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteUnit.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUnit.Location = new System.Drawing.Point(226, 178);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(66, 58);
            this.btnDeleteUnit.TabIndex = 5;
            this.btnDeleteUnit.UseVisualStyleBackColor = false;
            this.btnDeleteUnit.Click += new System.EventHandler(this.btnDeleteUnit_Click);
            // 
            // dataGridViewUNIT
            // 
            this.dataGridViewUNIT.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewUNIT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUNIT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUNIT.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewUNIT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewUNIT.Location = new System.Drawing.Point(38, 35);
            this.dataGridViewUNIT.Name = "dataGridViewUNIT";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUNIT.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUNIT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUNIT.Size = new System.Drawing.Size(254, 137);
            this.dataGridViewUNIT.TabIndex = 4;
            // 
            // panelAddUnit
            // 
            this.panelAddUnit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAddUnit.BackgroundImage")));
            this.panelAddUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAddUnit.Controls.Add(this.panel4);
            this.panelAddUnit.Controls.Add(this.btnAddNewUnit);
            this.panelAddUnit.Controls.Add(this.btnCancelUnitAdd);
            this.panelAddUnit.Location = new System.Drawing.Point(12, 71);
            this.panelAddUnit.Name = "panelAddUnit";
            this.panelAddUnit.Size = new System.Drawing.Size(330, 187);
            this.panelAddUnit.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.txtAddUnit);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(35, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 72);
            this.panel4.TabIndex = 7;
            // 
            // txtAddUnit
            // 
            this.txtAddUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddUnit.Location = new System.Drawing.Point(122, 21);
            this.txtAddUnit.Name = "txtAddUnit";
            this.txtAddUnit.Size = new System.Drawing.Size(98, 15);
            this.txtAddUnit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Unit :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAddNewUnit
            // 
            this.btnAddNewUnit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewUnit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewUnit.BackgroundImage")));
            this.btnAddNewUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewUnit.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddNewUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUnit.Location = new System.Drawing.Point(187, 103);
            this.btnAddNewUnit.Name = "btnAddNewUnit";
            this.btnAddNewUnit.Size = new System.Drawing.Size(66, 58);
            this.btnAddNewUnit.TabIndex = 1;
            this.btnAddNewUnit.UseVisualStyleBackColor = false;
            this.btnAddNewUnit.Click += new System.EventHandler(this.btnAddNewUnit_Click);
            // 
            // btnCancelUnitAdd
            // 
            this.btnCancelUnitAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelUnitAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelUnitAdd.BackgroundImage")));
            this.btnCancelUnitAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelUnitAdd.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCancelUnitAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelUnitAdd.Location = new System.Drawing.Point(69, 103);
            this.btnCancelUnitAdd.Name = "btnCancelUnitAdd";
            this.btnCancelUnitAdd.Size = new System.Drawing.Size(66, 58);
            this.btnCancelUnitAdd.TabIndex = 2;
            this.btnCancelUnitAdd.UseVisualStyleBackColor = false;
            this.btnCancelUnitAdd.Click += new System.EventHandler(this.btnCancelUnitAdd_Click);
            // 
            // toolTipUnits
            // 
            this.toolTipUnits.IsBalloon = true;
            // 
            // frmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(354, 538);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelGridUnit);
            this.Controls.Add(this.panelAddUnit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUnit_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelGridUnit.ResumeLayout(false);
            this.panelGridUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUNIT)).EndInit();
            this.panelAddUnit.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelGridUnit;
        private System.Windows.Forms.Button btnDeleteUnit;
        private System.Windows.Forms.DataGridView dataGridViewUNIT;
        private System.Windows.Forms.Panel panelAddUnit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtAddUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewUnit;
        private System.Windows.Forms.Button btnCancelUnitAdd;
        private System.Windows.Forms.ToolTip toolTipUnits;
        private System.Windows.Forms.Label lblCopyRight;
    }
}
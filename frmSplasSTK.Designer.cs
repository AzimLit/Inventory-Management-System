namespace StockManagementSystem
{
    partial class frmSplasSTK
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarSplash = new System.Windows.Forms.ProgressBar();
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblVersionX = new System.Windows.Forms.Label();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 70);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.lblCopyRight);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.progressBarSplash);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 68);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minisystem", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(318, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loading...";
            // 
            // progressBarSplash
            // 
            this.progressBarSplash.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBarSplash.Location = new System.Drawing.Point(156, 6);
            this.progressBarSplash.Name = "progressBarSplash";
            this.progressBarSplash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBarSplash.Size = new System.Drawing.Size(500, 14);
            this.progressBarSplash.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarSplash.TabIndex = 7;
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.AutoSize = true;
            this.lblApplicationName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationName.ForeColor = System.Drawing.Color.White;
            this.lblApplicationName.Location = new System.Drawing.Point(12, 227);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(420, 32);
            this.lblApplicationName.TabIndex = 9;
            this.lblApplicationName.Text = "Inventory Management System";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::StockManagementSystem.Properties.Resources.Finace;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblVersionX);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(438, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 317);
            this.panel3.TabIndex = 8;
            // 
            // lblVersionX
            // 
            this.lblVersionX.AutoSize = true;
            this.lblVersionX.BackColor = System.Drawing.Color.Azure;
            this.lblVersionX.Font = new System.Drawing.Font("Minisystem", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionX.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblVersionX.Location = new System.Drawing.Point(241, 3);
            this.lblVersionX.Name = "lblVersionX";
            this.lblVersionX.Size = new System.Drawing.Size(192, 24);
            this.lblVersionX.TabIndex = 6;
            this.lblVersionX.Text = "Version 1.2.1";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCopyRight.Location = new System.Drawing.Point(15, 37);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(109, 13);
            this.lblCopyRight.TabIndex = 8;
            this.lblCopyRight.Text = "© 2017 Azim Litanga.";
            // 
            // frmSplasSTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 455);
            this.ControlBox = false;
            this.Controls.Add(this.lblApplicationName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplasSTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBarSplash;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblApplicationName;
        private System.Windows.Forms.Label lblVersionX;
        private System.Windows.Forms.Label lblCopyRight;
    }
}
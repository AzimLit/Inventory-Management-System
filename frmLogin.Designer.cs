namespace StockManagementSystem
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panelMenu02 = new System.Windows.Forms.Panel();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.pictMenu01 = new System.Windows.Forms.PictureBox();
            this.btnLoginCancel = new System.Windows.Forms.Button();
            this.btnLoginOK = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.txtPassW = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pictMenu02 = new System.Windows.Forms.PictureBox();
            this.pictMenu03 = new System.Windows.Forms.PictureBox();
            this.panelMenu02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictMenu01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMenu02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMenu03)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu02
            // 
            this.panelMenu02.BackColor = System.Drawing.Color.NavajoWhite;
            this.panelMenu02.Controls.Add(this.lblCopyRight);
            this.panelMenu02.Controls.Add(this.pictMenu01);
            this.panelMenu02.Controls.Add(this.btnLoginCancel);
            this.panelMenu02.Controls.Add(this.btnLoginOK);
            this.panelMenu02.Controls.Add(this.lblUserName);
            this.panelMenu02.Controls.Add(this.lblPassWord);
            this.panelMenu02.Controls.Add(this.txtPassW);
            this.panelMenu02.Controls.Add(this.txtUserName);
            this.panelMenu02.Controls.Add(this.pictMenu02);
            this.panelMenu02.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu02.Location = new System.Drawing.Point(0, 61);
            this.panelMenu02.Name = "panelMenu02";
            this.panelMenu02.Size = new System.Drawing.Size(520, 214);
            this.panelMenu02.TabIndex = 2;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.ForeColor = System.Drawing.Color.Coral;
            this.lblCopyRight.Location = new System.Drawing.Point(13, 189);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(129, 16);
            this.lblCopyRight.TabIndex = 3;
            this.lblCopyRight.Text = "© 2017 Azim Litanga.";
            // 
            // pictMenu01
            // 
            this.pictMenu01.BackColor = System.Drawing.Color.Orange;
            this.pictMenu01.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictMenu01.BackgroundImage")));
            this.pictMenu01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictMenu01.Location = new System.Drawing.Point(13, 7);
            this.pictMenu01.Name = "pictMenu01";
            this.pictMenu01.Size = new System.Drawing.Size(145, 147);
            this.pictMenu01.TabIndex = 9;
            this.pictMenu01.TabStop = false;
            // 
            // btnLoginCancel
            // 
            this.btnLoginCancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoginCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoginCancel.BackgroundImage")));
            this.btnLoginCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLoginCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginCancel.Location = new System.Drawing.Point(359, 149);
            this.btnLoginCancel.Name = "btnLoginCancel";
            this.btnLoginCancel.Size = new System.Drawing.Size(66, 58);
            this.btnLoginCancel.TabIndex = 3;
            this.btnLoginCancel.UseVisualStyleBackColor = false;
            this.btnLoginCancel.Click += new System.EventHandler(this.btnLoginCancel_Click);
            // 
            // btnLoginOK
            // 
            this.btnLoginOK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoginOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoginOK.BackgroundImage")));
            this.btnLoginOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLoginOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginOK.Location = new System.Drawing.Point(441, 149);
            this.btnLoginOK.Name = "btnLoginOK";
            this.btnLoginOK.Size = new System.Drawing.Size(66, 58);
            this.btnLoginOK.TabIndex = 2;
            this.btnLoginOK.UseVisualStyleBackColor = false;
            this.btnLoginOK.Click += new System.EventHandler(this.btnLoginOK_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Linen;
            this.lblUserName.Location = new System.Drawing.Point(184, 47);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(158, 21);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Enter User Name";
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPassWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPassWord.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassWord.ForeColor = System.Drawing.Color.Linen;
            this.lblPassWord.Location = new System.Drawing.Point(191, 73);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(151, 21);
            this.lblPassWord.TabIndex = 7;
            this.lblPassWord.Text = "Enter PassWord";
            // 
            // txtPassW
            // 
            this.txtPassW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassW.Location = new System.Drawing.Point(348, 74);
            this.txtPassW.Name = "txtPassW";
            this.txtPassW.PasswordChar = '*';
            this.txtPassW.Size = new System.Drawing.Size(141, 22);
            this.txtPassW.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(348, 47);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(141, 22);
            this.txtUserName.TabIndex = 0;
            // 
            // pictMenu02
            // 
            this.pictMenu02.BackColor = System.Drawing.Color.Orange;
            this.pictMenu02.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictMenu02.BackgroundImage")));
            this.pictMenu02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictMenu02.Location = new System.Drawing.Point(164, 7);
            this.pictMenu02.Name = "pictMenu02";
            this.pictMenu02.Size = new System.Drawing.Size(353, 147);
            this.pictMenu02.TabIndex = 5;
            this.pictMenu02.TabStop = false;
            // 
            // pictMenu03
            // 
            this.pictMenu03.BackColor = System.Drawing.Color.Orange;
            this.pictMenu03.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictMenu03.BackgroundImage")));
            this.pictMenu03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictMenu03.Location = new System.Drawing.Point(330, 1);
            this.pictMenu03.Name = "pictMenu03";
            this.pictMenu03.Size = new System.Drawing.Size(179, 57);
            this.pictMenu03.TabIndex = 6;
            this.pictMenu03.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(520, 275);
            this.ControlBox = false;
            this.Controls.Add(this.pictMenu03);
            this.Controls.Add(this.panelMenu02);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelMenu02.ResumeLayout(false);
            this.panelMenu02.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictMenu01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMenu02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMenu03)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu02;
        private System.Windows.Forms.PictureBox pictMenu02;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.TextBox txtPassW;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLoginOK;
        private System.Windows.Forms.Button btnLoginCancel;
        private System.Windows.Forms.PictureBox pictMenu01;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.PictureBox pictMenu03;
    }
}
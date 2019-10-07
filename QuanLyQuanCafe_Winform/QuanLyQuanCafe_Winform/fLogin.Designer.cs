namespace QuanLyQuanCafe_Winform
{
    partial class fLogin
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
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.stackPanel3 = new DevExpress.Utils.Layout.StackPanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txbMaKhau = new System.Windows.Forms.TextBox();
            this.stackPanel4 = new DevExpress.Utils.Layout.StackPanel();
            this.btThoat = new System.Windows.Forms.Button();
            this.btDangNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).BeginInit();
            this.stackPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel4)).BeginInit();
            this.stackPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Appearance.BackColor = System.Drawing.Color.Gray;
            this.stackPanel1.Appearance.Options.UseBackColor = true;
            this.stackPanel1.Controls.Add(this.stackPanel2);
            this.stackPanel1.Controls.Add(this.stackPanel3);
            this.stackPanel1.Controls.Add(this.stackPanel4);
            this.stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel1.Location = new System.Drawing.Point(44, 83);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(440, 183);
            this.stackPanel1.TabIndex = 0;
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.labelControl1);
            this.stackPanel2.Controls.Add(this.txbTenDangNhap);
            this.stackPanel2.Location = new System.Drawing.Point(23, 20);
            this.stackPanel2.Margin = new System.Windows.Forms.Padding(20, 20, 20, 5);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(394, 37);
            this.stackPanel2.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 8);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(137, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Đăng Nhập:";
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.BackColor = System.Drawing.Color.Gray;
            this.txbTenDangNhap.ForeColor = System.Drawing.SystemColors.Window;
            this.txbTenDangNhap.Location = new System.Drawing.Point(152, 4);
            this.txbTenDangNhap.Margin = new System.Windows.Forms.Padding(5);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(230, 28);
            this.txbTenDangNhap.TabIndex = 1;
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.labelControl2);
            this.stackPanel3.Controls.Add(this.txbMaKhau);
            this.stackPanel3.Location = new System.Drawing.Point(21, 67);
            this.stackPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(397, 34);
            this.stackPanel3.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 6);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 21);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật Khẩu:";
            // 
            // txbMaKhau
            // 
            this.txbMaKhau.BackColor = System.Drawing.Color.Gray;
            this.txbMaKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMaKhau.ForeColor = System.Drawing.SystemColors.Window;
            this.txbMaKhau.Location = new System.Drawing.Point(153, 3);
            this.txbMaKhau.Margin = new System.Windows.Forms.Padding(56, 3, 10, 3);
            this.txbMaKhau.Name = "txbMaKhau";
            this.txbMaKhau.Size = new System.Drawing.Size(231, 28);
            this.txbMaKhau.TabIndex = 1;
            // 
            // stackPanel4
            // 
            this.stackPanel4.Controls.Add(this.btThoat);
            this.stackPanel4.Controls.Add(this.btDangNhap);
            this.stackPanel4.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            this.stackPanel4.Location = new System.Drawing.Point(20, 109);
            this.stackPanel4.Name = "stackPanel4";
            this.stackPanel4.Size = new System.Drawing.Size(399, 44);
            this.stackPanel4.TabIndex = 2;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.ForeColor = System.Drawing.Color.Black;
            this.btThoat.Location = new System.Drawing.Point(272, 1);
            this.btThoat.Name = "btThoat";
            this.btThoat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btThoat.Size = new System.Drawing.Size(124, 41);
            this.btThoat.TabIndex = 1;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseMnemonic = false;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDangNhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.btDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btDangNhap.Location = new System.Drawing.Point(142, 1);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btDangNhap.Size = new System.Drawing.Size(124, 41);
            this.btDangNhap.TabIndex = 0;
            this.btDangNhap.Text = "Đăng Nhập";
            this.btDangNhap.UseMnemonic = false;
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.BtDangNhap_Click);
            // 
            // fLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 365);
            this.Controls.Add(this.stackPanel1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            this.stackPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).EndInit();
            this.stackPanel3.ResumeLayout(false);
            this.stackPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel4)).EndInit();
            this.stackPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private DevExpress.Utils.Layout.StackPanel stackPanel3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txbMaKhau;
        private DevExpress.Utils.Layout.StackPanel stackPanel4;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btDangNhap;
    }
}
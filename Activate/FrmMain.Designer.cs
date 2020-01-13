namespace Activate
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pbBitmap = new System.Windows.Forms.PictureBox();
            this.tlpSN = new System.Windows.Forms.TableLayoutPanel();
            this.lSN = new System.Windows.Forms.Label();
            this.tbSN = new System.Windows.Forms.TextBox();
            this.bOpenQRCode = new System.Windows.Forms.Button();
            this.bCreateQRCode = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBitmap)).BeginInit();
            this.tlpSN.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMain.Controls.Add(this.pbBitmap, 1, 0);
            this.tlpMain.Controls.Add(this.tlpSN, 1, 1);
            this.tlpMain.Controls.Add(this.bCreateQRCode, 1, 2);
            this.tlpMain.Controls.Add(this.bOpenQRCode, 2, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpMain.Size = new System.Drawing.Size(782, 553);
            this.tlpMain.TabIndex = 0;
            // 
            // pbBitmap
            // 
            this.pbBitmap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbBitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpMain.SetColumnSpan(this.pbBitmap, 2);
            this.pbBitmap.Location = new System.Drawing.Point(241, 20);
            this.pbBitmap.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.pbBitmap.Name = "pbBitmap";
            this.pbBitmap.Size = new System.Drawing.Size(300, 300);
            this.pbBitmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBitmap.TabIndex = 0;
            this.pbBitmap.TabStop = false;
            // 
            // tlpSN
            // 
            this.tlpSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tlpSN.ColumnCount = 2;
            this.tlpMain.SetColumnSpan(this.tlpSN, 2);
            this.tlpSN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpSN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpSN.Controls.Add(this.lSN, 0, 0);
            this.tlpSN.Controls.Add(this.tbSN, 1, 0);
            this.tlpSN.Location = new System.Drawing.Point(241, 353);
            this.tlpSN.Name = "tlpSN";
            this.tlpSN.RowCount = 1;
            this.tlpSN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSN.Size = new System.Drawing.Size(300, 54);
            this.tlpSN.TabIndex = 5;
            // 
            // lSN
            // 
            this.lSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lSN.AutoSize = true;
            this.lSN.Location = new System.Drawing.Point(0, 19);
            this.lSN.Margin = new System.Windows.Forms.Padding(0);
            this.lSN.Name = "lSN";
            this.lSN.Size = new System.Drawing.Size(90, 15);
            this.lSN.TabIndex = 1;
            this.lSN.Text = "设备编号：";
            // 
            // tbSN
            // 
            this.tbSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSN.Location = new System.Drawing.Point(93, 14);
            this.tbSN.MaxLength = 9;
            this.tbSN.Name = "tbSN";
            this.tbSN.Size = new System.Drawing.Size(204, 25);
            this.tbSN.TabIndex = 2;
            // 
            // bOpenQRCode
            // 
            this.bOpenQRCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bOpenQRCode.Location = new System.Drawing.Point(411, 456);
            this.bOpenQRCode.Name = "bOpenQRCode";
            this.bOpenQRCode.Size = new System.Drawing.Size(150, 50);
            this.bOpenQRCode.TabIndex = 4;
            this.bOpenQRCode.Text = "打开图像位置";
            this.bOpenQRCode.UseVisualStyleBackColor = true;
            this.bOpenQRCode.Click += new System.EventHandler(this.bOpenQRCode_Click);
            // 
            // bCreateQRCode
            // 
            this.bCreateQRCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bCreateQRCode.Location = new System.Drawing.Point(220, 456);
            this.bCreateQRCode.Name = "bCreateQRCode";
            this.bCreateQRCode.Size = new System.Drawing.Size(150, 50);
            this.bCreateQRCode.TabIndex = 3;
            this.bCreateQRCode.Text = "生成二维码";
            this.bCreateQRCode.UseVisualStyleBackColor = true;
            this.bCreateQRCode.Click += new System.EventHandler(this.bCreateQRCode_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activate";
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBitmap)).EndInit();
            this.tlpSN.ResumeLayout(false);
            this.tlpSN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.PictureBox pbBitmap;
        private System.Windows.Forms.Label lSN;
        private System.Windows.Forms.TextBox tbSN;
        private System.Windows.Forms.Button bCreateQRCode;
        private System.Windows.Forms.Button bOpenQRCode;
        private System.Windows.Forms.TableLayoutPanel tlpSN;
    }
}


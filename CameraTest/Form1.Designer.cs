namespace CameraTest
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.tabRight = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tabComment = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.tabRight.SuspendLayout();
            this.tabComment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPhoto
            // 
            this.picPhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.picPhoto.Location = new System.Drawing.Point(0, 0);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(640, 480);
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // tabRight
            // 
            this.tabRight.Controls.Add(this.tabInfo);
            this.tabRight.Controls.Add(this.tabComment);
            this.tabRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRight.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabRight.Location = new System.Drawing.Point(0, 480);
            this.tabRight.Name = "tabRight";
            this.tabRight.SelectedIndex = 0;
            this.tabRight.Size = new System.Drawing.Size(640, 249);
            this.tabRight.TabIndex = 0;
            // 
            // tabInfo
            // 
            this.tabInfo.Location = new System.Drawing.Point(4, 37);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(632, 208);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "情報";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // tabComment
            // 
            this.tabComment.Controls.Add(this.textBox1);
            this.tabComment.Location = new System.Drawing.Point(4, 37);
            this.tabComment.Name = "tabComment";
            this.tabComment.Padding = new System.Windows.Forms.Padding(3);
            this.tabComment.Size = new System.Drawing.Size(632, 208);
            this.tabComment.TabIndex = 1;
            this.tabComment.Text = "コメント";
            this.tabComment.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 104);
            this.textBox1.TabIndex = 0;
            // 
            // pnLeft
            // 
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(368, 729);
            this.pnLeft.TabIndex = 1;
            this.pnLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLeft_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabRight);
            this.panel1.Controls.Add(this.picPhoto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(368, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 729);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnLeft);
            this.Name = "Form1";
            this.Text = "アプリ";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.tabRight.ResumeLayout(false);
            this.tabComment.ResumeLayout(false);
            this.tabComment.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.TabControl tabRight;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabComment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel panel1;

    }
}


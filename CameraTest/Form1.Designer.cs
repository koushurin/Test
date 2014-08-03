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
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnRight = new System.Windows.Forms.Panel();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.btnCmtLogPanel = new System.Windows.Forms.Button();
            this.btnCmtPanel = new System.Windows.Forms.Button();
            this.btnInfoPanel = new System.Windows.Forms.Button();
            this.pnComment = new System.Windows.Forms.Panel();
            this.cbComment = new System.Windows.Forms.ComboBox();
            this.btnNeutral = new System.Windows.Forms.Button();
            this.btnBad = new System.Windows.Forms.Button();
            this.btnGood = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnRight.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.pnButtons.SuspendLayout();
            this.pnComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLeft.Controls.Add(this.pictureBox1);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(1095, 1041);
            this.pnLeft.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::CameraTest.Properties.Resources.picure1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 717);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1093, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnRight
            // 
            this.pnRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnRight.Controls.Add(this.lblLog);
            this.pnRight.Controls.Add(this.lblInfo);
            this.pnRight.Controls.Add(this.pnLogo);
            this.pnRight.Controls.Add(this.pnButtons);
            this.pnRight.Controls.Add(this.pnComment);
            this.pnRight.Controls.Add(this.picPhoto);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRight.Location = new System.Drawing.Point(1095, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(809, 1041);
            this.pnRight.TabIndex = 2;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblLog.Location = new System.Drawing.Point(180, 74);
            this.lblLog.MaximumSize = new System.Drawing.Size(500, 400);
            this.lblLog.MinimumSize = new System.Drawing.Size(500, 400);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(500, 400);
            this.lblLog.TabIndex = 6;
            this.lblLog.Text = "lblLog";
            this.lblLog.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(478, 92);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(242, 140);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "川口　碧\r\n32歳女性\r\n\r\n<経歴>\r\n2014年\t東京国会大学卒業\r\n・・・\t\t・・・\r\n2019年\t厚生労働大臣就任";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInfo.Visible = false;
            // 
            // pnLogo
            // 
            this.pnLogo.Controls.Add(this.lblLogo);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLogo.Location = new System.Drawing.Point(0, 540);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(807, 499);
            this.pnLogo.TabIndex = 4;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("微软雅黑", 80F);
            this.lblLogo.Location = new System.Drawing.Point(31, 177);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(702, 140);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "スマート議会";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnButtons
            // 
            this.pnButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnButtons.Controls.Add(this.btnCmtLogPanel);
            this.pnButtons.Controls.Add(this.btnCmtPanel);
            this.pnButtons.Controls.Add(this.btnInfoPanel);
            this.pnButtons.Location = new System.Drawing.Point(100, 320);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(64, 185);
            this.pnButtons.TabIndex = 2;
            // 
            // btnCmtLogPanel
            // 
            this.btnCmtLogPanel.Image = global::CameraTest.Properties.Resources.log;
            this.btnCmtLogPanel.Location = new System.Drawing.Point(2, 123);
            this.btnCmtLogPanel.Name = "btnCmtLogPanel";
            this.btnCmtLogPanel.Size = new System.Drawing.Size(58, 58);
            this.btnCmtLogPanel.TabIndex = 2;
            this.btnCmtLogPanel.UseVisualStyleBackColor = true;
            this.btnCmtLogPanel.Click += new System.EventHandler(this.btnCmtLogPanel_Click);
            // 
            // btnCmtPanel
            // 
            this.btnCmtPanel.Image = global::CameraTest.Properties.Resources.comment;
            this.btnCmtPanel.Location = new System.Drawing.Point(2, 63);
            this.btnCmtPanel.Name = "btnCmtPanel";
            this.btnCmtPanel.Size = new System.Drawing.Size(58, 58);
            this.btnCmtPanel.TabIndex = 1;
            this.btnCmtPanel.UseVisualStyleBackColor = true;
            this.btnCmtPanel.Click += new System.EventHandler(this.btnCmtPanel_Click);
            // 
            // btnInfoPanel
            // 
            this.btnInfoPanel.Image = global::CameraTest.Properties.Resources.info;
            this.btnInfoPanel.Location = new System.Drawing.Point(2, 3);
            this.btnInfoPanel.Name = "btnInfoPanel";
            this.btnInfoPanel.Size = new System.Drawing.Size(58, 58);
            this.btnInfoPanel.TabIndex = 0;
            this.btnInfoPanel.UseVisualStyleBackColor = true;
            this.btnInfoPanel.Click += new System.EventHandler(this.btnInfoPanel_Click);
            // 
            // pnComment
            // 
            this.pnComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnComment.Controls.Add(this.cbComment);
            this.pnComment.Controls.Add(this.btnNeutral);
            this.pnComment.Controls.Add(this.btnBad);
            this.pnComment.Controls.Add(this.btnGood);
            this.pnComment.Controls.Add(this.btnSubmit);
            this.pnComment.Location = new System.Drawing.Point(170, 447);
            this.pnComment.Name = "pnComment";
            this.pnComment.Size = new System.Drawing.Size(550, 58);
            this.pnComment.TabIndex = 1;
            this.pnComment.Visible = false;
            // 
            // cbComment
            // 
            this.cbComment.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbComment.FormattingEnabled = true;
            this.cbComment.Items.AddRange(new object[] {
            "よく言いました！",
            "反対！"});
            this.cbComment.Location = new System.Drawing.Point(13, 10);
            this.cbComment.Name = "cbComment";
            this.cbComment.Size = new System.Drawing.Size(276, 41);
            this.cbComment.TabIndex = 6;
            this.cbComment.SelectedIndexChanged += new System.EventHandler(this.cbComment_SelectedIndexChanged);
            this.cbComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbComment_KeyDown);
            // 
            // btnNeutral
            // 
            this.btnNeutral.BackgroundImage = global::CameraTest.Properties.Resources.newtral;
            this.btnNeutral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNeutral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeutral.Location = new System.Drawing.Point(405, 6);
            this.btnNeutral.Name = "btnNeutral";
            this.btnNeutral.Size = new System.Drawing.Size(47, 47);
            this.btnNeutral.TabIndex = 5;
            this.btnNeutral.UseVisualStyleBackColor = true;
            this.btnNeutral.Click += new System.EventHandler(this.btnNeutral_Click);
            // 
            // btnBad
            // 
            this.btnBad.BackgroundImage = global::CameraTest.Properties.Resources.unlike;
            this.btnBad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBad.Location = new System.Drawing.Point(348, 6);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(47, 47);
            this.btnBad.TabIndex = 4;
            this.btnBad.UseVisualStyleBackColor = true;
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // btnGood
            // 
            this.btnGood.BackgroundImage = global::CameraTest.Properties.Resources.like;
            this.btnGood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGood.FlatAppearance.BorderSize = 4;
            this.btnGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGood.Location = new System.Drawing.Point(295, 6);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(47, 47);
            this.btnGood.TabIndex = 3;
            this.btnGood.UseVisualStyleBackColor = true;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Location = new System.Drawing.Point(461, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 46);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "投稿";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.BackgroundImage = global::CameraTest.Properties.Resources.ipad;
            this.picPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.picPhoto.Location = new System.Drawing.Point(0, 0);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(807, 540);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            this.picPhoto.Paint += new System.Windows.Forms.PaintEventHandler(this.picPhoto_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnLeft);
            this.Name = "Form1";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            this.pnButtons.ResumeLayout(false);
            this.pnComment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnComment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnButtons;
        private System.Windows.Forms.Button btnCmtLogPanel;
        private System.Windows.Forms.Button btnCmtPanel;
        private System.Windows.Forms.Button btnInfoPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnNeutral;
        private System.Windows.Forms.Button btnBad;
        private System.Windows.Forms.ComboBox cbComment;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}


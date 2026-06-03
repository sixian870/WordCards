namespace WordCards
{
    partial class frmWordCards
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWordCards));
            this.lstWordList = new System.Windows.Forms.ListBox();
            this.palMain = new System.Windows.Forms.Panel();
            this.lblExplain = new System.Windows.Forms.Label();
            this.lblPhonogram = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnAutoPlay = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.palMessage = new System.Windows.Forms.Panel();
            this.sssWord = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.timPlayer = new System.Windows.Forms.Timer(this.components);
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.palMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.palMessage.SuspendLayout();
            this.sssWord.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstWordList
            // 
            this.lstWordList.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstWordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWordList.FormattingEnabled = true;
            this.lstWordList.ItemHeight = 15;
            this.lstWordList.Location = new System.Drawing.Point(0, 0);
            this.lstWordList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstWordList.Name = "lstWordList";
            this.lstWordList.Size = new System.Drawing.Size(165, 302);
            this.lstWordList.TabIndex = 0;
            this.lstWordList.SelectedIndexChanged += new System.EventHandler(this.lstWordList_SelectedIndexChanged);
            this.lstWordList.DoubleClick += new System.EventHandler(this.lstWordList_DoubleClick);
            // 
            // palMain
            // 
            this.palMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(242)))));
            this.palMain.Controls.Add(this.btnSort);
            this.palMain.Controls.Add(this.btnShuffle);
            this.palMain.Controls.Add(this.lblExplain);
            this.palMain.Controls.Add(this.lblPhonogram);
            this.palMain.Controls.Add(this.lblWord);
            this.palMain.Controls.Add(this.lblHelp);
            this.palMain.Controls.Add(this.btnAutoPlay);
            this.palMain.Controls.Add(this.picLogo);
            this.palMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palMain.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.palMain.Location = new System.Drawing.Point(165, 0);
            this.palMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(498, 302);
            this.palMain.TabIndex = 1;
            // 
            // lblExplain
            // 
            this.lblExplain.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblExplain.Location = new System.Drawing.Point(28, 112);
            this.lblExplain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(246, 143);
            this.lblExplain.TabIndex = 8;
            this.lblExplain.Text = "label1";
            // 
            // lblPhonogram
            // 
            this.lblPhonogram.AutoSize = true;
            this.lblPhonogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhonogram.ForeColor = System.Drawing.Color.Green;
            this.lblPhonogram.Location = new System.Drawing.Point(24, 75);
            this.lblPhonogram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhonogram.Name = "lblPhonogram";
            this.lblPhonogram.Size = new System.Drawing.Size(85, 29);
            this.lblPhonogram.TabIndex = 7;
            this.lblPhonogram.Text = "label1";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblWord.Location = new System.Drawing.Point(19, 19);
            this.lblWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(153, 53);
            this.lblWord.TabIndex = 6;
            this.lblWord.Text = "label1";
            // 
            // lblHelp
            // 
            this.lblHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHelp.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHelp.Location = new System.Drawing.Point(405, 152);
            this.lblHelp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(70, 30);
            this.lblHelp.TabIndex = 5;
            this.lblHelp.Text = "Enter 下一個\r\nSpace 重複";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAutoPlay
            // 
            this.btnAutoPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoPlay.BackColor = System.Drawing.Color.White;
            this.btnAutoPlay.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAutoPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAutoPlay.Location = new System.Drawing.Point(410, 107);
            this.btnAutoPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.btnAutoPlay.Size = new System.Drawing.Size(57, 28);
            this.btnAutoPlay.TabIndex = 4;
            this.btnAutoPlay.Text = "Play";
            this.btnAutoPlay.UseVisualStyleBackColor = false;
            this.btnAutoPlay.Click += new System.EventHandler(this.btnAutoPlay_Click);
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(410, 19);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(57, 69);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // palMessage
            // 
            this.palMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(221)))), ((int)(((byte)(239)))));
            this.palMessage.Controls.Add(this.sssWord);
            this.palMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.palMessage.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.palMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.palMessage.Location = new System.Drawing.Point(0, 302);
            this.palMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.palMessage.Name = "palMessage";
            this.palMessage.Size = new System.Drawing.Size(663, 25);
            this.palMessage.TabIndex = 3;
            // 
            // sssWord
            // 
            this.sssWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(221)))), ((int)(((byte)(239)))));
            this.sssWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sssWord.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sssWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage});
            this.sssWord.Location = new System.Drawing.Point(0, 0);
            this.sssWord.Name = "sssWord";
            this.sssWord.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.sssWord.Size = new System.Drawing.Size(663, 25);
            this.sssWord.TabIndex = 0;
            this.sssWord.Text = "statusStrip1";
            // 
            // tsslMessage
            // 
            this.tsslMessage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsslMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(60, 20);
            this.tsslMessage.Text = "Message";
            // 
            // timPlayer
            // 
            this.timPlayer.Interval = 2000;
            this.timPlayer.Tick += new System.EventHandler(this.timPlayer_Tick);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShuffle.BackColor = System.Drawing.Color.White;
            this.btnShuffle.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShuffle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShuffle.Location = new System.Drawing.Point(408, 221);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(2);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(67, 28);
            this.btnShuffle.TabIndex = 9;
            this.btnShuffle.Text = "打亂";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort.BackColor = System.Drawing.Color.White;
            this.btnSort.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSort.Location = new System.Drawing.Point(408, 253);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(67, 28);
            this.btnSort.TabIndex = 10;
            this.btnSort.Text = "排序";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // frmWordCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 327);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.lstWordList);
            this.Controls.Add(this.palMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(679, 300);
            this.Name = "frmWordCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "單字卡";
            this.Load += new System.EventHandler(this.frmWordCards_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmWordCards_KeyPress);
            this.palMain.ResumeLayout(false);
            this.palMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.palMessage.ResumeLayout(false);
            this.palMessage.PerformLayout();
            this.sssWord.ResumeLayout(false);
            this.sssWord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstWordList;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.Panel palMessage;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnAutoPlay;
        private System.Windows.Forms.Timer timPlayer;
        private System.Windows.Forms.StatusStrip sssWord;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessage;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblPhonogram;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnSort;
    }
}


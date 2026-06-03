namespace WordCards
{
    partial class frmEditWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditWord));
            this.grpWord = new System.Windows.Forms.GroupBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.grpPhonogram = new System.Windows.Forms.GroupBox();
            this.txtPhonogram = new System.Windows.Forms.TextBox();
            this.grpSoundPath = new System.Windows.Forms.GroupBox();
            this.txtSoundPath = new System.Windows.Forms.TextBox();
            this.grpExplain = new System.Windows.Forms.GroupBox();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpWord.SuspendLayout();
            this.grpPhonogram.SuspendLayout();
            this.grpSoundPath.SuspendLayout();
            this.grpExplain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWord
            // 
            this.grpWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpWord.Controls.Add(this.txtWord);
            this.grpWord.Location = new System.Drawing.Point(15, 3);
            this.grpWord.Margin = new System.Windows.Forms.Padding(4);
            this.grpWord.Name = "grpWord";
            this.grpWord.Padding = new System.Windows.Forms.Padding(4);
            this.grpWord.Size = new System.Drawing.Size(275, 58);
            this.grpWord.TabIndex = 0;
            this.grpWord.TabStop = false;
            this.grpWord.Text = "單字";
            // 
            // txtWord
            // 
            this.txtWord.Enabled = false;
            this.txtWord.Location = new System.Drawing.Point(11, 22);
            this.txtWord.Name = "txtWord";
            this.txtWord.ReadOnly = true;
            this.txtWord.Size = new System.Drawing.Size(254, 25);
            this.txtWord.TabIndex = 0;
            // 
            // grpPhonogram
            // 
            this.grpPhonogram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpPhonogram.Controls.Add(this.txtPhonogram);
            this.grpPhonogram.Location = new System.Drawing.Point(15, 69);
            this.grpPhonogram.Margin = new System.Windows.Forms.Padding(4);
            this.grpPhonogram.Name = "grpPhonogram";
            this.grpPhonogram.Padding = new System.Windows.Forms.Padding(4);
            this.grpPhonogram.Size = new System.Drawing.Size(275, 58);
            this.grpPhonogram.TabIndex = 1;
            this.grpPhonogram.TabStop = false;
            this.grpPhonogram.Text = "音標";
            // 
            // txtPhonogram
            // 
            this.txtPhonogram.Location = new System.Drawing.Point(11, 22);
            this.txtPhonogram.Name = "txtPhonogram";
            this.txtPhonogram.Size = new System.Drawing.Size(254, 25);
            this.txtPhonogram.TabIndex = 0;
            // 
            // grpSoundPath
            // 
            this.grpSoundPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpSoundPath.Controls.Add(this.txtSoundPath);
            this.grpSoundPath.Location = new System.Drawing.Point(15, 135);
            this.grpSoundPath.Margin = new System.Windows.Forms.Padding(4);
            this.grpSoundPath.Name = "grpSoundPath";
            this.grpSoundPath.Padding = new System.Windows.Forms.Padding(4);
            this.grpSoundPath.Size = new System.Drawing.Size(275, 58);
            this.grpSoundPath.TabIndex = 2;
            this.grpSoundPath.TabStop = false;
            this.grpSoundPath.Text = "音檔路徑";
            // 
            // txtSoundPath
            // 
            this.txtSoundPath.Location = new System.Drawing.Point(11, 22);
            this.txtSoundPath.Name = "txtSoundPath";
            this.txtSoundPath.Size = new System.Drawing.Size(254, 25);
            this.txtSoundPath.TabIndex = 0;
            // 
            // grpExplain
            // 
            this.grpExplain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpExplain.Controls.Add(this.txtExplain);
            this.grpExplain.Location = new System.Drawing.Point(15, 201);
            this.grpExplain.Margin = new System.Windows.Forms.Padding(4);
            this.grpExplain.Name = "grpExplain";
            this.grpExplain.Padding = new System.Windows.Forms.Padding(4);
            this.grpExplain.Size = new System.Drawing.Size(275, 184);
            this.grpExplain.TabIndex = 3;
            this.grpExplain.TabStop = false;
            this.grpExplain.Text = "解釋";
            // 
            // txtExplain
            // 
            this.txtExplain.Location = new System.Drawing.Point(11, 22);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(254, 151);
            this.txtExplain.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSave.Location = new System.Drawing.Point(112, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 26);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEditWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 425);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpExplain);
            this.Controls.Add(this.grpSoundPath);
            this.Controls.Add(this.grpPhonogram);
            this.Controls.Add(this.grpWord);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEditWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "編輯單字";
            this.grpWord.ResumeLayout(false);
            this.grpWord.PerformLayout();
            this.grpPhonogram.ResumeLayout(false);
            this.grpPhonogram.PerformLayout();
            this.grpSoundPath.ResumeLayout(false);
            this.grpSoundPath.PerformLayout();
            this.grpExplain.ResumeLayout(false);
            this.grpExplain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.GroupBox grpPhonogram;
        private System.Windows.Forms.TextBox txtPhonogram;
        private System.Windows.Forms.GroupBox grpSoundPath;
        private System.Windows.Forms.TextBox txtSoundPath;
        private System.Windows.Forms.GroupBox grpExplain;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.Button btnSave;
    }
}
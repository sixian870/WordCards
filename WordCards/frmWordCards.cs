using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib; // 引用Windows Media Player COM元件
using System.IO; // 引用System.IO命名空間以使用File類別

namespace WordCards
{
    public partial class frmWordCards : Form
    {
        ///<summary>
        ///單字清單
        ///</summary>
        WordCollection _WordList= new WordCollection();
        ///<summary>
        ///Windows Media Player 播放器
        ///</summary>
        WindowsMediaPlayer wmp= new WindowsMediaPlayer();
        string strWordFile = "WordCards.txt"; // 單字檔名
        ///<summary>
///是否自動播放
///</summary>
        bool isPlay= false;

        public frmWordCards()
        {
            InitializeComponent();
        }

        ///<summary>
        ///顯示單字
        ///</summary>
        ///<paramname="word">單字物件</param>
        private void ShowWord(WordItem word)
        {
            lblWord.Text = word.Word;
            lblPhonogram.Text = word.Phonogram;
            lblExplain.Text = word.Explain;
        }

        ///<summary>
        ///將單字加入到播放清單
        ///</summary>
        private void UpdateWordList()
        {
            lstWordList.BeginUpdate(); // 開始更新
            lstWordList.Items.Clear();
            foreach (WordItem item in this._WordList)
            {
                lstWordList.Items.Add(item);
            }
            lstWordList.EndUpdate(); // 結束更新
        }

        private void frmWordCards_Load(object sender, EventArgs e)
        {
            string[] lines;
            // 若單字檔存在
            if (File.Exists(strWordFile))
            {
                lines = File.ReadAllLines(strWordFile, Encoding.UTF8);
            }
            else
            {
                MessageBox.Show($"找不到單字檔\n{strWordFile}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            // 載入單字檔
            this._WordList.LoadFromStringArray(lines);
            if (this._WordList.Count > 0)
            {
                // 更新單字清單
                UpdateWordList();
                // 顯示第一個單字
                this.ShowWord(_WordList[0]);
                tsslMessage.Text = $"單字數量：{_WordList.Count}";
            }
        }

        ///<summary>
        ///播放單字音檔
        ///</summary>
        ///<paramname="word">單字物件</param>
        private void PlayWord(WordItem word)
        {
            // 判斷音效檔是否存在
            if (File.Exists(word.SoundPath))
            {
                // 播放單字音檔
                wmp.URL = word.SoundPath;
                wmp.settings.autoStart = false;
                wmp.settings.mute = false;
                wmp.controls.play();
            }
            else
                tsslMessage.Text = $"找無{word.SoundPath}音效檔";
        }

        ///<summary>
        ///播放目前選取的單字
        ///</summary>
        private void PlaySelectedWord()
        {
            // 判斷目前選的項目是否為空
            if (lstWordList.SelectedItem != null)
            {
                // 取得目前選取的單字索引
                int idx = lstWordList.SelectedIndex;
                // 顯示單字
                ShowWord(_WordList[idx]);
                // 播放單字的發音
                PlayWord(_WordList[idx]);
            }
        }

        ///<summary>
        ///將單字清單的選項移到下一個
        ///</summary>
        private void NextWordList()
        {
            // 將焦點移到單字清單
            lstWordList.Focus();
            // 判斷目前選的下一項是否超過清單的項目數
            if (lstWordList.SelectedIndex + 1 >= lstWordList.Items.Count)
                lstWordList.SelectedIndex = 0; // 如果超過就回到第一項
            else
                lstWordList.SelectedIndex++; // 如果沒有就選擇下一項
                                             // 計算目前lstWordList顯示的行數
            int lstRows = lstWordList.Height / lstWordList.GetItemHeight(0);
            // 如果目前選的項目大於lstRows/ 2
            if (lstWordList.SelectedIndex >= lstRows / 2)
                // 將lstWordList的選項保持在中間
                lstWordList.TopIndex = lstWordList.SelectedIndex - lstRows / 2;
        }

        private void lstWordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWordList.SelectedItem != null)
            {
                // 判斷選取項目內容是否不為空字串
                if (lstWordList.SelectedItem.ToString().Length != 0)
                {
                    // 顯示並播放目前選取的單字
                    PlaySelectedWord();
                }
            }
        }

        private void timPlayer_Tick(object sender, EventArgs e)
        {
            // 移到下一個單字
            NextWordList();
            // 顯示並播放目前選取的單字
            PlaySelectedWord();
        }

        private void btnAutoPlay_Click(object sender, EventArgs e)
        {
            // 將焦點移到單字清單
            lstWordList.Focus();
            // 若目前不是自動播放
            if (isPlay == false)
            {
                btnAutoPlay.Text = "Stop";
                isPlay = true;
                // 顯示並播放目前選取的單字
                PlaySelectedWord();
                timPlayer.Start();
            }
            else
            {
                btnAutoPlay.Text = "Play";
                isPlay = false;
                timPlayer.Stop();
            }
        }

        private void frmWordCards_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isPlay == true)
                return;
            switch (e.KeyChar)
            {
                case (char)Keys.Return:
                    // 當按下Enter 時，播放下一個單字
                    NextWordList();
                    // 顯示並播放目前選取的單字
                    PlaySelectedWord();
                    e.Handled = true;
                    break;
                case (char)Keys.Space:
                    // 當按下Space 時，重複播放目前單字
                    if (lstWordList.SelectedIndex >= 0)
                    {
                        // 顯示並播放目前選取的單字
                        PlaySelectedWord();
                    }
                    e.Handled = true;
                    break;
            }
        }

        private void lstWordList_DoubleClick(object sender, EventArgs e)
        {
            lstWordList.Focus();
            // 目前選取的索引
            int idx = lstWordList.SelectedIndex;
            frmEditWord edit = new frmEditWord(_WordList[idx]);
            DialogResult result = edit.ShowDialog(this);
            // 如果使用者按下儲存按鈕
            if (result == DialogResult.Yes)
            {
                // 顯示並播放目前選取的單字
                PlaySelectedWord();
                // 儲存單字
                _WordList.SaveToFile(strWordFile);
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (isPlay == true) btnAutoPlay.PerformClick(); // 播放中先暫停

            if (this._WordList.Count > 0)
            {
                this._WordList.Shuffle(); // 洗牌
                UpdateWordList();        // 更新介面
                lstWordList.SelectedIndex = 0;
                tsslMessage.Text = "隨機打亂單字順序";
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (isPlay == true) btnAutoPlay.PerformClick();

            if (this._WordList.Count > 0)
            {
                this._WordList.SortByAlphabet(); // A-Z 排序
                UpdateWordList();               // 更新介面
                lstWordList.SelectedIndex = 0;
                tsslMessage.Text = "字母 A-Z 排序。";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // 引用System.IO命名空間以使用StreamWriter類別

namespace WordCards
{
    internal class WordCollection : Collection<WordItem>
    {
        private Random rng = new Random();

        ///<summary>
        ///從字串陣列載入資料
        ///</summary>
        ///<paramname="lines">輸入的單字字串陣列</param>
        public void LoadFromStringArray(string[] lines)
        {
            this.Clear();
            // 將字串陣列的資料載入到WordCollection物件中
            foreach (string line in lines)
            {
                // 產生WordItem物件
                WordItem item = new WordItem(line);
                this.Add(item);
            }
        }

        ///<summary>
        ///將WordCollection物件的資料儲存到檔案中
        ///</summary>
        ///<paramname="filePath"></param>
        public void SaveToFile(string filePath)
        {
            // 將WordCollection物件的資料儲存到檔案中
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (WordItem item in this)
                {
                    // 將每個單字項目轉換為字串並寫入檔案
                    writer.WriteLine(item.ToLineString());
                }
            }
        }

        /// <summary>
        /// 隨機打亂單字順序 (Fisher-Yates 洗牌)
        /// </summary>
        public void Shuffle()
        {
            if (this.Count <= 1) return;

            // 先把內部資料倒進一個臨時的 List，比較好做位置交換
            List<WordItem> tempList = this.ToList();

            // 進行洗牌
            int n = tempList.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                WordItem value = tempList[k];
                tempList[k] = tempList[n];
                tempList[n] = value;
            }

            // 清空原本的 Collection，再把洗好的單字放回來
            this.Clear();
            foreach (var item in tempList)
            {
                this.Add(item);
            }
        }

        /// <summary>
        /// 依據單字英文字母 (A-Z) 重新排序
        /// </summary>
        public void SortByAlphabet()
        {
            if (this.Count <= 1) return;

            // 利用 LINQ 依照 WordItem 裡面的 Word 屬性進行排序 (忽略大小寫)
            var sortedList = this.OrderBy(item => item.Word, StringComparer.OrdinalIgnoreCase).ToList();

            // 清空並重新塞回
            this.Clear();
            foreach (var item in sortedList)
            {
                this.Add(item);
            }
        }
    }
}

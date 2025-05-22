using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phonebook
{
    // 結構：用來儲存單一聯絡人資料（姓名與電話）
    struct PhoneBookEntry
    {
        public string name;   // 聯絡人姓名
        public string phone;  // 聯絡人電話
    }

    public partial class Form1 : Form
    {
        // 欄位：用來儲存所有聯絡人資料的清單
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
            // 將表單標題設為「電話簿」
            this.Text = "電話簿";
            // 設定姓名列表方塊的顯示文字
            if (nameListBox != null)
                nameListBox.Text = "姓名列表";
            // 設定離開按鈕的顯示文字
            if (exitButton != null)
                exitButton.Text = "離開";
            // 若有其他元件，請依需求補充
        }

        /// <summary>
        /// 讀取 PhoneList.txt 檔案內容，並將每一筆資料轉換為 PhoneBookEntry 物件，
        /// 最後存入 phoneList 清單中。
        /// </summary>

        private void ReadFile()
        {
            StreamReader inputFile;  // 宣告檔案的 StreamReader 物件
            if (openFile.ShowDialog() == DialogResult.OK) // 開啟檔案
            {
                try // 嘗試讀取檔案
                {
                    inputFile = File.OpenText(openFile.FileName); // 開啟檔案
                    string line;
                    while (!inputFile.EndOfStream) // 當未讀至檔案結尾
                    {
                        // 讀取一行資料，並去除前後空白
                        line = inputFile.ReadLine().Trim();
                        // 將資料以逗號分隔，並去除每個欄位的前後空白
                        string[] parts = line.Split(',');
                        if (parts.Length == 2) // 判斷格式是否正確
                        {
                            PhoneBookEntry entry; // 宣告一個 PhoneBookEntry 結構
                            entry.name = parts[0].Trim(); // 姓名
                            entry.phone = parts[1].Trim(); // 電話
                            phoneList.Add(entry); // 將資料加入 List
                        }
                        else // 格式不正確時
                        {
                            MessageBox.Show("檔案格式錯誤");
                        }
                    }
                    inputFile.Close(); // 關閉檔案
                }
                catch (Exception ex) // 若讀取檔案時發生錯誤
                {
                    MessageBox.Show("讀取檔案時發生錯誤：" + ex.Message);
                }
            }
        }



        /// <summary>
        /// 將 phoneList 清單中的所有聯絡人姓名顯示在 nameListBox 控制項上。
        /// </summary>
        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

        /// <summary>
        /// 表單載入時執行的事件處理函式。
        /// 可用於初始化資料或設定控制項狀態。
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile(); // 讀取檔案

            DisplayNames(); // 顯示姓名列表
        }

        /// <summary>
        /// 當使用者在 nameListBox 選取不同姓名時觸發此事件。
        /// 可用於顯示對應聯絡人的詳細資料。
        /// </summary>
        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex;
            if (index != -1) // 若有選取項目  
            {
                phoneLabel.Text = phoneList[index].phone;
                // 顯示對應的電話號碼  
            }
            else // 若沒有選取任何項目  
            {
                phoneLabel.Text = "無資料" ; // 清空電話號碼顯示  
            }
        }

        /// <summary>
        /// 當使用者按下離開按鈕時，關閉整個表單（程式結束）。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單（結束程式）
            this.Close();
        }
    }
}

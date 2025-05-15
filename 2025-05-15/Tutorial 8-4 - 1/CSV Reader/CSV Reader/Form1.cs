using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 設定表單標題與按鈕文字（繁體中文）
            this.Text = "CSV 檔案讀取器";
            getScoresButton.Text = "取得分數";
            exitButton.Text = "離開";
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                averagesListBox.Items.Clear(); // 清空顯示結果

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader inputFile = File.OpenText(openFile.FileName))
                    {
                        string line;
                        char[] delimiter = { ',', ' ' };

                        while (!inputFile.EndOfStream)
                        {
                            line = inputFile.ReadLine().Trim();
                            string[] tokens = line.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

                            if (tokens.Length < 2)
                            {
                                MessageBox.Show("格式錯誤：每筆資料需包含姓名與至少一個分數");
                                return;
                            }

                            string studentName = tokens[0];
                            int total = 0;

                            for (int i = 1; i < tokens.Length; i++)
                            {
                                if (int.TryParse(tokens[i], out int score))
                                {
                                    total += score;
                                }
                                else
                                {
                                    MessageBox.Show($"學生「{studentName}」的第 {i} 筆資料不是有效的數字：{tokens[i]}");
                                    return;
                                }
                            }

                            double average = (double)total / (tokens.Length - 1);
                            averagesListBox.Items.Add($"{studentName}：總分 {total}，平均 {average:F2}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("未選擇任何檔案");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("檔案讀取錯誤: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


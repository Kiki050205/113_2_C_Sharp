using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// IsValidNumber 方法用於檢查輸入的字串是否為有效的電話號碼。
        /// 它會檢查字串是否包含 10 個數字，並返回布林值。
        /// </summary>
        /// <param name="str">要檢查的字串。</param>
        /// <returns>如果字串包含 10 個數字，返回 true；否則返回 false。</returns>
        private bool IsValidNumber(string str)
        {
            const int VALID_LENGTH = 10; // 定義有效的電話號碼長度  

            // 檢查字串是否為 null 或空字串  
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            // 檢查字串是否包含 10 個數字  
            int digitCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    digitCount++;
                }
                else
                {
                    return false; // 如果字元不是數字，返回 false  
                }
            }

            // 返回是否包含正確數量的數字  
            return digitCount == VALID_LENGTH;
        }

        /// <summary>
        /// TelephoneFormat 方法用於將輸入的字串格式化為電話號碼格式。
        /// 例如，將 "1234567890" 格式化為 "(12) 3456-7890"。
        /// </summary>
        /// <param name="str">要格式化的字串，通過引用傳遞。</param>
        private void TelephoneFormat(ref string str)
        {

            //確保字串長度為10，並格式化為(xx) xxxx-xxxx的格式
            //if (str.Length == 10)
            // {
            //    str = $"({string.Format("({ 0}) { 1} -{ 2} ", str.Substring(0, 2), str.Substring(2, 4), str.Substring(6, 4)"};
           // }
            str = str.Insert(0, "("); // 在字串的開頭插入 "(
            str = str.Insert(3, ") "); // 在字串的第 3 個位置插入 ") "和空格
            str = str.Insert(9, "-"); // 在字串的第 9個位置插入 "-"

            // 方法實現應將字串格式化為電話號碼格式。


            /// <summary>
            /// formatButton_Click 是格式化按鈕的事件處理方法。
            /// 當使用者點擊格式化按鈕時，該方法會被觸發，並執行電話號碼格式化邏輯。
            /// </summary>
            /// <param name="sender">事件的來源物件。</param>
            /// <param name="e">包含事件資料的參數。</param>
        private void formatButton_Click(object sender, EventArgs e)
        {
            // 方法實現應執行電話號碼格式化邏輯。
        }

        /// <summary>
        /// exitButton_Click 是退出按鈕的事件處理方法。
        /// 當使用者點擊退出按鈕時，該方法會被觸發，並關閉表單。
        /// </summary>
        /// <param name="sender">事件的來源物件。</param>
        /// <param name="e">包含事件資料的參數。</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        // The error CS0121 occurs when there are multiple definitions of the same method or property,  
        // causing ambiguity. In this case, it seems there are duplicate definitions of the `InitializeComponent` method.  
        // To resolve this, ensure there is only one definition of `InitializeComponent` in the `Form1` class.  

        // Check for duplicate definitions and remove the redundant one.  
        // Below is the corrected code with only one `InitializeComponent` method.  

        private void InitializeComponent()
        {
            this.formatButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox(); // 添加此行以定義 numberTextBox  
            this.SuspendLayout();

            //  
            // formatButton  
            //  
            this.formatButton.Location = new System.Drawing.Point(50, 50);
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(100, 30);
            this.formatButton.TabIndex = 0;
            this.formatButton.Text = "格式化電話號碼"; // 更新為繁體中文  
            this.formatButton.UseVisualStyleBackColor = true;
            this.formatButton.Click += new System.EventHandler(this.formatButton_Click);

            //  
            // exitButton  
            //  
            this.exitButton.Location = new System.Drawing.Point(50, 100);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 30);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "退出"; // 更新為繁體中文  
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);

            //  
            // numberTextBox  
            //  
            this.numberTextBox.Location = new System.Drawing.Point(50, 20);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(200, 20);
            this.numberTextBox.TabIndex = 2;

            //  
            // Form1  
            //  
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.numberTextBox); // 添加此行以將 numberTextBox 添加到表單  
            this.Controls.Add(this.formatButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "電話號碼格式化工具"; // 更新為繁體中文  
            this.ResumeLayout(false);
            this.PerformLayout(); // 添加此行以啟用佈局  
        }
    }
}

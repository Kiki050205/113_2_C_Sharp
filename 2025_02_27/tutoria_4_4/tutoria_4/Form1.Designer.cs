namespace tutoria_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            distanceTextBox = new TextBox();
            gasTextBox = new TextBox();
            averageLabel1 = new Label();
            button2 = new Button();
            平均油耗紀錄 = new ListBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button1.Location = new Point(196, 308);
            button1.Name = "button1";
            button1.Size = new Size(105, 53);
            button1.TabIndex = 0;
            button1.Text = "計算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(109, 95);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 2;
            label1.Text = "輸入行駛公里數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(109, 157);
            label2.Name = "label2";
            label2.Size = new Size(181, 30);
            label2.TabIndex = 3;
            label2.Text = "輸入消耗油量數";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(109, 224);
            label3.Name = "label3";
            label3.Size = new Size(133, 30);
            label3.TabIndex = 4;
            label3.Text = "平均油耗量";
            // 
            // distanceTextBox
            // 
            distanceTextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            distanceTextBox.Location = new Point(338, 95);
            distanceTextBox.Name = "distanceTextBox";
            distanceTextBox.Size = new Size(111, 34);
            distanceTextBox.TabIndex = 5;
            // 
            // gasTextBox
            // 
            gasTextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            gasTextBox.Location = new Point(338, 157);
            gasTextBox.Name = "gasTextBox";
            gasTextBox.Size = new Size(111, 34);
            gasTextBox.TabIndex = 6;
            // 
            // averageLabel1
            // 
            averageLabel1.BorderStyle = BorderStyle.Fixed3D;
            averageLabel1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            averageLabel1.Location = new Point(292, 214);
            averageLabel1.Name = "averageLabel1";
            averageLabel1.Size = new Size(265, 59);
            averageLabel1.TabIndex = 7;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button2.Location = new Point(366, 308);
            button2.Name = "button2";
            button2.Size = new Size(105, 53);
            button2.TabIndex = 8;
            button2.Text = "離開";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // 平均油耗紀錄
            // 
            平均油耗紀錄.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            平均油耗紀錄.FormattingEnabled = true;
            平均油耗紀錄.ItemHeight = 26;
            平均油耗紀錄.Location = new Point(620, 70);
            平均油耗紀錄.Name = "平均油耗紀錄";
            平均油耗紀錄.Size = new Size(314, 316);
            平均油耗紀錄.TabIndex = 9;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button3.Location = new Point(964, 207);
            button3.Name = "button3";
            button3.Size = new Size(190, 46);
            button3.TabIndex = 10;
            button3.Text = "總平均油耗";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 450);
            Controls.Add(button3);
            Controls.Add(平均油耗紀錄);
            Controls.Add(button2);
            Controls.Add(averageLabel1);
            Controls.Add(gasTextBox);
            Controls.Add(distanceTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox distanceTextBox;
        private TextBox gasTextBox;
        private Label averageLabel1;
        private Button button2;
        private ListBox 平均油耗紀錄;
        private Button button3;
    }
}

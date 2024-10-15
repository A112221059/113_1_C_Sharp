namespace Tutorial3_1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDayofWeek = new TextBox();
            txtDay = new TextBox();
            txtMonth = new TextBox();
            txtYear = new TextBox();
            lblshow = new Label();
            btnShowDate = new Button();
            btnClear = new Button();
            btbExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20F);
            label1.Location = new Point(50, 39);
            label1.Name = "label1";
            label1.Size = new Size(96, 35);
            label1.TabIndex = 0;
            label1.Text = "星期幾";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20F);
            label2.Location = new Point(66, 108);
            label2.Name = "label2";
            label2.Size = new Size(69, 35);
            label2.TabIndex = 1;
            label2.Text = "日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 20F);
            label3.Location = new Point(66, 172);
            label3.Name = "label3";
            label3.Size = new Size(69, 35);
            label3.TabIndex = 2;
            label3.Text = "月份";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 20F);
            label4.Location = new Point(66, 242);
            label4.Name = "label4";
            label4.Size = new Size(69, 35);
            label4.TabIndex = 3;
            label4.Text = "年份";
            // 
            // txtDayofWeek
            // 
            txtDayofWeek.Font = new Font("Microsoft JhengHei UI", 20F);
            txtDayofWeek.Location = new Point(204, 39);
            txtDayofWeek.Name = "txtDayofWeek";
            txtDayofWeek.Size = new Size(148, 41);
            txtDayofWeek.TabIndex = 4;
            // 
            // txtDay
            // 
            txtDay.Font = new Font("Microsoft JhengHei UI", 20F);
            txtDay.Location = new Point(204, 102);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(148, 41);
            txtDay.TabIndex = 5;
            // 
            // txtMonth
            // 
            txtMonth.Font = new Font("Microsoft JhengHei UI", 20F);
            txtMonth.Location = new Point(204, 166);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(148, 41);
            txtMonth.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Microsoft JhengHei UI", 20F);
            txtYear.Location = new Point(204, 236);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(148, 41);
            txtYear.TabIndex = 7;
            // 
            // lblshow
            // 
            lblshow.Font = new Font("Microsoft JhengHei UI", 20F);
            lblshow.Location = new Point(66, 280);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(257, 45);
            lblshow.TabIndex = 8;
            lblshow.Text = "label5";
            lblshow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnShowDate
            // 
            btnShowDate.Location = new Point(48, 363);
            btnShowDate.Name = "btnShowDate";
            btnShowDate.Size = new Size(128, 32);
            btnShowDate.TabIndex = 9;
            btnShowDate.Text = "顯示完整內容";
            btnShowDate.UseVisualStyleBackColor = true;
            btnShowDate.Click += btnShowDate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(266, 363);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(128, 32);
            btnClear.TabIndex = 10;
            btnClear.Text = "清空內容";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btbExit
            // 
            btbExit.Location = new Point(504, 363);
            btbExit.Name = "btbExit";
            btbExit.Size = new Size(128, 32);
            btbExit.TabIndex = 11;
            btbExit.Text = "離開";
            btbExit.UseVisualStyleBackColor = true;
            btbExit.Click += btbExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btbExit);
            Controls.Add(btnClear);
            Controls.Add(btnShowDate);
            Controls.Add(lblshow);
            Controls.Add(txtYear);
            Controls.Add(txtMonth);
            Controls.Add(txtDay);
            Controls.Add(txtDayofWeek);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDayofWeek;
        private TextBox txtDay;
        private TextBox txtMonth;
        private TextBox txtYear;
        private Label lblshow;
        private Button btnShowDate;
        private Button btnClear;
        private Button btbExit;
    }
}

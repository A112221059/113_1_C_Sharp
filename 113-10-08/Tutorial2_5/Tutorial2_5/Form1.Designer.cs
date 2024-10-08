namespace Tutorial2_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ptxBack = new PictureBox();
            ptxFront = new PictureBox();
            btnShowBack = new Button();
            btnShowFront = new Button();
            button1 = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxFront).BeginInit();
            SuspendLayout();
            // 
            // ptxBack
            // 
            ptxBack.Image = (Image)resources.GetObject("ptxBack.Image");
            ptxBack.Location = new Point(162, 74);
            ptxBack.Margin = new Padding(5);
            ptxBack.Name = "ptxBack";
            ptxBack.Size = new Size(162, 232);
            ptxBack.SizeMode = PictureBoxSizeMode.Zoom;
            ptxBack.TabIndex = 0;
            ptxBack.TabStop = false;
            ptxBack.Visible = false;
            ptxBack.Click += ptxback_Click;
            // 
            // ptxFront
            // 
            ptxFront.Image = (Image)resources.GetObject("ptxFront.Image");
            ptxFront.Location = new Point(444, 83);
            ptxFront.Margin = new Padding(5);
            ptxFront.Name = "ptxFront";
            ptxFront.Size = new Size(159, 232);
            ptxFront.SizeMode = PictureBoxSizeMode.Zoom;
            ptxFront.TabIndex = 1;
            ptxFront.TabStop = false;
            ptxFront.Visible = false;
            // 
            // btnShowBack
            // 
            btnShowBack.Location = new Point(183, 356);
            btnShowBack.Name = "btnShowBack";
            btnShowBack.Size = new Size(158, 71);
            btnShowBack.TabIndex = 2;
            btnShowBack.Text = "背面";
            btnShowBack.UseVisualStyleBackColor = true;
            // 
            // btnShowFront
            // 
            btnShowFront.Location = new Point(461, 356);
            btnShowFront.Name = "btnShowFront";
            btnShowFront.Size = new Size(158, 71);
            btnShowFront.TabIndex = 3;
            btnShowFront.Text = "正面";
            btnShowFront.UseVisualStyleBackColor = true;
            btnShowFront.Click += btnShowFront_Click;
            // 
            // button1
            // 
            button1.Location = new Point(620, 240);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(172, 489);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(456, 85);
            btnExit.TabIndex = 5;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 675);
            Controls.Add(btnExit);
            Controls.Add(button1);
            Controls.Add(btnShowFront);
            Controls.Add(btnShowBack);
            Controls.Add(ptxFront);
            Controls.Add(ptxBack);
            Font = new Font("Microsoft JhengHei UI", 16F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxFront).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxBack;
        private PictureBox ptxFront;
        private Button btnShowBack;
        private Button btnShowFront;
        private Button button1;
        private Button btnExit;
    }
}

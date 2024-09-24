namespace helloword
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
            btnDisplayMassage = new Button();
            SuspendLayout();
            // 
            // btnDisplayMassage
            // 
            btnDisplayMassage.BackColor = Color.FloralWhite;
            btnDisplayMassage.Font = new Font("Microsoft JhengHei UI", 20F);
            btnDisplayMassage.Location = new Point(316, 148);
            btnDisplayMassage.Name = "btnDisplayMassage";
            btnDisplayMassage.Size = new Size(200, 101);
            btnDisplayMassage.TabIndex = 0;
            btnDisplayMassage.Text = "display massage";
            btnDisplayMassage.UseVisualStyleBackColor = false;
            btnDisplayMassage.Click += btnDisplayMassage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 491);
            Controls.Add(btnDisplayMassage);
            Name = "Form1";
            Text = "geeting";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisplayMassage;
    }
}

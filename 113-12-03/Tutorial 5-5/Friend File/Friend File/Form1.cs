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
using System.Linq.Expressions;

namespace Friend_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;

                outputFile = File.AppendText(@"date\Friends.txt");
                outputFile.WriteLine(nameTextBox.Text);
                outputFile.Close();
                MassageBox.show("名子" + "以寫入");
            }
            catch (Exception.ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}

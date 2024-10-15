using System.Xml;

namespace Tutorial3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            string output;

            output = "民國" + txtYear.Text + "年" + txtMonth.Text + "月" + txtDay.Text + "星期" + txtDayofWeek.Text;
            lblshow.Text = output;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDayofWeek.Text = "";
            txtDay.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
            lblshow.Text = "";
        }

        private void btbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

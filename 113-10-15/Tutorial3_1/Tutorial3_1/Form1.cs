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

            output = "����" + txtYear.Text + "�~" + txtMonth.Text + "��" + txtDay.Text + "�P��" + txtDayofWeek.Text;
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

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //��ܼ��J�P�I��.
        private void ptxback_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true; //�]�wvisible�ݩʬ���
            ptxFront.Visible = false;
        }
        //��ܼ��J�P����
        private void btnShowFront_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true;
            ptxFront.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

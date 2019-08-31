using System.Windows.Forms;

namespace CalculationOfIntegral
{
    public partial class ReferenceForm : Form
    {
        public ReferenceForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Image = Properties.Resources._1;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Image = Properties.Resources._2;
        }
    }
}

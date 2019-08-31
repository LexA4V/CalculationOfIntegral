using System;
using System.Windows.Forms;

namespace CalculationOfIntegral
{
    public partial class StartsForm : Form
    {
        public StartsForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MenuForm G = new MenuForm();
            this.Hide();
            G.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Windows.Forms;

namespace CalculationOfIntegral
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnSimpsonMethod_Click(object sender, EventArgs e)
        {
            MainForm F = new MainForm(new SimpsonMethod());
            this.Hide();
            F.ShowDialog();
            this.Close();
        }

        private void btnTrapezoidMethod_Click(object sender, EventArgs e)
        {
            MainForm F = new MainForm(new TrapezoidMethod());
            this.Hide();
            F.ShowDialog();
            this.Close();
        }
    }
}

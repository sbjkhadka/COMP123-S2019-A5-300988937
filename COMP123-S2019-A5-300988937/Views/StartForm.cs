using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_300988937.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            Hide();
        }

        private void OpenSavedOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            Hide();
        }

        private void ExitFromStartFormButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

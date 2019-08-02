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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            //Need to show open file dialog box to load previously saved file (1.C)
        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            Hide();
        }

        private void ProductInfoCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoNextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ORDER_FORM].Show();
            Hide();
        }
    }
}

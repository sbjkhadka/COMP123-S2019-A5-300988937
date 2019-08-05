using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// APP Name: Product selection System
/// Author's Name: Subarna Bijaya Khadka
/// Student ID: 300988937
/// App Creation Date: 8/2/2019
/// App Descrition: This application allows user to select products from a 
/// database table as well as from the saved file.
/// </summary>
namespace COMP123_S2019_A5_300988937.Views
{
    public partial class OrderForm : Form
    {
        

        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// about toolstrip click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ABOUT_FORM].ShowDialog();
        }
        /// <summary>
        /// moves towards product info form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderFormBackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            Hide();
        }
        /// <summary>
        /// Termnates the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderFromCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Displays messagebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderFormFinishButton_Click(object sender, EventArgs e)
        {
            var result=MessageBox.Show(this, "Thank you for your business, " +
                "\r\nYour order will be processed within seven business days", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, "Your selection is going to be printed !", "Print message", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if (result == DialogResult.OK)
            {
                ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
                ProductPrintForm.Print();
            }
            
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            //centering the form
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

            //load data into labels
            var Model = Program.product;
            ConditionValueLabel.Text = Model.condition;
            ManufacturerValueLabel.Text = Model.manufacturer;
            PlatformValueLabel.Text = Model.platform;
            ModelValueLabel.Text = Model.model;
            CPUSpeedValueLabel.Text = Model.CPU_speed;
            CPUBrandValueLabel.Text = Model.CPU_brand;
            CPUTypeValueLabel.Text = Model.CPU_type;
            CPUNumberValueLabel.Text = Model.CPU_number;
            LCDSizeValueLabel.Text = Model.screensize;
            HDDValueLabel.Text = Model.HDD_size;
            GPUTypeValueLabel.Text = Model.GPU_Type;
            WebcamValueLabel.Text = Model.webcam;
            MemoryValueLabel.Text = Model.RAM_size;
            OSValueLabel.Text = Model.OS;

            PrepareBill(Model);

        }

      
    }
}

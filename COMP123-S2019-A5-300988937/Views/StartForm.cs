using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// function to handle StartNewOrder button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            Hide();
        }
        /// <summary>
        /// Function to handle openSavedOrder button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSavedOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            Hide();
        }
        /// <summary>
        /// Terminates the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitFromStartFormButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

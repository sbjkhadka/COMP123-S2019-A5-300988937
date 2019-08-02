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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
        /// <summary>
        /// Splash timer tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Hide();
            Program.Forms[FormName.START_FORM].Show();
        }
    }
}

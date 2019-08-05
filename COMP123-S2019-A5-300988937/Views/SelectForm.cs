using COMP123_S2019_A5_300988937.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
    enum productHeaders
    {
        PRODUCT_ID,
        COST,
        MANUFACTURER,
        MODEL,
        RAM_TYPE,
        RAM_SIZE,
        DISPLAY_TYPE,
        SCREEN_SIZE,
        RESOLUTION,
        CPU_CLASS,
        CPU_BRAND,
        CPU_TYPE,
        CPU_SPEED,
        CPU_NUMBER,
        CONDITION,
        OS,
        PLATFORM,
        HDD_SIZE,
        HDD_SPEED,
        GPU_TYPE,
        OPTICAL_DRIVE,
        AUDIO_TYPE,
        LAN,
        WIFI,
        WIDTH,
        HEIGHT,
        DEPTH,
        WEIGHT,
        MOUST_TYPE,
        POWER,
        WEBCAM
    }
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// select form load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            NextButton.Enabled = false;
        }
        /// <summary>
        /// Terminates the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// closes this form and opens product info form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            Hide();
        }
        /// <summary>
        /// data grid view selection changed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
            var rowIndex = ProductsDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductsDataGridView.Rows[rowIndex];
            LoadDataFromSelectedRowToProductModel(currentRow); //method is defined in controller
            SelectedProductTextBox.Text = ProductsDataGridViewSelectedItem();// method is defined in controller
        }  
    }
}

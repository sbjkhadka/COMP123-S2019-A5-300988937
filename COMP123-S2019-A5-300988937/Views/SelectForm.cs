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
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
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
        /// closes this form and opens product into form
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
            SelectedProductTextBox.Text = ProductsDataGridViewSelectedItem();//put it in controller
        }

        // this method will go inside controller section in the final submission
        
        private string ProductsDataGridViewSelectedItem()
        {
            var rowIndex = ProductsDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductsDataGridView.Rows[rowIndex];
            var cost = ProductsDataGridView.CurrentRow.Cells[1].Value.ToString();
            var manufacturer=ProductsDataGridView.CurrentRow.Cells[2].Value.ToString();
            var model= ProductsDataGridView.CurrentRow.Cells[3].Value.ToString();
            string outputString = manufacturer + " " + model + " " + $"{cost:c2}";
            return outputString;
        }
    }
}

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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            NextButton.Enabled = false;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            Hide();
        }

        private void ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;

            SelectedProductTextBox.Text = ProductsDataGridViewSelectedItem();//put it in controller
            //int rowIndex = ProductsDataGridView.CurrentCell.RowIndex;

        }
        //inside controller
        
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

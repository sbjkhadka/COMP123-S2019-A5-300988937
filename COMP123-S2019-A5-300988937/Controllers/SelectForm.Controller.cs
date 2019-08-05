using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP123_S2019_A5_300988937.Views;
using COMP123_S2019_A5_300988937.Data;
using System.Data.Entity;

namespace COMP123_S2019_A5_300988937.Views
{
    public partial class SelectForm : Form
    {
        private void LoadDataIntoDataGridView()
        {
            using (var db = new ProductModel())
            {
                db.products.Load();
                productsBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }

        private string ProductsDataGridViewSelectedItem()
        {
            var rowIndex = ProductsDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductsDataGridView.Rows[rowIndex];
            var cost = currentRow.Cells[(int)productHeaders.PRODUCT_ID].Value.ToString();
            var manufacturer = currentRow.Cells[(int)productHeaders.MANUFACTURER].Value.ToString();
            var model = currentRow.Cells[(int)productHeaders.MODEL].Value.ToString();
            string outputString = manufacturer + " " + model + " " + $"{cost:c2}";
            return outputString;
        }
        private static void LoadDataFromSelectedRowToProductModel(DataGridViewRow currentRow)
        {
            Program.product.productID = short.Parse(currentRow.Cells[(int)productHeaders.PRODUCT_ID].Value.ToString());
            Program.product.cost = decimal.Parse(currentRow.Cells[(int)productHeaders.COST].Value.ToString());
            Program.product.manufacturer = currentRow.Cells[(int)productHeaders.MANUFACTURER].Value.ToString();
            Program.product.model = currentRow.Cells[(int)productHeaders.MODEL].Value.ToString();
            Program.product.RAM_type = currentRow.Cells[(int)productHeaders.RAM_TYPE].Value.ToString();
            Program.product.RAM_size = currentRow.Cells[(int)productHeaders.RAM_SIZE].Value.ToString();
            Program.product.displaytype = currentRow.Cells[(int)productHeaders.DISPLAY_TYPE].Value.ToString();
            Program.product.screensize = currentRow.Cells[(int)productHeaders.SCREEN_SIZE].Value.ToString();
            Program.product.resolution = currentRow.Cells[(int)productHeaders.RESOLUTION].Value.ToString();
            Program.product.CPU_Class = currentRow.Cells[(int)productHeaders.CPU_CLASS].Value.ToString();
            Program.product.CPU_brand = currentRow.Cells[(int)productHeaders.CPU_BRAND].Value.ToString();
            Program.product.CPU_type = currentRow.Cells[(int)productHeaders.CPU_TYPE].Value.ToString();
            Program.product.CPU_speed = currentRow.Cells[(int)productHeaders.CPU_SPEED].Value.ToString();
            Program.product.CPU_number = currentRow.Cells[(int)productHeaders.CPU_NUMBER].Value.ToString();
            Program.product.condition = currentRow.Cells[(int)productHeaders.CONDITION].Value.ToString();
            Program.product.OS = currentRow.Cells[(int)productHeaders.OS].Value.ToString();
            Program.product.platform = currentRow.Cells[(int)productHeaders.PLATFORM].Value.ToString();
            Program.product.HDD_size = currentRow.Cells[(int)productHeaders.HDD_SIZE].Value.ToString();
            Program.product.HDD_speed = currentRow.Cells[(int)productHeaders.HDD_SPEED].Value.ToString();
            Program.product.GPU_Type = currentRow.Cells[(int)productHeaders.GPU_TYPE].Value.ToString();
            Program.product.optical_drive = currentRow.Cells[(int)productHeaders.OPTICAL_DRIVE].Value.ToString();
            Program.product.Audio_type = currentRow.Cells[(int)productHeaders.AUDIO_TYPE].Value.ToString();
            Program.product.LAN = currentRow.Cells[(int)productHeaders.LAN].Value.ToString();
            Program.product.WIFI = currentRow.Cells[(int)productHeaders.WIFI].Value.ToString();
            Program.product.width = currentRow.Cells[(int)productHeaders.WIDTH].Value.ToString();
            Program.product.height = currentRow.Cells[(int)productHeaders.HEIGHT].Value.ToString();
            Program.product.depth = currentRow.Cells[(int)productHeaders.DEPTH].Value.ToString();
            Program.product.weight = currentRow.Cells[(int)productHeaders.WEIGHT].Value.ToString();
            Program.product.moust_type = currentRow.Cells[(int)productHeaders.MOUST_TYPE].Value.ToString();
            Program.product.power = currentRow.Cells[(int)productHeaders.POWER].Value.ToString();
            Program.product.webcam = currentRow.Cells[(int)productHeaders.WEBCAM].Value.ToString();
        }
    }
}

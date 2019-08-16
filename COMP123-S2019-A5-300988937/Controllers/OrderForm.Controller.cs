using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_300988937.Views
{
    public partial class OrderForm : Form
    {
        private void PrepareBill(Data.Product Model)
        {
            bool cost = float.TryParse(Model.cost.ToString(), out float costValue);
            bool tax = float.TryParse(((decimal)0.13 * Model.cost).ToString(), out float taxValue);
            PriceValueLabel.Text = $"{Model.cost:C2}".ToString();
            SalesTaxValueLabel.Text = $"{(decimal)0.13 * Model.cost:C2}";
            TotalValueLabel.Text = $"{(costValue + taxValue):C2}";
        }
        /// <summary>
        /// Method to select device image according to its type
        /// This method can be modified using different image for each devices
        /// </summary>
        /// <param name="Model"></param>
        private void SelectImage(Data.Product Model)
        {
            if (Model.platform == "Laptop")
            {
                SelectedProductPictureBox.Image = Image.FromFile("../../Resources/laptop.png");
            }
            else if (Model.platform == "Desktop PC")
            {
                SelectedProductPictureBox.Image = Image.FromFile("../../Resources/desktop.png");
            }
            else
            {
                SelectedProductPictureBox.Image = Image.FromFile("../../Resources/My-Computer.png");
            }
        }
    }


}

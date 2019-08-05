using System;
using System.Collections.Generic;
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
    }
}

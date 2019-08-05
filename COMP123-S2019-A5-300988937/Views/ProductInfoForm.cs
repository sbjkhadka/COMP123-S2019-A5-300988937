using COMP123_S2019_A5_300988937.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// form load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Program.product.condition);
            

        }
        /// <summary>
        /// allows user to change their selection by navigating to select form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            Hide();
        }
        /// <summary>
        /// Terminates the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Move towards order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoNextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ORDER_FORM].Show();
            Hide();
        }
        /// <summary>
        /// loads when productInfo form is loaded or visited again 
        /// by pressing "select another product"  button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDTextBox.Text = Program.product.productID.ToString();
            ConditionTextBox.Text = Program.product.condition;
            CostTextBox.Text = Program.product.cost.ToString();
            PlatformTextBox.Text = Program.product.platform;
            OSTextBox.Text = Program.product.OS;
            ManufacturerTextBox.Text = Program.product.manufacturer;
            ModelTextBox.Text = Program.product.model;
            MemoryTextBox.Text = Program.product.RAM_size;
            CPUBrandTextBox.Text = Program.product.CPU_brand;
            CPUTypeTextBox.Text = Program.product.CPU_type;
            LCDSizeTextBox.Text = Program.product.screensize;
            CPUNumberTextBox.Text = Program.product.CPU_number;
            CPUSpeedTextBox.Text = Program.product.CPU_speed;
            HDDTextBox.Text = Program.product.HDD_size + ", " + Program.product.HDD_speed;
            GPUTypeTextBox.Text = Program.product.GPU_Type;
            WebcamTextBox.Text = Program.product.webcam;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configuration for SaveFileDialog
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.FileName = "DefaultProduct.dat";
            ProductSaveFileDialog.Filter = "Binary Files (*.dat)|*.dat|All Files (*.*)|*.*";

            var result = ProductSaveFileDialog.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                //open binary stream to write
                using(BinaryWriter outputStream=new BinaryWriter(
                    File.Open(ProductSaveFileDialog.FileName, FileMode.Create)))
                {
                    //write to file
                    outputStream.Write(Program.product.productID.ToString());
                    outputStream.Write(Program.product.cost.ToString());
                    outputStream.Write(Program.product.manufacturer);
                    outputStream.Write(Program.product.model);
                    outputStream.Write(Program.product.RAM_type);
                    outputStream.Write(Program.product.RAM_size);
                    outputStream.Write(Program.product.displaytype);
                    outputStream.Write(Program.product.screensize);
                    outputStream.Write(Program.product.resolution);
                    outputStream.Write(Program.product.CPU_Class);
                    outputStream.Write(Program.product.CPU_brand);
                    outputStream.Write(Program.product.CPU_type);
                    outputStream.Write(Program.product.CPU_speed);
                    outputStream.Write(Program.product.CPU_number);
                    outputStream.Write(Program.product.condition);
                    outputStream.Write(Program.product.OS);
                    outputStream.Write(Program.product.platform);
                    outputStream.Write(Program.product.HDD_size);
                    outputStream.Write(Program.product.HDD_speed);
                    outputStream.Write(Program.product.GPU_Type);
                    outputStream.Write(Program.product.optical_drive);
                    outputStream.Write(Program.product.Audio_type);
                    outputStream.Write(Program.product.LAN);
                    outputStream.Write(Program.product.WIFI);
                    outputStream.Write(Program.product.width);
                    outputStream.Write(Program.product.height);
                    outputStream.Write(Program.product.depth);
                    outputStream.Write(Program.product.weight);
                    outputStream.Write(Program.product.moust_type);
                    outputStream.Write(Program.product.power);
                    outputStream.Write(Program.product.webcam);

                    //cleanup
                    outputStream.Close();
                    outputStream.Dispose();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Configuration for openFileDialog
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.FileName = "DefaultProduct.dat";
            ProductOpenFileDialog.Filter = "Binary Files (*.dat)|*.dat|All Files (*.*)|*.*";

            var result = ProductOpenFileDialog.ShowDialog(); //stores user action in result variable

            if (result != DialogResult.Cancel)
            {
                //open filestream 
                using (BinaryReader inputStream = new BinaryReader(File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                {
                    //read from file into product object
                    Program.product.productID = short.Parse(inputStream.ReadString());
                    Program.product.cost = decimal.Parse(inputStream.ReadString());
                    Program.product.manufacturer = inputStream.ReadString();
                    Program.product.model = inputStream.ReadString();
                    Program.product.RAM_type = inputStream.ReadString();
                    Program.product.RAM_size = inputStream.ReadString();
                    Program.product.displaytype = inputStream.ReadString();
                    Program.product.screensize = inputStream.ReadString();
                    Program.product.resolution = inputStream.ReadString();
                    Program.product.CPU_Class = inputStream.ReadString();
                    Program.product.CPU_brand = inputStream.ReadString();
                    Program.product.CPU_type = inputStream.ReadString();
                    Program.product.CPU_speed = inputStream.ReadString();
                    Program.product.CPU_number = inputStream.ReadString();
                    Program.product.condition = inputStream.ReadString();
                    Program.product.OS = inputStream.ReadString();
                    Program.product.platform = inputStream.ReadString();
                    Program.product.HDD_size = inputStream.ReadString();
                    Program.product.HDD_speed = inputStream.ReadString();
                    Program.product.GPU_Type = inputStream.ReadString();
                    Program.product.optical_drive = inputStream.ReadString();
                    Program.product.Audio_type = inputStream.ReadString();
                    Program.product.LAN = inputStream.ReadString();
                    Program.product.WIFI = inputStream.ReadString();
                    Program.product.width = inputStream.ReadString();
                    Program.product.height = inputStream.ReadString();
                    Program.product.depth = inputStream.ReadString();
                    Program.product.weight = inputStream.ReadString();
                    Program.product.moust_type = inputStream.ReadString();
                    Program.product.power = inputStream.ReadString();
                    Program.product.webcam = inputStream.ReadString();

                    //cleanup
                    inputStream.Close();
                    inputStream.Dispose();
                }
                ProductInfoForm_Activated(sender, e);
            }
        }
    }
}

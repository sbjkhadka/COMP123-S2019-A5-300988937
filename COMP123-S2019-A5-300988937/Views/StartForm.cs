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
    public partial class StartForm : Form
    {
        //flag to check if some error has occured
       // used to switch between startform and product info form
        private bool _errflag = false;
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
            _errflag = false; //this flag should be set to false when user starts to open from file
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
                    try
                    {
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
                    }
                    catch(Exception exception)
                    {
                        _errflag = true; //this flag is set to true when some error is caught
                        MessageBox.Show("ERROR: " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //cleanup
                    inputStream.Close();
                    inputStream.Dispose();
                }
                //when everything is good, product info form is displayed, else remains at start form
                if (_errflag == false) {
                    Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
                    Hide();
                }
                
            }
            
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

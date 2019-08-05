namespace COMP123_S2019_A5_300988937.Views
{
    partial class ProductInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.ProductInfoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.SpecificationsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.WebcamTextBox = new System.Windows.Forms.TextBox();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.CPUSpeedTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUNumberTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.LCDSizeTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.SelectAnotherProductButton = new System.Windows.Forms.Button();
            this.ProductInfoCancel = new System.Windows.Forms.Button();
            this.ProductInfoNextButton = new System.Windows.Forms.Button();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ProductSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ProductOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProductInfoMenuStrip.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SpecificationsGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductInfoMenuStrip
            // 
            this.ProductInfoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.ProductInfoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductInfoMenuStrip.Name = "ProductInfoMenuStrip";
            this.ProductInfoMenuStrip.Size = new System.Drawing.Size(864, 24);
            this.ProductInfoMenuStrip.TabIndex = 0;
            this.ProductInfoMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ProductInfoCancel_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "S&elect Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.SelectAnotherProductButton_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLabel.ForeColor = System.Drawing.Color.Snow;
            this.ProductIDLabel.Location = new System.Drawing.Point(24, 38);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(97, 24);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.ForeColor = System.Drawing.Color.Snow;
            this.ConditionLabel.Location = new System.Drawing.Point(225, 38);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(90, 24);
            this.ConditionLabel.TabIndex = 1;
            this.ConditionLabel.Text = "Condition";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.ForeColor = System.Drawing.Color.Snow;
            this.CostLabel.Location = new System.Drawing.Point(427, 38);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(47, 24);
            this.CostLabel.TabIndex = 1;
            this.CostLabel.Text = "Cost";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.ConditionTextBox.Location = new System.Drawing.Point(321, 35);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(100, 29);
            this.ConditionTextBox.TabIndex = 2;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.CostTextBox.Location = new System.Drawing.Point(480, 35);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 29);
            this.CostTextBox.TabIndex = 2;
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.ProductInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInfoGroupBox.ForeColor = System.Drawing.Color.Snow;
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(24, 90);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(816, 159);
            this.ProductInfoGroupBox.TabIndex = 3;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.29353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.58209F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.452736F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.9204F));
            this.tableLayoutPanel1.Controls.Add(this.PlatformLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ModelTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ModelLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.OSTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ManufacturerLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OSLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PlatformTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ManufacturerTextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 122);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.ForeColor = System.Drawing.Color.Snow;
            this.PlatformLabel.Location = new System.Drawing.Point(50, 0);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(77, 61);
            this.PlatformLabel.TabIndex = 1;
            this.PlatformLabel.Text = "Platform";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.ModelTextBox.Location = new System.Drawing.Point(477, 64);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(324, 29);
            this.ModelTextBox.TabIndex = 2;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.ForeColor = System.Drawing.Color.Snow;
            this.ModelLabel.Location = new System.Drawing.Point(408, 61);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(63, 61);
            this.ModelLabel.TabIndex = 1;
            this.ModelLabel.Text = "Model";
            // 
            // OSTextBox
            // 
            this.OSTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.OSTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.OSTextBox.Location = new System.Drawing.Point(477, 3);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.Size = new System.Drawing.Size(324, 29);
            this.OSTextBox.TabIndex = 2;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.ForeColor = System.Drawing.Color.Snow;
            this.ManufacturerLabel.Location = new System.Drawing.Point(7, 61);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(120, 61);
            this.ManufacturerLabel.TabIndex = 1;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.OSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSLabel.ForeColor = System.Drawing.Color.Snow;
            this.OSLabel.Location = new System.Drawing.Point(434, 0);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(37, 61);
            this.OSLabel.TabIndex = 1;
            this.OSLabel.Text = "OS";
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.PlatformTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.PlatformTextBox.Location = new System.Drawing.Point(133, 3);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(263, 29);
            this.PlatformTextBox.TabIndex = 2;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ManufacturerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.ManufacturerTextBox.Location = new System.Drawing.Point(133, 64);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(263, 29);
            this.ManufacturerTextBox.TabIndex = 2;
            // 
            // SpecificationsGroupBox
            // 
            this.SpecificationsGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.SpecificationsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecificationsGroupBox.ForeColor = System.Drawing.Color.Snow;
            this.SpecificationsGroupBox.Location = new System.Drawing.Point(24, 259);
            this.SpecificationsGroupBox.Name = "SpecificationsGroupBox";
            this.SpecificationsGroupBox.Size = new System.Drawing.Size(816, 231);
            this.SpecificationsGroupBox.TabIndex = 3;
            this.SpecificationsGroupBox.TabStop = false;
            this.SpecificationsGroupBox.Text = "Specifications";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.12358F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.16772F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.51955F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.77175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.36696F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.55486F));
            this.tableLayoutPanel2.Controls.Add(this.MemoryLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.WebcamTextBox, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.WebcamLabel, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.CPUBrandLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.HDDTextBox, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.GPUTypeLabel, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.CPUSpeedLabel, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.HDDLabel, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.CPUTypeLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.MemoryTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.CPUSpeedTextBox, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.CPUNumberLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.CPUBrandTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.CPUTypeTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.CPUNumberTextBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.LCDSizeLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.LCDSizeTextBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.GPUTypeTextBox, 5, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 36);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(793, 189);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.ForeColor = System.Drawing.Color.Snow;
            this.MemoryLabel.Location = new System.Drawing.Point(29, 0);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(79, 63);
            this.MemoryLabel.TabIndex = 1;
            this.MemoryLabel.Text = "Memory";
            // 
            // WebcamTextBox
            // 
            this.WebcamTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.WebcamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebcamTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.WebcamTextBox.Location = new System.Drawing.Point(632, 129);
            this.WebcamTextBox.Name = "WebcamTextBox";
            this.WebcamTextBox.Size = new System.Drawing.Size(158, 29);
            this.WebcamTextBox.TabIndex = 2;
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.AutoSize = true;
            this.WebcamLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.WebcamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebcamLabel.ForeColor = System.Drawing.Color.Snow;
            this.WebcamLabel.Location = new System.Drawing.Point(537, 126);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(89, 63);
            this.WebcamLabel.TabIndex = 1;
            this.WebcamLabel.Text = "WebCam";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CPUBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandLabel.ForeColor = System.Drawing.Color.Snow;
            this.CPUBrandLabel.Location = new System.Drawing.Point(5, 63);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(103, 63);
            this.CPUBrandLabel.TabIndex = 1;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.HDDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.HDDTextBox.Location = new System.Drawing.Point(632, 3);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.Size = new System.Drawing.Size(158, 29);
            this.HDDTextBox.TabIndex = 2;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.GPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypeLabel.ForeColor = System.Drawing.Color.Snow;
            this.GPUTypeLabel.Location = new System.Drawing.Point(529, 63);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(97, 63);
            this.GPUTypeLabel.TabIndex = 1;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CPUSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedLabel.ForeColor = System.Drawing.Color.Snow;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(280, 126);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(109, 63);
            this.CPUSpeedLabel.TabIndex = 1;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.HDDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDLabel.ForeColor = System.Drawing.Color.Snow;
            this.HDDLabel.Location = new System.Drawing.Point(576, 0);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(50, 63);
            this.HDDLabel.TabIndex = 1;
            this.HDDLabel.Text = "HDD";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeLabel.ForeColor = System.Drawing.Color.Snow;
            this.CPUTypeLabel.Location = new System.Drawing.Point(12, 126);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(96, 63);
            this.CPUTypeLabel.TabIndex = 1;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.MemoryTextBox.Location = new System.Drawing.Point(114, 3);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.Size = new System.Drawing.Size(145, 29);
            this.MemoryTextBox.TabIndex = 2;
            // 
            // CPUSpeedTextBox
            // 
            this.CPUSpeedTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CPUSpeedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.CPUSpeedTextBox.Location = new System.Drawing.Point(395, 129);
            this.CPUSpeedTextBox.Name = "CPUSpeedTextBox";
            this.CPUSpeedTextBox.Size = new System.Drawing.Size(126, 29);
            this.CPUSpeedTextBox.TabIndex = 2;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CPUNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberLabel.ForeColor = System.Drawing.Color.Snow;
            this.CPUNumberLabel.Location = new System.Drawing.Point(267, 63);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(122, 63);
            this.CPUNumberLabel.TabIndex = 1;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CPUBrandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.CPUBrandTextBox.Location = new System.Drawing.Point(114, 66);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.Size = new System.Drawing.Size(145, 29);
            this.CPUBrandTextBox.TabIndex = 2;
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CPUTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.CPUTypeTextBox.Location = new System.Drawing.Point(114, 129);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.Size = new System.Drawing.Size(145, 29);
            this.CPUTypeTextBox.TabIndex = 2;
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CPUNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.CPUNumberTextBox.Location = new System.Drawing.Point(395, 66);
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            this.CPUNumberTextBox.Size = new System.Drawing.Size(126, 29);
            this.CPUNumberTextBox.TabIndex = 2;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LCDSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDSizeLabel.ForeColor = System.Drawing.Color.Snow;
            this.LCDSizeLabel.Location = new System.Drawing.Point(302, 0);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(87, 63);
            this.LCDSizeLabel.TabIndex = 1;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LCDSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDSizeTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.LCDSizeTextBox.Location = new System.Drawing.Point(395, 3);
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            this.LCDSizeTextBox.Size = new System.Drawing.Size(126, 29);
            this.LCDSizeTextBox.TabIndex = 2;
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.GPUTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypeTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.GPUTypeTextBox.Location = new System.Drawing.Point(632, 66);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.Size = new System.Drawing.Size(158, 29);
            this.GPUTypeTextBox.TabIndex = 2;
            // 
            // SelectAnotherProductButton
            // 
            this.SelectAnotherProductButton.BackColor = System.Drawing.Color.Snow;
            this.SelectAnotherProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAnotherProductButton.ForeColor = System.Drawing.Color.Tomato;
            this.SelectAnotherProductButton.Location = new System.Drawing.Point(24, 508);
            this.SelectAnotherProductButton.Name = "SelectAnotherProductButton";
            this.SelectAnotherProductButton.Size = new System.Drawing.Size(249, 41);
            this.SelectAnotherProductButton.TabIndex = 4;
            this.SelectAnotherProductButton.Text = "Select Another Product";
            this.SelectAnotherProductButton.UseVisualStyleBackColor = false;
            this.SelectAnotherProductButton.Click += new System.EventHandler(this.SelectAnotherProductButton_Click);
            // 
            // ProductInfoCancel
            // 
            this.ProductInfoCancel.BackColor = System.Drawing.Color.Snow;
            this.ProductInfoCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInfoCancel.ForeColor = System.Drawing.Color.Tomato;
            this.ProductInfoCancel.Location = new System.Drawing.Point(510, 508);
            this.ProductInfoCancel.Name = "ProductInfoCancel";
            this.ProductInfoCancel.Size = new System.Drawing.Size(162, 41);
            this.ProductInfoCancel.TabIndex = 4;
            this.ProductInfoCancel.Text = "Cancel";
            this.ProductInfoCancel.UseVisualStyleBackColor = false;
            this.ProductInfoCancel.Click += new System.EventHandler(this.ProductInfoCancel_Click);
            // 
            // ProductInfoNextButton
            // 
            this.ProductInfoNextButton.BackColor = System.Drawing.Color.Snow;
            this.ProductInfoNextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInfoNextButton.ForeColor = System.Drawing.Color.Tomato;
            this.ProductInfoNextButton.Location = new System.Drawing.Point(678, 508);
            this.ProductInfoNextButton.Name = "ProductInfoNextButton";
            this.ProductInfoNextButton.Size = new System.Drawing.Size(162, 41);
            this.ProductInfoNextButton.TabIndex = 4;
            this.ProductInfoNextButton.Text = "Next";
            this.ProductInfoNextButton.UseVisualStyleBackColor = false;
            this.ProductInfoNextButton.Click += new System.EventHandler(this.ProductInfoNextButton_Click);
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDTextBox.ForeColor = System.Drawing.Color.Tomato;
            this.ProductIDTextBox.Location = new System.Drawing.Point(119, 35);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.Size = new System.Drawing.Size(100, 29);
            this.ProductIDTextBox.TabIndex = 2;
            // 
            // ProductOpenFileDialog
            // 
            this.ProductOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.ControlBox = false;
            this.Controls.Add(this.ProductInfoNextButton);
            this.Controls.Add(this.ProductInfoCancel);
            this.Controls.Add(this.SelectAnotherProductButton);
            this.Controls.Add(this.SpecificationsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.ProductInfoMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ProductInfoMenuStrip;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.ProductInfoMenuStrip.ResumeLayout(false);
            this.ProductInfoMenuStrip.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.SpecificationsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ProductInfoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.GroupBox SpecificationsGroupBox;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.TextBox CPUNumberTextBox;
        private System.Windows.Forms.TextBox LCDSizeTextBox;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.TextBox WebcamTextBox;
        private System.Windows.Forms.TextBox CPUSpeedTextBox;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.Button SelectAnotherProductButton;
        private System.Windows.Forms.Button ProductInfoCancel;
        private System.Windows.Forms.Button ProductInfoNextButton;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SaveFileDialog ProductSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog ProductOpenFileDialog;
    }
}
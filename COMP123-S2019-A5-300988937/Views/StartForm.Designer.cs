namespace COMP123_S2019_A5_300988937.Views
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.StartNewOrderButton = new System.Windows.Forms.Button();
            this.OpenSavedOrderButton = new System.Windows.Forms.Button();
            this.ExitFromStartFormButton = new System.Windows.Forms.Button();
            this.BottomPictureBox = new System.Windows.Forms.PictureBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.StartFormWebsiteLabel = new System.Windows.Forms.Label();
            this.ProductOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartNewOrderButton
            // 
            this.StartNewOrderButton.BackColor = System.Drawing.Color.Snow;
            this.StartNewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNewOrderButton.ForeColor = System.Drawing.Color.Tomato;
            this.StartNewOrderButton.Location = new System.Drawing.Point(12, 84);
            this.StartNewOrderButton.Name = "StartNewOrderButton";
            this.StartNewOrderButton.Size = new System.Drawing.Size(235, 56);
            this.StartNewOrderButton.TabIndex = 0;
            this.StartNewOrderButton.Text = "Start a New Order";
            this.StartNewOrderButton.UseVisualStyleBackColor = false;
            this.StartNewOrderButton.Click += new System.EventHandler(this.StartNewOrderButton_Click);
            // 
            // OpenSavedOrderButton
            // 
            this.OpenSavedOrderButton.BackColor = System.Drawing.Color.Snow;
            this.OpenSavedOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenSavedOrderButton.ForeColor = System.Drawing.Color.Tomato;
            this.OpenSavedOrderButton.Location = new System.Drawing.Point(12, 161);
            this.OpenSavedOrderButton.Name = "OpenSavedOrderButton";
            this.OpenSavedOrderButton.Size = new System.Drawing.Size(235, 56);
            this.OpenSavedOrderButton.TabIndex = 1;
            this.OpenSavedOrderButton.Text = "Open a Saved Order";
            this.OpenSavedOrderButton.UseVisualStyleBackColor = false;
            this.OpenSavedOrderButton.Click += new System.EventHandler(this.OpenSavedOrderButton_Click);
            // 
            // ExitFromStartFormButton
            // 
            this.ExitFromStartFormButton.BackColor = System.Drawing.Color.Snow;
            this.ExitFromStartFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitFromStartFormButton.ForeColor = System.Drawing.Color.Tomato;
            this.ExitFromStartFormButton.Location = new System.Drawing.Point(12, 493);
            this.ExitFromStartFormButton.Name = "ExitFromStartFormButton";
            this.ExitFromStartFormButton.Size = new System.Drawing.Size(235, 56);
            this.ExitFromStartFormButton.TabIndex = 2;
            this.ExitFromStartFormButton.Text = "Exit";
            this.ExitFromStartFormButton.UseVisualStyleBackColor = false;
            this.ExitFromStartFormButton.Click += new System.EventHandler(this.ExitFromStartFormButton_Click);
            // 
            // BottomPictureBox
            // 
            this.BottomPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomPictureBox.Image = global::COMP123_S2019_A5_300988937.Properties.Resources.header1;
            this.BottomPictureBox.Location = new System.Drawing.Point(12, 7);
            this.BottomPictureBox.Name = "BottomPictureBox";
            this.BottomPictureBox.Size = new System.Drawing.Size(840, 66);
            this.BottomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BottomPictureBox.TabIndex = 4;
            this.BottomPictureBox.TabStop = false;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::COMP123_S2019_A5_300988937.Properties.Resources.advert1;
            this.LogoPictureBox.Location = new System.Drawing.Point(263, 84);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(589, 465);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 3;
            this.LogoPictureBox.TabStop = false;
            // 
            // StartFormWebsiteLabel
            // 
            this.StartFormWebsiteLabel.AutoSize = true;
            this.StartFormWebsiteLabel.BackColor = System.Drawing.Color.Tomato;
            this.StartFormWebsiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartFormWebsiteLabel.ForeColor = System.Drawing.Color.Snow;
            this.StartFormWebsiteLabel.Location = new System.Drawing.Point(21, 44);
            this.StartFormWebsiteLabel.Name = "StartFormWebsiteLabel";
            this.StartFormWebsiteLabel.Size = new System.Drawing.Size(217, 24);
            this.StartFormWebsiteLabel.TabIndex = 5;
            this.StartFormWebsiteLabel.Text = "www.dollarcomputers.ca";
            // 
            // ProductOpenFileDialog
            // 
            this.ProductOpenFileDialog.FileName = "openFileDialog1";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.ControlBox = false;
            this.Controls.Add(this.StartFormWebsiteLabel);
            this.Controls.Add(this.BottomPictureBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.ExitFromStartFormButton);
            this.Controls.Add(this.OpenSavedOrderButton);
            this.Controls.Add(this.StartNewOrderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computer!";
            ((System.ComponentModel.ISupportInitialize)(this.BottomPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartNewOrderButton;
        private System.Windows.Forms.Button OpenSavedOrderButton;
        private System.Windows.Forms.Button ExitFromStartFormButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.PictureBox BottomPictureBox;
        private System.Windows.Forms.Label StartFormWebsiteLabel;
        private System.Windows.Forms.OpenFileDialog ProductOpenFileDialog;
    }
}


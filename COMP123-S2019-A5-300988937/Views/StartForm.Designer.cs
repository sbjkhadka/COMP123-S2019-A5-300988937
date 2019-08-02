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
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartNewOrderButton
            // 
            this.StartNewOrderButton.Location = new System.Drawing.Point(12, 12);
            this.StartNewOrderButton.Name = "StartNewOrderButton";
            this.StartNewOrderButton.Size = new System.Drawing.Size(169, 23);
            this.StartNewOrderButton.TabIndex = 0;
            this.StartNewOrderButton.Text = "Start a New Order";
            this.StartNewOrderButton.UseVisualStyleBackColor = true;
            this.StartNewOrderButton.Click += new System.EventHandler(this.StartNewOrderButton_Click);
            // 
            // OpenSavedOrderButton
            // 
            this.OpenSavedOrderButton.Location = new System.Drawing.Point(12, 52);
            this.OpenSavedOrderButton.Name = "OpenSavedOrderButton";
            this.OpenSavedOrderButton.Size = new System.Drawing.Size(166, 23);
            this.OpenSavedOrderButton.TabIndex = 1;
            this.OpenSavedOrderButton.Text = "Open a Saved Order";
            this.OpenSavedOrderButton.UseVisualStyleBackColor = true;
            this.OpenSavedOrderButton.Click += new System.EventHandler(this.OpenSavedOrderButton_Click);
            // 
            // ExitFromStartFormButton
            // 
            this.ExitFromStartFormButton.Location = new System.Drawing.Point(12, 426);
            this.ExitFromStartFormButton.Name = "ExitFromStartFormButton";
            this.ExitFromStartFormButton.Size = new System.Drawing.Size(166, 23);
            this.ExitFromStartFormButton.TabIndex = 2;
            this.ExitFromStartFormButton.Text = "Exit";
            this.ExitFromStartFormButton.UseVisualStyleBackColor = true;
            this.ExitFromStartFormButton.Click += new System.EventHandler(this.ExitFromStartFormButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(187, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(605, 437);
            this.LogoPictureBox.TabIndex = 3;
            this.LogoPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.ControlBox = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartNewOrderButton;
        private System.Windows.Forms.Button OpenSavedOrderButton;
        private System.Windows.Forms.Button ExitFromStartFormButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
    }
}


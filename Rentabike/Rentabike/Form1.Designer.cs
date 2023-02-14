namespace Rentabike
{
    partial class Form1
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
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.labelDescriptionBike = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxDescriptionBike = new System.Windows.Forms.TextBox();
            this.buttonRentABike = new System.Windows.Forms.Button();
            this.buttonReturnRentedBike = new System.Windows.Forms.Button();
            this.listBoxOverview = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Location = new System.Drawing.Point(48, 39);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(71, 13);
            this.labelSerialNumber.TabIndex = 0;
            this.labelSerialNumber.Text = "Serial number";
            this.labelSerialNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDescriptionBike
            // 
            this.labelDescriptionBike.AutoSize = true;
            this.labelDescriptionBike.Location = new System.Drawing.Point(198, 39);
            this.labelDescriptionBike.Name = "labelDescriptionBike";
            this.labelDescriptionBike.Size = new System.Drawing.Size(83, 13);
            this.labelDescriptionBike.TabIndex = 1;
            this.labelDescriptionBike.Text = "Description bike";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(51, 69);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxSerialNumber.TabIndex = 2;
            // 
            // textBoxDescriptionBike
            // 
            this.textBoxDescriptionBike.Location = new System.Drawing.Point(201, 69);
            this.textBoxDescriptionBike.Name = "textBoxDescriptionBike";
            this.textBoxDescriptionBike.Size = new System.Drawing.Size(323, 20);
            this.textBoxDescriptionBike.TabIndex = 3;
            // 
            // buttonRentABike
            // 
            this.buttonRentABike.Location = new System.Drawing.Point(548, 39);
            this.buttonRentABike.Name = "buttonRentABike";
            this.buttonRentABike.Size = new System.Drawing.Size(87, 53);
            this.buttonRentABike.TabIndex = 4;
            this.buttonRentABike.Text = "Rent a bike";
            this.buttonRentABike.UseVisualStyleBackColor = true;
            // 
            // buttonReturnRentedBike
            // 
            this.buttonReturnRentedBike.Location = new System.Drawing.Point(548, 259);
            this.buttonReturnRentedBike.Name = "buttonReturnRentedBike";
            this.buttonReturnRentedBike.Size = new System.Drawing.Size(87, 53);
            this.buttonReturnRentedBike.TabIndex = 6;
            this.buttonReturnRentedBike.Text = "Return rented bike";
            this.buttonReturnRentedBike.UseVisualStyleBackColor = true;
            // 
            // listBoxOverview
            // 
            this.listBoxOverview.FormattingEnabled = true;
            this.listBoxOverview.Location = new System.Drawing.Point(51, 133);
            this.listBoxOverview.Name = "listBoxOverview";
            this.listBoxOverview.Size = new System.Drawing.Size(473, 277);
            this.listBoxOverview.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxOverview);
            this.Controls.Add(this.buttonReturnRentedBike);
            this.Controls.Add(this.buttonRentABike);
            this.Controls.Add(this.textBoxDescriptionBike);
            this.Controls.Add(this.textBoxSerialNumber);
            this.Controls.Add(this.labelDescriptionBike);
            this.Controls.Add(this.labelSerialNumber);
            this.Name = "Form1";
            this.Text = "Rentabike";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.Label labelDescriptionBike;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxDescriptionBike;
        private System.Windows.Forms.Button buttonRentABike;
        private System.Windows.Forms.Button buttonReturnRentedBike;
        private System.Windows.Forms.ListBox listBoxOverview;
    }
}


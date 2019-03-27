namespace Program_4
{
    partial class program4
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
            this.originZipLbl = new System.Windows.Forms.Label();
            this.destinationZipLbl = new System.Windows.Forms.Label();
            this.lengthLbl = new System.Windows.Forms.Label();
            this.widthLbl = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.originTxt = new System.Windows.Forms.TextBox();
            this.destinationTxt = new System.Windows.Forms.TextBox();
            this.lengthTxt = new System.Windows.Forms.TextBox();
            this.widthTxt = new System.Windows.Forms.TextBox();
            this.heightTxt = new System.Windows.Forms.TextBox();
            this.weightTxt = new System.Windows.Forms.TextBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.sendToButton = new System.Windows.Forms.Button();
            this.sendFromButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originZipLbl
            // 
            this.originZipLbl.AutoSize = true;
            this.originZipLbl.Location = new System.Drawing.Point(52, 9);
            this.originZipLbl.Name = "originZipLbl";
            this.originZipLbl.Size = new System.Drawing.Size(80, 20);
            this.originZipLbl.TabIndex = 0;
            this.originZipLbl.Text = "Origin Zip:";
            // 
            // destinationZipLbl
            // 
            this.destinationZipLbl.AutoSize = true;
            this.destinationZipLbl.Location = new System.Drawing.Point(12, 46);
            this.destinationZipLbl.Name = "destinationZipLbl";
            this.destinationZipLbl.Size = new System.Drawing.Size(120, 20);
            this.destinationZipLbl.TabIndex = 1;
            this.destinationZipLbl.Text = "Destination Zip:";
            // 
            // lengthLbl
            // 
            this.lengthLbl.AutoSize = true;
            this.lengthLbl.Location = new System.Drawing.Point(39, 83);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(93, 20);
            this.lengthLbl.TabIndex = 2;
            this.lengthLbl.Text = "Length (in.):";
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(48, 120);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(84, 20);
            this.widthLbl.TabIndex = 3;
            this.widthLbl.Text = "Width (in.):";
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(42, 157);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(90, 20);
            this.heightLbl.TabIndex = 4;
            this.heightLbl.Text = "Height (in.):";
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(31, 194);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(101, 20);
            this.weightLbl.TabIndex = 5;
            this.weightLbl.Text = "Weight (lbs.):";
            // 
            // originTxt
            // 
            this.originTxt.Location = new System.Drawing.Point(138, 6);
            this.originTxt.Name = "originTxt";
            this.originTxt.Size = new System.Drawing.Size(140, 26);
            this.originTxt.TabIndex = 6;
            // 
            // destinationTxt
            // 
            this.destinationTxt.Location = new System.Drawing.Point(138, 43);
            this.destinationTxt.Name = "destinationTxt";
            this.destinationTxt.Size = new System.Drawing.Size(140, 26);
            this.destinationTxt.TabIndex = 7;
            // 
            // lengthTxt
            // 
            this.lengthTxt.Location = new System.Drawing.Point(138, 80);
            this.lengthTxt.Name = "lengthTxt";
            this.lengthTxt.Size = new System.Drawing.Size(140, 26);
            this.lengthTxt.TabIndex = 8;
            // 
            // widthTxt
            // 
            this.widthTxt.Location = new System.Drawing.Point(138, 117);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(140, 26);
            this.widthTxt.TabIndex = 9;
            // 
            // heightTxt
            // 
            this.heightTxt.Location = new System.Drawing.Point(138, 154);
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.Size = new System.Drawing.Size(140, 26);
            this.heightTxt.TabIndex = 10;
            // 
            // weightTxt
            // 
            this.weightTxt.Location = new System.Drawing.Point(138, 191);
            this.weightTxt.Name = "weightTxt";
            this.weightTxt.Size = new System.Drawing.Size(140, 26);
            this.weightTxt.TabIndex = 11;
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 20;
            this.outputListBox.Location = new System.Drawing.Point(299, 6);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(233, 264);
            this.outputListBox.TabIndex = 13;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(83, 223);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 43);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add Package";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(538, 12);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(153, 43);
            this.detailsButton.TabIndex = 14;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // sendToButton
            // 
            this.sendToButton.Location = new System.Drawing.Point(538, 169);
            this.sendToButton.Name = "sendToButton";
            this.sendToButton.Size = new System.Drawing.Size(153, 43);
            this.sendToButton.TabIndex = 15;
            this.sendToButton.Text = "Send to UofL";
            this.sendToButton.UseVisualStyleBackColor = true;
            this.sendToButton.Click += new System.EventHandler(this.sendToButton_Click);
            // 
            // sendFromButton
            // 
            this.sendFromButton.Location = new System.Drawing.Point(538, 223);
            this.sendFromButton.Name = "sendFromButton";
            this.sendFromButton.Size = new System.Drawing.Size(153, 43);
            this.sendFromButton.TabIndex = 16;
            this.sendFromButton.Text = "Send from UofL";
            this.sendFromButton.UseVisualStyleBackColor = true;
            this.sendFromButton.Click += new System.EventHandler(this.sendFromButton_Click);
            // 
            // program4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 278);
            this.Controls.Add(this.sendFromButton);
            this.Controls.Add(this.sendToButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.weightTxt);
            this.Controls.Add(this.heightTxt);
            this.Controls.Add(this.widthTxt);
            this.Controls.Add(this.lengthTxt);
            this.Controls.Add(this.destinationTxt);
            this.Controls.Add(this.originTxt);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.lengthLbl);
            this.Controls.Add(this.destinationZipLbl);
            this.Controls.Add(this.originZipLbl);
            this.Name = "program4";
            this.Text = "Program 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originZipLbl;
        private System.Windows.Forms.Label destinationZipLbl;
        private System.Windows.Forms.Label lengthLbl;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.TextBox originTxt;
        private System.Windows.Forms.TextBox destinationTxt;
        private System.Windows.Forms.TextBox lengthTxt;
        private System.Windows.Forms.TextBox widthTxt;
        private System.Windows.Forms.TextBox heightTxt;
        private System.Windows.Forms.TextBox weightTxt;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button sendToButton;
        private System.Windows.Forms.Button sendFromButton;
    }
}


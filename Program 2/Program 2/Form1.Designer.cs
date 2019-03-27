namespace Program_2
{
    partial class programTwo
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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.classStandingGroupBox = new System.Windows.Forms.GroupBox();
            this.freshmanRadioButton = new System.Windows.Forms.RadioButton();
            this.sophomoreRadioButton = new System.Windows.Forms.RadioButton();
            this.juniorRadioButton = new System.Windows.Forms.RadioButton();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.resultsButton = new System.Windows.Forms.Button();
            this.classStandingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(63, 38);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(152, 35);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(175, 26);
            this.lastNameTxt.TabIndex = 1;
            // 
            // classStandingGroupBox
            // 
            this.classStandingGroupBox.Controls.Add(this.freshmanRadioButton);
            this.classStandingGroupBox.Controls.Add(this.sophomoreRadioButton);
            this.classStandingGroupBox.Controls.Add(this.juniorRadioButton);
            this.classStandingGroupBox.Controls.Add(this.seniorRadioButton);
            this.classStandingGroupBox.Location = new System.Drawing.Point(67, 78);
            this.classStandingGroupBox.Name = "classStandingGroupBox";
            this.classStandingGroupBox.Size = new System.Drawing.Size(260, 151);
            this.classStandingGroupBox.TabIndex = 2;
            this.classStandingGroupBox.TabStop = false;
            this.classStandingGroupBox.Text = "Class Standing";
            // 
            // freshmanRadioButton
            // 
            this.freshmanRadioButton.AutoSize = true;
            this.freshmanRadioButton.Location = new System.Drawing.Point(6, 115);
            this.freshmanRadioButton.Name = "freshmanRadioButton";
            this.freshmanRadioButton.Size = new System.Drawing.Size(106, 24);
            this.freshmanRadioButton.TabIndex = 3;
            this.freshmanRadioButton.TabStop = true;
            this.freshmanRadioButton.Text = "Freshman";
            this.freshmanRadioButton.UseVisualStyleBackColor = true;
            // 
            // sophomoreRadioButton
            // 
            this.sophomoreRadioButton.AutoSize = true;
            this.sophomoreRadioButton.Location = new System.Drawing.Point(6, 85);
            this.sophomoreRadioButton.Name = "sophomoreRadioButton";
            this.sophomoreRadioButton.Size = new System.Drawing.Size(117, 24);
            this.sophomoreRadioButton.TabIndex = 2;
            this.sophomoreRadioButton.TabStop = true;
            this.sophomoreRadioButton.Text = "Sophomore";
            this.sophomoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // juniorRadioButton
            // 
            this.juniorRadioButton.AutoSize = true;
            this.juniorRadioButton.Location = new System.Drawing.Point(6, 55);
            this.juniorRadioButton.Name = "juniorRadioButton";
            this.juniorRadioButton.Size = new System.Drawing.Size(77, 24);
            this.juniorRadioButton.TabIndex = 1;
            this.juniorRadioButton.TabStop = true;
            this.juniorRadioButton.Text = "Junior";
            this.juniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Location = new System.Drawing.Point(6, 25);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(80, 24);
            this.seniorRadioButton.TabIndex = 0;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "Senior";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // resultsButton
            // 
            this.resultsButton.Location = new System.Drawing.Point(152, 253);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(85, 36);
            this.resultsButton.TabIndex = 3;
            this.resultsButton.Text = "Results";
            this.resultsButton.UseVisualStyleBackColor = true;
            this.resultsButton.Click += new System.EventHandler(this.resultsButton_Click);
            // 
            // programTwo
            // 
            this.AcceptButton = this.resultsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 310);
            this.Controls.Add(this.resultsButton);
            this.Controls.Add(this.classStandingGroupBox);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.lastNameLabel);
            this.Name = "programTwo";
            this.Text = "Program 2";
            this.classStandingGroupBox.ResumeLayout(false);
            this.classStandingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.GroupBox classStandingGroupBox;
        private System.Windows.Forms.RadioButton freshmanRadioButton;
        private System.Windows.Forms.RadioButton sophomoreRadioButton;
        private System.Windows.Forms.RadioButton juniorRadioButton;
        private System.Windows.Forms.RadioButton seniorRadioButton;
        private System.Windows.Forms.Button resultsButton;
    }
}


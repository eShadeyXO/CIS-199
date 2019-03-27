namespace Prog2
{
    partial class RegForm
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
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.findRegTimeBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.RegLbl = new System.Windows.Forms.Label();
            this.dateTimeLbl = new System.Windows.Forms.Label();
            this.levelGroupBox = new System.Windows.Forms.GroupBox();
            this.freshmanRBtn = new System.Windows.Forms.RadioButton();
            this.sophomoreRBtn = new System.Windows.Forms.RadioButton();
            this.juniorRBtn = new System.Windows.Forms.RadioButton();
            this.seniorRBtn = new System.Windows.Forms.RadioButton();
            this.levelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(141, 18);
            this.lastNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(148, 26);
            this.lastNameTxt.TabIndex = 1;
            // 
            // findRegTimeBtn
            // 
            this.findRegTimeBtn.Location = new System.Drawing.Point(140, 280);
            this.findRegTimeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findRegTimeBtn.Name = "findRegTimeBtn";
            this.findRegTimeBtn.Size = new System.Drawing.Size(148, 35);
            this.findRegTimeBtn.TabIndex = 3;
            this.findRegTimeBtn.Text = "Find Reg. Time";
            this.findRegTimeBtn.UseVisualStyleBackColor = true;
            this.findRegTimeBtn.Click += new System.EventHandler(this.findRegTimeBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(44, 23);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(88, 20);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Last name:";
            // 
            // RegLbl
            // 
            this.RegLbl.AutoSize = true;
            this.RegLbl.Location = new System.Drawing.Point(98, 334);
            this.RegLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegLbl.Name = "RegLbl";
            this.RegLbl.Size = new System.Drawing.Size(229, 20);
            this.RegLbl.TabIndex = 4;
            this.RegLbl.Text = "The earliest you may register is:";
            // 
            // dateTimeLbl
            // 
            this.dateTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLbl.Location = new System.Drawing.Point(18, 369);
            this.dateTimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateTimeLbl.Name = "dateTimeLbl";
            this.dateTimeLbl.Size = new System.Drawing.Size(394, 20);
            this.dateTimeLbl.TabIndex = 5;
            this.dateTimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelGroupBox
            // 
            this.levelGroupBox.Controls.Add(this.freshmanRBtn);
            this.levelGroupBox.Controls.Add(this.sophomoreRBtn);
            this.levelGroupBox.Controls.Add(this.juniorRBtn);
            this.levelGroupBox.Controls.Add(this.seniorRBtn);
            this.levelGroupBox.Location = new System.Drawing.Point(141, 66);
            this.levelGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.levelGroupBox.Name = "levelGroupBox";
            this.levelGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.levelGroupBox.Size = new System.Drawing.Size(150, 182);
            this.levelGroupBox.TabIndex = 2;
            this.levelGroupBox.TabStop = false;
            this.levelGroupBox.Text = "Choose Level:";
            // 
            // freshmanRBtn
            // 
            this.freshmanRBtn.AutoSize = true;
            this.freshmanRBtn.Location = new System.Drawing.Point(10, 137);
            this.freshmanRBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.freshmanRBtn.Name = "freshmanRBtn";
            this.freshmanRBtn.Size = new System.Drawing.Size(106, 24);
            this.freshmanRBtn.TabIndex = 3;
            this.freshmanRBtn.Text = "Freshman";
            this.freshmanRBtn.UseVisualStyleBackColor = true;
            // 
            // sophomoreRBtn
            // 
            this.sophomoreRBtn.AutoSize = true;
            this.sophomoreRBtn.Location = new System.Drawing.Point(10, 102);
            this.sophomoreRBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sophomoreRBtn.Name = "sophomoreRBtn";
            this.sophomoreRBtn.Size = new System.Drawing.Size(117, 24);
            this.sophomoreRBtn.TabIndex = 2;
            this.sophomoreRBtn.Text = "Sophomore";
            this.sophomoreRBtn.UseVisualStyleBackColor = true;
            // 
            // juniorRBtn
            // 
            this.juniorRBtn.AutoSize = true;
            this.juniorRBtn.Location = new System.Drawing.Point(10, 66);
            this.juniorRBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.juniorRBtn.Name = "juniorRBtn";
            this.juniorRBtn.Size = new System.Drawing.Size(77, 24);
            this.juniorRBtn.TabIndex = 1;
            this.juniorRBtn.Text = "Junior";
            this.juniorRBtn.UseVisualStyleBackColor = true;
            // 
            // seniorRBtn
            // 
            this.seniorRBtn.AutoSize = true;
            this.seniorRBtn.Checked = true;
            this.seniorRBtn.Location = new System.Drawing.Point(10, 31);
            this.seniorRBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seniorRBtn.Name = "seniorRBtn";
            this.seniorRBtn.Size = new System.Drawing.Size(80, 24);
            this.seniorRBtn.TabIndex = 0;
            this.seniorRBtn.TabStop = true;
            this.seniorRBtn.Text = "Senior";
            this.seniorRBtn.UseVisualStyleBackColor = true;
            // 
            // RegForm
            // 
            this.AcceptButton = this.findRegTimeBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 409);
            this.Controls.Add(this.dateTimeLbl);
            this.Controls.Add(this.RegLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.findRegTimeBtn);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.levelGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegForm";
            this.Text = "Program 3";
            this.levelGroupBox.ResumeLayout(false);
            this.levelGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Button findRegTimeBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label RegLbl;
        private System.Windows.Forms.Label dateTimeLbl;
        private System.Windows.Forms.GroupBox levelGroupBox;
        private System.Windows.Forms.RadioButton freshmanRBtn;
        private System.Windows.Forms.RadioButton sophomoreRBtn;
        private System.Windows.Forms.RadioButton juniorRBtn;
        private System.Windows.Forms.RadioButton seniorRBtn;
    }
}


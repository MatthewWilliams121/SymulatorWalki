namespace index
{
    partial class PopUpForm
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
            this.checkBoxNATO = new System.Windows.Forms.CheckBox();
            this.checkBoxCSTO = new System.Windows.Forms.CheckBox();
            this.unitNameLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unitSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unitNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.unitKind = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureType = new System.Windows.Forms.PictureBox();
            this.pictureSize = new System.Windows.Forms.PictureBox();
            this.saveUnitButton = new System.Windows.Forms.Button();
            this.cancelUnitButton = new System.Windows.Forms.Button();
            this.captionUnitName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSize)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxNATO
            // 
            this.checkBoxNATO.AutoSize = true;
            this.checkBoxNATO.Location = new System.Drawing.Point(104, 96);
            this.checkBoxNATO.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxNATO.Name = "checkBoxNATO";
            this.checkBoxNATO.Size = new System.Drawing.Size(56, 17);
            this.checkBoxNATO.TabIndex = 0;
            this.checkBoxNATO.Text = "NATO";
            this.checkBoxNATO.UseVisualStyleBackColor = true;
            this.checkBoxNATO.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxCSTO
            // 
            this.checkBoxCSTO.AutoSize = true;
            this.checkBoxCSTO.Location = new System.Drawing.Point(105, 117);
            this.checkBoxCSTO.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCSTO.Name = "checkBoxCSTO";
            this.checkBoxCSTO.Size = new System.Drawing.Size(55, 17);
            this.checkBoxCSTO.TabIndex = 1;
            this.checkBoxCSTO.Text = "CSTO";
            this.checkBoxCSTO.UseVisualStyleBackColor = true;
            this.checkBoxCSTO.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // unitNameLabel
            // 
            this.unitNameLabel.Location = new System.Drawing.Point(104, 66);
            this.unitNameLabel.Margin = new System.Windows.Forms.Padding(2);
            this.unitNameLabel.Name = "unitNameLabel";
            this.unitNameLabel.Size = new System.Drawing.Size(122, 20);
            this.unitNameLabel.TabIndex = 3;
            this.unitNameLabel.TextChanged += new System.EventHandler(this.UnitName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa jednostki";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // unitSizeComboBox
            // 
            this.unitSizeComboBox.FormattingEnabled = true;
            this.unitSizeComboBox.Location = new System.Drawing.Point(262, 59);
            this.unitSizeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.unitSizeComboBox.Name = "unitSizeComboBox";
            this.unitSizeComboBox.Size = new System.Drawing.Size(92, 21);
            this.unitSizeComboBox.TabIndex = 5;
            this.unitSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rozmiar jednostki";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // unitNumber
            // 
            this.unitNumber.Location = new System.Drawing.Point(105, 43);
            this.unitNumber.Margin = new System.Windows.Forms.Padding(2);
            this.unitNumber.Name = "unitNumber";
            this.unitNumber.Size = new System.Drawing.Size(36, 20);
            this.unitNumber.TabIndex = 7;
            this.unitNumber.TextChanged += new System.EventHandler(this.UnitNumber_textChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nr jednostki";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // unitKind
            // 
            this.unitKind.FormattingEnabled = true;
            this.unitKind.Location = new System.Drawing.Point(104, 145);
            this.unitKind.Margin = new System.Windows.Forms.Padding(2);
            this.unitKind.Name = "unitKind";
            this.unitKind.Size = new System.Drawing.Size(92, 21);
            this.unitKind.TabIndex = 11;
            this.unitKind.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rodzaj jednostki";
            // 
            // pictureType
            // 
            this.pictureType.Location = new System.Drawing.Point(406, 255);
            this.pictureType.Margin = new System.Windows.Forms.Padding(2);
            this.pictureType.Name = "pictureType";
            this.pictureType.Size = new System.Drawing.Size(134, 89);
            this.pictureType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureType.TabIndex = 13;
            this.pictureType.TabStop = false;
            // 
            // pictureSize
            // 
            this.pictureSize.Location = new System.Drawing.Point(447, 220);
            this.pictureSize.Margin = new System.Windows.Forms.Padding(2);
            this.pictureSize.Name = "pictureSize";
            this.pictureSize.Size = new System.Drawing.Size(53, 30);
            this.pictureSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSize.TabIndex = 10;
            this.pictureSize.TabStop = false;
            this.pictureSize.Click += new System.EventHandler(this.pictureSize_Click);
            // 
            // saveUnitButton
            // 
            this.saveUnitButton.Location = new System.Drawing.Point(146, 318);
            this.saveUnitButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveUnitButton.Name = "saveUnitButton";
            this.saveUnitButton.Size = new System.Drawing.Size(96, 26);
            this.saveUnitButton.TabIndex = 14;
            this.saveUnitButton.Text = "Zatwierdź";
            this.saveUnitButton.UseVisualStyleBackColor = true;
            this.saveUnitButton.Click += new System.EventHandler(this.saveUnitButton_Click);
            // 
            // cancelUnitButton
            // 
            this.cancelUnitButton.Location = new System.Drawing.Point(28, 317);
            this.cancelUnitButton.Name = "cancelUnitButton";
            this.cancelUnitButton.Size = new System.Drawing.Size(96, 27);
            this.cancelUnitButton.TabIndex = 15;
            this.cancelUnitButton.Text = "Wróć";
            this.cancelUnitButton.UseVisualStyleBackColor = true;
            this.cancelUnitButton.Click += new System.EventHandler(this.cancelUnitButton_Click);
            // 
            // captionUnitName
            // 
            this.captionUnitName.Location = new System.Drawing.Point(406, 357);
            this.captionUnitName.Name = "captionUnitName";
            this.captionUnitName.Size = new System.Drawing.Size(133, 22);
            this.captionUnitName.TabIndex = 16;
            this.captionUnitName.Text = "label6";
            // 
            // PopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(750, 457);
            this.Controls.Add(this.captionUnitName);
            this.Controls.Add(this.cancelUnitButton);
            this.Controls.Add(this.saveUnitButton);
            this.Controls.Add(this.pictureType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.unitKind);
            this.Controls.Add(this.pictureSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unitNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unitSizeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unitNameLabel);
            this.Controls.Add(this.checkBoxCSTO);
            this.Controls.Add(this.checkBoxNATO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PopUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label captionUnitName;

        private System.Windows.Forms.Button cancelUnitButton;

        #endregion

        private System.Windows.Forms.CheckBox checkBoxNATO;
        private System.Windows.Forms.CheckBox checkBoxCSTO;
        private System.Windows.Forms.TextBox unitNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox unitSizeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unitNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureSize;
        private System.Windows.Forms.ComboBox unitKind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureType;
        private System.Windows.Forms.Button saveUnitButton;
    }
}
namespace index
{
    partial class Form2
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.unitNameLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unitSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unitNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureType = new System.Windows.Forms.PictureBox();
            this.pictureSize = new System.Windows.Forms.PictureBox();
            this.saveUnitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSize)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(139, 118);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "NATO";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(140, 144);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(63, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "CSTO";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // unitNameLabel
            // 
            this.unitNameLabel.Location = new System.Drawing.Point(139, 81);
            this.unitNameLabel.Name = "unitNameLabel";
            this.unitNameLabel.Size = new System.Drawing.Size(162, 22);
            this.unitNameLabel.TabIndex = 3;
            this.unitNameLabel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa jednostki";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // unitSizeComboBox
            // 
            this.unitSizeComboBox.FormattingEnabled = true;
            this.unitSizeComboBox.Location = new System.Drawing.Point(349, 73);
            this.unitSizeComboBox.Name = "unitSizeComboBox";
            this.unitSizeComboBox.Size = new System.Drawing.Size(121, 24);
            this.unitSizeComboBox.TabIndex = 5;
            this.unitSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rozmiar jednostki";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // unitNumber
            // 
            this.unitNumber.Location = new System.Drawing.Point(140, 53);
            this.unitNumber.Name = "unitNumber";
            this.unitNumber.Size = new System.Drawing.Size(48, 22);
            this.unitNumber.TabIndex = 7;
            this.unitNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nr jednostki";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(139, 179);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rodzaj jednostki";
            // 
            // pictureType
            // 
            this.pictureType.Location = new System.Drawing.Point(541, 314);
            this.pictureType.Name = "pictureType";
            this.pictureType.Size = new System.Drawing.Size(179, 110);
            this.pictureType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureType.TabIndex = 13;
            this.pictureType.TabStop = false;
            // 
            // pictureSize
            // 
            this.pictureSize.Location = new System.Drawing.Point(596, 271);
            this.pictureSize.Name = "pictureSize";
            this.pictureSize.Size = new System.Drawing.Size(71, 37);
            this.pictureSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSize.TabIndex = 10;
            this.pictureSize.TabStop = false;
            this.pictureSize.Click += new System.EventHandler(this.pictureSize_Click);
            // 
            // saveUnitButton
            // 
            this.saveUnitButton.Location = new System.Drawing.Point(157, 381);
            this.saveUnitButton.Name = "saveUnitButton";
            this.saveUnitButton.Size = new System.Drawing.Size(128, 32);
            this.saveUnitButton.TabIndex = 14;
            this.saveUnitButton.Text = "Zatwierdź";
            this.saveUnitButton.UseVisualStyleBackColor = true;
            this.saveUnitButton.Click += new System.EventHandler(this.saveUnitButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.saveUnitButton);
            this.Controls.Add(this.pictureType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.pictureSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unitNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unitSizeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unitNameLabel);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form2";
            this.Text = "Dodawanie jednostki";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox unitNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox unitSizeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unitNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureSize;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureType;
        private System.Windows.Forms.Button saveUnitButton;
    }
}
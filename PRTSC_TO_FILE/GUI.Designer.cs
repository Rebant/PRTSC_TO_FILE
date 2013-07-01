namespace PRTSC_TO_FILE
{
    partial class GUI
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
            this.directoryButton = new System.Windows.Forms.Button();
            this.directoryText = new System.Windows.Forms.RichTextBox();
            this.closeCheckBox = new System.Windows.Forms.CheckBox();
            this.imageFormatList = new System.Windows.Forms.ComboBox();
            this.imageFormatLabel = new System.Windows.Forms.Label();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.outputExampleTextField = new System.Windows.Forms.RichTextBox();
            this.outputFormatCombo = new System.Windows.Forms.ComboBox();
            this.outputExampleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directoryButton
            // 
            this.directoryButton.Location = new System.Drawing.Point(204, 34);
            this.directoryButton.Name = "directoryButton";
            this.directoryButton.Size = new System.Drawing.Size(68, 27);
            this.directoryButton.TabIndex = 0;
            this.directoryButton.Text = "Apply";
            this.directoryButton.UseVisualStyleBackColor = true;
            this.directoryButton.Click += new System.EventHandler(this.directoryButton_Click);
            // 
            // directoryText
            // 
            this.directoryText.Location = new System.Drawing.Point(12, 34);
            this.directoryText.Name = "directoryText";
            this.directoryText.Size = new System.Drawing.Size(186, 27);
            this.directoryText.TabIndex = 1;
            this.directoryText.Text = "C:\\Testing\\output";
            // 
            // closeCheckBox
            // 
            this.closeCheckBox.AutoSize = true;
            this.closeCheckBox.Location = new System.Drawing.Point(185, 154);
            this.closeCheckBox.Name = "closeCheckBox";
            this.closeCheckBox.Size = new System.Drawing.Size(87, 17);
            this.closeCheckBox.TabIndex = 2;
            this.closeCheckBox.Text = "Close on Exit";
            this.closeCheckBox.UseVisualStyleBackColor = true;
            // 
            // imageFormatList
            // 
            this.imageFormatList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imageFormatList.FormattingEnabled = true;
            this.imageFormatList.Items.AddRange(new object[] {
            "Bmp",
            "Emf",
            "Exif",
            "Gif",
            "Guid",
            "Icon",
            "Jpeg",
            "MemoryBmp",
            "Png",
            "Tiff",
            "Wmf"});
            this.imageFormatList.Location = new System.Drawing.Point(84, 67);
            this.imageFormatList.Name = "imageFormatList";
            this.imageFormatList.Size = new System.Drawing.Size(114, 21);
            this.imageFormatList.TabIndex = 3;
            this.imageFormatList.SelectedIndexChanged += new System.EventHandler(this.imageFormatList_SelectedIndexChanged);
            // 
            // imageFormatLabel
            // 
            this.imageFormatLabel.AutoSize = true;
            this.imageFormatLabel.Location = new System.Drawing.Point(12, 70);
            this.imageFormatLabel.Name = "imageFormatLabel";
            this.imageFormatLabel.Size = new System.Drawing.Size(71, 13);
            this.imageFormatLabel.TabIndex = 4;
            this.imageFormatLabel.Text = "Image Format";
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directoryLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.directoryLabel.Location = new System.Drawing.Point(8, 9);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(81, 20);
            this.directoryLabel.TabIndex = 5;
            this.directoryLabel.Text = "Directory";
            this.directoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputExampleTextField
            // 
            this.outputExampleTextField.Location = new System.Drawing.Point(12, 124);
            this.outputExampleTextField.Name = "outputExampleTextField";
            this.outputExampleTextField.Size = new System.Drawing.Size(260, 24);
            this.outputExampleTextField.TabIndex = 6;
            this.outputExampleTextField.Text = "";
            // 
            // outputFormatCombo
            // 
            this.outputFormatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputFormatCombo.FormattingEnabled = true;
            this.outputFormatCombo.Items.AddRange(new object[] {
            "Number",
            "Date/Time",
            "Custom"});
            this.outputFormatCombo.Location = new System.Drawing.Point(12, 154);
            this.outputFormatCombo.Name = "outputFormatCombo";
            this.outputFormatCombo.Size = new System.Drawing.Size(125, 21);
            this.outputFormatCombo.TabIndex = 7;
            this.outputFormatCombo.SelectedIndexChanged += new System.EventHandler(this.outputFormatCombo_SelectedIndexChanged);
            // 
            // outputExampleLabel
            // 
            this.outputExampleLabel.AutoSize = true;
            this.outputExampleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputExampleLabel.Location = new System.Drawing.Point(8, 101);
            this.outputExampleLabel.Name = "outputExampleLabel";
            this.outputExampleLabel.Size = new System.Drawing.Size(64, 20);
            this.outputExampleLabel.TabIndex = 8;
            this.outputExampleLabel.Text = "Output";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.outputExampleLabel);
            this.Controls.Add(this.outputFormatCombo);
            this.Controls.Add(this.outputExampleTextField);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.imageFormatLabel);
            this.Controls.Add(this.imageFormatList);
            this.Controls.Add(this.closeCheckBox);
            this.Controls.Add(this.directoryText);
            this.Controls.Add(this.directoryButton);
            this.Name = "GUI";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button directoryButton;
        private System.Windows.Forms.RichTextBox directoryText;
        private System.Windows.Forms.CheckBox closeCheckBox;
        private System.Windows.Forms.ComboBox imageFormatList;
        private System.Windows.Forms.Label imageFormatLabel;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.RichTextBox outputExampleTextField;
        private System.Windows.Forms.ComboBox outputFormatCombo;
        private System.Windows.Forms.Label outputExampleLabel;
    }
}


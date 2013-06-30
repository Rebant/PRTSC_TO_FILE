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
            this.SuspendLayout();
            // 
            // directoryButton
            // 
            this.directoryButton.Location = new System.Drawing.Point(204, 95);
            this.directoryButton.Name = "directoryButton";
            this.directoryButton.Size = new System.Drawing.Size(68, 27);
            this.directoryButton.TabIndex = 0;
            this.directoryButton.Text = "Done";
            this.directoryButton.UseVisualStyleBackColor = true;
            this.directoryButton.Click += new System.EventHandler(this.directoryButton_Click);
            // 
            // directoryText
            // 
            this.directoryText.Location = new System.Drawing.Point(12, 95);
            this.directoryText.Name = "directoryText";
            this.directoryText.Size = new System.Drawing.Size(186, 27);
            this.directoryText.TabIndex = 1;
            this.directoryText.Text = "";
            this.directoryText.TextChanged += new System.EventHandler(this.directoryButton_TextChanged);
            // 
            // closeCheckBox
            // 
            this.closeCheckBox.AutoSize = true;
            this.closeCheckBox.Location = new System.Drawing.Point(192, 233);
            this.closeCheckBox.Name = "closeCheckBox";
            this.closeCheckBox.Size = new System.Drawing.Size(87, 17);
            this.closeCheckBox.TabIndex = 2;
            this.closeCheckBox.Text = "Close on Exit";
            this.closeCheckBox.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.closeCheckBox);
            this.Controls.Add(this.directoryText);
            this.Controls.Add(this.directoryButton);
            this.Name = "GUI";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button directoryButton;
        private System.Windows.Forms.RichTextBox directoryText;
        private System.Windows.Forms.CheckBox closeCheckBox;
    }
}


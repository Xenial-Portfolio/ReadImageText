namespace ReadImageText
{
    partial class ReadImageText
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
            this.imagePath = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // imagePath
            // 
            this.imagePath.Location = new System.Drawing.Point(12, 12);
            this.imagePath.Name = "imagePath";
            this.imagePath.Size = new System.Drawing.Size(238, 20);
            this.imagePath.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 38);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(238, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(13, 68);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(237, 287);
            this.outputTextBox.TabIndex = 2;
            // 
            // ReadImageText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 367);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.imagePath);
            this.Name = "ReadImageText";
            this.Text = "Read Text From Image";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imagePath;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}


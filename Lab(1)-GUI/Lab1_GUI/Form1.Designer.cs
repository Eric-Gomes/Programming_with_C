namespace Lab1_GUI
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
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.colourCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(441, 197);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(778, 20);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // colourCheckBox
            // 
            this.colourCheckBox.AutoSize = true;
            this.colourCheckBox.Checked = true;
            this.colourCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.colourCheckBox.Location = new System.Drawing.Point(730, 318);
            this.colourCheckBox.Name = "colourCheckBox";
            this.colourCheckBox.Size = new System.Drawing.Size(80, 17);
            this.colourCheckBox.TabIndex = 2;
            this.colourCheckBox.Text = "checkBox1";
            this.colourCheckBox.UseVisualStyleBackColor = true;
            this.colourCheckBox.CheckedChanged += new System.EventHandler(this.colourCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 681);
            this.Controls.Add(this.colourCheckBox);
            this.Controls.Add(this.messageTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.CheckBox colourCheckBox;
    }
}


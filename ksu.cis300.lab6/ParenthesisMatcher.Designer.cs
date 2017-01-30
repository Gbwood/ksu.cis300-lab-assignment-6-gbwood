namespace ksu.cis300.lab6
{
    partial class ParenthesisMatcher
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
            this.uxTextEntry = new System.Windows.Forms.TextBox();
            this.uxCheckButton = new System.Windows.Forms.Button();
            this.uxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxTextEntry
            // 
            this.uxTextEntry.Location = new System.Drawing.Point(78, 12);
            this.uxTextEntry.Name = "uxTextEntry";
            this.uxTextEntry.Size = new System.Drawing.Size(209, 20);
            this.uxTextEntry.TabIndex = 0;
            // 
            // uxCheckButton
            // 
            this.uxCheckButton.Location = new System.Drawing.Point(78, 38);
            this.uxCheckButton.Name = "uxCheckButton";
            this.uxCheckButton.Size = new System.Drawing.Size(209, 23);
            this.uxCheckButton.TabIndex = 1;
            this.uxCheckButton.Text = "Check";
            this.uxCheckButton.UseVisualStyleBackColor = true;
            this.uxCheckButton.Click += new System.EventHandler(this.uxCheckButton_Click);
            // 
            // uxLabel
            // 
            this.uxLabel.AutoSize = true;
            this.uxLabel.Location = new System.Drawing.Point(10, 15);
            this.uxLabel.Name = "uxLabel";
            this.uxLabel.Size = new System.Drawing.Size(62, 13);
            this.uxLabel.TabIndex = 2;
            this.uxLabel.Text = "Enter String";
            // 
            // ParenthesisMatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 73);
            this.Controls.Add(this.uxLabel);
            this.Controls.Add(this.uxCheckButton);
            this.Controls.Add(this.uxTextEntry);
            this.Name = "ParenthesisMatcher";
            this.Text = "Parenthesis Matcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTextEntry;
        private System.Windows.Forms.Button uxCheckButton;
        private System.Windows.Forms.Label uxLabel;
    }
}


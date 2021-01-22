
namespace IntegerTryAndParse
{
    partial class MainWindow
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
            this.integer1Label = new System.Windows.Forms.Label();
            this.integer2Label = new System.Windows.Forms.Label();
            this.integer1TB = new System.Windows.Forms.TextBox();
            this.integer2TB = new System.Windows.Forms.TextBox();
            this.tryParseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // integer1Label
            // 
            this.integer1Label.AutoSize = true;
            this.integer1Label.Location = new System.Drawing.Point(13, 13);
            this.integer1Label.Name = "integer1Label";
            this.integer1Label.Size = new System.Drawing.Size(77, 20);
            this.integer1Label.TabIndex = 0;
            this.integer1Label.Text = "Integer 1:";
            this.integer1Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // integer2Label
            // 
            this.integer2Label.AutoSize = true;
            this.integer2Label.Location = new System.Drawing.Point(12, 53);
            this.integer2Label.Name = "integer2Label";
            this.integer2Label.Size = new System.Drawing.Size(77, 20);
            this.integer2Label.TabIndex = 1;
            this.integer2Label.Text = "Integer 2:";
            // 
            // integer1TB
            // 
            this.integer1TB.Location = new System.Drawing.Point(96, 13);
            this.integer1TB.Name = "integer1TB";
            this.integer1TB.Size = new System.Drawing.Size(150, 26);
            this.integer1TB.TabIndex = 2;
            // 
            // integer2TB
            // 
            this.integer2TB.Location = new System.Drawing.Point(95, 53);
            this.integer2TB.Name = "integer2TB";
            this.integer2TB.Size = new System.Drawing.Size(150, 26);
            this.integer2TB.TabIndex = 3;
            // 
            // tryParseButton
            // 
            this.tryParseButton.Location = new System.Drawing.Point(16, 89);
            this.tryParseButton.Name = "tryParseButton";
            this.tryParseButton.Size = new System.Drawing.Size(229, 43);
            this.tryParseButton.TabIndex = 4;
            this.tryParseButton.Text = "Try to Parse!";
            this.tryParseButton.UseVisualStyleBackColor = true;
            this.tryParseButton.Click += new System.EventHandler(this.tryParseButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 140);
            this.Controls.Add(this.tryParseButton);
            this.Controls.Add(this.integer2TB);
            this.Controls.Add(this.integer1TB);
            this.Controls.Add(this.integer2Label);
            this.Controls.Add(this.integer1Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.Text = "Try And Parse Integers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label integer1Label;
        private System.Windows.Forms.Label integer2Label;
        private System.Windows.Forms.TextBox integer1TB;
        private System.Windows.Forms.TextBox integer2TB;
        private System.Windows.Forms.Button tryParseButton;
    }
}



namespace Time_Zone_Selector
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.timeZoneDescriptionLabel = new System.Windows.Forms.Label();
            this.timeZoneOutputLabel = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.cityListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(30, 24);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(331, 16);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Select a city and the program will tell you the time zone.";
            // 
            // timeZoneDescriptionLabel
            // 
            this.timeZoneDescriptionLabel.AutoSize = true;
            this.timeZoneDescriptionLabel.Location = new System.Drawing.Point(47, 175);
            this.timeZoneDescriptionLabel.Name = "timeZoneDescriptionLabel";
            this.timeZoneDescriptionLabel.Size = new System.Drawing.Size(76, 16);
            this.timeZoneDescriptionLabel.TabIndex = 1;
            this.timeZoneDescriptionLabel.Text = "Time Zone:";
            // 
            // timeZoneOutputLabel
            // 
            this.timeZoneOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeZoneOutputLabel.Location = new System.Drawing.Point(129, 175);
            this.timeZoneOutputLabel.Name = "timeZoneOutputLabel";
            this.timeZoneOutputLabel.Size = new System.Drawing.Size(207, 20);
            this.timeZoneOutputLabel.TabIndex = 2;
            this.timeZoneOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(29, 224);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(96, 28);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "S&elect";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(259, 224);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 28);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(145, 224);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(96, 28);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // cityListBox
            // 
            this.cityListBox.BackColor = System.Drawing.Color.Gainsboro;
            this.cityListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityListBox.FormattingEnabled = true;
            this.cityListBox.ItemHeight = 18;
            this.cityListBox.Items.AddRange(new object[] {
            "Denver",
            "Honolulu",
            "Minneapolis",
            "New York",
            "San Francisco"});
            this.cityListBox.Location = new System.Drawing.Point(131, 55);
            this.cityListBox.Name = "cityListBox";
            this.cityListBox.Size = new System.Drawing.Size(133, 94);
            this.cityListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(385, 272);
            this.Controls.Add(this.cityListBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.timeZoneOutputLabel);
            this.Controls.Add(this.timeZoneDescriptionLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Time Zone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label timeZoneDescriptionLabel;
        private System.Windows.Forms.Label timeZoneOutputLabel;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox cityListBox;
    }
}


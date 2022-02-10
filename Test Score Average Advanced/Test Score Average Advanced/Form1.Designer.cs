
namespace Test_Score_Average_Advanced
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
            this.aveGroupBox = new System.Windows.Forms.GroupBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.avgOutputLabel = new System.Windows.Forms.Label();
            this.avgLabel = new System.Windows.Forms.Label();
            this.test3Label = new System.Windows.Forms.Label();
            this.test2Label = new System.Windows.Forms.Label();
            this.test1Label = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.aveGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // aveGroupBox
            // 
            this.aveGroupBox.Controls.Add(this.test3TextBox);
            this.aveGroupBox.Controls.Add(this.test2TextBox);
            this.aveGroupBox.Controls.Add(this.test1TextBox);
            this.aveGroupBox.Controls.Add(this.avgOutputLabel);
            this.aveGroupBox.Controls.Add(this.avgLabel);
            this.aveGroupBox.Controls.Add(this.test3Label);
            this.aveGroupBox.Controls.Add(this.test2Label);
            this.aveGroupBox.Controls.Add(this.test1Label);
            this.aveGroupBox.Location = new System.Drawing.Point(22, 24);
            this.aveGroupBox.Name = "aveGroupBox";
            this.aveGroupBox.Size = new System.Drawing.Size(254, 174);
            this.aveGroupBox.TabIndex = 0;
            this.aveGroupBox.TabStop = false;
            this.aveGroupBox.Text = "Enter Three Test Scores";
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(134, 98);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(100, 20);
            this.test3TextBox.TabIndex = 7;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(134, 66);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(100, 20);
            this.test2TextBox.TabIndex = 6;
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(134, 34);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(100, 20);
            this.test1TextBox.TabIndex = 5;
            // 
            // avgOutputLabel
            // 
            this.avgOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgOutputLabel.Location = new System.Drawing.Point(134, 134);
            this.avgOutputLabel.Name = "avgOutputLabel";
            this.avgOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.avgOutputLabel.TabIndex = 4;
            this.avgOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avgLabel
            // 
            this.avgLabel.AutoSize = true;
            this.avgLabel.Location = new System.Drawing.Point(60, 139);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(47, 13);
            this.avgLabel.TabIndex = 3;
            this.avgLabel.Text = "Average";
            // 
            // test3Label
            // 
            this.test3Label.AutoSize = true;
            this.test3Label.Location = new System.Drawing.Point(32, 101);
            this.test3Label.Name = "test3Label";
            this.test3Label.Size = new System.Drawing.Size(75, 13);
            this.test3Label.TabIndex = 2;
            this.test3Label.Text = "Test Score #3";
            // 
            // test2Label
            // 
            this.test2Label.AutoSize = true;
            this.test2Label.Location = new System.Drawing.Point(32, 69);
            this.test2Label.Name = "test2Label";
            this.test2Label.Size = new System.Drawing.Size(75, 13);
            this.test2Label.TabIndex = 1;
            this.test2Label.Text = "Test Score #2\r\n";
            // 
            // test1Label
            // 
            this.test1Label.AutoSize = true;
            this.test1Label.Location = new System.Drawing.Point(32, 37);
            this.test1Label.Name = "test1Label";
            this.test1Label.Size = new System.Drawing.Size(75, 13);
            this.test1Label.TabIndex = 0;
            this.test1Label.Text = "Test Score #1";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(64, 215);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(81, 59);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "Calculate Average";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(158, 215);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(158, 251);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 289);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.aveGroupBox);
            this.Name = "Form1";
            this.Text = "Test Score Average Calculator";
            this.aveGroupBox.ResumeLayout(false);
            this.aveGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox aveGroupBox;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.Label avgOutputLabel;
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Label test3Label;
        private System.Windows.Forms.Label test2Label;
        private System.Windows.Forms.Label test1Label;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}


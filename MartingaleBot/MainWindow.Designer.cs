namespace MartingaleBot
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
            this.browser = new Gecko.GeckoWebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colourCombo = new System.Windows.Forms.ComboBox();
            this.startCreditsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startAmountTextbox = new System.Windows.Forms.MaskedTextBox();
            this.concurWinLabel = new System.Windows.Forms.Label();
            this.concurLossLabel = new System.Windows.Forms.Label();
            this.winsLabel = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(378, 12);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(394, 388);
            this.browser.TabIndex = 0;
            this.browser.UseHttpActivityObserver = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.colourCombo);
            this.groupBox1.Controls.Add(this.startCreditsLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.startAmountTextbox);
            this.groupBox1.Controls.Add(this.concurWinLabel);
            this.groupBox1.Controls.Add(this.concurLossLabel);
            this.groupBox1.Controls.Add(this.winsLabel);
            this.groupBox1.Controls.Add(this.creditsLabel);
            this.groupBox1.Controls.Add(this.userLabel);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.stopCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 388);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Colour";
            // 
            // colourCombo
            // 
            this.colourCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colourCombo.FormattingEnabled = true;
            this.colourCombo.Items.AddRange(new object[] {
            "red",
            "black"});
            this.colourCombo.Location = new System.Drawing.Point(279, 256);
            this.colourCombo.Name = "colourCombo";
            this.colourCombo.Size = new System.Drawing.Size(75, 21);
            this.colourCombo.TabIndex = 10;
            // 
            // startCreditsLabel
            // 
            this.startCreditsLabel.AutoSize = true;
            this.startCreditsLabel.Location = new System.Drawing.Point(6, 79);
            this.startCreditsLabel.Name = "startCreditsLabel";
            this.startCreditsLabel.Size = new System.Drawing.Size(80, 13);
            this.startCreditsLabel.TabIndex = 9;
            this.startCreditsLabel.Text = "Credits on start:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Start amount";
            // 
            // startAmountTextbox
            // 
            this.startAmountTextbox.Location = new System.Drawing.Point(279, 324);
            this.startAmountTextbox.Name = "startAmountTextbox";
            this.startAmountTextbox.Size = new System.Drawing.Size(75, 20);
            this.startAmountTextbox.TabIndex = 7;
            this.startAmountTextbox.Text = "1";
            // 
            // concurWinLabel
            // 
            this.concurWinLabel.AutoSize = true;
            this.concurWinLabel.Location = new System.Drawing.Point(6, 115);
            this.concurWinLabel.Name = "concurWinLabel";
            this.concurWinLabel.Size = new System.Drawing.Size(89, 13);
            this.concurWinLabel.TabIndex = 6;
            this.concurWinLabel.Text = "Concurrent Wins:";
            // 
            // concurLossLabel
            // 
            this.concurLossLabel.AutoSize = true;
            this.concurLossLabel.Location = new System.Drawing.Point(6, 102);
            this.concurLossLabel.Name = "concurLossLabel";
            this.concurLossLabel.Size = new System.Drawing.Size(94, 13);
            this.concurLossLabel.TabIndex = 5;
            this.concurLossLabel.Text = "Concurrent losses:";
            // 
            // winsLabel
            // 
            this.winsLabel.AutoSize = true;
            this.winsLabel.Location = new System.Drawing.Point(6, 53);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(34, 13);
            this.winsLabel.TabIndex = 4;
            this.winsLabel.Text = "Wins:";
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Location = new System.Drawing.Point(6, 40);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(42, 13);
            this.creditsLabel.TabIndex = 3;
            this.creditsLabel.Text = "Credits:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(6, 27);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(35, 13);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "User: ";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(279, 359);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopCheckbox
            // 
            this.stopCheckbox.AutoSize = true;
            this.stopCheckbox.Location = new System.Drawing.Point(6, 363);
            this.stopCheckbox.Name = "stopCheckbox";
            this.stopCheckbox.Size = new System.Drawing.Size(114, 17);
            this.stopCheckbox.TabIndex = 0;
            this.stopCheckbox.Text = "Stop after next win";
            this.stopCheckbox.UseVisualStyleBackColor = true;
            this.stopCheckbox.CheckedChanged += new System.EventHandler(this.setStopNext);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.browser);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Martingale Bot - Lemondragon";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gecko.GeckoWebBrowser browser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox stopCheckbox;
        private System.Windows.Forms.Label concurWinLabel;
        private System.Windows.Forms.Label concurLossLabel;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label startCreditsLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox startAmountTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox colourCombo;
    }
}


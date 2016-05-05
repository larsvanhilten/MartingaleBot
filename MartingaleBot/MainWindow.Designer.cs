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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.browser = new Gecko.GeckoWebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stopCreditsCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stopNumeric = new System.Windows.Forms.NumericUpDown();
            this.startAmountNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.colourCombo = new System.Windows.Forms.ComboBox();
            this.startCreditsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.concurWinLabel = new System.Windows.Forms.Label();
            this.concurLossLabel = new System.Windows.Forms.Label();
            this.winsLabel = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopCheckbox = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAmountNumeric)).BeginInit();
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
            this.groupBox1.Controls.Add(this.stopCreditsCheckbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.stopNumeric);
            this.groupBox1.Controls.Add(this.startAmountNumeric);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.colourCombo);
            this.groupBox1.Controls.Add(this.startCreditsLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.concurWinLabel);
            this.groupBox1.Controls.Add(this.concurLossLabel);
            this.groupBox1.Controls.Add(this.winsLabel);
            this.groupBox1.Controls.Add(this.creditsLabel);
            this.groupBox1.Controls.Add(this.userLabel);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.stopCheckbox);
            this.groupBox1.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 388);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // stopCreditsCheckbox
            // 
            this.stopCreditsCheckbox.AutoSize = true;
            this.stopCreditsCheckbox.Location = new System.Drawing.Point(6, 327);
            this.stopCreditsCheckbox.Name = "stopCreditsCheckbox";
            this.stopCreditsCheckbox.Size = new System.Drawing.Size(15, 14);
            this.stopCreditsCheckbox.TabIndex = 15;
            this.stopCreditsCheckbox.UseVisualStyleBackColor = true;
            this.stopCreditsCheckbox.CheckedChanged += new System.EventHandler(this.setStopNext);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Stop after credits > :";
            // 
            // stopNumeric
            // 
            this.stopNumeric.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopNumeric.Location = new System.Drawing.Point(28, 324);
            this.stopNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.stopNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stopNumeric.Name = "stopNumeric";
            this.stopNumeric.Size = new System.Drawing.Size(114, 22);
            this.stopNumeric.TabIndex = 13;
            this.stopNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startAmountNumeric
            // 
            this.startAmountNumeric.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startAmountNumeric.Location = new System.Drawing.Point(268, 317);
            this.startAmountNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.startAmountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startAmountNumeric.Name = "startAmountNumeric";
            this.startAmountNumeric.Size = new System.Drawing.Size(85, 22);
            this.startAmountNumeric.TabIndex = 12;
            this.startAmountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Colour";
            // 
            // colourCombo
            // 
            this.colourCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colourCombo.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourCombo.FormattingEnabled = true;
            this.colourCombo.Items.AddRange(new object[] {
            "red",
            "black"});
            this.colourCombo.Location = new System.Drawing.Point(268, 256);
            this.colourCombo.Name = "colourCombo";
            this.colourCombo.Size = new System.Drawing.Size(85, 25);
            this.colourCombo.TabIndex = 10;
            // 
            // startCreditsLabel
            // 
            this.startCreditsLabel.AutoSize = true;
            this.startCreditsLabel.Font = new System.Drawing.Font("Ubuntu Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCreditsLabel.Location = new System.Drawing.Point(6, 45);
            this.startCreditsLabel.Name = "startCreditsLabel";
            this.startCreditsLabel.Size = new System.Drawing.Size(98, 18);
            this.startCreditsLabel.TabIndex = 9;
            this.startCreditsLabel.Text = "Credits on start:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Start amount";
            // 
            // concurWinLabel
            // 
            this.concurWinLabel.AutoSize = true;
            this.concurWinLabel.Font = new System.Drawing.Font("Ubuntu Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concurWinLabel.Location = new System.Drawing.Point(6, 140);
            this.concurWinLabel.Name = "concurWinLabel";
            this.concurWinLabel.Size = new System.Drawing.Size(103, 18);
            this.concurWinLabel.TabIndex = 6;
            this.concurWinLabel.Text = "Concurrent Wins:";
            // 
            // concurLossLabel
            // 
            this.concurLossLabel.AutoSize = true;
            this.concurLossLabel.Font = new System.Drawing.Font("Ubuntu Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concurLossLabel.Location = new System.Drawing.Point(6, 122);
            this.concurLossLabel.Name = "concurLossLabel";
            this.concurLossLabel.Size = new System.Drawing.Size(109, 18);
            this.concurLossLabel.TabIndex = 5;
            this.concurLossLabel.Text = "Concurrent losses:";
            // 
            // winsLabel
            // 
            this.winsLabel.AutoSize = true;
            this.winsLabel.Font = new System.Drawing.Font("Ubuntu Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsLabel.Location = new System.Drawing.Point(6, 92);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(38, 18);
            this.winsLabel.TabIndex = 4;
            this.winsLabel.Text = "Wins:";
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Font = new System.Drawing.Font("Ubuntu Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.Location = new System.Drawing.Point(6, 74);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(51, 18);
            this.creditsLabel.TabIndex = 3;
            this.creditsLabel.Text = "Credits:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Ubuntu Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(6, 27);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(39, 18);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "User: ";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(268, 357);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(86, 25);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopCheckbox
            // 
            this.stopCheckbox.AutoSize = true;
            this.stopCheckbox.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopCheckbox.Location = new System.Drawing.Point(6, 359);
            this.stopCheckbox.Name = "stopCheckbox";
            this.stopCheckbox.Size = new System.Drawing.Size(143, 21);
            this.stopCheckbox.TabIndex = 0;
            this.stopCheckbox.Text = "Stop after next win";
            this.stopCheckbox.UseVisualStyleBackColor = true;
            this.stopCheckbox.CheckedChanged += new System.EventHandler(this.setStopNext);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Martingale bot";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.iconDoubleClick);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.browser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Martingale Bot - Lemondragon";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.formResize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startAmountNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gecko.GeckoWebBrowser browser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label concurWinLabel;
        private System.Windows.Forms.Label concurLossLabel;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label startCreditsLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox colourCombo;
        private System.Windows.Forms.NumericUpDown startAmountNumeric;
        private System.Windows.Forms.NumericUpDown stopNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox stopCreditsCheckbox;
        private System.Windows.Forms.CheckBox stopCheckbox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}


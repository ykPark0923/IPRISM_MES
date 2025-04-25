namespace LotteMES.Forms
{
    partial class HardwareConfigurationForm
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
            this.buttonHeadCheck = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonApplyData = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxPrinterSetting = new System.Windows.Forms.GroupBox();
            this.comboBoxPrintSpeed = new System.Windows.Forms.ComboBox();
            this.comboBoxTemperatureSetting = new System.Windows.Forms.ComboBox();
            this.textBoxYPosition = new System.Windows.Forms.TextBox();
            this.labelYPosition = new System.Windows.Forms.Label();
            this.labelTemperatureSetting = new System.Windows.Forms.Label();
            this.textBoxXPosition = new System.Windows.Forms.TextBox();
            this.labelXPosition = new System.Windows.Forms.Label();
            this.labelPrintSpeed = new System.Windows.Forms.Label();
            this.groupBoxBarcodeFormatSetting = new System.Windows.Forms.GroupBox();
            this.comboBoxDateFormat = new System.Windows.Forms.ComboBox();
            this.radioButtonIgnoreSystemChange = new System.Windows.Forms.RadioButton();
            this.radioButtonApplySystemChange = new System.Windows.Forms.RadioButton();
            this.textBoxPalletDigits = new System.Windows.Forms.TextBox();
            this.labelPalletDigits = new System.Windows.Forms.Label();
            this.labelSystemChange = new System.Windows.Forms.Label();
            this.labelDateFormat = new System.Windows.Forms.Label();
            this.panelSplitBar = new System.Windows.Forms.Panel();
            this.groupBoxPrinterSetting.SuspendLayout();
            this.groupBoxBarcodeFormatSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHeadCheck
            // 
            this.buttonHeadCheck.Location = new System.Drawing.Point(12, 428);
            this.buttonHeadCheck.Name = "buttonHeadCheck";
            this.buttonHeadCheck.Size = new System.Drawing.Size(191, 70);
            this.buttonHeadCheck.TabIndex = 10;
            this.buttonHeadCheck.Text = "HEAD체크";
            this.buttonHeadCheck.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("굴림", 35F);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(320, 47);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "H/W 환경설정";
            // 
            // buttonApplyData
            // 
            this.buttonApplyData.Location = new System.Drawing.Point(224, 428);
            this.buttonApplyData.Name = "buttonApplyData";
            this.buttonApplyData.Size = new System.Drawing.Size(194, 70);
            this.buttonApplyData.TabIndex = 11;
            this.buttonApplyData.Text = "데이터 적용";
            this.buttonApplyData.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(438, 428);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(184, 70);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "닫기";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxPrinterSetting
            // 
            this.groupBoxPrinterSetting.Controls.Add(this.comboBoxPrintSpeed);
            this.groupBoxPrinterSetting.Controls.Add(this.comboBoxTemperatureSetting);
            this.groupBoxPrinterSetting.Controls.Add(this.textBoxYPosition);
            this.groupBoxPrinterSetting.Controls.Add(this.labelYPosition);
            this.groupBoxPrinterSetting.Controls.Add(this.labelTemperatureSetting);
            this.groupBoxPrinterSetting.Controls.Add(this.textBoxXPosition);
            this.groupBoxPrinterSetting.Controls.Add(this.labelXPosition);
            this.groupBoxPrinterSetting.Controls.Add(this.labelPrintSpeed);
            this.groupBoxPrinterSetting.Location = new System.Drawing.Point(20, 93);
            this.groupBoxPrinterSetting.Name = "groupBoxPrinterSetting";
            this.groupBoxPrinterSetting.Size = new System.Drawing.Size(580, 137);
            this.groupBoxPrinterSetting.TabIndex = 13;
            this.groupBoxPrinterSetting.TabStop = false;
            this.groupBoxPrinterSetting.Text = "프린터설정";
            // 
            // comboBoxPrintSpeed
            // 
            this.comboBoxPrintSpeed.FormattingEnabled = true;
            this.comboBoxPrintSpeed.Location = new System.Drawing.Point(434, 87);
            this.comboBoxPrintSpeed.Name = "comboBoxPrintSpeed";
            this.comboBoxPrintSpeed.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPrintSpeed.TabIndex = 24;
            // 
            // comboBoxTemperatureSetting
            // 
            this.comboBoxTemperatureSetting.FormattingEnabled = true;
            this.comboBoxTemperatureSetting.Location = new System.Drawing.Point(107, 92);
            this.comboBoxTemperatureSetting.Name = "comboBoxTemperatureSetting";
            this.comboBoxTemperatureSetting.Size = new System.Drawing.Size(121, 20);
            this.comboBoxTemperatureSetting.TabIndex = 23;
            // 
            // textBoxYPosition
            // 
            this.textBoxYPosition.Location = new System.Drawing.Point(434, 29);
            this.textBoxYPosition.Name = "textBoxYPosition";
            this.textBoxYPosition.Size = new System.Drawing.Size(109, 21);
            this.textBoxYPosition.TabIndex = 22;
            // 
            // labelYPosition
            // 
            this.labelYPosition.AutoSize = true;
            this.labelYPosition.Font = new System.Drawing.Font("굴림", 10F);
            this.labelYPosition.Location = new System.Drawing.Point(338, 36);
            this.labelYPosition.Name = "labelYPosition";
            this.labelYPosition.Size = new System.Drawing.Size(43, 14);
            this.labelYPosition.TabIndex = 21;
            this.labelYPosition.Text = "Y좌표";
            // 
            // labelTemperatureSetting
            // 
            this.labelTemperatureSetting.AutoSize = true;
            this.labelTemperatureSetting.Font = new System.Drawing.Font("굴림", 10F);
            this.labelTemperatureSetting.Location = new System.Drawing.Point(37, 92);
            this.labelTemperatureSetting.Name = "labelTemperatureSetting";
            this.labelTemperatureSetting.Size = new System.Drawing.Size(63, 14);
            this.labelTemperatureSetting.TabIndex = 19;
            this.labelTemperatureSetting.Text = "온도설정";
            // 
            // textBoxXPosition
            // 
            this.textBoxXPosition.Location = new System.Drawing.Point(100, 31);
            this.textBoxXPosition.Name = "textBoxXPosition";
            this.textBoxXPosition.Size = new System.Drawing.Size(109, 21);
            this.textBoxXPosition.TabIndex = 18;
            // 
            // labelXPosition
            // 
            this.labelXPosition.AutoSize = true;
            this.labelXPosition.Font = new System.Drawing.Font("굴림", 10F);
            this.labelXPosition.Location = new System.Drawing.Point(37, 36);
            this.labelXPosition.Name = "labelXPosition";
            this.labelXPosition.Size = new System.Drawing.Size(44, 14);
            this.labelXPosition.TabIndex = 17;
            this.labelXPosition.Text = "X좌표";
            // 
            // labelPrintSpeed
            // 
            this.labelPrintSpeed.AutoSize = true;
            this.labelPrintSpeed.Font = new System.Drawing.Font("굴림", 10F);
            this.labelPrintSpeed.Location = new System.Drawing.Point(327, 87);
            this.labelPrintSpeed.Name = "labelPrintSpeed";
            this.labelPrintSpeed.Size = new System.Drawing.Size(63, 14);
            this.labelPrintSpeed.TabIndex = 15;
            this.labelPrintSpeed.Text = "인쇄속도";
            // 
            // groupBoxBarcodeFormatSetting
            // 
            this.groupBoxBarcodeFormatSetting.Controls.Add(this.comboBoxDateFormat);
            this.groupBoxBarcodeFormatSetting.Controls.Add(this.radioButtonIgnoreSystemChange);
            this.groupBoxBarcodeFormatSetting.Controls.Add(this.radioButtonApplySystemChange);
            this.groupBoxBarcodeFormatSetting.Controls.Add(this.textBoxPalletDigits);
            this.groupBoxBarcodeFormatSetting.Controls.Add(this.labelPalletDigits);
            this.groupBoxBarcodeFormatSetting.Controls.Add(this.labelSystemChange);
            this.groupBoxBarcodeFormatSetting.Controls.Add(this.labelDateFormat);
            this.groupBoxBarcodeFormatSetting.Location = new System.Drawing.Point(20, 267);
            this.groupBoxBarcodeFormatSetting.Name = "groupBoxBarcodeFormatSetting";
            this.groupBoxBarcodeFormatSetting.Size = new System.Drawing.Size(580, 137);
            this.groupBoxBarcodeFormatSetting.TabIndex = 23;
            this.groupBoxBarcodeFormatSetting.TabStop = false;
            this.groupBoxBarcodeFormatSetting.Text = "바코드포맷설정";
            // 
            // comboBoxDateFormat
            // 
            this.comboBoxDateFormat.FormattingEnabled = true;
            this.comboBoxDateFormat.Location = new System.Drawing.Point(118, 34);
            this.comboBoxDateFormat.Name = "comboBoxDateFormat";
            this.comboBoxDateFormat.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDateFormat.TabIndex = 25;
            // 
            // radioButtonIgnoreSystemChange
            // 
            this.radioButtonIgnoreSystemChange.AutoSize = true;
            this.radioButtonIgnoreSystemChange.Location = new System.Drawing.Point(243, 90);
            this.radioButtonIgnoreSystemChange.Name = "radioButtonIgnoreSystemChange";
            this.radioButtonIgnoreSystemChange.Size = new System.Drawing.Size(107, 16);
            this.radioButtonIgnoreSystemChange.TabIndex = 24;
            this.radioButtonIgnoreSystemChange.TabStop = true;
            this.radioButtonIgnoreSystemChange.Text = "체계변경미적용";
            this.radioButtonIgnoreSystemChange.UseVisualStyleBackColor = true;
            // 
            // radioButtonApplySystemChange
            // 
            this.radioButtonApplySystemChange.AutoSize = true;
            this.radioButtonApplySystemChange.Location = new System.Drawing.Point(133, 92);
            this.radioButtonApplySystemChange.Name = "radioButtonApplySystemChange";
            this.radioButtonApplySystemChange.Size = new System.Drawing.Size(95, 16);
            this.radioButtonApplySystemChange.TabIndex = 23;
            this.radioButtonApplySystemChange.TabStop = true;
            this.radioButtonApplySystemChange.Text = "체계변경적용";
            this.radioButtonApplySystemChange.UseVisualStyleBackColor = true;
            // 
            // textBoxPalletDigits
            // 
            this.textBoxPalletDigits.Location = new System.Drawing.Point(434, 29);
            this.textBoxPalletDigits.Name = "textBoxPalletDigits";
            this.textBoxPalletDigits.Size = new System.Drawing.Size(109, 21);
            this.textBoxPalletDigits.TabIndex = 22;
            // 
            // labelPalletDigits
            // 
            this.labelPalletDigits.AutoSize = true;
            this.labelPalletDigits.Font = new System.Drawing.Font("굴림", 10F);
            this.labelPalletDigits.Location = new System.Drawing.Point(338, 36);
            this.labelPalletDigits.Name = "labelPalletDigits";
            this.labelPalletDigits.Size = new System.Drawing.Size(91, 14);
            this.labelPalletDigits.TabIndex = 21;
            this.labelPalletDigits.Text = "파렛트자릿수";
            // 
            // labelSystemChange
            // 
            this.labelSystemChange.AutoSize = true;
            this.labelSystemChange.Font = new System.Drawing.Font("굴림", 10F);
            this.labelSystemChange.Location = new System.Drawing.Point(37, 92);
            this.labelSystemChange.Name = "labelSystemChange";
            this.labelSystemChange.Size = new System.Drawing.Size(63, 14);
            this.labelSystemChange.TabIndex = 19;
            this.labelSystemChange.Text = "체계변경";
            // 
            // labelDateFormat
            // 
            this.labelDateFormat.AutoSize = true;
            this.labelDateFormat.Font = new System.Drawing.Font("굴림", 10F);
            this.labelDateFormat.Location = new System.Drawing.Point(37, 36);
            this.labelDateFormat.Name = "labelDateFormat";
            this.labelDateFormat.Size = new System.Drawing.Size(63, 14);
            this.labelDateFormat.TabIndex = 17;
            this.labelDateFormat.Text = "날짜포맷";
            // 
            // panelSplitBar
            // 
            this.panelSplitBar.BackColor = System.Drawing.Color.White;
            this.panelSplitBar.Location = new System.Drawing.Point(18, 70);
            this.panelSplitBar.Name = "panelSplitBar";
            this.panelSplitBar.Size = new System.Drawing.Size(600, 3);
            this.panelSplitBar.TabIndex = 58;
            // 
            // HardwareConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 510);
            this.Controls.Add(this.panelSplitBar);
            this.Controls.Add(this.groupBoxBarcodeFormatSetting);
            this.Controls.Add(this.groupBoxPrinterSetting);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonApplyData);
            this.Controls.Add(this.buttonHeadCheck);
            this.Controls.Add(this.labelTitle);
            this.Name = "HardwareConfigurationForm";
            this.Text = "HardwareConfigurationForm";
            this.groupBoxPrinterSetting.ResumeLayout(false);
            this.groupBoxPrinterSetting.PerformLayout();
            this.groupBoxBarcodeFormatSetting.ResumeLayout(false);
            this.groupBoxBarcodeFormatSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHeadCheck;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonApplyData;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxPrinterSetting;
        private System.Windows.Forms.ComboBox comboBoxPrintSpeed;
        private System.Windows.Forms.ComboBox comboBoxTemperatureSetting;
        private System.Windows.Forms.TextBox textBoxYPosition;
        private System.Windows.Forms.Label labelYPosition;
        private System.Windows.Forms.Label labelTemperatureSetting;
        private System.Windows.Forms.TextBox textBoxXPosition;
        private System.Windows.Forms.Label labelXPosition;
        private System.Windows.Forms.Label labelPrintSpeed;
        private System.Windows.Forms.GroupBox groupBoxBarcodeFormatSetting;
        private System.Windows.Forms.ComboBox comboBoxDateFormat;
        private System.Windows.Forms.RadioButton radioButtonIgnoreSystemChange;
        private System.Windows.Forms.RadioButton radioButtonApplySystemChange;
        private System.Windows.Forms.TextBox textBoxPalletDigits;
        private System.Windows.Forms.Label labelPalletDigits;
        private System.Windows.Forms.Label labelSystemChange;
        private System.Windows.Forms.Label labelDateFormat;
        private System.Windows.Forms.Panel panelSplitBar;
    }
}
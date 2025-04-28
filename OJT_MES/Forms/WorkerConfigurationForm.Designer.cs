namespace LotteMES.Forms
{
    partial class WorkerConfigurationForm
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
            this.groupBoxWorkDataChange = new System.Windows.Forms.GroupBox();
            this.textBoxBokEndNo = new System.Windows.Forms.TextBox();
            this.labelBokEndNo = new System.Windows.Forms.Label();
            this.textBoxSerialNo = new System.Windows.Forms.TextBox();
            this.labelSerialNo = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.comboBoxShiftType = new System.Windows.Forms.ComboBox();
            this.textBoxProductionDate = new System.Windows.Forms.TextBox();
            this.labelProductionDate = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxLineNameSetting = new System.Windows.Forms.TextBox();
            this.labelLineNameSetting = new System.Windows.Forms.Label();
            this.labelShiftType = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonApplyData = new System.Windows.Forms.Button();
            this.groupBoxFactoryLineSetting = new System.Windows.Forms.GroupBox();
            this.comboBoxLineName = new System.Windows.Forms.ComboBox();
            this.labelLineName = new System.Windows.Forms.Label();
            this.comboBoxFactoryName = new System.Windows.Forms.ComboBox();
            this.labelFactoryName = new System.Windows.Forms.Label();
            this.groupBoxPrinterConsumableSetting = new System.Windows.Forms.GroupBox();
            this.textBoxLabelRemainChange = new System.Windows.Forms.TextBox();
            this.labelLabelRemainChange = new System.Windows.Forms.Label();
            this.textBoxRibbonRemainChange = new System.Windows.Forms.TextBox();
            this.labelRibbonRemainChange = new System.Windows.Forms.Label();
            this.textBoxRibbonTotal = new System.Windows.Forms.TextBox();
            this.labelRibbonTotal = new System.Windows.Forms.Label();
            this.textBoxLabelTotal = new System.Windows.Forms.TextBox();
            this.labelLabelTotal = new System.Windows.Forms.Label();
            this.panelSplitBar = new System.Windows.Forms.Panel();
            this.groupBoxWorkDataChange.SuspendLayout();
            this.groupBoxFactoryLineSetting.SuspendLayout();
            this.groupBoxPrinterConsumableSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxWorkDataChange
            // 
            this.groupBoxWorkDataChange.Controls.Add(this.textBoxBokEndNo);
            this.groupBoxWorkDataChange.Controls.Add(this.labelBokEndNo);
            this.groupBoxWorkDataChange.Controls.Add(this.textBoxSerialNo);
            this.groupBoxWorkDataChange.Controls.Add(this.labelSerialNo);
            this.groupBoxWorkDataChange.Controls.Add(this.textBoxProductName);
            this.groupBoxWorkDataChange.Controls.Add(this.comboBoxShiftType);
            this.groupBoxWorkDataChange.Controls.Add(this.textBoxProductionDate);
            this.groupBoxWorkDataChange.Controls.Add(this.labelProductionDate);
            this.groupBoxWorkDataChange.Controls.Add(this.labelProductName);
            this.groupBoxWorkDataChange.Controls.Add(this.textBoxLineNameSetting);
            this.groupBoxWorkDataChange.Controls.Add(this.labelLineNameSetting);
            this.groupBoxWorkDataChange.Controls.Add(this.labelShiftType);
            this.groupBoxWorkDataChange.Location = new System.Drawing.Point(20, 80);
            this.groupBoxWorkDataChange.Name = "groupBoxWorkDataChange";
            this.groupBoxWorkDataChange.Size = new System.Drawing.Size(725, 180);
            this.groupBoxWorkDataChange.TabIndex = 28;
            this.groupBoxWorkDataChange.TabStop = false;
            this.groupBoxWorkDataChange.Text = "작업데이터 변경";
            // 
            // textBoxBokEndNo
            // 
            this.textBoxBokEndNo.Location = new System.Drawing.Point(513, 119);
            this.textBoxBokEndNo.Name = "textBoxBokEndNo";
            this.textBoxBokEndNo.Size = new System.Drawing.Size(109, 21);
            this.textBoxBokEndNo.TabIndex = 29;
            // 
            // labelBokEndNo
            // 
            this.labelBokEndNo.AutoSize = true;
            this.labelBokEndNo.Font = new System.Drawing.Font("굴림", 10F);
            this.labelBokEndNo.Location = new System.Drawing.Point(417, 126);
            this.labelBokEndNo.Name = "labelBokEndNo";
            this.labelBokEndNo.Size = new System.Drawing.Size(79, 14);
            this.labelBokEndNo.TabIndex = 28;
            this.labelBokEndNo.Text = "BOK끝번호";
            // 
            // textBoxSerialNo
            // 
            this.textBoxSerialNo.Location = new System.Drawing.Point(134, 119);
            this.textBoxSerialNo.Name = "textBoxSerialNo";
            this.textBoxSerialNo.Size = new System.Drawing.Size(109, 21);
            this.textBoxSerialNo.TabIndex = 27;
            // 
            // labelSerialNo
            // 
            this.labelSerialNo.AutoSize = true;
            this.labelSerialNo.Font = new System.Drawing.Font("굴림", 10F);
            this.labelSerialNo.Location = new System.Drawing.Point(38, 126);
            this.labelSerialNo.Name = "labelSerialNo";
            this.labelSerialNo.Size = new System.Drawing.Size(63, 14);
            this.labelSerialNo.TabIndex = 26;
            this.labelSerialNo.Text = "일련번호";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(134, 92);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(534, 21);
            this.textBoxProductName.TabIndex = 25;
            // 
            // comboBoxShiftType
            // 
            this.comboBoxShiftType.FormattingEnabled = true;
            this.comboBoxShiftType.Location = new System.Drawing.Point(501, 61);
            this.comboBoxShiftType.Name = "comboBoxShiftType";
            this.comboBoxShiftType.Size = new System.Drawing.Size(121, 20);
            this.comboBoxShiftType.TabIndex = 24;
            // 
            // textBoxProductionDate
            // 
            this.textBoxProductionDate.Location = new System.Drawing.Point(134, 60);
            this.textBoxProductionDate.Name = "textBoxProductionDate";
            this.textBoxProductionDate.Size = new System.Drawing.Size(109, 21);
            this.textBoxProductionDate.TabIndex = 22;
            // 
            // labelProductionDate
            // 
            this.labelProductionDate.AutoSize = true;
            this.labelProductionDate.Font = new System.Drawing.Font("굴림", 10F);
            this.labelProductionDate.Location = new System.Drawing.Point(38, 67);
            this.labelProductionDate.Name = "labelProductionDate";
            this.labelProductionDate.Size = new System.Drawing.Size(63, 14);
            this.labelProductionDate.TabIndex = 21;
            this.labelProductionDate.Text = "생산일자";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("굴림", 10F);
            this.labelProductName.Location = new System.Drawing.Point(37, 92);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(49, 14);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "제품명";
            // 
            // textBoxLineNameSetting
            // 
            this.textBoxLineNameSetting.Location = new System.Drawing.Point(100, 31);
            this.textBoxLineNameSetting.Name = "textBoxLineNameSetting";
            this.textBoxLineNameSetting.Size = new System.Drawing.Size(568, 21);
            this.textBoxLineNameSetting.TabIndex = 18;
            // 
            // labelLineNameSetting
            // 
            this.labelLineNameSetting.AutoSize = true;
            this.labelLineNameSetting.Font = new System.Drawing.Font("굴림", 10F);
            this.labelLineNameSetting.Location = new System.Drawing.Point(37, 36);
            this.labelLineNameSetting.Name = "labelLineNameSetting";
            this.labelLineNameSetting.Size = new System.Drawing.Size(63, 14);
            this.labelLineNameSetting.TabIndex = 17;
            this.labelLineNameSetting.Text = "생산라인";
            // 
            // labelShiftType
            // 
            this.labelShiftType.AutoSize = true;
            this.labelShiftType.Font = new System.Drawing.Font("굴림", 10F);
            this.labelShiftType.Location = new System.Drawing.Point(417, 63);
            this.labelShiftType.Name = "labelShiftType";
            this.labelShiftType.Size = new System.Drawing.Size(63, 14);
            this.labelShiftType.TabIndex = 15;
            this.labelShiftType.Text = "주야구분";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("굴림", 35F);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(365, 47);
            this.labelTitle.TabIndex = 24;
            this.labelTitle.Text = "작업자 환경설정";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(384, 582);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(247, 70);
            this.buttonClose.TabIndex = 27;
            this.buttonClose.Text = "닫기";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonApplyData
            // 
            this.buttonApplyData.Location = new System.Drawing.Point(91, 582);
            this.buttonApplyData.Name = "buttonApplyData";
            this.buttonApplyData.Size = new System.Drawing.Size(260, 70);
            this.buttonApplyData.TabIndex = 26;
            this.buttonApplyData.Text = "데이터 적용";
            this.buttonApplyData.UseVisualStyleBackColor = true;
            // 
            // groupBoxFactoryLineSetting
            // 
            this.groupBoxFactoryLineSetting.Controls.Add(this.comboBoxLineName);
            this.groupBoxFactoryLineSetting.Controls.Add(this.labelLineName);
            this.groupBoxFactoryLineSetting.Controls.Add(this.comboBoxFactoryName);
            this.groupBoxFactoryLineSetting.Controls.Add(this.labelFactoryName);
            this.groupBoxFactoryLineSetting.Location = new System.Drawing.Point(20, 279);
            this.groupBoxFactoryLineSetting.Name = "groupBoxFactoryLineSetting";
            this.groupBoxFactoryLineSetting.Size = new System.Drawing.Size(725, 124);
            this.groupBoxFactoryLineSetting.TabIndex = 30;
            this.groupBoxFactoryLineSetting.TabStop = false;
            this.groupBoxFactoryLineSetting.Text = "공장 및 라인셋팅";
            // 
            // comboBoxLineName
            // 
            this.comboBoxLineName.FormattingEnabled = true;
            this.comboBoxLineName.Location = new System.Drawing.Point(134, 81);
            this.comboBoxLineName.Name = "comboBoxLineName";
            this.comboBoxLineName.Size = new System.Drawing.Size(519, 20);
            this.comboBoxLineName.TabIndex = 26;
            // 
            // labelLineName
            // 
            this.labelLineName.AutoSize = true;
            this.labelLineName.Font = new System.Drawing.Font("굴림", 10F);
            this.labelLineName.Location = new System.Drawing.Point(27, 81);
            this.labelLineName.Name = "labelLineName";
            this.labelLineName.Size = new System.Drawing.Size(77, 14);
            this.labelLineName.TabIndex = 25;
            this.labelLineName.Text = "생산라인명";
            // 
            // comboBoxFactoryName
            // 
            this.comboBoxFactoryName.FormattingEnabled = true;
            this.comboBoxFactoryName.Location = new System.Drawing.Point(134, 44);
            this.comboBoxFactoryName.Name = "comboBoxFactoryName";
            this.comboBoxFactoryName.Size = new System.Drawing.Size(121, 20);
            this.comboBoxFactoryName.TabIndex = 24;
            // 
            // labelFactoryName
            // 
            this.labelFactoryName.AutoSize = true;
            this.labelFactoryName.Font = new System.Drawing.Font("굴림", 10F);
            this.labelFactoryName.Location = new System.Drawing.Point(27, 44);
            this.labelFactoryName.Name = "labelFactoryName";
            this.labelFactoryName.Size = new System.Drawing.Size(77, 14);
            this.labelFactoryName.TabIndex = 15;
            this.labelFactoryName.Text = "생산공장명";
            // 
            // groupBoxPrinterConsumableSetting
            // 
            this.groupBoxPrinterConsumableSetting.Controls.Add(this.textBoxLabelRemainChange);
            this.groupBoxPrinterConsumableSetting.Controls.Add(this.labelLabelRemainChange);
            this.groupBoxPrinterConsumableSetting.Controls.Add(this.textBoxRibbonRemainChange);
            this.groupBoxPrinterConsumableSetting.Controls.Add(this.labelRibbonRemainChange);
            this.groupBoxPrinterConsumableSetting.Controls.Add(this.textBoxRibbonTotal);
            this.groupBoxPrinterConsumableSetting.Controls.Add(this.labelRibbonTotal);
            this.groupBoxPrinterConsumableSetting.Controls.Add(this.textBoxLabelTotal);
            this.groupBoxPrinterConsumableSetting.Controls.Add(this.labelLabelTotal);
            this.groupBoxPrinterConsumableSetting.Location = new System.Drawing.Point(20, 423);
            this.groupBoxPrinterConsumableSetting.Name = "groupBoxPrinterConsumableSetting";
            this.groupBoxPrinterConsumableSetting.Size = new System.Drawing.Size(725, 144);
            this.groupBoxPrinterConsumableSetting.TabIndex = 31;
            this.groupBoxPrinterConsumableSetting.TabStop = false;
            this.groupBoxPrinterConsumableSetting.Text = "프린터 소모품 셋팅";
            // 
            // textBoxLabelRemainChange
            // 
            this.textBoxLabelRemainChange.Location = new System.Drawing.Point(525, 41);
            this.textBoxLabelRemainChange.Name = "textBoxLabelRemainChange";
            this.textBoxLabelRemainChange.Size = new System.Drawing.Size(109, 21);
            this.textBoxLabelRemainChange.TabIndex = 31;
            // 
            // labelLabelRemainChange
            // 
            this.labelLabelRemainChange.AutoSize = true;
            this.labelLabelRemainChange.Font = new System.Drawing.Font("굴림", 10F);
            this.labelLabelRemainChange.Location = new System.Drawing.Point(429, 43);
            this.labelLabelRemainChange.Name = "labelLabelRemainChange";
            this.labelLabelRemainChange.Size = new System.Drawing.Size(96, 14);
            this.labelLabelRemainChange.TabIndex = 30;
            this.labelLabelRemainChange.Text = "라벨잔량 변경";
            // 
            // textBoxRibbonRemainChange
            // 
            this.textBoxRibbonRemainChange.Location = new System.Drawing.Point(525, 100);
            this.textBoxRibbonRemainChange.Name = "textBoxRibbonRemainChange";
            this.textBoxRibbonRemainChange.Size = new System.Drawing.Size(109, 21);
            this.textBoxRibbonRemainChange.TabIndex = 29;
            // 
            // labelRibbonRemainChange
            // 
            this.labelRibbonRemainChange.AutoSize = true;
            this.labelRibbonRemainChange.Font = new System.Drawing.Font("굴림", 10F);
            this.labelRibbonRemainChange.Location = new System.Drawing.Point(429, 107);
            this.labelRibbonRemainChange.Name = "labelRibbonRemainChange";
            this.labelRibbonRemainChange.Size = new System.Drawing.Size(96, 14);
            this.labelRibbonRemainChange.TabIndex = 28;
            this.labelRibbonRemainChange.Text = "리본잔량 변경";
            // 
            // textBoxRibbonTotal
            // 
            this.textBoxRibbonTotal.Location = new System.Drawing.Point(146, 100);
            this.textBoxRibbonTotal.Name = "textBoxRibbonTotal";
            this.textBoxRibbonTotal.Size = new System.Drawing.Size(109, 21);
            this.textBoxRibbonTotal.TabIndex = 27;
            // 
            // labelRibbonTotal
            // 
            this.labelRibbonTotal.AutoSize = true;
            this.labelRibbonTotal.Font = new System.Drawing.Font("굴림", 10F);
            this.labelRibbonTotal.Location = new System.Drawing.Point(50, 107);
            this.labelRibbonTotal.Name = "labelRibbonTotal";
            this.labelRibbonTotal.Size = new System.Drawing.Size(82, 14);
            this.labelRibbonTotal.TabIndex = 26;
            this.labelRibbonTotal.Text = "리본 총매수";
            // 
            // textBoxLabelTotal
            // 
            this.textBoxLabelTotal.Location = new System.Drawing.Point(146, 41);
            this.textBoxLabelTotal.Name = "textBoxLabelTotal";
            this.textBoxLabelTotal.Size = new System.Drawing.Size(109, 21);
            this.textBoxLabelTotal.TabIndex = 22;
            // 
            // labelLabelTotal
            // 
            this.labelLabelTotal.AutoSize = true;
            this.labelLabelTotal.Font = new System.Drawing.Font("굴림", 10F);
            this.labelLabelTotal.Location = new System.Drawing.Point(50, 48);
            this.labelLabelTotal.Name = "labelLabelTotal";
            this.labelLabelTotal.Size = new System.Drawing.Size(82, 14);
            this.labelLabelTotal.TabIndex = 21;
            this.labelLabelTotal.Text = "라벨 총매수";
            // 
            // panelSplitBar
            // 
            this.panelSplitBar.BackColor = System.Drawing.Color.White;
            this.panelSplitBar.Location = new System.Drawing.Point(12, 59);
            this.panelSplitBar.Name = "panelSplitBar";
            this.panelSplitBar.Size = new System.Drawing.Size(750, 3);
            this.panelSplitBar.TabIndex = 57;
            // 
            // WorkerConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 664);
            this.Controls.Add(this.panelSplitBar);
            this.Controls.Add(this.groupBoxPrinterConsumableSetting);
            this.Controls.Add(this.groupBoxFactoryLineSetting);
            this.Controls.Add(this.groupBoxWorkDataChange);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonApplyData);
            this.Controls.Add(this.labelTitle);
            this.Name = "WorkerConfigurationForm";
            this.Text = "WorkerConfigurationForm";
            this.Load += new System.EventHandler(this.WorkerConfigurationForm_Load);
            this.groupBoxWorkDataChange.ResumeLayout(false);
            this.groupBoxWorkDataChange.PerformLayout();
            this.groupBoxFactoryLineSetting.ResumeLayout(false);
            this.groupBoxFactoryLineSetting.PerformLayout();
            this.groupBoxPrinterConsumableSetting.ResumeLayout(false);
            this.groupBoxPrinterConsumableSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWorkDataChange;
        private System.Windows.Forms.TextBox textBoxBokEndNo;
        private System.Windows.Forms.Label labelBokEndNo;
        private System.Windows.Forms.TextBox textBoxSerialNo;
        private System.Windows.Forms.Label labelSerialNo;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.ComboBox comboBoxShiftType;
        private System.Windows.Forms.TextBox textBoxProductionDate;
        private System.Windows.Forms.Label labelProductionDate;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxLineNameSetting;
        private System.Windows.Forms.Label labelLineNameSetting;
        private System.Windows.Forms.Label labelShiftType;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonApplyData;
        private System.Windows.Forms.GroupBox groupBoxFactoryLineSetting;
        private System.Windows.Forms.ComboBox comboBoxLineName;
        private System.Windows.Forms.Label labelLineName;
        private System.Windows.Forms.ComboBox comboBoxFactoryName;
        private System.Windows.Forms.Label labelFactoryName;
        private System.Windows.Forms.GroupBox groupBoxPrinterConsumableSetting;
        private System.Windows.Forms.TextBox textBoxLabelRemainChange;
        private System.Windows.Forms.Label labelLabelRemainChange;
        private System.Windows.Forms.TextBox textBoxRibbonRemainChange;
        private System.Windows.Forms.Label labelRibbonRemainChange;
        private System.Windows.Forms.TextBox textBoxRibbonTotal;
        private System.Windows.Forms.Label labelRibbonTotal;
        private System.Windows.Forms.TextBox textBoxLabelTotal;
        private System.Windows.Forms.Label labelLabelTotal;
        private System.Windows.Forms.Panel panelSplitBar;
    }
}
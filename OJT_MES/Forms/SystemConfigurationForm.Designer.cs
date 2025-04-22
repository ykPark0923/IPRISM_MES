namespace LotteMES.Forms
{
    partial class SystemConfigurationForm
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
            this.groupBoxCommunicationSettings = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.textBoxDataRetentionDays = new System.Windows.Forms.TextBox();
            this.labelDataRetentionDays = new System.Windows.Forms.Label();
            this.groupBoxGeneralSettings = new System.Windows.Forms.GroupBox();
            this.radioButtonUnset = new System.Windows.Forms.RadioButton();
            this.radioButton501 = new System.Windows.Forms.RadioButton();
            this.comboBoxLabelDirection = new System.Windows.Forms.ComboBox();
            this.radioButton001 = new System.Windows.Forms.RadioButton();
            this.labelStartNumberBasis = new System.Windows.Forms.Label();
            this.labelLabelPrintDirection = new System.Windows.Forms.Label();
            this.labelDownloadMinutes = new System.Windows.Forms.Label();
            this.labelUploadMinutes = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.checkBoxUnverifiedAllowed = new System.Windows.Forms.CheckBox();
            this.labelVerificationSetting = new System.Windows.Forms.Label();
            this.checkBoxExpirationEnabled = new System.Windows.Forms.CheckBox();
            this.textBoxServerIP = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxDownloadTime = new System.Windows.Forms.ComboBox();
            this.comboBoxUploadTime = new System.Windows.Forms.ComboBox();
            this.labelExpirationSetting = new System.Windows.Forms.Label();
            this.labelUploadTimeSetting = new System.Windows.Forms.Label();
            this.labelServerIP = new System.Windows.Forms.Label();
            this.labelDownloadTimeSetting = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonApplyData = new System.Windows.Forms.Button();
            this.buttonRecoverMDB = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelSplitBar = new System.Windows.Forms.Panel();
            this.groupBoxCommunicationSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxGeneralSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCommunicationSettings
            // 
            this.groupBoxCommunicationSettings.Controls.Add(this.dataGridView1);
            this.groupBoxCommunicationSettings.Location = new System.Drawing.Point(20, 311);
            this.groupBoxCommunicationSettings.Name = "groupBoxCommunicationSettings";
            this.groupBoxCommunicationSettings.Size = new System.Drawing.Size(674, 254);
            this.groupBoxCommunicationSettings.TabIndex = 29;
            this.groupBoxCommunicationSettings.TabStop = false;
            this.groupBoxCommunicationSettings.Text = "통신설정";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(661, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "장비명";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "포트설정";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Baudrate";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Parity";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DataBit";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "StopBit";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // textBoxDataRetentionDays
            // 
            this.textBoxDataRetentionDays.Location = new System.Drawing.Point(464, 72);
            this.textBoxDataRetentionDays.Name = "textBoxDataRetentionDays";
            this.textBoxDataRetentionDays.Size = new System.Drawing.Size(58, 21);
            this.textBoxDataRetentionDays.TabIndex = 22;
            // 
            // labelDataRetentionDays
            // 
            this.labelDataRetentionDays.AutoSize = true;
            this.labelDataRetentionDays.Font = new System.Drawing.Font("굴림", 10F);
            this.labelDataRetentionDays.Location = new System.Drawing.Point(353, 76);
            this.labelDataRetentionDays.Name = "labelDataRetentionDays";
            this.labelDataRetentionDays.Size = new System.Drawing.Size(105, 14);
            this.labelDataRetentionDays.TabIndex = 21;
            this.labelDataRetentionDays.Text = "데이터저장일수";
            // 
            // groupBoxGeneralSettings
            // 
            this.groupBoxGeneralSettings.Controls.Add(this.radioButtonUnset);
            this.groupBoxGeneralSettings.Controls.Add(this.radioButton501);
            this.groupBoxGeneralSettings.Controls.Add(this.comboBoxLabelDirection);
            this.groupBoxGeneralSettings.Controls.Add(this.radioButton001);
            this.groupBoxGeneralSettings.Controls.Add(this.labelStartNumberBasis);
            this.groupBoxGeneralSettings.Controls.Add(this.labelLabelPrintDirection);
            this.groupBoxGeneralSettings.Controls.Add(this.labelDownloadMinutes);
            this.groupBoxGeneralSettings.Controls.Add(this.labelUploadMinutes);
            this.groupBoxGeneralSettings.Controls.Add(this.labelDays);
            this.groupBoxGeneralSettings.Controls.Add(this.checkBoxUnverifiedAllowed);
            this.groupBoxGeneralSettings.Controls.Add(this.labelVerificationSetting);
            this.groupBoxGeneralSettings.Controls.Add(this.checkBoxExpirationEnabled);
            this.groupBoxGeneralSettings.Controls.Add(this.textBoxDataRetentionDays);
            this.groupBoxGeneralSettings.Controls.Add(this.labelDataRetentionDays);
            this.groupBoxGeneralSettings.Controls.Add(this.textBoxServerIP);
            this.groupBoxGeneralSettings.Controls.Add(this.comboBoxDownloadTime);
            this.groupBoxGeneralSettings.Controls.Add(this.comboBoxUploadTime);
            this.groupBoxGeneralSettings.Controls.Add(this.labelExpirationSetting);
            this.groupBoxGeneralSettings.Controls.Add(this.labelUploadTimeSetting);
            this.groupBoxGeneralSettings.Controls.Add(this.labelServerIP);
            this.groupBoxGeneralSettings.Controls.Add(this.labelDownloadTimeSetting);
            this.groupBoxGeneralSettings.Location = new System.Drawing.Point(20, 70);
            this.groupBoxGeneralSettings.Name = "groupBoxGeneralSettings";
            this.groupBoxGeneralSettings.Size = new System.Drawing.Size(674, 235);
            this.groupBoxGeneralSettings.TabIndex = 28;
            this.groupBoxGeneralSettings.TabStop = false;
            this.groupBoxGeneralSettings.Text = "기본설정";
            // 
            // radioButtonUnset
            // 
            this.radioButtonUnset.AutoSize = true;
            this.radioButtonUnset.Location = new System.Drawing.Point(427, 199);
            this.radioButtonUnset.Name = "radioButtonUnset";
            this.radioButtonUnset.Size = new System.Drawing.Size(59, 16);
            this.radioButtonUnset.TabIndex = 34;
            this.radioButtonUnset.TabStop = true;
            this.radioButtonUnset.Text = "비설정";
            this.radioButtonUnset.UseVisualStyleBackColor = true;
            // 
            // radioButton501
            // 
            this.radioButton501.AutoSize = true;
            this.radioButton501.Location = new System.Drawing.Point(523, 165);
            this.radioButton501.Name = "radioButton501";
            this.radioButton501.Size = new System.Drawing.Size(41, 16);
            this.radioButton501.TabIndex = 28;
            this.radioButton501.TabStop = true;
            this.radioButton501.Text = "501";
            this.radioButton501.UseVisualStyleBackColor = true;
            // 
            // comboBoxLabelDirection
            // 
            this.comboBoxLabelDirection.FormattingEnabled = true;
            this.comboBoxLabelDirection.Location = new System.Drawing.Point(164, 167);
            this.comboBoxLabelDirection.Name = "comboBoxLabelDirection";
            this.comboBoxLabelDirection.Size = new System.Drawing.Size(80, 20);
            this.comboBoxLabelDirection.TabIndex = 33;
            // 
            // radioButton001
            // 
            this.radioButton001.AutoSize = true;
            this.radioButton001.Location = new System.Drawing.Point(425, 167);
            this.radioButton001.Name = "radioButton001";
            this.radioButton001.Size = new System.Drawing.Size(41, 16);
            this.radioButton001.TabIndex = 27;
            this.radioButton001.TabStop = true;
            this.radioButton001.Text = "001";
            this.radioButton001.UseVisualStyleBackColor = true;
            // 
            // labelStartNumberBasis
            // 
            this.labelStartNumberBasis.AutoSize = true;
            this.labelStartNumberBasis.Font = new System.Drawing.Font("굴림", 10F);
            this.labelStartNumberBasis.Location = new System.Drawing.Point(317, 167);
            this.labelStartNumberBasis.Name = "labelStartNumberBasis";
            this.labelStartNumberBasis.Size = new System.Drawing.Size(91, 14);
            this.labelStartNumberBasis.TabIndex = 26;
            this.labelStartNumberBasis.Text = "시작번호기준";
            // 
            // labelLabelPrintDirection
            // 
            this.labelLabelPrintDirection.AutoSize = true;
            this.labelLabelPrintDirection.Font = new System.Drawing.Font("굴림", 10F);
            this.labelLabelPrintDirection.Location = new System.Drawing.Point(43, 169);
            this.labelLabelPrintDirection.Name = "labelLabelPrintDirection";
            this.labelLabelPrintDirection.Size = new System.Drawing.Size(101, 14);
            this.labelLabelPrintDirection.TabIndex = 32;
            this.labelLabelPrintDirection.Text = "라벨 발행 방향";
            // 
            // labelDownloadMinutes
            // 
            this.labelDownloadMinutes.AutoSize = true;
            this.labelDownloadMinutes.Font = new System.Drawing.Font("굴림", 10F);
            this.labelDownloadMinutes.Location = new System.Drawing.Point(540, 115);
            this.labelDownloadMinutes.Name = "labelDownloadMinutes";
            this.labelDownloadMinutes.Size = new System.Drawing.Size(21, 14);
            this.labelDownloadMinutes.TabIndex = 31;
            this.labelDownloadMinutes.Text = "분";
            // 
            // labelUploadMinutes
            // 
            this.labelUploadMinutes.AutoSize = true;
            this.labelUploadMinutes.Font = new System.Drawing.Font("굴림", 10F);
            this.labelUploadMinutes.Location = new System.Drawing.Point(240, 106);
            this.labelUploadMinutes.Name = "labelUploadMinutes";
            this.labelUploadMinutes.Size = new System.Drawing.Size(21, 14);
            this.labelUploadMinutes.TabIndex = 30;
            this.labelUploadMinutes.Text = "분";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("굴림", 10F);
            this.labelDays.Location = new System.Drawing.Point(528, 76);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(21, 14);
            this.labelDays.TabIndex = 29;
            this.labelDays.Text = "일";
            // 
            // checkBoxUnverifiedAllowed
            // 
            this.checkBoxUnverifiedAllowed.AutoSize = true;
            this.checkBoxUnverifiedAllowed.Location = new System.Drawing.Point(171, 74);
            this.checkBoxUnverifiedAllowed.Name = "checkBoxUnverifiedAllowed";
            this.checkBoxUnverifiedAllowed.Size = new System.Drawing.Size(84, 16);
            this.checkBoxUnverifiedAllowed.TabIndex = 28;
            this.checkBoxUnverifiedAllowed.Text = "검증미확인";
            this.checkBoxUnverifiedAllowed.UseVisualStyleBackColor = true;
            // 
            // labelVerificationSetting
            // 
            this.labelVerificationSetting.AutoSize = true;
            this.labelVerificationSetting.Font = new System.Drawing.Font("굴림", 10F);
            this.labelVerificationSetting.Location = new System.Drawing.Point(43, 74);
            this.labelVerificationSetting.Name = "labelVerificationSetting";
            this.labelVerificationSetting.Size = new System.Drawing.Size(105, 14);
            this.labelVerificationSetting.TabIndex = 27;
            this.labelVerificationSetting.Text = "검증미확인여부";
            // 
            // checkBoxExpirationEnabled
            // 
            this.checkBoxExpirationEnabled.AutoSize = true;
            this.checkBoxExpirationEnabled.Location = new System.Drawing.Point(434, 33);
            this.checkBoxExpirationEnabled.Name = "checkBoxExpirationEnabled";
            this.checkBoxExpirationEnabled.Size = new System.Drawing.Size(100, 16);
            this.checkBoxExpirationEnabled.TabIndex = 26;
            this.checkBoxExpirationEnabled.Text = "유통기한 출력";
            this.checkBoxExpirationEnabled.UseVisualStyleBackColor = true;
            // 
            // textBoxServerIP
            // 
            this.textBoxServerIP.Location = new System.Drawing.Point(107, 36);
            this.textBoxServerIP.Name = "textBoxServerIP";
            this.textBoxServerIP.Size = new System.Drawing.Size(100, 21);
            this.textBoxServerIP.TabIndex = 25;
            // 
            // comboBoxDownloadTime
            // 
            this.comboBoxDownloadTime.FormattingEnabled = true;
            this.comboBoxDownloadTime.Location = new System.Drawing.Point(472, 113);
            this.comboBoxDownloadTime.Name = "comboBoxDownloadTime";
            this.comboBoxDownloadTime.Size = new System.Drawing.Size(62, 20);
            this.comboBoxDownloadTime.TabIndex = 24;
            // 
            // comboBoxUploadTime
            // 
            this.comboBoxUploadTime.FormattingEnabled = true;
            this.comboBoxUploadTime.Location = new System.Drawing.Point(148, 104);
            this.comboBoxUploadTime.Name = "comboBoxUploadTime";
            this.comboBoxUploadTime.Size = new System.Drawing.Size(80, 20);
            this.comboBoxUploadTime.TabIndex = 23;
            // 
            // labelExpirationSetting
            // 
            this.labelExpirationSetting.AutoSize = true;
            this.labelExpirationSetting.Font = new System.Drawing.Font("굴림", 10F);
            this.labelExpirationSetting.Location = new System.Drawing.Point(268, 36);
            this.labelExpirationSetting.Name = "labelExpirationSetting";
            this.labelExpirationSetting.Size = new System.Drawing.Size(124, 14);
            this.labelExpirationSetting.TabIndex = 21;
            this.labelExpirationSetting.Text = "유통기한 출력유무";
            // 
            // labelUploadTimeSetting
            // 
            this.labelUploadTimeSetting.AutoSize = true;
            this.labelUploadTimeSetting.Font = new System.Drawing.Font("굴림", 10F);
            this.labelUploadTimeSetting.Location = new System.Drawing.Point(27, 106);
            this.labelUploadTimeSetting.Name = "labelUploadTimeSetting";
            this.labelUploadTimeSetting.Size = new System.Drawing.Size(105, 14);
            this.labelUploadTimeSetting.TabIndex = 19;
            this.labelUploadTimeSetting.Text = "업로드시간설정";
            // 
            // labelServerIP
            // 
            this.labelServerIP.AutoSize = true;
            this.labelServerIP.Font = new System.Drawing.Font("굴림", 10F);
            this.labelServerIP.Location = new System.Drawing.Point(37, 36);
            this.labelServerIP.Name = "labelServerIP";
            this.labelServerIP.Size = new System.Drawing.Size(53, 14);
            this.labelServerIP.TabIndex = 17;
            this.labelServerIP.Text = "서버 IP";
            // 
            // labelDownloadTimeSetting
            // 
            this.labelDownloadTimeSetting.AutoSize = true;
            this.labelDownloadTimeSetting.Font = new System.Drawing.Font("굴림", 10F);
            this.labelDownloadTimeSetting.Location = new System.Drawing.Point(342, 115);
            this.labelDownloadTimeSetting.Name = "labelDownloadTimeSetting";
            this.labelDownloadTimeSetting.Size = new System.Drawing.Size(124, 14);
            this.labelDownloadTimeSetting.TabIndex = 15;
            this.labelDownloadTimeSetting.Text = "다운로드 시간설정";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(469, 571);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(184, 70);
            this.buttonClose.TabIndex = 27;
            this.buttonClose.Text = "닫기";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonApplyData
            // 
            this.buttonApplyData.Location = new System.Drawing.Point(231, 571);
            this.buttonApplyData.Name = "buttonApplyData";
            this.buttonApplyData.Size = new System.Drawing.Size(194, 70);
            this.buttonApplyData.TabIndex = 26;
            this.buttonApplyData.Text = "데이터적용";
            this.buttonApplyData.UseVisualStyleBackColor = true;
            // 
            // buttonRecoverMDB
            // 
            this.buttonRecoverMDB.Location = new System.Drawing.Point(12, 571);
            this.buttonRecoverMDB.Name = "buttonRecoverMDB";
            this.buttonRecoverMDB.Size = new System.Drawing.Size(191, 70);
            this.buttonRecoverMDB.TabIndex = 25;
            this.buttonRecoverMDB.Text = "MDB복구";
            this.buttonRecoverMDB.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("굴림", 35F);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(365, 47);
            this.labelTitle.TabIndex = 24;
            this.labelTitle.Text = "시스템 환경설정";
            // 
            // panelSplitBar
            // 
            this.panelSplitBar.BackColor = System.Drawing.Color.White;
            this.panelSplitBar.Location = new System.Drawing.Point(8, 61);
            this.panelSplitBar.Name = "panelSplitBar";
            this.panelSplitBar.Size = new System.Drawing.Size(700, 3);
            this.panelSplitBar.TabIndex = 57;
            // 
            // SystemConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 653);
            this.Controls.Add(this.panelSplitBar);
            this.Controls.Add(this.groupBoxCommunicationSettings);
            this.Controls.Add(this.groupBoxGeneralSettings);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonApplyData);
            this.Controls.Add(this.buttonRecoverMDB);
            this.Controls.Add(this.labelTitle);
            this.Name = "SystemConfigurationForm";
            this.Text = "SystemConfigurationForm";
            this.groupBoxCommunicationSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxGeneralSettings.ResumeLayout(false);
            this.groupBoxGeneralSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCommunicationSettings;
        private System.Windows.Forms.TextBox textBoxDataRetentionDays;
        private System.Windows.Forms.Label labelDataRetentionDays;
        private System.Windows.Forms.GroupBox groupBoxGeneralSettings;
        private System.Windows.Forms.ComboBox comboBoxDownloadTime;
        private System.Windows.Forms.ComboBox comboBoxUploadTime;
        private System.Windows.Forms.Label labelExpirationSetting;
        private System.Windows.Forms.Label labelUploadTimeSetting;
        private System.Windows.Forms.Label labelServerIP;
        private System.Windows.Forms.Label labelDownloadTimeSetting;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonApplyData;
        private System.Windows.Forms.Button buttonRecoverMDB;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox checkBoxUnverifiedAllowed;
        private System.Windows.Forms.Label labelVerificationSetting;
        private System.Windows.Forms.CheckBox checkBoxExpirationEnabled;
        private System.Windows.Forms.MaskedTextBox textBoxServerIP;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.RadioButton radioButton501;
        private System.Windows.Forms.ComboBox comboBoxLabelDirection;
        private System.Windows.Forms.RadioButton radioButton001;
        private System.Windows.Forms.Label labelStartNumberBasis;
        private System.Windows.Forms.Label labelLabelPrintDirection;
        private System.Windows.Forms.Label labelDownloadMinutes;
        private System.Windows.Forms.Label labelUploadMinutes;
        private System.Windows.Forms.RadioButton radioButtonUnset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
        private System.Windows.Forms.Panel panelSplitBar;
    }
}
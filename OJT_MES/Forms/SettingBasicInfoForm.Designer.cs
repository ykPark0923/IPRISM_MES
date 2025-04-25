namespace LotteMES.Forms
{
    partial class SettingBasicInfoForm
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
            this.comboBoxSearchBasicCode = new System.Windows.Forms.ComboBox();
            this.labelSearchBasicCode = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDownloadLineInfo = new System.Windows.Forms.Button();
            this.buttonDownloadProductInfo = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewSettingBasicInfo = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSplitBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSettingBasicInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSearchBasicCode
            // 
            this.comboBoxSearchBasicCode.FormattingEnabled = true;
            this.comboBoxSearchBasicCode.Location = new System.Drawing.Point(47, 127);
            this.comboBoxSearchBasicCode.Name = "comboBoxSearchBasicCode";
            this.comboBoxSearchBasicCode.Size = new System.Drawing.Size(201, 20);
            this.comboBoxSearchBasicCode.TabIndex = 23;
            // 
            // labelSearchBasicCode
            // 
            this.labelSearchBasicCode.AutoSize = true;
            this.labelSearchBasicCode.Font = new System.Drawing.Font("굴림", 10F);
            this.labelSearchBasicCode.Location = new System.Drawing.Point(67, 96);
            this.labelSearchBasicCode.Name = "labelSearchBasicCode";
            this.labelSearchBasicCode.Size = new System.Drawing.Size(96, 14);
            this.labelSearchBasicCode.TabIndex = 19;
            this.labelSearchBasicCode.Text = "기본코드 조회";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(552, 96);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(110, 70);
            this.buttonClose.TabIndex = 27;
            this.buttonClose.Text = "닫기";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDownloadLineInfo
            // 
            this.buttonDownloadLineInfo.Location = new System.Drawing.Point(427, 96);
            this.buttonDownloadLineInfo.Name = "buttonDownloadLineInfo";
            this.buttonDownloadLineInfo.Size = new System.Drawing.Size(120, 70);
            this.buttonDownloadLineInfo.TabIndex = 26;
            this.buttonDownloadLineInfo.Text = "라인정보\r\n다운로드";
            this.buttonDownloadLineInfo.UseVisualStyleBackColor = true;
            this.buttonDownloadLineInfo.Click += new System.EventHandler(this.buttonDownloadLineInfo_Click);
            // 
            // buttonDownloadProductInfo
            // 
            this.buttonDownloadProductInfo.Location = new System.Drawing.Point(304, 96);
            this.buttonDownloadProductInfo.Name = "buttonDownloadProductInfo";
            this.buttonDownloadProductInfo.Size = new System.Drawing.Size(117, 70);
            this.buttonDownloadProductInfo.TabIndex = 25;
            this.buttonDownloadProductInfo.Text = "제품정보\r\n다운로드";
            this.buttonDownloadProductInfo.UseVisualStyleBackColor = true;
            this.buttonDownloadProductInfo.Click += new System.EventHandler(this.buttonDownloadProductInfo_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("굴림", 35F);
            this.labelTitle.Location = new System.Drawing.Point(12, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(318, 47);
            this.labelTitle.TabIndex = 24;
            this.labelTitle.Text = "기본정보 설정";
            // 
            // dataGridViewSettingBasicInfo
            // 
            this.dataGridViewSettingBasicInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSettingBasicInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.ProcessName,
            this.LineCode,
            this.LineName});
            this.dataGridViewSettingBasicInfo.Location = new System.Drawing.Point(20, 172);
            this.dataGridViewSettingBasicInfo.Name = "dataGridViewSettingBasicInfo";
            this.dataGridViewSettingBasicInfo.RowTemplate.Height = 23;
            this.dataGridViewSettingBasicInfo.Size = new System.Drawing.Size(642, 438);
            this.dataGridViewSettingBasicInfo.TabIndex = 28;
            // 
            // Number
            // 
            this.Number.HeaderText = "No";
            this.Number.Name = "Number";
            // 
            // ProcessName
            // 
            this.ProcessName.HeaderText = "공정명";
            this.ProcessName.Name = "ProcessName";
            // 
            // LineCode
            // 
            this.LineCode.HeaderText = "라인코드";
            this.LineCode.Name = "LineCode";
            // 
            // LineName
            // 
            this.LineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LineName.HeaderText = "라인명";
            this.LineName.Name = "LineName";
            // 
            // panelSplitBar
            // 
            this.panelSplitBar.BackColor = System.Drawing.Color.White;
            this.panelSplitBar.Location = new System.Drawing.Point(20, 76);
            this.panelSplitBar.Name = "panelSplitBar";
            this.panelSplitBar.Size = new System.Drawing.Size(640, 3);
            this.panelSplitBar.TabIndex = 29;
            // 
            // SettingBasicInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(675, 622);
            this.Controls.Add(this.panelSplitBar);
            this.Controls.Add(this.dataGridViewSettingBasicInfo);
            this.Controls.Add(this.comboBoxSearchBasicCode);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDownloadLineInfo);
            this.Controls.Add(this.labelSearchBasicCode);
            this.Controls.Add(this.buttonDownloadProductInfo);
            this.Name = "SettingBasicInfoForm";
            this.Text = "CreateBasicInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSettingBasicInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSearchBasicCode;
        private System.Windows.Forms.Label labelSearchBasicCode;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDownloadLineInfo;
        private System.Windows.Forms.Button buttonDownloadProductInfo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewSettingBasicInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineName;
        private System.Windows.Forms.Panel panelSplitBar;
    }
}
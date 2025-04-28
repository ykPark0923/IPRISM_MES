namespace LotteMES.Forms
{
    partial class PerformanceManageForm
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
            this.groupBoxBoxInfo = new System.Windows.Forms.GroupBox();
            this.buttonUploadBoxHistory = new System.Windows.Forms.Button();
            this.buttonEditBoxNo = new System.Windows.Forms.Button();
            this.textBoxEndBoxNo = new System.Windows.Forms.TextBox();
            this.textBoxStartBoxNo = new System.Windows.Forms.TextBox();
            this.radioButtonEndBoxNo = new System.Windows.Forms.RadioButton();
            this.radioButtonStartBoxNo = new System.Windows.Forms.RadioButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelTotalPeriod = new System.Windows.Forms.Label();
            this.labelTestPeriod = new System.Windows.Forms.Label();
            this.comboBoxTransmissionMedia = new System.Windows.Forms.ComboBox();
            this.labelTransmissionMedia = new System.Windows.Forms.Label();
            this.buttonUploadPerformance = new System.Windows.Forms.Button();
            this.buttonPerformanceDelete = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridViewPerformance = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSplitBar = new System.Windows.Forms.Panel();
            this.comboBoxTestPeriod = new System.Windows.Forms.ComboBox();
            this.comboBoxTotalPeriod = new System.Windows.Forms.ComboBox();
            this.groupBoxBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerformance)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBoxInfo
            // 
            this.groupBoxBoxInfo.Controls.Add(this.buttonUploadBoxHistory);
            this.groupBoxBoxInfo.Controls.Add(this.buttonEditBoxNo);
            this.groupBoxBoxInfo.Controls.Add(this.textBoxEndBoxNo);
            this.groupBoxBoxInfo.Controls.Add(this.textBoxStartBoxNo);
            this.groupBoxBoxInfo.Controls.Add(this.radioButtonEndBoxNo);
            this.groupBoxBoxInfo.Controls.Add(this.radioButtonStartBoxNo);
            this.groupBoxBoxInfo.Font = new System.Drawing.Font("굴림", 13F);
            this.groupBoxBoxInfo.Location = new System.Drawing.Point(12, 580);
            this.groupBoxBoxInfo.Name = "groupBoxBoxInfo";
            this.groupBoxBoxInfo.Size = new System.Drawing.Size(441, 119);
            this.groupBoxBoxInfo.TabIndex = 34;
            this.groupBoxBoxInfo.TabStop = false;
            this.groupBoxBoxInfo.Text = "BOX번호 정보";
            // 
            // buttonUploadBoxHistory
            // 
            this.buttonUploadBoxHistory.Font = new System.Drawing.Font("굴림", 9F);
            this.buttonUploadBoxHistory.Location = new System.Drawing.Point(315, 16);
            this.buttonUploadBoxHistory.Name = "buttonUploadBoxHistory";
            this.buttonUploadBoxHistory.Size = new System.Drawing.Size(119, 96);
            this.buttonUploadBoxHistory.TabIndex = 52;
            this.buttonUploadBoxHistory.Text = "BOX수정내역\r\n업로드";
            this.buttonUploadBoxHistory.UseVisualStyleBackColor = true;
            // 
            // buttonEditBoxNo
            // 
            this.buttonEditBoxNo.Font = new System.Drawing.Font("굴림", 9F);
            this.buttonEditBoxNo.Location = new System.Drawing.Point(194, 15);
            this.buttonEditBoxNo.Name = "buttonEditBoxNo";
            this.buttonEditBoxNo.Size = new System.Drawing.Size(119, 96);
            this.buttonEditBoxNo.TabIndex = 51;
            this.buttonEditBoxNo.Text = "BOX번호수정";
            this.buttonEditBoxNo.UseVisualStyleBackColor = true;
            // 
            // textBoxEndBoxNo
            // 
            this.textBoxEndBoxNo.Location = new System.Drawing.Point(102, 69);
            this.textBoxEndBoxNo.Name = "textBoxEndBoxNo";
            this.textBoxEndBoxNo.Size = new System.Drawing.Size(86, 27);
            this.textBoxEndBoxNo.TabIndex = 36;
            // 
            // textBoxStartBoxNo
            // 
            this.textBoxStartBoxNo.Location = new System.Drawing.Point(103, 33);
            this.textBoxStartBoxNo.Name = "textBoxStartBoxNo";
            this.textBoxStartBoxNo.Size = new System.Drawing.Size(86, 27);
            this.textBoxStartBoxNo.TabIndex = 35;
            // 
            // radioButtonEndBoxNo
            // 
            this.radioButtonEndBoxNo.AutoSize = true;
            this.radioButtonEndBoxNo.Font = new System.Drawing.Font("굴림", 13F);
            this.radioButtonEndBoxNo.Location = new System.Drawing.Point(8, 68);
            this.radioButtonEndBoxNo.Name = "radioButtonEndBoxNo";
            this.radioButtonEndBoxNo.Size = new System.Drawing.Size(80, 22);
            this.radioButtonEndBoxNo.TabIndex = 34;
            this.radioButtonEndBoxNo.TabStop = true;
            this.radioButtonEndBoxNo.Text = "끝번호";
            this.radioButtonEndBoxNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonStartBoxNo
            // 
            this.radioButtonStartBoxNo.AutoSize = true;
            this.radioButtonStartBoxNo.Font = new System.Drawing.Font("굴림", 13F);
            this.radioButtonStartBoxNo.Location = new System.Drawing.Point(6, 36);
            this.radioButtonStartBoxNo.Name = "radioButtonStartBoxNo";
            this.radioButtonStartBoxNo.Size = new System.Drawing.Size(98, 22);
            this.radioButtonStartBoxNo.TabIndex = 27;
            this.radioButtonStartBoxNo.TabStop = true;
            this.radioButtonStartBoxNo.Text = "시작번호";
            this.radioButtonStartBoxNo.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("굴림", 35F);
            this.labelTitle.Location = new System.Drawing.Point(13, 29);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(208, 47);
            this.labelTitle.TabIndex = 30;
            this.labelTitle.Text = "실적관리";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(683, 18);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(116, 70);
            this.buttonSearch.TabIndex = 50;
            this.buttonSearch.Text = "조회";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // labelTotalPeriod
            // 
            this.labelTotalPeriod.AutoSize = true;
            this.labelTotalPeriod.Font = new System.Drawing.Font("굴림", 13F);
            this.labelTotalPeriod.Location = new System.Drawing.Point(484, 64);
            this.labelTotalPeriod.Name = "labelTotalPeriod";
            this.labelTotalPeriod.Size = new System.Drawing.Size(62, 18);
            this.labelTotalPeriod.TabIndex = 49;
            this.labelTotalPeriod.Text = "총기간";
            // 
            // labelTestPeriod
            // 
            this.labelTestPeriod.AutoSize = true;
            this.labelTestPeriod.Font = new System.Drawing.Font("굴림", 13F);
            this.labelTestPeriod.Location = new System.Drawing.Point(465, 34);
            this.labelTestPeriod.Name = "labelTestPeriod";
            this.labelTestPeriod.Size = new System.Drawing.Size(80, 18);
            this.labelTestPeriod.TabIndex = 48;
            this.labelTestPeriod.Text = "시험기간";
            // 
            // comboBoxTransmissionMedia
            // 
            this.comboBoxTransmissionMedia.FormattingEnabled = true;
            this.comboBoxTransmissionMedia.Location = new System.Drawing.Point(347, 62);
            this.comboBoxTransmissionMedia.Name = "comboBoxTransmissionMedia";
            this.comboBoxTransmissionMedia.Size = new System.Drawing.Size(108, 20);
            this.comboBoxTransmissionMedia.TabIndex = 45;
            // 
            // labelTransmissionMedia
            // 
            this.labelTransmissionMedia.AutoSize = true;
            this.labelTransmissionMedia.Font = new System.Drawing.Font("굴림", 13F);
            this.labelTransmissionMedia.Location = new System.Drawing.Point(371, 36);
            this.labelTransmissionMedia.Name = "labelTransmissionMedia";
            this.labelTransmissionMedia.Size = new System.Drawing.Size(80, 18);
            this.labelTransmissionMedia.TabIndex = 44;
            this.labelTransmissionMedia.Text = "전송매체";
            // 
            // buttonUploadPerformance
            // 
            this.buttonUploadPerformance.Location = new System.Drawing.Point(576, 593);
            this.buttonUploadPerformance.Name = "buttonUploadPerformance";
            this.buttonUploadPerformance.Size = new System.Drawing.Size(119, 96);
            this.buttonUploadPerformance.TabIndex = 54;
            this.buttonUploadPerformance.Text = "실적내역\r\n업로드";
            this.buttonUploadPerformance.UseVisualStyleBackColor = true;
            this.buttonUploadPerformance.Click += new System.EventHandler(this.buttonUploadPerformance_Click);
            // 
            // buttonPerformanceDelete
            // 
            this.buttonPerformanceDelete.Location = new System.Drawing.Point(456, 593);
            this.buttonPerformanceDelete.Name = "buttonPerformanceDelete";
            this.buttonPerformanceDelete.Size = new System.Drawing.Size(119, 96);
            this.buttonPerformanceDelete.TabIndex = 53;
            this.buttonPerformanceDelete.Text = "생산실적삭제";
            this.buttonPerformanceDelete.UseVisualStyleBackColor = true;
            this.buttonPerformanceDelete.Click += new System.EventHandler(this.buttonPerformanceDelete_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(695, 592);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(119, 96);
            this.buttonClose.TabIndex = 55;
            this.buttonClose.Text = "닫기";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridViewPerformance
            // 
            this.dataGridViewPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerformance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridViewPerformance.Location = new System.Drawing.Point(18, 110);
            this.dataGridViewPerformance.Name = "dataGridViewPerformance";
            this.dataGridViewPerformance.RowTemplate.Height = 23;
            this.dataGridViewPerformance.Size = new System.Drawing.Size(781, 455);
            this.dataGridViewPerformance.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "생산일자";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "생산시간";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "태그";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "BOX시작";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "BOX끝";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "전송";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // panelSplitBar
            // 
            this.panelSplitBar.BackColor = System.Drawing.Color.White;
            this.panelSplitBar.Location = new System.Drawing.Point(12, 98);
            this.panelSplitBar.Name = "panelSplitBar";
            this.panelSplitBar.Size = new System.Drawing.Size(787, 3);
            this.panelSplitBar.TabIndex = 56;
            // 
            // comboBoxTestPeriod
            // 
            this.comboBoxTestPeriod.FormattingEnabled = true;
            this.comboBoxTestPeriod.Location = new System.Drawing.Point(552, 29);
            this.comboBoxTestPeriod.Name = "comboBoxTestPeriod";
            this.comboBoxTestPeriod.Size = new System.Drawing.Size(108, 20);
            this.comboBoxTestPeriod.TabIndex = 57;
            // 
            // comboBoxTotalPeriod
            // 
            this.comboBoxTotalPeriod.FormattingEnabled = true;
            this.comboBoxTotalPeriod.Location = new System.Drawing.Point(552, 66);
            this.comboBoxTotalPeriod.Name = "comboBoxTotalPeriod";
            this.comboBoxTotalPeriod.Size = new System.Drawing.Size(108, 20);
            this.comboBoxTotalPeriod.TabIndex = 58;
            // 
            // PerformanceManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 699);
            this.Controls.Add(this.comboBoxTotalPeriod);
            this.Controls.Add(this.comboBoxTestPeriod);
            this.Controls.Add(this.panelSplitBar);
            this.Controls.Add(this.dataGridViewPerformance);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonUploadPerformance);
            this.Controls.Add(this.buttonPerformanceDelete);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelTotalPeriod);
            this.Controls.Add(this.labelTestPeriod);
            this.Controls.Add(this.comboBoxTransmissionMedia);
            this.Controls.Add(this.labelTransmissionMedia);
            this.Controls.Add(this.groupBoxBoxInfo);
            this.Controls.Add(this.labelTitle);
            this.Name = "PerformanceManageForm";
            this.Text = "PerformanceManageForm";
            this.Load += new System.EventHandler(this.PerformanceManageForm_Load);
            this.groupBoxBoxInfo.ResumeLayout(false);
            this.groupBoxBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerformance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxBoxInfo;
        private System.Windows.Forms.RadioButton radioButtonEndBoxNo;
        private System.Windows.Forms.RadioButton radioButtonStartBoxNo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelTotalPeriod;
        private System.Windows.Forms.Label labelTestPeriod;
        private System.Windows.Forms.ComboBox comboBoxTransmissionMedia;
        private System.Windows.Forms.Label labelTransmissionMedia;
        private System.Windows.Forms.Button buttonUploadBoxHistory;
        private System.Windows.Forms.Button buttonEditBoxNo;
        private System.Windows.Forms.TextBox textBoxEndBoxNo;
        private System.Windows.Forms.TextBox textBoxStartBoxNo;
        private System.Windows.Forms.Button buttonUploadPerformance;
        private System.Windows.Forms.Button buttonPerformanceDelete;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewPerformance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Panel panelSplitBar;
        private System.Windows.Forms.ComboBox comboBoxTestPeriod;
        private System.Windows.Forms.ComboBox comboBoxTotalPeriod;
    }
}
namespace LotteMES.Forms
{
    partial class PerformanceSendLogForm
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
            this.groupBoxDataInput = new System.Windows.Forms.GroupBox();
            this.comboBoxShiftType = new System.Windows.Forms.ComboBox();
            this.comboBoxDateTo = new System.Windows.Forms.ComboBox();
            this.textBoxPlanNo = new System.Windows.Forms.TextBox();
            this.labelPlan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDateFrom = new System.Windows.Forms.ComboBox();
            this.labelShiftType = new System.Windows.Forms.Label();
            this.labelDateInput = new System.Windows.Forms.Label();
            this.dataGridViewTransmissionLog = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewTransmissionSummary = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSplitBar = new System.Windows.Forms.Panel();
            this.groupBoxDataInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransmissionLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransmissionSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDataInput
            // 
            this.groupBoxDataInput.Controls.Add(this.comboBoxShiftType);
            this.groupBoxDataInput.Controls.Add(this.comboBoxDateTo);
            this.groupBoxDataInput.Controls.Add(this.textBoxPlanNo);
            this.groupBoxDataInput.Controls.Add(this.labelPlan);
            this.groupBoxDataInput.Controls.Add(this.label8);
            this.groupBoxDataInput.Controls.Add(this.comboBoxDateFrom);
            this.groupBoxDataInput.Controls.Add(this.labelShiftType);
            this.groupBoxDataInput.Controls.Add(this.labelDateInput);
            this.groupBoxDataInput.Location = new System.Drawing.Point(380, 356);
            this.groupBoxDataInput.Name = "groupBoxDataInput";
            this.groupBoxDataInput.Size = new System.Drawing.Size(449, 99);
            this.groupBoxDataInput.TabIndex = 58;
            this.groupBoxDataInput.TabStop = false;
            // 
            // comboBoxShiftType
            // 
            this.comboBoxShiftType.FormattingEnabled = true;
            this.comboBoxShiftType.Location = new System.Drawing.Point(364, 61);
            this.comboBoxShiftType.Name = "comboBoxShiftType";
            this.comboBoxShiftType.Size = new System.Drawing.Size(79, 20);
            this.comboBoxShiftType.TabIndex = 30;
            // 
            // comboBoxDateTo
            // 
            this.comboBoxDateTo.FormattingEnabled = true;
            this.comboBoxDateTo.Location = new System.Drawing.Point(286, 25);
            this.comboBoxDateTo.Name = "comboBoxDateTo";
            this.comboBoxDateTo.Size = new System.Drawing.Size(124, 20);
            this.comboBoxDateTo.TabIndex = 29;
            // 
            // textBoxPlanNo
            // 
            this.textBoxPlanNo.Location = new System.Drawing.Point(103, 61);
            this.textBoxPlanNo.Name = "textBoxPlanNo";
            this.textBoxPlanNo.Size = new System.Drawing.Size(163, 21);
            this.textBoxPlanNo.TabIndex = 28;
            // 
            // labelPlan
            // 
            this.labelPlan.AutoSize = true;
            this.labelPlan.Font = new System.Drawing.Font("굴림", 15F);
            this.labelPlan.Location = new System.Drawing.Point(8, 57);
            this.labelPlan.Name = "labelPlan";
            this.labelPlan.Size = new System.Drawing.Size(89, 20);
            this.labelPlan.TabIndex = 27;
            this.labelPlan.Text = "생산계획";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 10F);
            this.label8.Location = new System.Drawing.Point(248, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 14);
            this.label8.TabIndex = 25;
            this.label8.Text = "~";
            // 
            // comboBoxDateFrom
            // 
            this.comboBoxDateFrom.FormattingEnabled = true;
            this.comboBoxDateFrom.Location = new System.Drawing.Point(103, 25);
            this.comboBoxDateFrom.Name = "comboBoxDateFrom";
            this.comboBoxDateFrom.Size = new System.Drawing.Size(124, 20);
            this.comboBoxDateFrom.TabIndex = 23;
            // 
            // labelShiftType
            // 
            this.labelShiftType.AutoSize = true;
            this.labelShiftType.Font = new System.Drawing.Font("굴림", 15F);
            this.labelShiftType.Location = new System.Drawing.Point(272, 62);
            this.labelShiftType.Name = "labelShiftType";
            this.labelShiftType.Size = new System.Drawing.Size(89, 20);
            this.labelShiftType.TabIndex = 21;
            this.labelShiftType.Text = "주야구분";
            // 
            // labelDateInput
            // 
            this.labelDateInput.AutoSize = true;
            this.labelDateInput.Font = new System.Drawing.Font("굴림", 15F);
            this.labelDateInput.Location = new System.Drawing.Point(8, 25);
            this.labelDateInput.Name = "labelDateInput";
            this.labelDateInput.Size = new System.Drawing.Size(89, 20);
            this.labelDateInput.TabIndex = 19;
            this.labelDateInput.Text = "날짜입력";
            // 
            // dataGridViewTransmissionLog
            // 
            this.dataGridViewTransmissionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransmissionLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewTransmissionLog.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewTransmissionLog.Name = "dataGridViewTransmissionLog";
            this.dataGridViewTransmissionLog.RowTemplate.Height = 23;
            this.dataGridViewTransmissionLog.Size = new System.Drawing.Size(817, 268);
            this.dataGridViewTransmissionLog.TabIndex = 51;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "계시일자";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "주/야";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "제품명";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "생산계획번호";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "실적조회";
            this.Column5.Name = "Column5";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("굴림", 35F);
            this.labelTitle.Location = new System.Drawing.Point(3, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(412, 47);
            this.labelTitle.TabIndex = 47;
            this.labelTitle.Text = "실적전송 이력조회";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(640, 479);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(189, 70);
            this.buttonClose.TabIndex = 50;
            this.buttonClose.Text = "닫기";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(380, 479);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(196, 70);
            this.buttonSearch.TabIndex = 48;
            this.buttonSearch.Text = "조회";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTransmissionSummary
            // 
            this.dataGridViewTransmissionSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransmissionSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewTransmissionSummary.Location = new System.Drawing.Point(11, 356);
            this.dataGridViewTransmissionSummary.Name = "dataGridViewTransmissionSummary";
            this.dataGridViewTransmissionSummary.RowTemplate.Height = 23;
            this.dataGridViewTransmissionSummary.Size = new System.Drawing.Size(346, 215);
            this.dataGridViewTransmissionSummary.TabIndex = 59;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "생산일자";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "실적전송수량";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // panelSplitBar
            // 
            this.panelSplitBar.BackColor = System.Drawing.Color.White;
            this.panelSplitBar.Location = new System.Drawing.Point(13, 64);
            this.panelSplitBar.Name = "panelSplitBar";
            this.panelSplitBar.Size = new System.Drawing.Size(800, 3);
            this.panelSplitBar.TabIndex = 60;
            // 
            // PerformanceSendLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 583);
            this.Controls.Add(this.panelSplitBar);
            this.Controls.Add(this.dataGridViewTransmissionSummary);
            this.Controls.Add(this.groupBoxDataInput);
            this.Controls.Add(this.dataGridViewTransmissionLog);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSearch);
            this.Name = "PerformanceSendLogForm";
            this.Text = "PerformanceSendLogForm";
            this.groupBoxDataInput.ResumeLayout(false);
            this.groupBoxDataInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransmissionLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransmissionSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDataInput;
        private System.Windows.Forms.TextBox textBoxPlanNo;
        private System.Windows.Forms.Label labelPlan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxDateFrom;
        private System.Windows.Forms.Label labelShiftType;
        private System.Windows.Forms.Label labelDateInput;
        private System.Windows.Forms.DataGridView dataGridViewTransmissionLog;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxShiftType;
        private System.Windows.Forms.ComboBox comboBoxDateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dataGridViewTransmissionSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panelSplitBar;
    }
}
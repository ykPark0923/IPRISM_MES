namespace LotteMES.Forms
{
    partial class ProductionPlanForm
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
            this.dataGridViewPlanList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxMismatchProduct = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSelectPlan = new System.Windows.Forms.Button();
            this.labelMismatchInfo = new System.Windows.Forms.Label();
            this.buttonDownloadPlan = new System.Windows.Forms.Button();
            this.buttonInputPlan = new System.Windows.Forms.Button();
            this.labelTestPeriod = new System.Windows.Forms.Label();
            this.labelTotalPeriod = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxProductionPlan = new System.Windows.Forms.GroupBox();
            this.dateTimePickerProductionDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPlanQuantity = new System.Windows.Forms.TextBox();
            this.labelPlanQuantity = new System.Windows.Forms.Label();
            this.comboBoxShiftType = new System.Windows.Forms.ComboBox();
            this.labelShiftType = new System.Windows.Forms.Label();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.textBoxPlanNo = new System.Windows.Forms.TextBox();
            this.labelPlanNo = new System.Windows.Forms.Label();
            this.labelProductionDate = new System.Windows.Forms.Label();
            this.textBoxBarcodeNo = new System.Windows.Forms.TextBox();
            this.labelBarcodeNo = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.panelSplitBar = new System.Windows.Forms.Panel();
            this.dateTimePickerTotalPeriod = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTestPeriod = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanList)).BeginInit();
            this.groupBoxProductionPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPlanList
            // 
            this.dataGridViewPlanList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPlanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlanList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewPlanList.Location = new System.Drawing.Point(12, 85);
            this.dataGridViewPlanList.Name = "dataGridViewPlanList";
            this.dataGridViewPlanList.RowHeadersVisible = false;
            this.dataGridViewPlanList.RowTemplate.Height = 23;
            this.dataGridViewPlanList.Size = new System.Drawing.Size(907, 277);
            this.dataGridViewPlanList.TabIndex = 35;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "생산일자";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "주/야";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "제품명";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "계획수량";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "생산계획번호";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "설치수량";
            this.Column7.Name = "Column7";
            // 
            // comboBoxMismatchProduct
            // 
            this.comboBoxMismatchProduct.FormattingEnabled = true;
            this.comboBoxMismatchProduct.Location = new System.Drawing.Point(380, 45);
            this.comboBoxMismatchProduct.Name = "comboBoxMismatchProduct";
            this.comboBoxMismatchProduct.Size = new System.Drawing.Size(181, 20);
            this.comboBoxMismatchProduct.TabIndex = 30;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("굴림", 35F);
            this.labelTitle.Location = new System.Drawing.Point(12, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(208, 47);
            this.labelTitle.TabIndex = 31;
            this.labelTitle.Text = "생산계획";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(711, 498);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(208, 70);
            this.buttonClose.TabIndex = 34;
            this.buttonClose.Text = "닫기";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSelectPlan
            // 
            this.buttonSelectPlan.Location = new System.Drawing.Point(239, 498);
            this.buttonSelectPlan.Name = "buttonSelectPlan";
            this.buttonSelectPlan.Size = new System.Drawing.Size(218, 70);
            this.buttonSelectPlan.TabIndex = 33;
            this.buttonSelectPlan.Text = "생산계획선택";
            this.buttonSelectPlan.UseVisualStyleBackColor = true;
            this.buttonSelectPlan.Click += new System.EventHandler(this.buttonSelectPlan_Click);
            // 
            // labelMismatchInfo
            // 
            this.labelMismatchInfo.AutoSize = true;
            this.labelMismatchInfo.Font = new System.Drawing.Font("굴림", 13F);
            this.labelMismatchInfo.Location = new System.Drawing.Point(371, 22);
            this.labelMismatchInfo.Name = "labelMismatchInfo";
            this.labelMismatchInfo.Size = new System.Drawing.Size(190, 18);
            this.labelMismatchInfo.TabIndex = 29;
            this.labelMismatchInfo.Text = "제품/단위 불일치 건수";
            // 
            // buttonDownloadPlan
            // 
            this.buttonDownloadPlan.Location = new System.Drawing.Point(8, 498);
            this.buttonDownloadPlan.Name = "buttonDownloadPlan";
            this.buttonDownloadPlan.Size = new System.Drawing.Size(215, 70);
            this.buttonDownloadPlan.TabIndex = 32;
            this.buttonDownloadPlan.Text = "생산계획 Down";
            this.buttonDownloadPlan.UseVisualStyleBackColor = true;
            this.buttonDownloadPlan.Click += new System.EventHandler(this.buttonDownloadPlan_Click);
            // 
            // buttonInputPlan
            // 
            this.buttonInputPlan.Location = new System.Drawing.Point(475, 498);
            this.buttonInputPlan.Name = "buttonInputPlan";
            this.buttonInputPlan.Size = new System.Drawing.Size(218, 70);
            this.buttonInputPlan.TabIndex = 36;
            this.buttonInputPlan.Text = "생산계획입력";
            this.buttonInputPlan.UseVisualStyleBackColor = true;
            this.buttonInputPlan.Click += new System.EventHandler(this.buttonInputPlan_Click);
            // 
            // labelTestPeriod
            // 
            this.labelTestPeriod.AutoSize = true;
            this.labelTestPeriod.Font = new System.Drawing.Font("굴림", 13F);
            this.labelTestPeriod.Location = new System.Drawing.Point(574, 18);
            this.labelTestPeriod.Name = "labelTestPeriod";
            this.labelTestPeriod.Size = new System.Drawing.Size(80, 18);
            this.labelTestPeriod.TabIndex = 41;
            this.labelTestPeriod.Text = "시험기간";
            // 
            // labelTotalPeriod
            // 
            this.labelTotalPeriod.AutoSize = true;
            this.labelTotalPeriod.Font = new System.Drawing.Font("굴림", 13F);
            this.labelTotalPeriod.Location = new System.Drawing.Point(592, 47);
            this.labelTotalPeriod.Name = "labelTotalPeriod";
            this.labelTotalPeriod.Size = new System.Drawing.Size(62, 18);
            this.labelTotalPeriod.TabIndex = 42;
            this.labelTotalPeriod.Text = "총기간";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(803, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(116, 58);
            this.buttonSearch.TabIndex = 43;
            this.buttonSearch.Text = "조회";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // groupBoxProductionPlan
            // 
            this.groupBoxProductionPlan.Controls.Add(this.dateTimePickerProductionDate);
            this.groupBoxProductionPlan.Controls.Add(this.textBoxPlanQuantity);
            this.groupBoxProductionPlan.Controls.Add(this.labelPlanQuantity);
            this.groupBoxProductionPlan.Controls.Add(this.comboBoxShiftType);
            this.groupBoxProductionPlan.Controls.Add(this.labelShiftType);
            this.groupBoxProductionPlan.Controls.Add(this.comboBoxProductName);
            this.groupBoxProductionPlan.Controls.Add(this.textBoxPlanNo);
            this.groupBoxProductionPlan.Controls.Add(this.labelPlanNo);
            this.groupBoxProductionPlan.Controls.Add(this.labelProductionDate);
            this.groupBoxProductionPlan.Controls.Add(this.textBoxBarcodeNo);
            this.groupBoxProductionPlan.Controls.Add(this.labelBarcodeNo);
            this.groupBoxProductionPlan.Controls.Add(this.labelProductName);
            this.groupBoxProductionPlan.Location = new System.Drawing.Point(12, 368);
            this.groupBoxProductionPlan.Name = "groupBoxProductionPlan";
            this.groupBoxProductionPlan.Size = new System.Drawing.Size(907, 124);
            this.groupBoxProductionPlan.TabIndex = 44;
            this.groupBoxProductionPlan.TabStop = false;
            // 
            // dateTimePickerProductionDate
            // 
            this.dateTimePickerProductionDate.Location = new System.Drawing.Point(90, 74);
            this.dateTimePickerProductionDate.Name = "dateTimePickerProductionDate";
            this.dateTimePickerProductionDate.Size = new System.Drawing.Size(147, 21);
            this.dateTimePickerProductionDate.TabIndex = 29;
            // 
            // textBoxPlanQuantity
            // 
            this.textBoxPlanQuantity.Location = new System.Drawing.Point(500, 73);
            this.textBoxPlanQuantity.Name = "textBoxPlanQuantity";
            this.textBoxPlanQuantity.Size = new System.Drawing.Size(109, 21);
            this.textBoxPlanQuantity.TabIndex = 28;
            // 
            // labelPlanQuantity
            // 
            this.labelPlanQuantity.AutoSize = true;
            this.labelPlanQuantity.Font = new System.Drawing.Font("굴림", 13F);
            this.labelPlanQuantity.Location = new System.Drawing.Point(414, 78);
            this.labelPlanQuantity.Name = "labelPlanQuantity";
            this.labelPlanQuantity.Size = new System.Drawing.Size(80, 18);
            this.labelPlanQuantity.TabIndex = 27;
            this.labelPlanQuantity.Text = "계획수량";
            // 
            // comboBoxShiftType
            // 
            this.comboBoxShiftType.FormattingEnabled = true;
            this.comboBoxShiftType.Location = new System.Drawing.Point(324, 75);
            this.comboBoxShiftType.Name = "comboBoxShiftType";
            this.comboBoxShiftType.Size = new System.Drawing.Size(80, 20);
            this.comboBoxShiftType.TabIndex = 26;
            // 
            // labelShiftType
            // 
            this.labelShiftType.AutoSize = true;
            this.labelShiftType.Font = new System.Drawing.Font("굴림", 13F);
            this.labelShiftType.Location = new System.Drawing.Point(243, 75);
            this.labelShiftType.Name = "labelShiftType";
            this.labelShiftType.Size = new System.Drawing.Size(80, 18);
            this.labelShiftType.TabIndex = 25;
            this.labelShiftType.Text = "주야구분";
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(90, 28);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(547, 20);
            this.comboBoxProductName.TabIndex = 24;
            // 
            // textBoxPlanNo
            // 
            this.textBoxPlanNo.Location = new System.Drawing.Point(737, 75);
            this.textBoxPlanNo.Name = "textBoxPlanNo";
            this.textBoxPlanNo.Size = new System.Drawing.Size(164, 21);
            this.textBoxPlanNo.TabIndex = 22;
            // 
            // labelPlanNo
            // 
            this.labelPlanNo.AutoSize = true;
            this.labelPlanNo.Font = new System.Drawing.Font("굴림", 13F);
            this.labelPlanNo.Location = new System.Drawing.Point(615, 77);
            this.labelPlanNo.Name = "labelPlanNo";
            this.labelPlanNo.Size = new System.Drawing.Size(116, 18);
            this.labelPlanNo.TabIndex = 21;
            this.labelPlanNo.Text = "생산계획번호";
            // 
            // labelProductionDate
            // 
            this.labelProductionDate.AutoSize = true;
            this.labelProductionDate.Font = new System.Drawing.Font("굴림", 13F);
            this.labelProductionDate.Location = new System.Drawing.Point(6, 78);
            this.labelProductionDate.Name = "labelProductionDate";
            this.labelProductionDate.Size = new System.Drawing.Size(80, 18);
            this.labelProductionDate.TabIndex = 19;
            this.labelProductionDate.Text = "생산일자";
            // 
            // textBoxBarcodeNo
            // 
            this.textBoxBarcodeNo.Location = new System.Drawing.Point(779, 29);
            this.textBoxBarcodeNo.Name = "textBoxBarcodeNo";
            this.textBoxBarcodeNo.Size = new System.Drawing.Size(109, 21);
            this.textBoxBarcodeNo.TabIndex = 18;
            // 
            // labelBarcodeNo
            // 
            this.labelBarcodeNo.AutoSize = true;
            this.labelBarcodeNo.Font = new System.Drawing.Font("굴림", 13F);
            this.labelBarcodeNo.Location = new System.Drawing.Point(676, 32);
            this.labelBarcodeNo.Name = "labelBarcodeNo";
            this.labelBarcodeNo.Size = new System.Drawing.Size(97, 18);
            this.labelBarcodeNo.TabIndex = 17;
            this.labelBarcodeNo.Text = "바코드 No.";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("굴림", 13F);
            this.labelProductName.Location = new System.Drawing.Point(12, 32);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(74, 18);
            this.labelProductName.TabIndex = 15;
            this.labelProductName.Text = "제 품 명";
            // 
            // panelSplitBar
            // 
            this.panelSplitBar.BackColor = System.Drawing.Color.White;
            this.panelSplitBar.Location = new System.Drawing.Point(8, 76);
            this.panelSplitBar.Name = "panelSplitBar";
            this.panelSplitBar.Size = new System.Drawing.Size(911, 3);
            this.panelSplitBar.TabIndex = 45;
            // 
            // dateTimePickerTotalPeriod
            // 
            this.dateTimePickerTotalPeriod.Location = new System.Drawing.Point(653, 44);
            this.dateTimePickerTotalPeriod.Name = "dateTimePickerTotalPeriod";
            this.dateTimePickerTotalPeriod.Size = new System.Drawing.Size(147, 21);
            this.dateTimePickerTotalPeriod.TabIndex = 30;
            // 
            // dateTimePickerTestPeriod
            // 
            this.dateTimePickerTestPeriod.Location = new System.Drawing.Point(653, 17);
            this.dateTimePickerTestPeriod.Name = "dateTimePickerTestPeriod";
            this.dateTimePickerTestPeriod.Size = new System.Drawing.Size(147, 21);
            this.dateTimePickerTestPeriod.TabIndex = 31;
            // 
            // ProductionPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 570);
            this.Controls.Add(this.dateTimePickerTotalPeriod);
            this.Controls.Add(this.dateTimePickerTestPeriod);
            this.Controls.Add(this.panelSplitBar);
            this.Controls.Add(this.groupBoxProductionPlan);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelTotalPeriod);
            this.Controls.Add(this.labelTestPeriod);
            this.Controls.Add(this.buttonInputPlan);
            this.Controls.Add(this.dataGridViewPlanList);
            this.Controls.Add(this.comboBoxMismatchProduct);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSelectPlan);
            this.Controls.Add(this.labelMismatchInfo);
            this.Controls.Add(this.buttonDownloadPlan);
            this.Name = "ProductionPlanForm";
            this.Text = "ProductionPlanForm";
            this.Load += new System.EventHandler(this.ProductionPlanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanList)).EndInit();
            this.groupBoxProductionPlan.ResumeLayout(false);
            this.groupBoxProductionPlan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlanList;
        private System.Windows.Forms.ComboBox comboBoxMismatchProduct;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSelectPlan;
        private System.Windows.Forms.Label labelMismatchInfo;
        private System.Windows.Forms.Button buttonDownloadPlan;
        private System.Windows.Forms.Button buttonInputPlan;
        private System.Windows.Forms.Label labelTestPeriod;
        private System.Windows.Forms.Label labelTotalPeriod;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxProductionPlan;
        private System.Windows.Forms.TextBox textBoxPlanQuantity;
        private System.Windows.Forms.Label labelPlanQuantity;
        private System.Windows.Forms.ComboBox comboBoxShiftType;
        private System.Windows.Forms.Label labelShiftType;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.TextBox textBoxPlanNo;
        private System.Windows.Forms.Label labelPlanNo;
        private System.Windows.Forms.Label labelProductionDate;
        private System.Windows.Forms.TextBox textBoxBarcodeNo;
        private System.Windows.Forms.Label labelBarcodeNo;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Panel panelSplitBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DateTimePicker dateTimePickerProductionDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTotalPeriod;
        private System.Windows.Forms.DateTimePicker dateTimePickerTestPeriod;
    }
}
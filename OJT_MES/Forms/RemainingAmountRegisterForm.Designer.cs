namespace LotteMES.Forms
{
    partial class RemainingAmountRegisterForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.textBoxRemainQuantity = new System.Windows.Forms.TextBox();
            this.labelRemainQuantity = new System.Windows.Forms.Label();
            this.textBoxActualQuantity = new System.Windows.Forms.TextBox();
            this.labelActualQuantity = new System.Windows.Forms.Label();
            this.textBoxPlanQuantity = new System.Windows.Forms.TextBox();
            this.labelPlanQuantity = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxShiftType = new System.Windows.Forms.TextBox();
            this.labelShiftType = new System.Windows.Forms.Label();
            this.textBoxPlanNo = new System.Windows.Forms.TextBox();
            this.labelPlanNo = new System.Windows.Forms.Label();
            this.textBoxProductionDateTop = new System.Windows.Forms.TextBox();
            this.labelProductionDate = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelSplitBar = new System.Windows.Forms.Panel();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(18, 278);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(252, 71);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "취소";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(297, 279);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(265, 70);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "저장";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.textBoxRemainQuantity);
            this.panelData.Controls.Add(this.labelRemainQuantity);
            this.panelData.Controls.Add(this.textBoxActualQuantity);
            this.panelData.Controls.Add(this.labelActualQuantity);
            this.panelData.Controls.Add(this.textBoxPlanQuantity);
            this.panelData.Controls.Add(this.labelPlanQuantity);
            this.panelData.Controls.Add(this.textBoxProductName);
            this.panelData.Controls.Add(this.labelProductName);
            this.panelData.Controls.Add(this.textBoxShiftType);
            this.panelData.Controls.Add(this.labelShiftType);
            this.panelData.Controls.Add(this.textBoxPlanNo);
            this.panelData.Controls.Add(this.labelPlanNo);
            this.panelData.Controls.Add(this.textBoxProductionDateTop);
            this.panelData.Controls.Add(this.labelProductionDate);
            this.panelData.Location = new System.Drawing.Point(18, 61);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(544, 212);
            this.panelData.TabIndex = 5;
            // 
            // textBoxRemainQuantity
            // 
            this.textBoxRemainQuantity.Location = new System.Drawing.Point(402, 101);
            this.textBoxRemainQuantity.Name = "textBoxRemainQuantity";
            this.textBoxRemainQuantity.Size = new System.Drawing.Size(109, 21);
            this.textBoxRemainQuantity.TabIndex = 14;
            // 
            // labelRemainQuantity
            // 
            this.labelRemainQuantity.AutoSize = true;
            this.labelRemainQuantity.Font = new System.Drawing.Font("굴림", 10F);
            this.labelRemainQuantity.Location = new System.Drawing.Point(322, 108);
            this.labelRemainQuantity.Name = "labelRemainQuantity";
            this.labelRemainQuantity.Size = new System.Drawing.Size(70, 14);
            this.labelRemainQuantity.TabIndex = 13;
            this.labelRemainQuantity.Text = "*잔량수량";
            // 
            // textBoxActualQuantity
            // 
            this.textBoxActualQuantity.Location = new System.Drawing.Point(74, 169);
            this.textBoxActualQuantity.Name = "textBoxActualQuantity";
            this.textBoxActualQuantity.Size = new System.Drawing.Size(109, 21);
            this.textBoxActualQuantity.TabIndex = 12;
            // 
            // labelActualQuantity
            // 
            this.labelActualQuantity.AutoSize = true;
            this.labelActualQuantity.Font = new System.Drawing.Font("굴림", 10F);
            this.labelActualQuantity.Location = new System.Drawing.Point(11, 174);
            this.labelActualQuantity.Name = "labelActualQuantity";
            this.labelActualQuantity.Size = new System.Drawing.Size(63, 14);
            this.labelActualQuantity.TabIndex = 11;
            this.labelActualQuantity.Text = "실적수량";
            // 
            // textBoxPlanQuantity
            // 
            this.textBoxPlanQuantity.Location = new System.Drawing.Point(74, 113);
            this.textBoxPlanQuantity.Name = "textBoxPlanQuantity";
            this.textBoxPlanQuantity.Size = new System.Drawing.Size(109, 21);
            this.textBoxPlanQuantity.TabIndex = 10;
            // 
            // labelPlanQuantity
            // 
            this.labelPlanQuantity.AutoSize = true;
            this.labelPlanQuantity.Font = new System.Drawing.Font("굴림", 10F);
            this.labelPlanQuantity.Location = new System.Drawing.Point(11, 118);
            this.labelPlanQuantity.Name = "labelPlanQuantity";
            this.labelPlanQuantity.Size = new System.Drawing.Size(63, 14);
            this.labelPlanQuantity.TabIndex = 9;
            this.labelPlanQuantity.Text = "계획수량";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(74, 62);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(464, 21);
            this.textBoxProductName.TabIndex = 8;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("굴림", 10F);
            this.labelProductName.Location = new System.Drawing.Point(11, 67);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(49, 14);
            this.labelProductName.TabIndex = 7;
            this.labelProductName.Text = "제품명";
            // 
            // textBoxShiftType
            // 
            this.textBoxShiftType.Location = new System.Drawing.Point(461, 15);
            this.textBoxShiftType.Name = "textBoxShiftType";
            this.textBoxShiftType.Size = new System.Drawing.Size(77, 21);
            this.textBoxShiftType.TabIndex = 6;
            // 
            // labelShiftType
            // 
            this.labelShiftType.AutoSize = true;
            this.labelShiftType.Font = new System.Drawing.Font("굴림", 10F);
            this.labelShiftType.Location = new System.Drawing.Point(399, 20);
            this.labelShiftType.Name = "labelShiftType";
            this.labelShiftType.Size = new System.Drawing.Size(63, 14);
            this.labelShiftType.TabIndex = 5;
            this.labelShiftType.Text = "주야구분";
            // 
            // textBoxPlanNo
            // 
            this.textBoxPlanNo.Location = new System.Drawing.Point(277, 17);
            this.textBoxPlanNo.Name = "textBoxPlanNo";
            this.textBoxPlanNo.Size = new System.Drawing.Size(115, 21);
            this.textBoxPlanNo.TabIndex = 4;
            // 
            // labelPlanNo
            // 
            this.labelPlanNo.AutoSize = true;
            this.labelPlanNo.Font = new System.Drawing.Font("굴림", 10F);
            this.labelPlanNo.Location = new System.Drawing.Point(186, 22);
            this.labelPlanNo.Name = "labelPlanNo";
            this.labelPlanNo.Size = new System.Drawing.Size(91, 14);
            this.labelPlanNo.TabIndex = 3;
            this.labelPlanNo.Text = "생산계획번호";
            // 
            // textBoxProductionDateTop
            // 
            this.textBoxProductionDateTop.Location = new System.Drawing.Point(74, 17);
            this.textBoxProductionDateTop.Name = "textBoxProductionDateTop";
            this.textBoxProductionDateTop.Size = new System.Drawing.Size(109, 21);
            this.textBoxProductionDateTop.TabIndex = 2;
            // 
            // labelProductionDate
            // 
            this.labelProductionDate.AutoSize = true;
            this.labelProductionDate.Font = new System.Drawing.Font("굴림", 10F);
            this.labelProductionDate.Location = new System.Drawing.Point(11, 22);
            this.labelProductionDate.Name = "labelProductionDate";
            this.labelProductionDate.Size = new System.Drawing.Size(63, 14);
            this.labelProductionDate.TabIndex = 0;
            this.labelProductionDate.Text = "생산일자";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("굴림", 35F);
            this.labelTitle.Location = new System.Drawing.Point(18, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(208, 47);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "잔량등록";
            // 
            // panelSplitBar
            // 
            this.panelSplitBar.BackColor = System.Drawing.Color.White;
            this.panelSplitBar.Location = new System.Drawing.Point(12, 55);
            this.panelSplitBar.Name = "panelSplitBar";
            this.panelSplitBar.Size = new System.Drawing.Size(550, 3);
            this.panelSplitBar.TabIndex = 57;
            // 
            // RemainingAmountRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panelSplitBar);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.labelTitle);
            this.Name = "RemainingAmountRegisterForm";
            this.Text = "RemainingAmountRegisterForm";
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxShiftType;
        private System.Windows.Forms.Label labelShiftType;
        private System.Windows.Forms.TextBox textBoxPlanNo;
        private System.Windows.Forms.Label labelPlanNo;
        private System.Windows.Forms.TextBox textBoxProductionDateTop;
        private System.Windows.Forms.Label labelProductionDate;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxRemainQuantity;
        private System.Windows.Forms.Label labelRemainQuantity;
        private System.Windows.Forms.TextBox textBoxActualQuantity;
        private System.Windows.Forms.Label labelActualQuantity;
        private System.Windows.Forms.TextBox textBoxPlanQuantity;
        private System.Windows.Forms.Label labelPlanQuantity;
        private System.Windows.Forms.Panel panelSplitBar;
    }
}
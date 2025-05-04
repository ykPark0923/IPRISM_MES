namespace LotteMES.Forms
{
    partial class WorkInfoForm
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
            this.panelSplitBar = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelWorkStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelSplitBar
            // 
            this.panelSplitBar.BackColor = System.Drawing.Color.White;
            this.panelSplitBar.Location = new System.Drawing.Point(14, 64);
            this.panelSplitBar.Name = "panelSplitBar";
            this.panelSplitBar.Size = new System.Drawing.Size(360, 3);
            this.panelSplitBar.TabIndex = 35;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Turquoise;
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(16, 165);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(356, 84);
            this.buttonOK.TabIndex = 33;
            this.buttonOK.Text = "확인";
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("돋움", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(10, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(177, 40);
            this.labelTitle.TabIndex = 31;
            this.labelTitle.Text = "작업정보";
            // 
            // labelWorkStatus
            // 
            this.labelWorkStatus.BackColor = System.Drawing.Color.White;
            this.labelWorkStatus.Location = new System.Drawing.Point(17, 74);
            this.labelWorkStatus.Name = "labelWorkStatus";
            this.labelWorkStatus.Size = new System.Drawing.Size(356, 84);
            this.labelWorkStatus.TabIndex = 36;
            this.labelWorkStatus.Text = "생산계획데이터가 수동으로 등록되었습니다!!!";
            this.labelWorkStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.labelWorkStatus);
            this.Controls.Add(this.panelSplitBar);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelTitle);
            this.Name = "WorkInfoForm";
            this.Text = "WorkInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSplitBar;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelWorkStatus;
    }
}
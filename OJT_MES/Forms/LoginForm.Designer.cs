namespace LotteMES.Forms
{
    partial class LoginForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.textBoxWorkerPassword = new System.Windows.Forms.TextBox();
            this.textBoxWorkerId = new System.Windows.Forms.TextBox();
            this.labelWorkerPassword = new System.Windows.Forms.Label();
            this.labelWorkerId = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelSplitBar = new System.Windows.Forms.Panel();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("굴림", 35F);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(7, 17);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(208, 47);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "접근암호";
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.textBoxWorkerPassword);
            this.panelData.Controls.Add(this.textBoxWorkerId);
            this.panelData.Controls.Add(this.labelWorkerPassword);
            this.panelData.Controls.Add(this.labelWorkerId);
            this.panelData.Location = new System.Drawing.Point(12, 73);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(360, 106);
            this.panelData.TabIndex = 1;
            // 
            // textBoxWorkerPassword
            // 
            this.textBoxWorkerPassword.BackColor = System.Drawing.Color.Khaki;
            this.textBoxWorkerPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxWorkerPassword.Location = new System.Drawing.Point(176, 69);
            this.textBoxWorkerPassword.Name = "textBoxWorkerPassword";
            this.textBoxWorkerPassword.Size = new System.Drawing.Size(168, 21);
            this.textBoxWorkerPassword.TabIndex = 3;
            // 
            // textBoxWorkerId
            // 
            this.textBoxWorkerId.BackColor = System.Drawing.Color.Khaki;
            this.textBoxWorkerId.ForeColor = System.Drawing.Color.White;
            this.textBoxWorkerId.Location = new System.Drawing.Point(177, 22);
            this.textBoxWorkerId.Name = "textBoxWorkerId";
            this.textBoxWorkerId.Size = new System.Drawing.Size(168, 21);
            this.textBoxWorkerId.TabIndex = 2;
            // 
            // labelWorkerPassword
            // 
            this.labelWorkerPassword.AutoSize = true;
            this.labelWorkerPassword.Font = new System.Drawing.Font("굴림", 15F);
            this.labelWorkerPassword.ForeColor = System.Drawing.Color.White;
            this.labelWorkerPassword.Location = new System.Drawing.Point(32, 69);
            this.labelWorkerPassword.Name = "labelWorkerPassword";
            this.labelWorkerPassword.Size = new System.Drawing.Size(116, 20);
            this.labelWorkerPassword.TabIndex = 1;
            this.labelWorkerPassword.Text = "작업자 암호";
            // 
            // labelWorkerId
            // 
            this.labelWorkerId.AutoSize = true;
            this.labelWorkerId.Font = new System.Drawing.Font("굴림", 15F);
            this.labelWorkerId.ForeColor = System.Drawing.Color.White;
            this.labelWorkerId.Location = new System.Drawing.Point(53, 20);
            this.labelWorkerId.Name = "labelWorkerId";
            this.labelWorkerId.Size = new System.Drawing.Size(92, 20);
            this.labelWorkerId.TabIndex = 0;
            this.labelWorkerId.Text = "작업자 ID";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Turquoise;
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(13, 179);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(176, 70);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "확인";
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Turquoise;
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(192, 179);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(177, 71);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "취소";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelSplitBar
            // 
            this.panelSplitBar.BackColor = System.Drawing.Color.White;
            this.panelSplitBar.Location = new System.Drawing.Point(11, 67);
            this.panelSplitBar.Name = "panelSplitBar";
            this.panelSplitBar.Size = new System.Drawing.Size(360, 3);
            this.panelSplitBar.TabIndex = 30;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.panelSplitBar);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.labelTitle);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.TextBox textBoxWorkerPassword;
        private System.Windows.Forms.TextBox textBoxWorkerId;
        private System.Windows.Forms.Label labelWorkerPassword;
        private System.Windows.Forms.Label labelWorkerId;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelSplitBar;
    }
}
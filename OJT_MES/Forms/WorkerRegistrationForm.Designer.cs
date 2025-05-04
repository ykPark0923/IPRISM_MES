namespace LotteMES.Forms
{
    partial class WorkerRegistrationForm
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
            this.dataGridViewWorker = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDataInput = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelDateInput = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorker)).BeginInit();
            this.groupBoxDataInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSplitBar
            // 
            this.panelSplitBar.BackColor = System.Drawing.Color.White;
            this.panelSplitBar.Location = new System.Drawing.Point(11, 59);
            this.panelSplitBar.Name = "panelSplitBar";
            this.panelSplitBar.Size = new System.Drawing.Size(680, 3);
            this.panelSplitBar.TabIndex = 39;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Turquoise;
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(4, 507);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(356, 84);
            this.buttonOK.TabIndex = 38;
            this.buttonOK.Text = "닫기";
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("굴림", 35F);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(255, 47);
            this.labelTitle.TabIndex = 37;
            this.labelTitle.Text = "작업자생성";
            // 
            // dataGridViewWorker
            // 
            this.dataGridViewWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.WorkerName});
            this.dataGridViewWorker.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewWorker.Name = "dataGridViewWorker";
            this.dataGridViewWorker.RowHeadersVisible = false;
            this.dataGridViewWorker.RowTemplate.Height = 23;
            this.dataGridViewWorker.Size = new System.Drawing.Size(307, 595);
            this.dataGridViewWorker.TabIndex = 40;
            // 
            // No
            // 
            this.No.FillWeight = 71.06599F;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            // 
            // WorkerName
            // 
            this.WorkerName.FillWeight = 128.934F;
            this.WorkerName.HeaderText = "작업자이름";
            this.WorkerName.Name = "WorkerName";
            // 
            // groupBoxDataInput
            // 
            this.groupBoxDataInput.BackColor = System.Drawing.Color.White;
            this.groupBoxDataInput.Controls.Add(this.button3);
            this.groupBoxDataInput.Controls.Add(this.button2);
            this.groupBoxDataInput.Controls.Add(this.button1);
            this.groupBoxDataInput.Controls.Add(this.textBox3);
            this.groupBoxDataInput.Controls.Add(this.label2);
            this.groupBoxDataInput.Controls.Add(this.textBox2);
            this.groupBoxDataInput.Controls.Add(this.label1);
            this.groupBoxDataInput.Controls.Add(this.textBox1);
            this.groupBoxDataInput.Controls.Add(this.labelDateInput);
            this.groupBoxDataInput.Controls.Add(this.buttonOK);
            this.groupBoxDataInput.Location = new System.Drawing.Point(325, 69);
            this.groupBoxDataInput.Name = "groupBoxDataInput";
            this.groupBoxDataInput.Size = new System.Drawing.Size(363, 594);
            this.groupBoxDataInput.TabIndex = 59;
            this.groupBoxDataInput.TabStop = false;
            this.groupBoxDataInput.Text = "신규등록 및 삭제";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 21);
            this.textBox1.TabIndex = 28;
            // 
            // labelDateInput
            // 
            this.labelDateInput.AutoSize = true;
            this.labelDateInput.Font = new System.Drawing.Font("굴림", 10F);
            this.labelDateInput.Location = new System.Drawing.Point(53, 54);
            this.labelDateInput.Name = "labelDateInput";
            this.labelDateInput.Size = new System.Drawing.Size(77, 14);
            this.labelDateInput.TabIndex = 19;
            this.labelDateInput.Text = "작업자이름";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 21);
            this.textBox2.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 39;
            this.label1.Text = "작업자아이디";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 21);
            this.textBox3.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(53, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 41;
            this.label2.Text = "작업자암호";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 73);
            this.button1.TabIndex = 43;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(128, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 73);
            this.button2.TabIndex = 44;
            this.button2.Text = "수정";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Turquoise;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(247, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 73);
            this.button3.TabIndex = 45;
            this.button3.Text = "삭제";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // WorkerRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(700, 672);
            this.Controls.Add(this.groupBoxDataInput);
            this.Controls.Add(this.dataGridViewWorker);
            this.Controls.Add(this.panelSplitBar);
            this.Controls.Add(this.labelTitle);
            this.Name = "WorkerRegistrationForm";
            this.Text = "WorkerRegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorker)).EndInit();
            this.groupBoxDataInput.ResumeLayout(false);
            this.groupBoxDataInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSplitBar;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerName;
        private System.Windows.Forms.GroupBox groupBoxDataInput;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelDateInput;
    }
}
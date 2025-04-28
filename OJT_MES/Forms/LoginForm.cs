using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LotteMES.Bases;
using LotteMES.FormData;
using LotteMES.Styles;
using LotteMES.Helpers;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using System.Reflection.Emit;

namespace LotteMES.Forms
{
    public partial class LoginForm : MESFormBase
    {
        LoginFormData m_data = new LoginFormData();
        public LoginForm()
        {
            InitializeComponent();

            //테두리
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            SetStyles();
        }

        /// <summary>
        /// 컨트롤로부터 데이터 객체의 값들을 업데이트
        /// </summary>
        protected override void SetObjectFromControls()
        {
            // 텍스트박스에서 데이터를 가져와 객체에 설정
            m_data.WorkerId = textBoxWorkerId.Text;
            m_data.WorkerPassword = textBoxWorkerPassword.Text;

        }

        /// <summary>
        /// 데이터 객체의 값들로부터 컨트롤을 업데이트
        /// </summary>
        protected override void UpdateControlsFromObject()
        {
            // 텍스트박스에 데이터 설정
            textBoxWorkerId.Text = m_data.WorkerId;
            textBoxWorkerPassword.Text = m_data.WorkerPassword;
        }

        protected override void SetStyles()
        {
            #region BackColor
            this.BackColor = Style.CommonBackgroundColor;
            labelTitle.BackColor = Style.CommonLabelBackgroundColor;
            panelSplitBar.BackColor = Style.CommonSplitBarBackgroundColor;
            panelData.BackColor = Style.CommonLabelBackgroundColor;
            labelWorkerId.BackColor = Style.CommonLabelBackgroundColor;
            labelWorkerPassword.BackColor = Style.CommonLabelBackgroundColor;

            buttonOK.BackColor = Style.CommonButtonBackgroundColor;
            buttonCancel.BackColor = Style.CommonButtonBackgroundColor;

            textBoxWorkerId.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxWorkerPassword.BackColor = Style.TextBoxBackgroundColorEditable;
            #endregion

            #region ForeColor
            labelTitle.ForeColor = Style.CommonForeColor;

            labelWorkerId.ForeColor = Style.CommonForeColor;
            labelWorkerPassword.ForeColor = Style.CommonForeColor;

            buttonOK.ForeColor = Style.CommonForeColor;
            buttonCancel.ForeColor = Style.CommonForeColor;

            textBoxWorkerId.ForeColor = Style.CommonForeColor;
            textBoxWorkerPassword.ForeColor = Style.CommonForeColor;
            #endregion

            #region Font
            labelTitle.Font = Style.CommonTitleFont;

            labelWorkerId.Font = Style.CommonFont;
            labelWorkerPassword.Font = Style.CommonFont;

            buttonOK.Font = Style.CommonFont;
            buttonCancel.Font = Style.CommonFont;

            textBoxWorkerId.Font = Style.CommonFont;
            textBoxWorkerPassword.Font = Style.CommonFont;
            #endregion            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

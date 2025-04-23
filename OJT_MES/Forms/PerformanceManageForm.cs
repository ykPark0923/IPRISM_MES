using LotteMES.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LotteMES.FormData;
using LotteMES.Styles;
using LotteMES.Helpers;

namespace LotteMES.Forms
{
    public partial class PerformanceManageForm : MESFormBase
    {
        public PerformanceManageForm()
        {
            InitializeComponent();
            // 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;

            SetStyles();
        }

        protected override void SetStyles()
        {
            #region BackColor
            this.BackColor = Style.CommonBackgroundColor;
            panelSplitBar.BackColor = Style.CommonSplitBarBackgroundColor;
            dataGridViewPerformance.BackColor = Style.CommonListBackgroundColor;

            buttonSearch.BackColor = Style.CommonButtonBackgroundColor;
            buttonEditBoxNo.BackColor = Style.CommonButtonBackgroundColor;
            buttonUploadBoxHistory.BackColor = Style.CommonButtonBackgroundColor;
            buttonPerformanceView.BackColor = Style.CommonButtonBackgroundColor;
            buttonUploadPerformance.BackColor = Style.CommonButtonBackgroundColor;
            buttonClose.BackColor = Style.CommonButtonBackgroundColor;

            groupBoxBoxInfo.BackColor = Style.CommonLabelBackgroundColor;
            radioButtonStartBoxNo.BackColor = Style.CommonLabelBackgroundColor;
            radioButtonEndBoxNo.BackColor = Style.CommonLabelBackgroundColor;


            textBoxStartBoxNo.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxEndBoxNo.BackColor = Style.TextBoxBackgroundColorEditable;

            comboBoxTestPeriod.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxTotalPeriod.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxTransmissionMedia.BackColor = Style.CommonComboBoxBackgroundColor;

            labelTitle.BackColor = Style.CommonLabelBackgroundColor;
            labelTransmissionMedia.BackColor = Style.CommonLabelBackgroundColor;
            labelTestPeriod.BackColor = Style.CommonLabelBackgroundColor;
            labelTotalPeriod.BackColor = Style.CommonLabelBackgroundColor;
            #endregion

            #region ForeColor
            dataGridViewPerformance.ForeColor = Style.CommonListForeColor;

            buttonSearch.ForeColor = Style.CommonForeColor;
            buttonEditBoxNo.ForeColor = Style.CommonForeColor;
            buttonUploadBoxHistory.ForeColor = Style.CommonForeColor;
            buttonPerformanceView.ForeColor = Style.CommonForeColor;
            buttonUploadPerformance.ForeColor = Style.CommonForeColor;
            buttonClose.ForeColor = Style.CommonForeColor;

            groupBoxBoxInfo.ForeColor = Style.CommonForeColor;
            radioButtonStartBoxNo.ForeColor = Style.CommonForeColor;
            radioButtonEndBoxNo.ForeColor = Style.CommonForeColor;

            textBoxStartBoxNo.ForeColor = Style.CommonSettingForeColor;
            textBoxEndBoxNo.ForeColor = Style.CommonSettingForeColor;

            comboBoxTestPeriod.ForeColor = Style.CommonComboBoxForeColor;
            comboBoxTotalPeriod.ForeColor = Style.CommonComboBoxForeColor;
            comboBoxTransmissionMedia.ForeColor = Style.CommonComboBoxForeColor;

            labelTitle.ForeColor = Style.CommonForeColor;
            labelTransmissionMedia.ForeColor = Style.CommonForeColor;
            labelTestPeriod.ForeColor = Style.CommonForeColor;
            labelTotalPeriod.ForeColor = Style.CommonForeColor;
            #endregion

            #region Font
            dataGridViewPerformance.Font = Style.CommonListFont;

            buttonSearch.Font = Style.CommonFont;
            buttonEditBoxNo.Font = Style.CommonFont;
            buttonUploadBoxHistory.Font = Style.CommonFont;
            buttonPerformanceView.Font = Style.CommonFont;
            buttonUploadPerformance.Font = Style.CommonFont;
            buttonClose.Font = Style.CommonFont;

            groupBoxBoxInfo.Font = Style.CommonFont;
            radioButtonStartBoxNo.Font = Style.CommonFont;
            radioButtonEndBoxNo.Font = Style.CommonFont;

            textBoxStartBoxNo.Font = Style.CommonFont;
            textBoxEndBoxNo.Font = Style.CommonFont;

            comboBoxTestPeriod.Font = Style.CommonFont;
            comboBoxTotalPeriod.Font = Style.CommonFont;
            comboBoxTransmissionMedia.Font = Style.CommonFont;

            labelTitle.Font = Style.CommonTitleFont;
            labelTransmissionMedia.Font = Style.CommonFont;
            labelTestPeriod.Font = Style.CommonFont;
            labelTotalPeriod.Font = Style.CommonFont;
            #endregion            
        }

        private void buttonUploadPerformance_Click(object sender, EventArgs e)
        {
            //생산한 데이터의 실적 관리를 위한 화면, POP서버로 전송
        }
    }
}
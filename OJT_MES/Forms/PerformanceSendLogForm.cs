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
using LotteMES.Bases;

namespace LotteMES.Forms
{
    public partial class PerformanceSendLogForm : MESFormBase
    {
        public PerformanceSendLogForm()
        {
            InitializeComponent();

            //테두리
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void PerformanceSendLogForm_Load(object sender, EventArgs e)
        {
            SetStyles();
        }

        protected override void SetStyles()
        {
            #region BackColor
            this.BackColor = Style.CommonBackgroundColor;
            panelSplitBar.BackColor = Style.CommonSplitBarBackgroundColor;
            dataGridViewTransmissionLog.BackColor = Style.CommonListBackgroundColor;
            dataGridViewTransmissionSummary.BackColor = Style.CommonListBackgroundColor;

            buttonSearch.BackColor = Style.CommonButtonBackgroundColor;
            buttonClose.BackColor = Style.CommonButtonBackgroundColor;

            groupBoxDataInput.BackColor = Style.CommonSettingBackgroundColor;

            textBoxPlanNo.BackColor = Style.TextBoxBackgroundColorEditable;

            comboBoxDateFrom.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxDateTo.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxShiftType.BackColor = Style.CommonComboBoxBackgroundColor;

            labelTitle.BackColor = Style.CommonLabelBackgroundColor;
            labelDateInput.BackColor = Style.CommonLabelBackgroundColor;
            labelPlan.BackColor = Style.CommonLabelBackgroundColor;
            labelShiftType.BackColor = Style.CommonLabelBackgroundColor;
            #endregion

            #region ForeColor
            dataGridViewTransmissionLog.ForeColor = Style.CommonListForeColor;
            dataGridViewTransmissionSummary.ForeColor = Style.CommonListForeColor;

            buttonSearch.ForeColor = Style.CommonForeColor;
            buttonClose.ForeColor = Style.CommonForeColor;

            groupBoxDataInput.ForeColor = Style.CommonSettingForeColor;

            textBoxPlanNo.ForeColor = Style.CommonSettingForeColor;

            comboBoxDateFrom.ForeColor = Style.CommonSettingForeColor;
            comboBoxDateTo.ForeColor = Style.CommonSettingForeColor;
            comboBoxShiftType.ForeColor = Style.CommonSettingForeColor;

            labelTitle.ForeColor = Style.CommonForeColor;
            labelDateInput.ForeColor = Style.CommonSettingForeColor;
            labelPlan.ForeColor = Style.CommonSettingForeColor;
            labelShiftType.ForeColor = Style.CommonSettingForeColor;
            #endregion

            #region Font
            dataGridViewTransmissionLog.Font = Style.CommonListFont;
            dataGridViewTransmissionSummary.Font = Style.CommonListFont;

            buttonSearch.Font = Style.CommonFont;
            buttonClose.Font = Style.CommonFont;

            groupBoxDataInput.Font = Style.CommonFont;

            textBoxPlanNo.Font = Style.CommonFont;

            comboBoxDateFrom.Font = Style.CommonFont;
            comboBoxDateTo.Font = Style.CommonFont;
            comboBoxShiftType.Font = Style.CommonFont;

            labelTitle.Font = Style.CommonTitleFont;
            labelDateInput.Font = Style.CommonFont;
            labelPlan.Font = Style.CommonFont;
            labelShiftType.Font = Style.CommonFont;
            #endregion            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

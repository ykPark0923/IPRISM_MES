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

namespace LotteMES.Forms
{
    public partial class SystemConfigurationForm : MESFormBase
    {
        public SystemConfigurationForm()
        {
            InitializeComponent();

            //테두리
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void SystemConfigurationForm_Load(object sender, EventArgs e)
        {
            SetStyles();
            SetDateGridView();

        }

        protected override void SetStyles()
        {
            #region BackColor
            this.BackColor = Style.CommonBackgroundColor;
            panelSplitBar.BackColor = Style.CommonSplitBarBackgroundColor;

            groupBoxGeneralSettings.BackColor = Style.CommonSettingBackgroundColor;
            groupBoxCommunicationSettings.BackColor = Style.CommonSettingBackgroundColor;

            buttonRecoverMDB.BackColor = Style.CommonButtonBackgroundColor;
            buttonApplyData.BackColor = Style.CommonButtonBackgroundColor;
            buttonClose.BackColor = Style.CommonButtonBackgroundColor;

            textBoxServerIP.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxDataRetentionDays.BackColor = Style.TextBoxBackgroundColorEditable;

            comboBoxUploadTime.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxDownloadTime.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxLabelDirection.BackColor = Style.CommonComboBoxBackgroundColor;

            radioButton001.BackColor = Style.CommonLabelBackgroundColor;
            radioButton501.BackColor = Style.CommonLabelBackgroundColor;
            radioButtonUnset.BackColor = Style.CommonLabelBackgroundColor;

            checkBoxExpirationEnabled.BackColor = Style.CommonLabelBackgroundColor;
            checkBoxUnverifiedAllowed.BackColor = Style.CommonLabelBackgroundColor;

            labelTitle.BackColor = Style.CommonLabelBackgroundColor;
            labelServerIP.BackColor = Style.CommonLabelBackgroundColor;
            labelExpirationSetting.BackColor = Style.CommonLabelBackgroundColor;
            labelVerificationSetting.BackColor = Style.CommonLabelBackgroundColor;
            labelDataRetentionDays.BackColor = Style.CommonLabelBackgroundColor;
            labelDays.BackColor = Style.CommonLabelBackgroundColor;
            labelUploadTimeSetting.BackColor = Style.CommonLabelBackgroundColor;
            labelUploadMinutes.BackColor = Style.CommonLabelBackgroundColor;
            labelDownloadTimeSetting.BackColor = Style.CommonLabelBackgroundColor;
            labelDownloadMinutes.BackColor = Style.CommonLabelBackgroundColor;
            labelLabelPrintDirection.BackColor = Style.CommonLabelBackgroundColor;
            labelStartNumberBasis.BackColor = Style.CommonLabelBackgroundColor;
            #endregion

            #region ForeColor
            groupBoxGeneralSettings.ForeColor = Style.CommonSettingForeColor;
            groupBoxCommunicationSettings.ForeColor = Style.CommonSettingForeColor;

            buttonRecoverMDB.ForeColor = Style.CommonForeColor;
            buttonApplyData.ForeColor = Style.CommonForeColor;
            buttonClose.ForeColor = Style.CommonForeColor;

            textBoxServerIP.ForeColor = Style.CommonSettingForeColor;
            textBoxDataRetentionDays.ForeColor = Style.CommonSettingForeColor;

            comboBoxUploadTime.ForeColor = Style.CommonSettingForeColor;
            comboBoxDownloadTime.ForeColor = Style.CommonSettingForeColor;
            comboBoxLabelDirection.ForeColor = Style.CommonSettingForeColor;

            radioButton001.ForeColor = Style.CommonSettingForeColor;
            radioButton501.ForeColor = Style.CommonSettingForeColor;
            radioButtonUnset.ForeColor = Style.CommonSettingForeColor;

            checkBoxExpirationEnabled.ForeColor = Style.CommonSettingForeColor;
            checkBoxUnverifiedAllowed.ForeColor = Style.CommonSettingForeColor;

            labelTitle.ForeColor = Style.CommonForeColor;
            labelServerIP.ForeColor = Style.CommonSettingForeColor;
            labelExpirationSetting.ForeColor = Style.CommonSettingForeColor;
            labelVerificationSetting.ForeColor = Style.CommonSettingForeColor;
            labelDataRetentionDays.ForeColor = Style.CommonSettingForeColor;
            labelDays.ForeColor = Style.CommonSettingForeColor;
            labelUploadTimeSetting.ForeColor = Style.CommonSettingForeColor;
            labelUploadMinutes.ForeColor = Style.CommonSettingForeColor;
            labelDownloadTimeSetting.ForeColor = Style.CommonSettingForeColor;
            labelDownloadMinutes.ForeColor = Style.CommonSettingForeColor;
            labelLabelPrintDirection.ForeColor = Style.CommonSettingForeColor;
            labelStartNumberBasis.ForeColor = Style.CommonSettingForeColor;
            #endregion

            #region Font
            groupBoxGeneralSettings.Font = Style.CommonFont;
            groupBoxCommunicationSettings.Font = Style.CommonFont;

            buttonRecoverMDB.Font = Style.CommonFont;
            buttonApplyData.Font = Style.CommonFont;
            buttonClose.Font = Style.CommonFont;

            textBoxServerIP.Font = Style.CommonFont;
            textBoxDataRetentionDays.Font = Style.CommonFont;

            comboBoxUploadTime.Font = Style.CommonFont;
            comboBoxDownloadTime.Font = Style.CommonFont;
            comboBoxLabelDirection.Font = Style.CommonFont;

            radioButton001.Font = Style.CommonFont;
            radioButton501.Font = Style.CommonFont;
            radioButtonUnset.Font = Style.CommonFont;

            checkBoxExpirationEnabled.Font = Style.CommonFont;
            checkBoxUnverifiedAllowed.Font = Style.CommonFont;

            labelTitle.Font = Style.CommonTitleFont;
            labelServerIP.Font = Style.CommonFont;
            labelExpirationSetting.Font = Style.CommonFont;
            labelVerificationSetting.Font = Style.CommonFont;
            labelDataRetentionDays.Font = Style.CommonFont;
            labelDays.Font = Style.CommonFont;
            labelUploadTimeSetting.Font = Style.CommonFont;
            labelUploadMinutes.Font = Style.CommonFont;
            labelDownloadTimeSetting.Font = Style.CommonFont;
            labelDownloadMinutes.Font = Style.CommonFont;
            labelLabelPrintDirection.Font = Style.CommonFont;
            labelStartNumberBasis.Font = Style.CommonFont;
            #endregion            
        }

        private void SetDateGridView()
        {

            dataGridViewCommunicationSettings.Rows.Add("PLC");
            dataGridViewCommunicationSettings.Rows.Add("PRINT");
            dataGridViewCommunicationSettings.Rows.Add("SCAN");

            //row fill 기능
            int totalHeight = dataGridViewCommunicationSettings.Height;
            int headerHeight = dataGridViewCommunicationSettings.ColumnHeadersHeight;


            int rowCount = dataGridViewCommunicationSettings.RowCount;

            if (rowCount == 0)
                return;

            // 각 행 높이 계산
            int rowHeight = (totalHeight - headerHeight) / rowCount;

            foreach (DataGridViewRow row in dataGridViewCommunicationSettings.Rows)
            {
                row.Height = rowHeight;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

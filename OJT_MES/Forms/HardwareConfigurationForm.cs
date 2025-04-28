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
    public partial class HardwareConfigurationForm : MESFormBase
    {
        public HardwareConfigurationForm()
        {
            InitializeComponent();

            //테두리
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void HardwareConfigurationForm_Load(object sender, EventArgs e)
        {
            SetStyles();
        }

        protected override void SetStyles()
        {
            #region BackColor
            this.BackColor = Style.CommonBackgroundColor;
            panelSplitBar.BackColor = Style.CommonSplitBarBackgroundColor;

            groupBoxPrinterSetting.BackColor = Style.CommonSettingBackgroundColor;
            groupBoxBarcodeFormatSetting.BackColor = Style.CommonSettingBackgroundColor;

            buttonHeadCheck.BackColor = Style.CommonButtonBackgroundColor;
            buttonApplyData.BackColor = Style.CommonButtonBackgroundColor;
            buttonClose.BackColor = Style.CommonButtonBackgroundColor;

            textBoxXPosition.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxYPosition.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxPalletDigits.BackColor = Style.TextBoxBackgroundColorEditable;

            comboBoxTemperatureSetting.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxPrintSpeed.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxDateFormat.BackColor = Style.CommonComboBoxBackgroundColor;

            radioButtonApplySystemChange.BackColor = Style.CommonLabelBackgroundColor;
            radioButtonIgnoreSystemChange.BackColor = Style.CommonLabelBackgroundColor;

            labelTitle.BackColor = Style.CommonLabelBackgroundColor;
            labelXPosition.BackColor = Style.CommonLabelBackgroundColor;
            labelYPosition.BackColor = Style.CommonLabelBackgroundColor;
            labelTemperatureSetting.BackColor = Style.CommonLabelBackgroundColor;
            labelPrintSpeed.BackColor = Style.CommonLabelBackgroundColor;
            labelDateFormat.BackColor = Style.CommonLabelBackgroundColor;
            labelPalletDigits.BackColor = Style.CommonLabelBackgroundColor;
            labelSystemChange.BackColor = Style.CommonLabelBackgroundColor;
            #endregion

            #region ForeColor
            groupBoxPrinterSetting.ForeColor = Style.CommonSettingForeColor;
            groupBoxBarcodeFormatSetting.ForeColor = Style.CommonSettingForeColor;

            buttonHeadCheck.ForeColor = Style.CommonForeColor;
            buttonApplyData.ForeColor = Style.CommonForeColor;
            buttonClose.ForeColor = Style.CommonForeColor;

            textBoxXPosition.ForeColor = Style.CommonSettingForeColor;
            textBoxYPosition.ForeColor = Style.CommonSettingForeColor;
            textBoxPalletDigits.ForeColor = Style.CommonSettingForeColor;

            comboBoxTemperatureSetting.ForeColor = Style.CommonSettingForeColor;
            comboBoxPrintSpeed.ForeColor = Style.CommonSettingForeColor;
            comboBoxDateFormat.ForeColor = Style.CommonSettingForeColor;

            radioButtonApplySystemChange.ForeColor = Style.CommonSettingForeColor;
            radioButtonIgnoreSystemChange.ForeColor = Style.CommonSettingForeColor;

            labelTitle.ForeColor = Style.CommonForeColor;
            labelXPosition.ForeColor = Style.CommonSettingForeColor;
            labelYPosition.ForeColor = Style.CommonSettingForeColor;
            labelTemperatureSetting.ForeColor = Style.CommonSettingForeColor;
            labelPrintSpeed.ForeColor = Style.CommonSettingForeColor;
            labelDateFormat.ForeColor = Style.CommonSettingForeColor;
            labelPalletDigits.ForeColor = Style.CommonSettingForeColor;
            labelSystemChange.ForeColor = Style.CommonSettingForeColor;
            #endregion

            #region Font
            groupBoxPrinterSetting.Font = Style.CommonFont;
            groupBoxBarcodeFormatSetting.Font = Style.CommonFont;

            buttonHeadCheck.Font = Style.CommonFont;
            buttonApplyData.Font = Style.CommonFont;
            buttonClose.Font = Style.CommonFont;

            textBoxXPosition.Font = Style.CommonFont;
            textBoxYPosition.Font = Style.CommonFont;
            textBoxPalletDigits.Font = Style.CommonFont;

            comboBoxTemperatureSetting.Font = Style.CommonFont;
            comboBoxPrintSpeed.Font = Style.CommonFont;
            comboBoxDateFormat.Font = Style.CommonFont;

            radioButtonApplySystemChange.Font = Style.CommonFont;
            radioButtonIgnoreSystemChange.Font = Style.CommonFont;

            labelTitle.Font = Style.CommonTitleFont;
            labelXPosition.Font = Style.CommonFont;
            labelYPosition.Font = Style.CommonFont;
            labelTemperatureSetting.Font = Style.CommonFont;
            labelPrintSpeed.Font = Style.CommonFont;
            labelDateFormat.Font = Style.CommonFont;
            labelPalletDigits.Font = Style.CommonFont;
            labelSystemChange.Font = Style.CommonFont;
            #endregion            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

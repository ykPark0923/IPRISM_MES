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
    public partial class WorkerConfigurationForm : MESFormBase
    {
        public WorkerConfigurationForm()
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

            groupBoxWorkDataChange.BackColor = Style.CommonSettingBackgroundColor;
            groupBoxFactoryLineSetting.BackColor = Style.CommonSettingBackgroundColor;
            groupBoxPrinterConsumableSetting.BackColor = Style.CommonSettingBackgroundColor;

            buttonApplyData.BackColor = Style.CommonButtonBackgroundColor;
            buttonClose.BackColor = Style.CommonButtonBackgroundColor;

            textBoxLineNameSetting.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxProductionDate.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxProductName.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxSerialNo.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxBokEndNo.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxLabelTotal.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxLabelRemainChange.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxRibbonTotal.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxRibbonRemainChange.BackColor = Style.TextBoxBackgroundColorEditable;

            comboBoxShiftType.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxFactoryName.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxLineName.BackColor = Style.CommonComboBoxBackgroundColor;

            labelTitle.BackColor = Style.CommonLabelBackgroundColor;
            labelLineNameSetting.BackColor = Style.CommonLabelBackgroundColor;
            labelProductionDate.BackColor = Style.CommonLabelBackgroundColor;
            labelShiftType.BackColor = Style.CommonLabelBackgroundColor;
            labelProductName.BackColor = Style.CommonLabelBackgroundColor;
            labelSerialNo.BackColor = Style.CommonLabelBackgroundColor;
            labelBokEndNo.BackColor = Style.CommonLabelBackgroundColor;
            labelFactoryName.BackColor = Style.CommonLabelBackgroundColor;
            labelLineName.BackColor = Style.CommonLabelBackgroundColor;
            labelLabelTotal.BackColor = Style.CommonLabelBackgroundColor;
            labelLabelRemainChange.BackColor = Style.CommonLabelBackgroundColor;
            labelRibbonTotal.BackColor = Style.CommonLabelBackgroundColor;
            labelRibbonRemainChange.BackColor = Style.CommonLabelBackgroundColor;
            #endregion

            #region ForeColor
            groupBoxWorkDataChange.ForeColor = Style.CommonSettingForeColor;
            groupBoxFactoryLineSetting.ForeColor = Style.CommonSettingForeColor;
            groupBoxPrinterConsumableSetting.ForeColor = Style.CommonSettingForeColor;

            buttonApplyData.ForeColor = Style.CommonForeColor;
            buttonClose.ForeColor = Style.CommonForeColor;

            textBoxLineNameSetting.ForeColor = Style.CommonSettingForeColor;
            textBoxProductionDate.ForeColor = Style.CommonSettingForeColor;
            textBoxProductName.ForeColor = Style.CommonSettingForeColor;
            textBoxSerialNo.ForeColor = Style.CommonSettingForeColor;
            textBoxBokEndNo.ForeColor = Style.CommonSettingForeColor;
            textBoxLabelTotal.ForeColor = Style.CommonSettingForeColor;
            textBoxLabelRemainChange.ForeColor = Style.CommonSettingForeColor;
            textBoxRibbonTotal.ForeColor = Style.CommonSettingForeColor;
            textBoxRibbonRemainChange.ForeColor = Style.CommonSettingForeColor;

            comboBoxShiftType.ForeColor = Style.CommonSettingForeColor;
            comboBoxFactoryName.ForeColor = Style.CommonSettingForeColor;
            comboBoxLineName.ForeColor = Style.CommonSettingForeColor;

            labelTitle.ForeColor = Style.CommonForeColor;
            labelLineNameSetting.ForeColor = Style.CommonSettingForeColor;
            labelProductionDate.ForeColor = Style.CommonSettingForeColor;
            labelShiftType.ForeColor = Style.CommonSettingForeColor;
            labelProductName.ForeColor = Style.CommonSettingForeColor;
            labelSerialNo.ForeColor = Style.CommonSettingForeColor;
            labelBokEndNo.ForeColor = Style.CommonSettingForeColor;
            labelFactoryName.ForeColor = Style.CommonSettingForeColor;
            labelLineName.ForeColor = Style.CommonSettingForeColor;
            labelLabelTotal.ForeColor = Style.CommonSettingForeColor;
            labelLabelRemainChange.ForeColor = Style.CommonSettingForeColor;
            labelRibbonTotal.ForeColor = Style.CommonSettingForeColor;
            labelRibbonRemainChange.ForeColor = Style.CommonSettingForeColor;
            #endregion

            #region Font
            groupBoxWorkDataChange.Font = Style.CommonFont;
            groupBoxFactoryLineSetting.Font = Style.CommonFont;
            groupBoxPrinterConsumableSetting.Font = Style.CommonFont;

            buttonApplyData.Font = Style.CommonFont;
            buttonClose.Font = Style.CommonFont;

            textBoxLineNameSetting.Font = Style.CommonFont;
            textBoxProductionDate.Font = Style.CommonFont;
            textBoxProductName.Font = Style.CommonFont;
            textBoxSerialNo.Font = Style.CommonFont;
            textBoxBokEndNo.Font = Style.CommonFont;
            textBoxLabelTotal.Font = Style.CommonFont;
            textBoxLabelRemainChange.Font = Style.CommonFont;
            textBoxRibbonTotal.Font = Style.CommonFont;
            textBoxRibbonRemainChange.Font = Style.CommonFont;

            comboBoxShiftType.Font = Style.CommonFont;
            comboBoxFactoryName.Font = Style.CommonFont;
            comboBoxLineName.Font = Style.CommonFont;

            labelTitle.Font = Style.CommonTitleFont;
            labelLineNameSetting.Font = Style.CommonFont;
            labelProductionDate.Font = Style.CommonFont;
            labelShiftType.Font = Style.CommonFont;
            labelProductName.Font = Style.CommonFont;
            labelSerialNo.Font = Style.CommonFont;
            labelBokEndNo.Font = Style.CommonFont;
            labelFactoryName.Font = Style.CommonFont;
            labelLineName.Font = Style.CommonFont;
            labelLabelTotal.Font = Style.CommonFont;
            labelLabelRemainChange.Font = Style.CommonFont;
            labelRibbonTotal.Font = Style.CommonFont;
            labelRibbonRemainChange.Font = Style.CommonFont;
            #endregion            
        }
    }
}

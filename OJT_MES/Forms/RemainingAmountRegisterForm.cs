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
    public partial class RemainingAmountRegisterForm : MESFormBase
    {
        public RemainingAmountRegisterForm()
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
            panelData.BackColor = Style.CommonSettingBackgroundColor;

            buttonOK.BackColor = Style.CommonButtonBackgroundColor;
            buttonCancel.BackColor = Style.CommonButtonBackgroundColor;

            textBoxProductionDateTop.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxPlanNo.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxShiftType.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxProductName.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxPlanQuantity.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxRemainQuantity.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxActualQuantity.BackColor = Style.TextBoxBackgroundColorEditable;

            labelTitle.BackColor = Style.CommonLabelBackgroundColor;
            labelProductionDate.BackColor = Style.CommonLabelBackgroundColor;
            labelPlanNo.BackColor = Style.CommonLabelBackgroundColor;
            labelShiftType.BackColor = Style.CommonLabelBackgroundColor;
            labelProductName.BackColor = Style.CommonLabelBackgroundColor;
            labelPlanQuantity.BackColor = Style.CommonLabelBackgroundColor;
            labelRemainQuantity.BackColor = Style.CommonLabelBackgroundColor;
            labelActualQuantity.BackColor = Style.CommonLabelBackgroundColor;
            #endregion

            #region ForeColor
            buttonOK.ForeColor = Style.CommonForeColor;
            buttonCancel.ForeColor = Style.CommonForeColor;

            textBoxProductionDateTop.ForeColor = Style.CommonSettingForeColor;
            textBoxPlanNo.ForeColor = Style.CommonSettingForeColor;
            textBoxShiftType.ForeColor = Style.CommonSettingForeColor;
            textBoxProductName.ForeColor = Style.CommonSettingForeColor;
            textBoxPlanQuantity.ForeColor = Style.CommonSettingForeColor;
            textBoxRemainQuantity.ForeColor = Style.CommonSettingForeColor;
            textBoxActualQuantity.ForeColor = Style.CommonSettingForeColor;

            labelTitle.ForeColor = Style.CommonForeColor;
            labelProductionDate.ForeColor = Style.CommonSettingForeColor;
            labelPlanNo.ForeColor = Style.CommonSettingForeColor;
            labelShiftType.ForeColor = Style.CommonSettingForeColor;
            labelProductName.ForeColor = Style.CommonSettingForeColor;
            labelPlanQuantity.ForeColor = Style.CommonSettingForeColor;
            labelRemainQuantity.ForeColor = Style.RemainingAmountRegisterFormLabelForeColorRequired;
            labelActualQuantity.ForeColor = Style.CommonSettingForeColor;
            #endregion

            #region Font
            buttonOK.Font = Style.CommonFont;
            buttonCancel.Font = Style.CommonFont;

            textBoxProductionDateTop.Font = Style.CommonFont;
            textBoxPlanNo.Font = Style.CommonFont;
            textBoxShiftType.Font = Style.CommonFont;
            textBoxProductName.Font = Style.CommonFont;
            textBoxPlanQuantity.Font = Style.CommonFont;
            textBoxRemainQuantity.Font = Style.RemainingAmountRegisterFormTextBoxFontRequired;
            textBoxActualQuantity.Font = Style.CommonFont;

            labelTitle.Font = Style.CommonTitleFont;
            labelProductionDate.Font = Style.CommonFont;
            labelPlanNo.Font = Style.CommonFont;
            labelShiftType.Font = Style.CommonFont;
            labelProductName.Font = Style.CommonFont;
            labelPlanQuantity.Font = Style.CommonFont;
            labelRemainQuantity.Font = Style.CommonFont;
            labelActualQuantity.Font = Style.CommonFont;
            #endregion            
        }
    }
}

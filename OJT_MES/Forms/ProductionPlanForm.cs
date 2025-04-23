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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using LotteMES.DBAccess;

namespace LotteMES.Forms
{
    public partial class ProductionPlanForm : MESFormBase
    {
        public ProductionPlanForm()
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
            dataGridViewPlanList.BackColor = Style.CommonListBackgroundColor;

            buttonSearch.BackColor = Style.CommonButtonBackgroundColor;
            buttonDownloadPlan.BackColor = Style.CommonButtonBackgroundColor;
            buttonSelectPlan.BackColor = Style.CommonButtonBackgroundColor;
            buttonInputPlan.BackColor = Style.CommonButtonBackgroundColor;
            buttonClose.BackColor = Style.CommonButtonBackgroundColor;

            groupBoxProductionPlan.BackColor = Style.CommonSettingBackgroundColor;

            textBoxBarcodeNo.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxPlanQuantity.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxPlanNo.BackColor = Style.TextBoxBackgroundColorEditable;

            comboBoxMismatchProduct.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxProductName.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxProductionDate.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxShiftType.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxTestPeriod.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxTotalPeriod.BackColor = Style.CommonComboBoxBackgroundColor;

            labelTitle.BackColor = Style.CommonLabelBackgroundColor;
            labelMismatchInfo.BackColor = Style.CommonLabelBackgroundColor;
            labelTestPeriod.BackColor = Style.CommonLabelBackgroundColor;
            labelTotalPeriod.BackColor = Style.CommonLabelBackgroundColor;
            labelProductName.BackColor = Style.CommonLabelBackgroundColor;
            labelBarcodeNo.BackColor = Style.CommonLabelBackgroundColor;
            labelProductionDate.BackColor = Style.CommonLabelBackgroundColor;
            labelShiftType.BackColor = Style.CommonLabelBackgroundColor;
            labelPlanQuantity.BackColor = Style.CommonLabelBackgroundColor;
            labelPlanNo.BackColor = Style.CommonLabelBackgroundColor;
            #endregion

            #region ForeColor
            dataGridViewPlanList.ForeColor = Style.CommonListForeColor;

            buttonSearch.ForeColor = Style.CommonForeColor;
            buttonDownloadPlan.ForeColor = Style.CommonForeColor;
            buttonSelectPlan.ForeColor = Style.CommonForeColor;
            buttonInputPlan.ForeColor = Style.CommonForeColor;
            buttonClose.ForeColor = Style.CommonForeColor;

            textBoxBarcodeNo.ForeColor = Style.CommonSettingForeColor;
            textBoxPlanQuantity.ForeColor = Style.CommonSettingForeColor;
            textBoxPlanNo.ForeColor = Style.CommonSettingForeColor;

            comboBoxMismatchProduct.ForeColor = Style.CommonComboBoxForeColor;
            comboBoxProductName.ForeColor = Style.CommonComboBoxForeColor;
            comboBoxProductionDate.ForeColor = Style.CommonComboBoxForeColor;
            comboBoxShiftType.ForeColor = Style.CommonComboBoxForeColor;
            comboBoxTestPeriod.ForeColor = Style.CommonComboBoxForeColor;
            comboBoxTotalPeriod.ForeColor = Style.CommonComboBoxForeColor;

            labelTitle.ForeColor = Style.CommonForeColor;
            labelMismatchInfo.ForeColor = Style.CommonForeColor;
            labelTestPeriod.ForeColor = Style.CommonForeColor;
            labelTotalPeriod.ForeColor = Style.CommonForeColor;

            labelProductName.ForeColor = Style.CommonSettingForeColor;
            labelBarcodeNo.ForeColor = Style.CommonSettingForeColor;
            labelProductionDate.ForeColor = Style.CommonSettingForeColor;
            labelShiftType.ForeColor = Style.CommonSettingForeColor;
            labelPlanQuantity.ForeColor = Style.CommonSettingForeColor;
            labelPlanNo.ForeColor = Style.CommonSettingForeColor;
            #endregion

            #region Font
            dataGridViewPlanList.Font = Style.CommonListFont;

            buttonSearch.Font = Style.CommonFont;
            buttonDownloadPlan.Font = Style.CommonFont;
            buttonSelectPlan.Font = Style.CommonFont;
            buttonInputPlan.Font = Style.CommonFont;
            buttonClose.Font = Style.CommonFont;

            textBoxBarcodeNo.Font = Style.CommonFont;
            textBoxPlanQuantity.Font = Style.CommonFont;
            textBoxPlanNo.Font = Style.CommonFont;

            comboBoxMismatchProduct.Font = Style.CommonFont;
            comboBoxProductName.Font = Style.PoductionPlanFormComboBoxFont;
            comboBoxProductionDate.Font = Style.CommonFont;
            comboBoxShiftType.Font = Style.PoductionPlanFormComboBoxFont;
            comboBoxTestPeriod.Font = Style.CommonFont;
            comboBoxTotalPeriod.Font = Style.CommonFont;

            labelTitle.Font = Style.CommonTitleFont;
            labelMismatchInfo.Font = Style.CommonFont;
            labelTestPeriod.Font = Style.CommonFont;
            labelTotalPeriod.Font = Style.CommonFont;
            labelProductName.Font = Style.CommonFont;
            labelBarcodeNo.Font = Style.CommonFont;
            labelProductionDate.Font = Style.CommonFont;
            labelShiftType.Font = Style.CommonFont;
            labelPlanQuantity.Font = Style.CommonFont;
            labelPlanNo.Font = Style.CommonFont;
            #endregion            
        }

        protected override void UpdateControlsFromObject()
        {
            string strSql = " SELECT PLANDATE, AUFNR, PLANQTY FROM tpprodplan_sap ";

            dataGridViewPlanList.DataSource = DBAccessor.Maria_Data(strSql);
        }
    }
}
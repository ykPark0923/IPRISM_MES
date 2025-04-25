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
            UpdateControlsFromObject();
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

        private void buttonDownloadPlan_Click(object sender, EventArgs e)
        {
            //생산계획 Download 서버 -> local
            // 서버 DB에서 데이터 조회
            string strSelect = "SELECT * FROM TPPRODPLAN_SAP";
            DataTable dt = ServerDBAccessor.Maria_Data(strSelect);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("서버로부터 생산정보를 불러오지 못했습니다.");
                return;
            }

            // 로컬 테이블 초기화
            string strTruncate = "TRUNCATE TABLE TPPRODPLAN_LOCAL";
            LocalDBAccessor.Maria_Data(strTruncate);

            // 로컬 DB로 Insert
            foreach (DataRow row in dt.Rows)
            {
                string sql = $@"
                    INSERT INTO TPPRODPLAN_LOCAL 
                    (WERKS, PRODLINECD, PLANDATE, ITEMCD, DNTYPE, AUFNR, UNITCD, PRODVER, PLANQTY, READDATA, I_DATE, U_DATE) 
                    VALUES (
                        '{row["WERKS"]}', 
                        '{row["PRODLINECD"]}', 
                        '{row["PLANDATE"]}', 
                        '{row["ITEMCD"]}', 
                        '{row["DNTYPE"]}', 
                        '{row["AUFNR"]}', 
                        '{row["UNITCD"]}', 
                        '{row["PRODVER"]}', 
                        '{row["PLANQTY"]}', 
                        '{row["READDATA"]}', 
                        '{row["I_DATE"]}', 
                        '{row["U_DATE"]}'
                    )";

                LocalDBAccessor.Maria_Data(sql);
            }

            // 최종 데이터 확인용 출력
            string strView = "SELECT PLANDATE, AUFNR, PLANQTY FROM TPPRODPLAN_LOCAL";
            dataGridViewPlanList.Columns.Clear();
            dataGridViewPlanList.DataSource = LocalDBAccessor.Maria_Data(strView);
            dataGridViewPlanList.Columns["PLANDATE"].HeaderText = "생산일자";
            dataGridViewPlanList.Columns["AUFNR"].HeaderText = "오더번호";
            dataGridViewPlanList.Columns["PLANQTY"].HeaderText = "계획수량";

        }
        private void buttonSelectPlan_Click(object sender, EventArgs e)
        {
            //생산계획 선택 : 로컬 DB에서 해당 투플 Select해 하단의 제품명, 생산일자 등 뿌려주기
            
        }

        private void buttonInputPlan_Click(object sender, EventArgs e)
        {
            //위에서 선택된 생산계획선택해서 수정한 내역 LocalDB로 Update
        }
    }
}
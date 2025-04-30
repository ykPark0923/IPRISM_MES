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
using LotteMES.DBAccess;
using LotteMES.Keyboard;

namespace LotteMES.Forms
{
    public partial class PerformanceManageForm : MESFormBase
    {
        public PerformanceManageForm()
        {
            InitializeComponent();

            //테두리
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void PerformanceManageForm_Load(object sender, EventArgs e)
        {
            SetStyles();
            SetGridListViewDataFromLocalDB();

            KeyboardBinder.BindTextBoxes(this); // 현재 폼 전체에 대해 바인딩
        }

        private void SetGridListViewDataFromLocalDB()
        {

            string strSelect = "SELECT * FROM TPPRODRESULT_LOCAL";
            DataTable dt = LocalDBAccessor.Maria_Data(strSelect);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("서버로부터 라인정보를 불러오지 못했습니다.");
                return;
            }

            dataGridViewPerformance.Columns.Clear();
            dataGridViewPerformance.DataSource = dt;
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
            buttonPerformanceDelete.BackColor = Style.CommonButtonBackgroundColor;
            buttonUploadPerformance.BackColor = Style.CommonButtonBackgroundColor;
            buttonClose.BackColor = Style.CommonButtonBackgroundColor;

            groupBoxBoxInfo.BackColor = Style.CommonLabelBackgroundColor;
            radioButtonStartBoxNo.BackColor = Style.CommonLabelBackgroundColor;
            radioButtonEndBoxNo.BackColor = Style.CommonLabelBackgroundColor;


            textBoxStartBoxNo.BackColor = Style.TextBoxBackgroundColorEditable;
            textBoxEndBoxNo.BackColor = Style.TextBoxBackgroundColorEditable;

            dateTimePickerTestPeriod.BackColor = Style.CommonComboBoxBackgroundColor;
            dateTimePickerTotalPeriod.BackColor = Style.CommonComboBoxBackgroundColor;
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
            buttonPerformanceDelete.ForeColor = Style.CommonForeColor;
            buttonUploadPerformance.ForeColor = Style.CommonForeColor;
            buttonClose.ForeColor = Style.CommonForeColor;

            groupBoxBoxInfo.ForeColor = Style.CommonForeColor;
            radioButtonStartBoxNo.ForeColor = Style.CommonForeColor;
            radioButtonEndBoxNo.ForeColor = Style.CommonForeColor;

            textBoxStartBoxNo.ForeColor = Style.CommonSettingForeColor;
            textBoxEndBoxNo.ForeColor = Style.CommonSettingForeColor;

            dateTimePickerTestPeriod.ForeColor = Style.CommonComboBoxForeColor;
            dateTimePickerTotalPeriod.ForeColor = Style.CommonComboBoxForeColor;
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
            buttonPerformanceDelete.Font = Style.CommonFont;
            buttonUploadPerformance.Font = Style.CommonFont;
            buttonClose.Font = Style.CommonFont;

            groupBoxBoxInfo.Font = Style.CommonFont;
            radioButtonStartBoxNo.Font = Style.CommonFont;
            radioButtonEndBoxNo.Font = Style.CommonFont;

            textBoxStartBoxNo.Font = Style.CommonFont;
            textBoxEndBoxNo.Font = Style.CommonFont;

            dateTimePickerTestPeriod.Font = Style.CommonFont;
            dateTimePickerTotalPeriod.Font = Style.CommonFont;
            comboBoxTransmissionMedia.Font = Style.CommonFont;

            labelTitle.Font = Style.CommonTitleFont;
            labelTransmissionMedia.Font = Style.CommonFont;
            labelTestPeriod.Font = Style.CommonFont;
            labelTotalPeriod.Font = Style.CommonFont;
            #endregion            
        }

        private void buttonPerformanceDelete_Click(object sender, EventArgs e)
        {
            //생산한 데이터 실적 삭제, PK값 기준으로 LocalDB에서 삭제
        }
        private void buttonUploadPerformance_Click(object sender, EventArgs e)
        {
            //생산한 데이터의 실적 관리를 위한 화면, POP서버로 전송

            string strSelect = "SELECT * FROM TPPRODRESULT_LOCAL";
            DataTable dt = LocalDBAccessor.Maria_Data(strSelect);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("서버로부터 생산정보를 불러오지 못했습니다.");
                return;
            }

            // 로컬 테이블 초기화
            string strTruncate = "TRUNCATE TABLE TPPRODRESULT_SAP";
            ServerDBAccessor.Maria_Data(strTruncate);

            // 로컬 DB로 Insert
            foreach (DataRow row in dt.Rows)
            {
                string sql = $@"
                    INSERT INTO TPPRODRESULT_SAP 
                    (WERKS, PRODLINECD, AUFNR, ITEMCD, DNTYPE, PLNO, PLSERL, RESULTGUBUN, RESULTYN, PRODDATE, PRODTIME, BOXQTY, STARTBOXNO, STARTBOXTIME, ENDBOXNO, ENDBOXTIME, READDATA,I_DATE, U_DATE, RESULT, RESULT_MSG) 
                    VALUES (
                        '{row["WERKS"]}', 
                        '{row["PRODLINECD"]}', 
                        '{row["AUFNR"]}', 
                        '{row["ITEMCD"]}', 
                        '{row["DNTYPE"]}', 
                        '{row["PLNO"]}', 
                        '{row["PLSERL"]}', 
                        '{row["RESULTGUBUN"]}', 
                        '{row["RESULTYN"]}', 
                        '{row["PRODDATE"]}', 
                        '{row["PRODTIME"]}', 
                        '{row["BOXQTY"]}', 
                        '{row["STARTBOXNO"]}', 
                        '{row["STARTBOXTIME"]}', 
                        '{row["ENDBOXNO"]}',  
                        '{row["ENDBOXTIME"]}', 
                        '{row["READDATA"]}', 
                        '{row["I_DATE"]}', 
                        '{row["U_DATE"]}',
                        '{row["RESULT"]}', 
                        '{row["RESULT_MSG"]}'
                    )";

                ServerDBAccessor.Maria_Data(sql);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
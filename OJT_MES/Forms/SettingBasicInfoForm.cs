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
using System.Reflection.Emit;
using LotteMES.DBAccess;

namespace LotteMES.Forms
{
    public partial class SettingBasicInfoForm : MESFormBase
    {
        public SettingBasicInfoForm()
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
            labelTitle.BackColor = Style.CommonLabelBackgroundColor;
            panelSplitBar.BackColor = Style.CommonSplitBarBackgroundColor;
            labelSearchBasicCode.BackColor = Style.CommonLabelBackgroundColor;
            comboBoxSearchBasicCode.BackColor = Style.CommonComboBoxBackgroundColor;

            dataGridViewSettingBasicInfo.BackColor = Style.CommonListBackgroundColor;
            buttonDownloadProductInfo.BackColor = Style.CommonButtonBackgroundColor;
            buttonDownloadLineInfo.BackColor = Style.CommonButtonBackgroundColor;
            buttonClose.BackColor = Style.CommonButtonBackgroundColor;

            #endregion

            #region ForeColor
            labelTitle.ForeColor = Style.CommonForeColor;
            labelSearchBasicCode.ForeColor = Style.CommonForeColor;
            comboBoxSearchBasicCode.ForeColor = Style.CommonComboBoxForeColor;

            dataGridViewSettingBasicInfo.ForeColor = Style.CommonListForeColor;
            buttonDownloadProductInfo.ForeColor = Style.CommonForeColor;
            buttonDownloadLineInfo.ForeColor = Style.CommonForeColor;
            buttonClose.ForeColor = Style.CommonForeColor;

            #endregion

            #region Font
            labelTitle.Font = Style.CommonTitleFont;

            labelSearchBasicCode.Font = Style.CommonFont;
            comboBoxSearchBasicCode.Font = Style.CommonFont;
            dataGridViewSettingBasicInfo.Font = Style.CommonListFont;
            buttonDownloadProductInfo.Font = Style.CommonFont;
            buttonDownloadLineInfo.Font = Style.CommonFont;
            buttonClose.Font = Style.CommonFont;
            #endregion            
        }

        private void buttonDownloadLineInfo_Click(object sender, EventArgs e)
        {
            // 서버 DB에서 데이터 조회
            string strSelect = "SELECT * FROM TPLINEINFO_SAP";
            DataTable dt = ServerDBAccessor.Maria_Data(strSelect);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("서버로부터 라인정보를 불러오지 못했습니다.");
                return;
            }

            // 로컬 테이블 초기화
            string strTruncate = "TRUNCATE TABLE TPLINEINFO_LOCAL";
            LocalDBAccessor.Maria_Data(strTruncate);

            // 로컬 DB로 Insert
            foreach (DataRow row in dt.Rows)
            {
                string sql = $@"
                    INSERT INTO TPLINEINFO_LOCAL 
                    (WERKS, PRODLINECD, LINESEQ, WERKSNM, PRODLINENM, BARLINECD, VJCODE, I_DATE, U_DATE) 
                    VALUES (
                        '{row["WERKS"]}', 
                        '{row["PRODLINECD"]}', 
                        '{row["LINESEQ"]}', 
                        '{row["WERKSNM"].ToString().Replace("'", "''")}', 
                        '{row["PRODLINENM"].ToString().Replace("'", "''")}', 
                        '{row["BARLINECD"]}', 
                        '{row["VJCODE"]}', 
                        '{row["I_DATE"]}', 
                        '{row["U_DATE"]}'
                    )";

                LocalDBAccessor.Maria_Data(sql);
            }

            // 최종 데이터 확인용 출력
            string strView = "SELECT PRODLINECD, PRODLINENM FROM TPLINEINFO_LOCAL";
            dataGridViewSettingBasicInfo.Columns.Clear();
            dataGridViewSettingBasicInfo.DataSource = LocalDBAccessor.Maria_Data(strView);
            dataGridViewSettingBasicInfo.Columns["PRODLINECD"].HeaderText = "작업장";
            dataGridViewSettingBasicInfo.Columns["PRODLINENM"].HeaderText = "생산라인명";
        }

        private void buttonDownloadProductInfo_Click(object sender, EventArgs e)
        {
            // 서버 DB에서 데이터 조회
            string strSelect = "SELECT * FROM TPITEMINFO_SAP";
            DataTable dt = ServerDBAccessor.Maria_Data(strSelect);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("서버로부터 제품정보를 불러오지 못했습니다.");
                return;
            }

            // 로컬 테이블 초기화
            string strTruncate = "TRUNCATE TABLE TPITEMINFO_LOCAL";
            LocalDBAccessor.Maria_Data(strTruncate);

            // 로컬 DB로 Insert
            foreach (DataRow row in dt.Rows)
            {
                string sql = $@"
                    INSERT INTO TPITEMINFO_LOCAL 
                    (WERKS, PRODLINECD, ITEMCD, ITEMNM, UNITCD, UNITNM, CIRCULDAY, CIRCULTYPE, PIECQTY, CSRQTY, PLBOXQTY, BARCODE, I_DATE, U_DATE) 
                    VALUES (
                        '{row["WERKS"]}', 
                        '{row["PRODLINECD"]}', 
                        '{row["ITEMCD"]}', 
                        '{row["ITEMNM"]}', 
                        '{row["UNITCD"]}', 
                        '{row["UNITNM"]}', 
                        '{row["CIRCULDAY"]}', 
                        '{row["CIRCULTYPE"]}', 
                        '{row["PIECQTY"]}', 
                        '{row["CSRQTY"]}', 
                        '{row["PLBOXQTY"]}', 
                        '{row["BARCODE"]}', 
                        '{row["I_DATE"]}', 
                        '{row["U_DATE"]}'
                    )";

                LocalDBAccessor.Maria_Data(sql);
            }

            // 최종 데이터 확인용 출력
            string strView = "SELECT * FROM TPITEMINFO_LOCAL";
            dataGridViewSettingBasicInfo.Columns.Clear();
            dataGridViewSettingBasicInfo.DataSource = LocalDBAccessor.Maria_Data(strView);
        }
    }
}

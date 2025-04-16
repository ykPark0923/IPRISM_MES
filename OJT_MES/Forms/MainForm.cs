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

namespace LotteMES.Forms
{
    public partial class MainForm : MESFormBase
    {
        MainFormData m_data = new MainFormData();

        public MainForm()
        {
            InitializeComponent();

            // 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 작업 표시줄을 포함한 화면 전체로 설정
            this.WindowState = FormWindowState.Maximized;

            SetStyles();
        }

        #region TryParseMethod
        public static int TryParseInt(string input, int defaultValue = 0)
        {
            return int.TryParse(input, out int result) ? result : defaultValue;
        }
        public static DateTime TryParseDateTime(string input, DateTime defaultValue = default)
        {
            return DateTime.TryParse(input, out DateTime result) ? result : defaultValue;
        }
        #endregion

        /// <summary>
        /// 컨트롤로부터 데이터 객체의 값들을 업데이트
        /// </summary>
        protected override void SetObjectFromControls()
        {
            // 라벨 데이터 가져오기 (UI에서 Text 속성 가져오기)
            m_data.LabelCurrentDateTime = labelCurrentDateTime.Text;
            m_data.Label1 = label1.Text;
            m_data.Label2 = label2.Text;
            m_data.Label3 = label3.Text;
            m_data.Label4 = label4.Text;


            // 텍스트박스에서 데이터를 가져와 객체에 설정
            m_data.TextBoxManagerName = textBoxManagerName.Text;
            m_data.TextBoxPlannedQuantity = TryParseInt(textBoxPlannedQuantity.Text);
            m_data.TextBoxProducedQuantity = TryParseInt(textBoxProducedQuantity.Text);
            m_data.TextBoxRemainingRibbon = TryParseInt(textBoxRemainingRibbon.Text);
            m_data.TextBoxRemainingLabel = TryParseInt(textBoxRemainingLabel.Text);
            m_data.TextBoxProductionLine = textBoxProductionLine.Text;
            m_data.TextBoxProductionDate = TryParseDateTime(textBoxProductionDate.Text);
            m_data.TextBoxShiftType = textBoxShiftType.Text;
            m_data.TextBoxProductName = textBoxProductName.Text;
            m_data.TextBoxUnit = textBoxUnit.Text;
            m_data.TextBoxSerialNumber = textBoxSerialNumber.Text;
            m_data.TextBoxBomVersion = textBoxBomVersion.Text;
            m_data.TextBoxStorageLocation = textBoxStorageLocation.Text;
            m_data.TextBoxBoxPerPallet = TryParseInt(textBoxBoxPerPallet.Text);
            m_data.TextBoxBoxCode = textBoxBoxCode.Text;
            m_data.TextBoxExpirationDate = TryParseDateTime(textBoxExpirationDate.Text);
            m_data.TextBoxShelfLife = TryParseInt(textBoxShelfLife.Text);

        }

        /// <summary>
        /// 데이터 객체의 값들로부터 컨트롤을 업데이트
        /// </summary>
        protected override void UpdateControlsFromObject()
        {
            // 라벨에 데이터 설정
            labelCurrentDateTime.Text = m_data.LabelCurrentDateTime;
            label1.Text = m_data.Label1;
            label2.Text = m_data.Label2;
            label3.Text = m_data.Label3;
            label4.Text = m_data.Label4;

            // 텍스트박스에 데이터 설정
            textBoxManagerName.Text = m_data.TextBoxManagerName;
            textBoxPlannedQuantity.Text = m_data.TextBoxPlannedQuantity.ToString();
            textBoxProducedQuantity.Text = m_data.TextBoxProducedQuantity.ToString();
            textBoxRemainingRibbon.Text = m_data.TextBoxRemainingRibbon.ToString();
            textBoxRemainingLabel.Text = m_data.TextBoxRemainingLabel.ToString();
            textBoxProductionLine.Text = m_data.TextBoxProductionLine;
            textBoxProductionDate.Text = m_data.TextBoxProductionDate.ToString("yyyy-MM-dd"); // 날짜 포맷
            textBoxShiftType.Text = m_data.TextBoxShiftType;
            textBoxProductName.Text = m_data.TextBoxProductName;
            textBoxUnit.Text = m_data.TextBoxUnit;
            textBoxSerialNumber.Text = m_data.TextBoxSerialNumber;
            textBoxBomVersion.Text = m_data.TextBoxBomVersion;
            textBoxStorageLocation.Text = m_data.TextBoxStorageLocation;
            textBoxBoxPerPallet.Text = m_data.TextBoxBoxPerPallet.ToString();
            textBoxBoxCode.Text = m_data.TextBoxBoxCode;
            textBoxExpirationDate.Text = m_data.TextBoxExpirationDate.ToString("yyyy-MM-dd"); // 날짜 포맷
            textBoxShelfLife.Text = m_data.TextBoxShelfLife.ToString();

        }

        protected override void SetStyles()
        {
            #region MainForm

            #region BackColor
            panelHeader.BackColor = Style.CommonBackgroundColorTransparent;
            panelCommStatus.BackColor = Style.CommonBackgroundColorTransparent;
            panelData.BackColor = Style.CommonBackgroundColorTransparent;
            panelButton.BackColor = Style.CommonBackgroundColorTransparent;

            buttonProductionPlan.BackColor = Style.CommonBackgroundColorBlack;
            buttonBulkBarcodePrint.BackColor = Style.CommonBackgroundColorBlack;
            buttonPopDeviceHistory.BackColor = Style.CommonBackgroundColorBlack;
            buttonProductionResult.BackColor = Style.CommonBackgroundColorBlack;
            buttonVariousHistoryInquiry.BackColor = Style.CommonBackgroundColorBlack;
            buttonResultTransferHistory.BackColor = Style.CommonBackgroundColorBlack;
            buttonWorkEnvironmentSettings.BackColor = Style.CommonBackgroundColorBlack;
            buttonSystemEnvironmentSettings.BackColor = Style.CommonBackgroundColorBlack;
            buttonHardwareEnvironmentSettings.BackColor = Style.CommonBackgroundColorBlack;
            buttonCreateBasicInfo.BackColor = Style.CommonBackgroundColorBlack;
            buttonCreateWorker.BackColor = Style.CommonBackgroundColorBlack;
            buttonRemainingAmountRegister.BackColor = Style.CommonBackgroundColorBlack;
            buttonPause.BackColor = Style.CommonBackgroundColorBlack;
            buttonStop.BackColor = Style.CommonBackgroundColorBlack;
            buttonReset.BackColor = Style.CommonBackgroundColorBlack;
            buttonReissue.BackColor = Style.CommonBackgroundColorBlack;
            buttonPrintTest.BackColor = Style.CommonBackgroundColorBlack;
            buttonHelp.BackColor = Style.CommonBackgroundColorBlack;
            buttonExit.BackColor = Style.CommonBackgroundColorBlack;

            textBoxManagerName.BackColor = Style.TextBoxBackgroundColorDarkGray;
            textBoxPlannedQuantity.BackColor = Style.TextBoxBackgroundColorDarkGray;
            textBoxProducedQuantity.BackColor = Style.TextBoxBackgroundColorDarkGray;
            textBoxRemainingRibbon.BackColor = Style.TextBoxBackgroundColorLightGray;
            textBoxRemainingLabel.BackColor = Style.TextBoxBackgroundColorLightGray;
            textBoxProductionLine.BackColor = Style.TextBoxBackgroundColorGray;
            textBoxProductionDate.BackColor = Style.TextBoxBackgroundColorGray;
            textBoxShiftType.BackColor = Style.TextBoxBackgroundColorGray;
            textBoxProductName.BackColor = Style.TextBoxBackgroundColorGray;
            textBoxUnit.BackColor = Style.TextBoxBackgroundColorGray;
            textBoxSerialNumber.BackColor = Style.TextBoxBackgroundColorGray;
            textBoxBomVersion.BackColor = Style.TextBoxBackgroundColorGray;
            textBoxStorageLocation.BackColor = Style.TextBoxBackgroundColorGray;
            textBoxBoxPerPallet.BackColor = Style.TextBoxBackgroundColorGray;
            textBoxBoxCode.BackColor = Style.TextBoxBackgroundColorGray;
            textBoxExpirationDate.BackColor = Style.TextBoxBackgroundColorGray;
            textBoxShelfLife.BackColor = Style.TextBoxBackgroundColorGray;

            labelCurrentDateTime.BackColor = Style.CommonBackgroundColorTransparent;
            labelCommStatus.BackColor = Style.CommonBackgroundColorTransparent;
            labelAL.BackColor = Style.CommonBackgroundColorTransparent;
            labelServer.BackColor = Style.CommonBackgroundColorTransparent;
            labelDemon.BackColor = Style.CommonBackgroundColorTransparent;
            label1.BackColor = Style.CommonBackgroundColorTransparent;
            label2.BackColor = Style.CommonBackgroundColorTransparent;
            label3.BackColor = Style.CommonBackgroundColorTransparent;
            label4.BackColor = Style.CommonBackgroundColorTransparent;
            labelManagerName.BackColor = Style.CommonBackgroundColorTransparent;
            labelPlannedQuantity.BackColor = Style.CommonBackgroundColorTransparent;
            labelProducedQuantity.BackColor = Style.CommonBackgroundColorTransparent;
            labelRemainingRibbon.BackColor = Style.CommonBackgroundColorTransparent;
            labelRemainingLabel.BackColor = Style.CommonBackgroundColorTransparent;
            labelProductionLine.BackColor = Style.CommonBackgroundColorTransparent;
            labelProductionDate.BackColor = Style.CommonBackgroundColorTransparent;
            labelShiftType.BackColor = Style.CommonBackgroundColorTransparent;
            labelProductName.BackColor = Style.CommonBackgroundColorTransparent;
            labelUnit.BackColor = Style.CommonBackgroundColorTransparent;
            labelSerialNumber.BackColor = Style.CommonBackgroundColorTransparent;
            labelBomVersion.BackColor = Style.CommonBackgroundColorTransparent;
            labelStorageLocation.BackColor = Style.CommonBackgroundColorTransparent;
            labelBoxPerPallet.BackColor = Style.CommonBackgroundColorTransparent;
            labelBoxCode.BackColor = Style.CommonBackgroundColorTransparent;
            labelExpirationDate.BackColor = Style.CommonBackgroundColorTransparent;
            labelShelfLife.BackColor = Style.CommonBackgroundColorTransparent;

            pictureBoxAL.BackColor = Style.MainFormCommunicationColorRed;
            pictureBoxServer.BackColor = Style.MainFormCommunicationColorGreen;
            pictureBoxDemon.BackColor = Style.MainFormCommunicationColorGreen;
            #endregion

            #region ForeColor
            labelCurrentDateTime.ForeColor = Style.CommonForeColorWhite;
            labelCommStatus.ForeColor = Style.MainFormCommunicationColorGreen;
            labelAL.ForeColor = Style.CommonForeColorWhite;
            labelServer.ForeColor = Style.CommonForeColorWhite;
            labelDemon.ForeColor = Style.CommonForeColorWhite;
            label1.ForeColor = Style.CommonForeColorWhite;
            label2.ForeColor = Style.CommonForeColorWhite;
            label3.ForeColor = Style.CommonForeColorRed;
            label4.ForeColor = Style.CommonForeColorCyan;
            labelManagerName.ForeColor = Style.CommonForeColorCyan;
            labelPlannedQuantity.ForeColor = Style.CommonForeColorCyan;
            labelProducedQuantity.ForeColor = Style.CommonForeColorCyan;
            labelRemainingRibbon.ForeColor = Style.CommonForeColorCyan;
            labelRemainingLabel.ForeColor = Style.CommonForeColorCyan;
            labelProductionLine.ForeColor = Style.CommonForeColorCyan;
            labelProductionDate.ForeColor = Style.CommonForeColorCyan;
            labelShiftType.ForeColor = Style.CommonForeColorCyan;
            labelProductName.ForeColor = Style.CommonForeColorCyan;
            labelUnit.ForeColor = Style.CommonForeColorCyan;
            labelSerialNumber.ForeColor = Style.CommonForeColorCyan;
            labelBomVersion.ForeColor = Style.CommonForeColorCyan;
            labelStorageLocation.ForeColor = Style.CommonForeColorCyan;
            labelBoxPerPallet.ForeColor = Style.CommonForeColorCyan;
            labelBoxCode.ForeColor = Style.CommonForeColorCyan;
            labelExpirationDate.ForeColor = Style.CommonForeColorCyan;
            labelShelfLife.ForeColor = Style.CommonForeColorCyan;

            textBoxManagerName.ForeColor = Style.CommonForeColorWhite;
            textBoxPlannedQuantity.ForeColor = Style.CommonForeColorWhite;
            textBoxProducedQuantity.ForeColor = Style.CommonForeColorWhite;
            textBoxRemainingRibbon.ForeColor = Style.CommonForeColorWhite;
            textBoxRemainingLabel.ForeColor = Style.CommonForeColorWhite;
            textBoxProductionLine.ForeColor = Style.CommonForeColorWhite;
            textBoxProductionDate.ForeColor = Style.CommonForeColorWhite;
            textBoxShiftType.ForeColor = Style.CommonForeColorWhite;
            textBoxProductName.ForeColor = Style.CommonForeColorWhite;
            textBoxUnit.ForeColor = Style.CommonForeColorWhite;
            textBoxSerialNumber.ForeColor = Style.CommonForeColorWhite;
            textBoxBomVersion.ForeColor = Style.CommonForeColorWhite;
            textBoxStorageLocation.ForeColor = Style.CommonForeColorWhite;
            textBoxBoxPerPallet.ForeColor = Style.CommonForeColorWhite;
            textBoxBoxCode.ForeColor = Style.CommonForeColorWhite;
            textBoxExpirationDate.ForeColor = Style.CommonForeColorWhite;
            textBoxShelfLife.ForeColor = Style.CommonForeColorWhite;

            buttonProductionPlan.ForeColor = Style.CommonForeColorCyan;
            buttonBulkBarcodePrint.ForeColor = Style.CommonForeColorWhite;
            buttonPopDeviceHistory.ForeColor = Style.CommonForeColorCyan;
            buttonProductionResult.ForeColor = Style.CommonForeColorCyan;
            buttonVariousHistoryInquiry.ForeColor = Style.CommonForeColorCyan;
            buttonResultTransferHistory.ForeColor = Style.CommonForeColorCyan;
            buttonWorkEnvironmentSettings.ForeColor = Style.CommonForeColorWhite;
            buttonSystemEnvironmentSettings.ForeColor = Style.CommonForeColorWhite;
            buttonHardwareEnvironmentSettings.ForeColor = Style.CommonForeColorWhite;
            buttonCreateBasicInfo.ForeColor = Style.CommonForeColorWhite;
            buttonCreateWorker.ForeColor = Style.CommonForeColorCyan;
            buttonRemainingAmountRegister.ForeColor = Style.CommonForeColorCyan;
            buttonPause.ForeColor = Style.CommonForeColorWhite;
            buttonStop.ForeColor = Style.CommonForeColorWhite;
            buttonReset.ForeColor = Style.CommonForeColorWhite;
            buttonReissue.ForeColor = Style.CommonForeColorWhite;
            buttonPrintTest.ForeColor = Style.CommonForeColorWhite;
            buttonHelp.ForeColor = Style.CommonForeColorCyan;
            buttonExit.ForeColor = Style.CommonForeColorWhite;
            #endregion

            #region Font
            labelCurrentDateTime.Font = Style.MainFormDatetimeFontSize;
            labelCommStatus.Font = Style.CommonFont;
            labelAL.Font = Style.CommonFont;
            labelServer.Font = Style.CommonFont;
            labelDemon.Font = Style.CommonFont;
            label1.Font = Style.CommonFont;
            label2.Font = Style.MainFormLabel2FontSize;
            label3.Font = Style.MainFormLabel3FontSize;
            label4.Font = Style.MainFormLabel3FontSize;
            labelManagerName.Font = Style.CommonFont;
            labelPlannedQuantity.Font = Style.CommonFont;
            labelProducedQuantity.Font = Style.CommonFont;
            labelRemainingRibbon.Font = Style.CommonFont;
            labelRemainingLabel.Font = Style.CommonFont;
            labelProductionLine.Font = Style.CommonFont;
            labelProductionDate.Font = Style.CommonFont;
            labelShiftType.Font = Style.CommonFont;
            labelProductName.Font = Style.CommonFont;
            labelUnit.Font = Style.CommonFont;
            labelSerialNumber.Font = Style.CommonFont;
            labelBomVersion.Font = Style.CommonFont;
            labelStorageLocation.Font = Style.CommonFont;
            labelBoxPerPallet.Font = Style.CommonFont;
            labelBoxCode.Font = Style.CommonFont;
            labelExpirationDate.Font = Style.CommonFont;
            labelShelfLife.Font = Style.CommonFont;

            textBoxManagerName.Font = Style.CommonFont;
            textBoxPlannedQuantity.Font = Style.CommonFont;
            textBoxProducedQuantity.Font = Style.CommonFont;
            textBoxRemainingRibbon.Font = Style.CommonFont;
            textBoxRemainingLabel.Font = Style.CommonFont;
            textBoxProductionLine.Font = Style.CommonFont;
            textBoxProductionDate.Font = Style.CommonFont;
            textBoxShiftType.Font = Style.CommonFont;
            textBoxProductName.Font = Style.CommonFont;
            textBoxUnit.Font = Style.CommonFont;
            textBoxSerialNumber.Font = Style.CommonFont;
            textBoxBomVersion.Font = Style.CommonFont;
            textBoxStorageLocation.Font = Style.CommonFont;
            textBoxBoxPerPallet.Font = Style.CommonFont;
            textBoxBoxCode.Font = Style.CommonFont;
            textBoxExpirationDate.Font = Style.CommonFont;
            textBoxShelfLife.Font = Style.CommonFont;

            buttonProductionPlan.Font = Style.CommonFont;
            buttonBulkBarcodePrint.Font = Style.CommonFont;
            buttonPopDeviceHistory.Font = Style.CommonFont;
            buttonProductionResult.Font = Style.CommonFont;
            buttonVariousHistoryInquiry.Font = Style.CommonFont;
            buttonResultTransferHistory.Font = Style.CommonFont;
            buttonWorkEnvironmentSettings.Font = Style.CommonFont;
            buttonSystemEnvironmentSettings.Font = Style.CommonFont;
            buttonHardwareEnvironmentSettings.Font = Style.CommonFont;
            buttonCreateBasicInfo.Font = Style.CommonFont;
            buttonCreateWorker.Font = Style.CommonFont;
            buttonRemainingAmountRegister.Font = Style.CommonFont;
            buttonPause.Font = Style.CommonFont;
            buttonStop.Font = Style.CommonFont;
            buttonReset.Font = Style.CommonFont;
            buttonReissue.Font = Style.CommonFont;
            buttonPrintTest.Font = Style.CommonFont;
            buttonHelp.Font = Style.CommonFont;
            buttonExit.Font = Style.CommonFont;
            #endregion
            
            #endregion
        }
    }
}
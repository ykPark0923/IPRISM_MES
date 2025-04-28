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
using LotteMES.Constants;

namespace LotteMES.Forms
{
    public partial class MainForm : MESFormBase
    {
        const string DATE_FORMAT = "yyyy-MM-dd";

        MainFormData m_data = new MainFormData();


        public MainForm()
        {
            InitializeComponent();
            this.Size = new Size(1024, 768);

            // 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;

            // 작업 표시줄을 포함한 화면 전체로 설정
            //this.WindowState = FormWindowState.Maximized;

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            SetStyles();
        }

        /// <summary>
        /// 컨트롤로부터 데이터 객체의 값들을 업데이트
        /// </summary>
        protected override void SetObjectFromControls()
        {
            // 라벨 데이터 가져오기 (UI에서 Text 속성 가져오기)
            m_data.CurrentDateTime = labelCurrentDateTime.Text;
            m_data.Label1 = label1.Text;
            m_data.Label2 = label2.Text;
            m_data.Label3 = label3.Text;
            m_data.Label4 = label4.Text;


            // 텍스트박스에서 데이터를 가져와 객체에 설정
            m_data.ManagerName = textBoxManagerName.Text;
            m_data.PlannedQuantity = Helper.TryParseInt(textBoxPlannedQuantity.Text);
            m_data.ProducedQuantity = Helper.TryParseInt(textBoxProducedQuantity.Text);
            m_data.RemainingRibbon = Helper.TryParseInt(textBoxRemainingRibbon.Text);
            m_data.RemainingLabel = Helper.TryParseInt(textBoxRemainingLabel.Text);
            m_data.ProductionLine = textBoxProductionLine.Text;
            m_data.ProductionDate = Helper.TryParseDateTime(textBoxProductionDate.Text);
            m_data.ShiftType = textBoxShiftType.Text;
            m_data.ProductName = textBoxProductName.Text;
            m_data.Unit = textBoxUnit.Text;
            m_data.SerialNumber = textBoxSerialNumber.Text;
            m_data.BomVersion = textBoxBomVersion.Text;
            m_data.StorageLocation = textBoxStorageLocation.Text;
            m_data.BoxPerPallet = Helper.TryParseInt(textBoxBoxPerPallet.Text);
            m_data.BoxCode = textBoxBoxCode.Text;
            m_data.ExpirationDate = Helper.TryParseDateTime(textBoxExpirationDate.Text);
            m_data.ShelfLife = Helper.TryParseInt(textBoxShelfLife.Text);

        }

        /// <summary>
        /// 데이터 객체의 값들로부터 컨트롤을 업데이트
        /// </summary>
        protected override void UpdateControlsFromObject()
        {
            // 라벨에 데이터 설정
            labelCurrentDateTime.Text = m_data.CurrentDateTime;
            label1.Text = m_data.Label1;
            label2.Text = m_data.Label2;
            label3.Text = m_data.Label3;
            label4.Text = m_data.Label4;

            // 텍스트박스에 데이터 설정
            textBoxManagerName.Text = m_data.ManagerName;
            textBoxPlannedQuantity.Text = m_data.PlannedQuantity.ToString();
            textBoxProducedQuantity.Text = m_data.ProducedQuantity.ToString();
            textBoxRemainingRibbon.Text = m_data.RemainingRibbon.ToString();
            textBoxRemainingLabel.Text = m_data.RemainingLabel.ToString();
            textBoxProductionLine.Text = m_data.ProductionLine;
            textBoxProductionDate.Text = m_data.ProductionDate.ToString(Constant.DATE_FORMAT); // 날짜 포맷
            textBoxShiftType.Text = m_data.ShiftType;
            textBoxProductName.Text = m_data.ProductName;
            textBoxUnit.Text = m_data.Unit;
            textBoxSerialNumber.Text = m_data.SerialNumber;
            textBoxBomVersion.Text = m_data.BomVersion;
            textBoxStorageLocation.Text = m_data.StorageLocation;
            textBoxBoxPerPallet.Text = m_data.BoxPerPallet.ToString();
            textBoxBoxCode.Text = m_data.BoxCode;
            textBoxExpirationDate.Text = m_data.ExpirationDate.ToString(Constant.DATE_FORMAT); // 날짜 포맷
            textBoxShelfLife.Text = m_data.ShelfLife.ToString();

        }

        protected override void SetStyles()
        {
            #region BackColor
            this.BackColor = Style.CommonBackgroundColor;
            panelHeader.BackColor = Style.CommonLabelBackgroundColor;
            panelCommStatus.BackColor = Style.CommonLabelBackgroundColor;
            panelData.BackColor = Style.CommonLabelBackgroundColor;
            panelButton.BackColor = Style.CommonLabelBackgroundColor;

            buttonProductionPlan.BackColor = Style.MainFormButtonBackgroundColor;
            buttonBulkBarcodePrint.BackColor = Style.MainFormButtonBackgroundColor;
            buttonPopDeviceHistory.BackColor = Style.MainFormButtonBackgroundColor;
            buttonProductionResult.BackColor = Style.MainFormButtonBackgroundColor;
            buttonVariousHistoryInquiry.BackColor = Style.MainFormButtonBackgroundColor;
            buttonResultTransferHistory.BackColor = Style.MainFormButtonBackgroundColor;
            buttonWorkEnvironmentSettings.BackColor = Style.MainFormButtonBackgroundColor;
            buttonSystemEnvironmentSettings.BackColor = Style.MainFormButtonBackgroundColor;
            buttonHardwareEnvironmentSettings.BackColor = Style.MainFormButtonBackgroundColor;
            buttonCreateBasicInfo.BackColor = Style.MainFormButtonBackgroundColor;
            buttonCreateWorker.BackColor = Style.MainFormButtonBackgroundColor;
            buttonRemainingAmountRegister.BackColor = Style.MainFormButtonBackgroundColor;
            buttonPause.BackColor = Style.MainFormButtonBackgroundColor;
            buttonStop.BackColor = Style.MainFormButtonBackgroundColor;
            buttonReset.BackColor = Style.MainFormButtonBackgroundColor;
            buttonReissue.BackColor = Style.MainFormButtonBackgroundColor;
            buttonPrintTest.BackColor = Style.MainFormButtonBackgroundColor;
            buttonHelp.BackColor = Style.MainFormButtonBackgroundColor;
            buttonExit.BackColor = Style.MainFormButtonBackgroundColor;

            textBoxManagerName.BackColor = Style.TextBoxBackgroundColorReadOnly;
            textBoxPlannedQuantity.BackColor = Style.TextBoxBackgroundColorReadOnly;
            textBoxProducedQuantity.BackColor = Style.TextBoxBackgroundColorReadOnly;
            textBoxRemainingRibbon.BackColor = Style.TextBoxBackgroundColorLight;
            textBoxRemainingLabel.BackColor = Style.TextBoxBackgroundColorLight;
            textBoxProductionLine.BackColor = Style.TextBoxBackgroundColor;
            textBoxProductionDate.BackColor = Style.TextBoxBackgroundColor;
            textBoxShiftType.BackColor = Style.TextBoxBackgroundColor;
            textBoxProductName.BackColor = Style.TextBoxBackgroundColor;
            textBoxUnit.BackColor = Style.TextBoxBackgroundColor;
            textBoxSerialNumber.BackColor = Style.TextBoxBackgroundColor;
            textBoxBomVersion.BackColor = Style.TextBoxBackgroundColor;
            textBoxStorageLocation.BackColor = Style.TextBoxBackgroundColor;
            textBoxBoxPerPallet.BackColor = Style.TextBoxBackgroundColor;
            textBoxBoxCode.BackColor = Style.TextBoxBackgroundColor;
            textBoxExpirationDate.BackColor = Style.TextBoxBackgroundColor;
            textBoxShelfLife.BackColor = Style.TextBoxBackgroundColor;

            labelCurrentDateTime.BackColor = Style.CommonLabelBackgroundColor;
            labelCommStatus.BackColor = Style.CommonLabelBackgroundColor;
            labelAL.BackColor = Style.CommonLabelBackgroundColor;
            labelServer.BackColor = Style.CommonLabelBackgroundColor;
            labelDemon.BackColor = Style.CommonLabelBackgroundColor;
            label1.BackColor = Style.CommonLabelBackgroundColor;
            label2.BackColor = Style.CommonLabelBackgroundColor;
            label3.BackColor = Style.CommonLabelBackgroundColor;
            label4.BackColor = Style.CommonLabelBackgroundColor;
            labelManagerName.BackColor = Style.CommonLabelBackgroundColor;
            labelPlannedQuantity.BackColor = Style.CommonLabelBackgroundColor;
            labelProducedQuantity.BackColor = Style.CommonLabelBackgroundColor;
            labelRemainingRibbon.BackColor = Style.CommonLabelBackgroundColor;
            labelRemainingLabel.BackColor = Style.CommonLabelBackgroundColor;
            labelProductionLine.BackColor = Style.CommonLabelBackgroundColor;
            labelProductionDate.BackColor = Style.CommonLabelBackgroundColor;
            labelShiftType.BackColor = Style.CommonLabelBackgroundColor;
            labelProductName.BackColor = Style.CommonLabelBackgroundColor;
            labelUnit.BackColor = Style.CommonLabelBackgroundColor;
            labelSerialNumber.BackColor = Style.CommonLabelBackgroundColor;
            labelBomVersion.BackColor = Style.CommonLabelBackgroundColor;
            labelStorageLocation.BackColor = Style.CommonLabelBackgroundColor;
            labelBoxPerPallet.BackColor = Style.CommonLabelBackgroundColor;
            labelBoxCode.BackColor = Style.CommonLabelBackgroundColor;
            labelExpirationDate.BackColor = Style.CommonLabelBackgroundColor;
            labelShelfLife.BackColor = Style.CommonLabelBackgroundColor;

            pictureBoxAL.BackColor = Style.MainFormCommStatusColorError;
            pictureBoxServer.BackColor = Style.MainFormCommStatusColorGood;
            pictureBoxDemon.BackColor = Style.MainFormCommStatusColorGood;
            #endregion

            #region ForeColor
            labelCurrentDateTime.ForeColor = Style.CommonForeColor;

            labelCommStatus.ForeColor = Style.MainFormCommStatusColorGood;
            labelAL.ForeColor = Style.CommonForeColor;
            labelServer.ForeColor = Style.CommonForeColor;
            labelDemon.ForeColor = Style.CommonForeColor;

            label1.ForeColor = Style.CommonForeColor;
            label2.ForeColor = Style.CommonForeColor;
            label3.ForeColor = Style.MainFormLabel2ForeColor;
            label4.ForeColor = Style.MainFormLabel3ForeColor;

            labelManagerName.ForeColor = Style.MainFormForeColorData;
            labelPlannedQuantity.ForeColor = Style.MainFormForeColorData;
            labelProducedQuantity.ForeColor = Style.MainFormForeColorData;
            labelRemainingRibbon.ForeColor = Style.MainFormForeColorData;
            labelRemainingLabel.ForeColor = Style.MainFormForeColorData;
            labelProductionLine.ForeColor = Style.MainFormForeColorData;
            labelProductionDate.ForeColor = Style.MainFormForeColorData;
            labelShiftType.ForeColor = Style.MainFormForeColorData;
            labelProductName.ForeColor = Style.MainFormForeColorData;
            labelUnit.ForeColor = Style.MainFormForeColorData;
            labelSerialNumber.ForeColor = Style.MainFormForeColorData;
            labelBomVersion.ForeColor = Style.MainFormForeColorData;
            labelStorageLocation.ForeColor = Style.MainFormForeColorData;
            labelBoxPerPallet.ForeColor = Style.MainFormForeColorData;
            labelBoxCode.ForeColor = Style.MainFormForeColorData;
            labelExpirationDate.ForeColor = Style.MainFormForeColorData;
            labelShelfLife.ForeColor = Style.MainFormForeColorData;

            textBoxManagerName.ForeColor = Style.CommonForeColor;
            textBoxPlannedQuantity.ForeColor = Style.CommonForeColor;
            textBoxProducedQuantity.ForeColor = Style.CommonForeColor;
            textBoxRemainingRibbon.ForeColor = Style.CommonForeColor;
            textBoxRemainingLabel.ForeColor = Style.CommonForeColor;
            textBoxProductionLine.ForeColor = Style.CommonForeColor;
            textBoxProductionDate.ForeColor = Style.CommonForeColor;
            textBoxShiftType.ForeColor = Style.CommonForeColor;
            textBoxProductName.ForeColor = Style.CommonForeColor;
            textBoxUnit.ForeColor = Style.CommonForeColor;
            textBoxSerialNumber.ForeColor = Style.CommonForeColor;
            textBoxBomVersion.ForeColor = Style.CommonForeColor;
            textBoxStorageLocation.ForeColor = Style.CommonForeColor;
            textBoxBoxPerPallet.ForeColor = Style.CommonForeColor;
            textBoxBoxCode.ForeColor = Style.CommonForeColor;
            textBoxExpirationDate.ForeColor = Style.CommonForeColor;
            textBoxShelfLife.ForeColor = Style.CommonForeColor;

            buttonProductionPlan.ForeColor = Style.MainFormForeColorData;
            buttonBulkBarcodePrint.ForeColor = Style.CommonForeColor;
            buttonPopDeviceHistory.ForeColor = Style.MainFormForeColorData;
            buttonProductionResult.ForeColor = Style.MainFormForeColorData;
            buttonVariousHistoryInquiry.ForeColor = Style.MainFormForeColorData;
            buttonResultTransferHistory.ForeColor = Style.MainFormForeColorData;
            buttonWorkEnvironmentSettings.ForeColor = Style.CommonForeColor;
            buttonSystemEnvironmentSettings.ForeColor = Style.CommonForeColor;
            buttonHardwareEnvironmentSettings.ForeColor = Style.CommonForeColor;
            buttonCreateBasicInfo.ForeColor = Style.CommonForeColor;
            buttonCreateWorker.ForeColor = Style.MainFormForeColorData;
            buttonRemainingAmountRegister.ForeColor = Style.MainFormForeColorData;
            buttonPause.ForeColor = Style.CommonForeColor;
            buttonStop.ForeColor = Style.CommonForeColor;
            buttonReset.ForeColor = Style.CommonForeColor;
            buttonReissue.ForeColor = Style.CommonForeColor;
            buttonPrintTest.ForeColor = Style.CommonForeColor;
            buttonHelp.ForeColor = Style.MainFormForeColorData;
            buttonExit.ForeColor = Style.CommonForeColor;
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
        }

        // 생산계획버튼
        private void buttonProductionPlan_Click(object sender, EventArgs e)
        {
            ProductionPlanForm productionPlanForm = new ProductionPlanForm();
            productionPlanForm.ShowDialog();
        }

        // 실적관리버튼
        private void buttonProductionResult_Click(object sender, EventArgs e)
        {
            PerformanceManageForm performanceManageForm = new PerformanceManageForm();
            performanceManageForm.ShowDialog();
        }

        // 각종이력조회버튼
        private void buttonVariousHistoryInquiry_Click(object sender, EventArgs e)
        {
            AllHistoryViewForm allHistoryViewForm = new AllHistoryViewForm();
            allHistoryViewForm.ShowDialog();
        }

        // 실적전송이력조회버튼
        private void buttonResultTransferHistory_Click(object sender, EventArgs e)
        {
            PerformanceSendLogForm performanceSendLogForm = new PerformanceSendLogForm();
            performanceSendLogForm.ShowDialog();
        }

        // 잔량등록버튼
        private void buttonRemainingAmountRegister_Click(object sender, EventArgs e)
        {
            RemainingAmountRegisterForm remainingAmountRegisterForm = new RemainingAmountRegisterForm();
            remainingAmountRegisterForm.ShowDialog();
        }

        // 작업환경설정버튼 - 작업자환경설정폼
        private void buttonWorkEnvironmentSettings_Click(object sender, EventArgs e)
        {
            WorkerConfigurationForm workerConfigurationForm = new WorkerConfigurationForm();
            workerConfigurationForm.ShowDialog();
        }

        // 시스템환경설정버튼
        private void buttonSystemEnvironmentSettings_Click(object sender, EventArgs e)
        {
            SystemConfigurationForm systemConfigurationForm = new SystemConfigurationForm();
            systemConfigurationForm.ShowDialog();
        }

        private void buttonHardwareEnvironmentSettings_Click(object sender, EventArgs e)
        {
            HardwareConfigurationForm hardwareConfigurationForm = new HardwareConfigurationForm();
            hardwareConfigurationForm.ShowDialog();
        }

        // 기본정보생성버튼
        private void buttonCreateBasicInfo_Click(object sender, EventArgs e)
        {
            SettingBasicInfoForm settingBasicInfoForm = new SettingBasicInfoForm();
            settingBasicInfoForm.ShowDialog();
        }


        private void textBoxPlannedQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        // 바코드일괄출력버튼
        private void buttonBulkBarcodePrint_Click(object sender, EventArgs e)
        {

        }

        // POP장비관리이력버튼
        private void buttonPopDeviceHistory_Click(object sender, EventArgs e)
        {

        }

        // 작업자설정버튼 - 접근암호입력해 작업자설정
        private void buttonCreateWorker_Click(object sender, EventArgs e)
        {

        }

        // 일시정지버튼 - 시작버튼과 토글
        private void buttonPause_Click(object sender, EventArgs e)
        {

        }

        // 중지버튼
        private void buttonStop_Click(object sender, EventArgs e)
        {

        }

        // 리셋버튼
        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

        // 재발행버튼
        private void buttonReissue_Click(object sender, EventArgs e)
        {

        }

        // 인쇄테스트버튼
        private void buttonPrintTest_Click(object sender, EventArgs e)
        {

        }

        // 도움말버튼
        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }

        // 종료버튼
        private void buttonExit_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

    }
}
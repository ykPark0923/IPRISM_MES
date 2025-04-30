namespace LotteMES.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelCurrentDateTime = new System.Windows.Forms.Label();
            this.textBoxManagerName = new System.Windows.Forms.TextBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelBarcodeNumber = new System.Windows.Forms.Label();
            this.labelBoxStartNumber = new System.Windows.Forms.Label();
            this.labelCommStatus = new System.Windows.Forms.Label();
            this.labelAL = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelManagerName = new System.Windows.Forms.Label();
            this.pictureBoxAL = new System.Windows.Forms.PictureBox();
            this.pictureBoxServer = new System.Windows.Forms.PictureBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.pictureBoxDemon = new System.Windows.Forms.PictureBox();
            this.labelDemon = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCommStatus = new System.Windows.Forms.Panel();
            this.panelBoxInfo = new System.Windows.Forms.Panel();
            this.labelBoxEndNumber = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.labelProducedQuantity = new System.Windows.Forms.Label();
            this.textBoxProducedQuantity = new System.Windows.Forms.TextBox();
            this.labelRemainingLabel = new System.Windows.Forms.Label();
            this.textBoxRemainingLabel = new System.Windows.Forms.TextBox();
            this.labelShiftType = new System.Windows.Forms.Label();
            this.textBoxShiftType = new System.Windows.Forms.TextBox();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.labelStorageLocation = new System.Windows.Forms.Label();
            this.textBoxStorageLocation = new System.Windows.Forms.TextBox();
            this.labelBoxCode = new System.Windows.Forms.Label();
            this.textBoxBoxCode = new System.Windows.Forms.TextBox();
            this.labelShelfLife = new System.Windows.Forms.Label();
            this.textBoxShelfLife = new System.Windows.Forms.TextBox();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.textBoxExpirationDate = new System.Windows.Forms.TextBox();
            this.labelBoxPerPallet = new System.Windows.Forms.Label();
            this.textBoxBoxPerPallet = new System.Windows.Forms.TextBox();
            this.labelBomVersion = new System.Windows.Forms.Label();
            this.textBoxBomVersion = new System.Windows.Forms.TextBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProductionDate = new System.Windows.Forms.Label();
            this.textBoxProductionDate = new System.Windows.Forms.TextBox();
            this.labelProductionLine = new System.Windows.Forms.Label();
            this.textBoxProductionLine = new System.Windows.Forms.TextBox();
            this.labelRemainingRibbon = new System.Windows.Forms.Label();
            this.textBoxRemainingRibbon = new System.Windows.Forms.TextBox();
            this.labelPlannedQuantity = new System.Windows.Forms.Label();
            this.textBoxPlannedQuantity = new System.Windows.Forms.TextBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonRemainingAmountRegister = new System.Windows.Forms.Button();
            this.buttonPerformanceSendLog = new System.Windows.Forms.Button();
            this.buttonAllHistoryView = new System.Windows.Forms.Button();
            this.buttonPerformanceManage = new System.Windows.Forms.Button();
            this.buttonPopDeviceLog = new System.Windows.Forms.Button();
            this.buttonBulkBarcodePrint = new System.Windows.Forms.Button();
            this.buttonProductionPlan = new System.Windows.Forms.Button();
            this.buttonWorkerSetting = new System.Windows.Forms.Button();
            this.buttonSettingBasicInfo = new System.Windows.Forms.Button();
            this.buttonHardwareConfiguration = new System.Windows.Forms.Button();
            this.buttonSystemConfiguration = new System.Windows.Forms.Button();
            this.buttonWorkerConfiguration = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonPrintTest = new System.Windows.Forms.Button();
            this.buttonReissue = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDemon)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCommStatus.SuspendLayout();
            this.panelBoxInfo.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCurrentDateTime
            // 
            this.labelCurrentDateTime.Font = new System.Drawing.Font("돋움체", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCurrentDateTime.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCurrentDateTime.Location = new System.Drawing.Point(398, 12);
            this.labelCurrentDateTime.Name = "labelCurrentDateTime";
            this.labelCurrentDateTime.Size = new System.Drawing.Size(205, 20);
            this.labelCurrentDateTime.TabIndex = 0;
            this.labelCurrentDateTime.Text = "03월 12일 14:33:46";
            this.labelCurrentDateTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxManagerName
            // 
            this.textBoxManagerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxManagerName.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxManagerName.ForeColor = System.Drawing.Color.White;
            this.textBoxManagerName.Location = new System.Drawing.Point(137, 31);
            this.textBoxManagerName.Name = "textBoxManagerName";
            this.textBoxManagerName.Size = new System.Drawing.Size(485, 27);
            this.textBoxManagerName.TabIndex = 2;
            this.textBoxManagerName.Text = "유재영";
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.Black;
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPause.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonPause.ForeColor = System.Drawing.Color.White;
            this.buttonPause.Image = ((System.Drawing.Image)(resources.GetObject("buttonPause.Image")));
            this.buttonPause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPause.Location = new System.Drawing.Point(228, 27);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(106, 63);
            this.buttonPause.TabIndex = 3;
            this.buttonPause.Text = "시작";
            this.buttonPause.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(8, 6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(151, 43);
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelBarcodeNumber
            // 
            this.labelBarcodeNumber.AutoSize = true;
            this.labelBarcodeNumber.Font = new System.Drawing.Font("돋움체", 30F, System.Drawing.FontStyle.Bold);
            this.labelBarcodeNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBarcodeNumber.Location = new System.Drawing.Point(13, 39);
            this.labelBarcodeNumber.Name = "labelBarcodeNumber";
            this.labelBarcodeNumber.Size = new System.Drawing.Size(531, 40);
            this.labelBarcodeNumber.TabIndex = 5;
            this.labelBarcodeNumber.Text = "진행되는 작업이 없습니다.";
            this.labelBarcodeNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBoxStartNumber
            // 
            this.labelBoxStartNumber.AutoSize = true;
            this.labelBoxStartNumber.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelBoxStartNumber.ForeColor = System.Drawing.Color.Red;
            this.labelBoxStartNumber.Location = new System.Drawing.Point(841, 2);
            this.labelBoxStartNumber.Name = "labelBoxStartNumber";
            this.labelBoxStartNumber.Size = new System.Drawing.Size(138, 54);
            this.labelBoxStartNumber.TabIndex = 6;
            this.labelBoxStartNumber.Text = "00001";
            this.labelBoxStartNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCommStatus
            // 
            this.labelCommStatus.AutoSize = true;
            this.labelCommStatus.BackColor = System.Drawing.Color.Black;
            this.labelCommStatus.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCommStatus.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelCommStatus.Location = new System.Drawing.Point(24, 9);
            this.labelCommStatus.Name = "labelCommStatus";
            this.labelCommStatus.Size = new System.Drawing.Size(84, 17);
            this.labelCommStatus.TabIndex = 8;
            this.labelCommStatus.Text = "통신상태";
            this.labelCommStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAL
            // 
            this.labelAL.AutoSize = true;
            this.labelAL.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelAL.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAL.Location = new System.Drawing.Point(134, 9);
            this.labelAL.Name = "labelAL";
            this.labelAL.Size = new System.Drawing.Size(28, 17);
            this.labelAL.TabIndex = 10;
            this.labelAL.Text = "AL";
            this.labelAL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelVersion.ForeColor = System.Drawing.SystemColors.Control;
            this.labelVersion.Location = new System.Drawing.Point(869, 9);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(136, 17);
            this.labelVersion.TabIndex = 15;
            this.labelVersion.Text = "신형POPv11.06";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelManagerName
            // 
            this.labelManagerName.AutoSize = true;
            this.labelManagerName.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelManagerName.ForeColor = System.Drawing.Color.Cyan;
            this.labelManagerName.Location = new System.Drawing.Point(46, 34);
            this.labelManagerName.Name = "labelManagerName";
            this.labelManagerName.Size = new System.Drawing.Size(84, 17);
            this.labelManagerName.TabIndex = 16;
            this.labelManagerName.Text = "작업책임";
            this.labelManagerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxAL
            // 
            this.pictureBoxAL.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBoxAL.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAL.InitialImage")));
            this.pictureBoxAL.Location = new System.Drawing.Point(163, 5);
            this.pictureBoxAL.Name = "pictureBoxAL";
            this.pictureBoxAL.Size = new System.Drawing.Size(36, 24);
            this.pictureBoxAL.TabIndex = 17;
            this.pictureBoxAL.TabStop = false;
            // 
            // pictureBoxServer
            // 
            this.pictureBoxServer.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBoxServer.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxServer.InitialImage")));
            this.pictureBoxServer.Location = new System.Drawing.Point(282, 5);
            this.pictureBoxServer.Name = "pictureBoxServer";
            this.pictureBoxServer.Size = new System.Drawing.Size(36, 24);
            this.pictureBoxServer.TabIndex = 19;
            this.pictureBoxServer.TabStop = false;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelServer.ForeColor = System.Drawing.SystemColors.Control;
            this.labelServer.Location = new System.Drawing.Point(214, 8);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(68, 17);
            this.labelServer.TabIndex = 18;
            this.labelServer.Text = "Server";
            this.labelServer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxDemon
            // 
            this.pictureBoxDemon.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBoxDemon.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDemon.InitialImage")));
            this.pictureBoxDemon.Location = new System.Drawing.Point(396, 5);
            this.pictureBoxDemon.Name = "pictureBoxDemon";
            this.pictureBoxDemon.Size = new System.Drawing.Size(36, 24);
            this.pictureBoxDemon.TabIndex = 21;
            this.pictureBoxDemon.TabStop = false;
            // 
            // labelDemon
            // 
            this.labelDemon.AutoSize = true;
            this.labelDemon.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDemon.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDemon.Location = new System.Drawing.Point(339, 8);
            this.labelDemon.Name = "labelDemon";
            this.labelDemon.Size = new System.Drawing.Size(58, 17);
            this.labelDemon.TabIndex = 20;
            this.labelDemon.Text = "Demon";
            this.labelDemon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.pictureBoxLogo);
            this.panelHeader.Controls.Add(this.labelCurrentDateTime);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1008, 768);
            this.panelHeader.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(850, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 43);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panelCommStatus
            // 
            this.panelCommStatus.Controls.Add(this.labelCommStatus);
            this.panelCommStatus.Controls.Add(this.labelAL);
            this.panelCommStatus.Controls.Add(this.pictureBoxDemon);
            this.panelCommStatus.Controls.Add(this.labelVersion);
            this.panelCommStatus.Controls.Add(this.pictureBoxAL);
            this.panelCommStatus.Controls.Add(this.labelDemon);
            this.panelCommStatus.Controls.Add(this.labelServer);
            this.panelCommStatus.Controls.Add(this.pictureBoxServer);
            this.panelCommStatus.Location = new System.Drawing.Point(0, 55);
            this.panelCommStatus.Name = "panelCommStatus";
            this.panelCommStatus.Size = new System.Drawing.Size(1008, 34);
            this.panelCommStatus.TabIndex = 24;
            // 
            // panelBoxInfo
            // 
            this.panelBoxInfo.BackColor = System.Drawing.Color.DimGray;
            this.panelBoxInfo.Controls.Add(this.labelBoxEndNumber);
            this.panelBoxInfo.Controls.Add(this.labelBarcodeNumber);
            this.panelBoxInfo.Controls.Add(this.labelBoxStartNumber);
            this.panelBoxInfo.Location = new System.Drawing.Point(0, 92);
            this.panelBoxInfo.Name = "panelBoxInfo";
            this.panelBoxInfo.Size = new System.Drawing.Size(1008, 113);
            this.panelBoxInfo.TabIndex = 25;
            // 
            // labelBoxEndNumber
            // 
            this.labelBoxEndNumber.AutoSize = true;
            this.labelBoxEndNumber.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelBoxEndNumber.ForeColor = System.Drawing.Color.Cyan;
            this.labelBoxEndNumber.Location = new System.Drawing.Point(841, 54);
            this.labelBoxEndNumber.Name = "labelBoxEndNumber";
            this.labelBoxEndNumber.Size = new System.Drawing.Size(138, 54);
            this.labelBoxEndNumber.TabIndex = 7;
            this.labelBoxEndNumber.Text = "00000";
            this.labelBoxEndNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.labelProducedQuantity);
            this.panelData.Controls.Add(this.textBoxProducedQuantity);
            this.panelData.Controls.Add(this.labelRemainingLabel);
            this.panelData.Controls.Add(this.textBoxRemainingLabel);
            this.panelData.Controls.Add(this.labelShiftType);
            this.panelData.Controls.Add(this.textBoxShiftType);
            this.panelData.Controls.Add(this.labelSerialNumber);
            this.panelData.Controls.Add(this.textBoxSerialNumber);
            this.panelData.Controls.Add(this.labelStorageLocation);
            this.panelData.Controls.Add(this.textBoxStorageLocation);
            this.panelData.Controls.Add(this.labelBoxCode);
            this.panelData.Controls.Add(this.textBoxBoxCode);
            this.panelData.Controls.Add(this.labelShelfLife);
            this.panelData.Controls.Add(this.textBoxShelfLife);
            this.panelData.Controls.Add(this.labelExpirationDate);
            this.panelData.Controls.Add(this.textBoxExpirationDate);
            this.panelData.Controls.Add(this.labelBoxPerPallet);
            this.panelData.Controls.Add(this.textBoxBoxPerPallet);
            this.panelData.Controls.Add(this.labelBomVersion);
            this.panelData.Controls.Add(this.textBoxBomVersion);
            this.panelData.Controls.Add(this.labelUnit);
            this.panelData.Controls.Add(this.textBoxUnit);
            this.panelData.Controls.Add(this.labelProductName);
            this.panelData.Controls.Add(this.textBoxProductName);
            this.panelData.Controls.Add(this.labelProductionDate);
            this.panelData.Controls.Add(this.textBoxProductionDate);
            this.panelData.Controls.Add(this.labelProductionLine);
            this.panelData.Controls.Add(this.textBoxProductionLine);
            this.panelData.Controls.Add(this.labelRemainingRibbon);
            this.panelData.Controls.Add(this.textBoxRemainingRibbon);
            this.panelData.Controls.Add(this.labelPlannedQuantity);
            this.panelData.Controls.Add(this.textBoxPlannedQuantity);
            this.panelData.Controls.Add(this.labelManagerName);
            this.panelData.Controls.Add(this.textBoxManagerName);
            this.panelData.Location = new System.Drawing.Point(0, 211);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(656, 518);
            this.panelData.TabIndex = 26;
            // 
            // labelProducedQuantity
            // 
            this.labelProducedQuantity.AutoSize = true;
            this.labelProducedQuantity.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelProducedQuantity.ForeColor = System.Drawing.Color.Cyan;
            this.labelProducedQuantity.Location = new System.Drawing.Point(347, 82);
            this.labelProducedQuantity.Name = "labelProducedQuantity";
            this.labelProducedQuantity.Size = new System.Drawing.Size(84, 17);
            this.labelProducedQuantity.TabIndex = 48;
            this.labelProducedQuantity.Text = "생산수량";
            this.labelProducedQuantity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxProducedQuantity
            // 
            this.textBoxProducedQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxProducedQuantity.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxProducedQuantity.ForeColor = System.Drawing.Color.White;
            this.textBoxProducedQuantity.Location = new System.Drawing.Point(439, 79);
            this.textBoxProducedQuantity.Name = "textBoxProducedQuantity";
            this.textBoxProducedQuantity.Size = new System.Drawing.Size(183, 27);
            this.textBoxProducedQuantity.TabIndex = 47;
            this.textBoxProducedQuantity.Text = "20449";
            // 
            // labelRemainingLabel
            // 
            this.labelRemainingLabel.AutoSize = true;
            this.labelRemainingLabel.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelRemainingLabel.ForeColor = System.Drawing.Color.Cyan;
            this.labelRemainingLabel.Location = new System.Drawing.Point(348, 128);
            this.labelRemainingLabel.Name = "labelRemainingLabel";
            this.labelRemainingLabel.Size = new System.Drawing.Size(84, 17);
            this.labelRemainingLabel.TabIndex = 46;
            this.labelRemainingLabel.Text = "잔여라벨";
            this.labelRemainingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxRemainingLabel
            // 
            this.textBoxRemainingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxRemainingLabel.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxRemainingLabel.ForeColor = System.Drawing.Color.White;
            this.textBoxRemainingLabel.Location = new System.Drawing.Point(439, 125);
            this.textBoxRemainingLabel.Name = "textBoxRemainingLabel";
            this.textBoxRemainingLabel.Size = new System.Drawing.Size(183, 27);
            this.textBoxRemainingLabel.TabIndex = 45;
            this.textBoxRemainingLabel.Text = "139";
            // 
            // labelShiftType
            // 
            this.labelShiftType.AutoSize = true;
            this.labelShiftType.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelShiftType.ForeColor = System.Drawing.Color.Cyan;
            this.labelShiftType.Location = new System.Drawing.Point(348, 221);
            this.labelShiftType.Name = "labelShiftType";
            this.labelShiftType.Size = new System.Drawing.Size(84, 17);
            this.labelShiftType.TabIndex = 44;
            this.labelShiftType.Text = "주야구분";
            this.labelShiftType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxShiftType
            // 
            this.textBoxShiftType.BackColor = System.Drawing.Color.Gray;
            this.textBoxShiftType.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxShiftType.ForeColor = System.Drawing.Color.White;
            this.textBoxShiftType.Location = new System.Drawing.Point(439, 218);
            this.textBoxShiftType.Name = "textBoxShiftType";
            this.textBoxShiftType.Size = new System.Drawing.Size(183, 27);
            this.textBoxShiftType.TabIndex = 43;
            this.textBoxShiftType.Text = "야간";
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSerialNumber.ForeColor = System.Drawing.Color.Cyan;
            this.labelSerialNumber.Location = new System.Drawing.Point(348, 308);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(84, 17);
            this.labelSerialNumber.TabIndex = 42;
            this.labelSerialNumber.Text = "일련번호";
            this.labelSerialNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.BackColor = System.Drawing.Color.Gray;
            this.textBoxSerialNumber.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxSerialNumber.ForeColor = System.Drawing.Color.White;
            this.textBoxSerialNumber.Location = new System.Drawing.Point(439, 305);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(183, 27);
            this.textBoxSerialNumber.TabIndex = 41;
            this.textBoxSerialNumber.Text = "144";
            // 
            // labelStorageLocation
            // 
            this.labelStorageLocation.AutoSize = true;
            this.labelStorageLocation.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelStorageLocation.ForeColor = System.Drawing.Color.Cyan;
            this.labelStorageLocation.Location = new System.Drawing.Point(348, 356);
            this.labelStorageLocation.Name = "labelStorageLocation";
            this.labelStorageLocation.Size = new System.Drawing.Size(84, 17);
            this.labelStorageLocation.TabIndex = 40;
            this.labelStorageLocation.Text = "적재위치";
            this.labelStorageLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxStorageLocation
            // 
            this.textBoxStorageLocation.BackColor = System.Drawing.Color.Gray;
            this.textBoxStorageLocation.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxStorageLocation.ForeColor = System.Drawing.Color.White;
            this.textBoxStorageLocation.Location = new System.Drawing.Point(439, 353);
            this.textBoxStorageLocation.Name = "textBoxStorageLocation";
            this.textBoxStorageLocation.Size = new System.Drawing.Size(183, 27);
            this.textBoxStorageLocation.TabIndex = 39;
            this.textBoxStorageLocation.Text = "기본적재창고";
            // 
            // labelBoxCode
            // 
            this.labelBoxCode.AutoSize = true;
            this.labelBoxCode.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelBoxCode.ForeColor = System.Drawing.Color.Cyan;
            this.labelBoxCode.Location = new System.Drawing.Point(348, 403);
            this.labelBoxCode.Name = "labelBoxCode";
            this.labelBoxCode.Size = new System.Drawing.Size(84, 17);
            this.labelBoxCode.TabIndex = 38;
            this.labelBoxCode.Text = "박스코드";
            this.labelBoxCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxBoxCode
            // 
            this.textBoxBoxCode.BackColor = System.Drawing.Color.Gray;
            this.textBoxBoxCode.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxBoxCode.ForeColor = System.Drawing.Color.White;
            this.textBoxBoxCode.Location = new System.Drawing.Point(439, 400);
            this.textBoxBoxCode.Name = "textBoxBoxCode";
            this.textBoxBoxCode.Size = new System.Drawing.Size(183, 27);
            this.textBoxBoxCode.TabIndex = 37;
            // 
            // labelShelfLife
            // 
            this.labelShelfLife.AutoSize = true;
            this.labelShelfLife.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelShelfLife.ForeColor = System.Drawing.Color.Cyan;
            this.labelShelfLife.Location = new System.Drawing.Point(348, 453);
            this.labelShelfLife.Name = "labelShelfLife";
            this.labelShelfLife.Size = new System.Drawing.Size(84, 17);
            this.labelShelfLife.TabIndex = 36;
            this.labelShelfLife.Text = "유통기간";
            this.labelShelfLife.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxShelfLife
            // 
            this.textBoxShelfLife.BackColor = System.Drawing.Color.Gray;
            this.textBoxShelfLife.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxShelfLife.ForeColor = System.Drawing.Color.White;
            this.textBoxShelfLife.Location = new System.Drawing.Point(439, 450);
            this.textBoxShelfLife.Name = "textBoxShelfLife";
            this.textBoxShelfLife.Size = new System.Drawing.Size(183, 27);
            this.textBoxShelfLife.TabIndex = 35;
            this.textBoxShelfLife.Text = "12개월";
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelExpirationDate.ForeColor = System.Drawing.Color.Cyan;
            this.labelExpirationDate.Location = new System.Drawing.Point(46, 453);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(84, 17);
            this.labelExpirationDate.TabIndex = 34;
            this.labelExpirationDate.Text = "유통기한";
            this.labelExpirationDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxExpirationDate
            // 
            this.textBoxExpirationDate.BackColor = System.Drawing.Color.Gray;
            this.textBoxExpirationDate.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxExpirationDate.ForeColor = System.Drawing.Color.White;
            this.textBoxExpirationDate.Location = new System.Drawing.Point(137, 450);
            this.textBoxExpirationDate.Name = "textBoxExpirationDate";
            this.textBoxExpirationDate.Size = new System.Drawing.Size(183, 27);
            this.textBoxExpirationDate.TabIndex = 33;
            this.textBoxExpirationDate.Text = "2026.03.11";
            // 
            // labelBoxPerPallet
            // 
            this.labelBoxPerPallet.AutoSize = true;
            this.labelBoxPerPallet.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelBoxPerPallet.ForeColor = System.Drawing.Color.Cyan;
            this.labelBoxPerPallet.Location = new System.Drawing.Point(46, 403);
            this.labelBoxPerPallet.Name = "labelBoxPerPallet";
            this.labelBoxPerPallet.Size = new System.Drawing.Size(68, 17);
            this.labelBoxPerPallet.TabIndex = 32;
            this.labelBoxPerPallet.Text = "BOX/PL";
            this.labelBoxPerPallet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxBoxPerPallet
            // 
            this.textBoxBoxPerPallet.BackColor = System.Drawing.Color.Gray;
            this.textBoxBoxPerPallet.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxBoxPerPallet.ForeColor = System.Drawing.Color.White;
            this.textBoxBoxPerPallet.Location = new System.Drawing.Point(137, 400);
            this.textBoxBoxPerPallet.Name = "textBoxBoxPerPallet";
            this.textBoxBoxPerPallet.Size = new System.Drawing.Size(183, 27);
            this.textBoxBoxPerPallet.TabIndex = 31;
            this.textBoxBoxPerPallet.Text = "143";
            // 
            // labelBomVersion
            // 
            this.labelBomVersion.AutoSize = true;
            this.labelBomVersion.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelBomVersion.ForeColor = System.Drawing.Color.Cyan;
            this.labelBomVersion.Location = new System.Drawing.Point(46, 356);
            this.labelBomVersion.Name = "labelBomVersion";
            this.labelBomVersion.Size = new System.Drawing.Size(76, 17);
            this.labelBomVersion.TabIndex = 30;
            this.labelBomVersion.Text = "BOM버전";
            this.labelBomVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxBomVersion
            // 
            this.textBoxBomVersion.BackColor = System.Drawing.Color.Gray;
            this.textBoxBomVersion.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxBomVersion.ForeColor = System.Drawing.Color.White;
            this.textBoxBomVersion.Location = new System.Drawing.Point(137, 353);
            this.textBoxBomVersion.Name = "textBoxBomVersion";
            this.textBoxBomVersion.Size = new System.Drawing.Size(183, 27);
            this.textBoxBomVersion.TabIndex = 29;
            this.textBoxBomVersion.Text = "C103";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelUnit.ForeColor = System.Drawing.Color.Cyan;
            this.labelUnit.Location = new System.Drawing.Point(46, 308);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(46, 17);
            this.labelUnit.TabIndex = 28;
            this.labelUnit.Text = "단위";
            this.labelUnit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.BackColor = System.Drawing.Color.Gray;
            this.textBoxUnit.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxUnit.ForeColor = System.Drawing.Color.White;
            this.textBoxUnit.Location = new System.Drawing.Point(137, 305);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(183, 27);
            this.textBoxUnit.TabIndex = 27;
            this.textBoxUnit.Text = "CSR";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelProductName.ForeColor = System.Drawing.Color.Cyan;
            this.labelProductName.Location = new System.Drawing.Point(46, 266);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(65, 17);
            this.labelProductName.TabIndex = 26;
            this.labelProductName.Text = "제품명";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.Color.Gray;
            this.textBoxProductName.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxProductName.ForeColor = System.Drawing.Color.White;
            this.textBoxProductName.Location = new System.Drawing.Point(137, 263);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(485, 27);
            this.textBoxProductName.TabIndex = 25;
            this.textBoxProductName.Text = "(23867)레쓰비마일드175캔(업소용)(표준)";
            // 
            // labelProductionDate
            // 
            this.labelProductionDate.AutoSize = true;
            this.labelProductionDate.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelProductionDate.ForeColor = System.Drawing.Color.Cyan;
            this.labelProductionDate.Location = new System.Drawing.Point(46, 221);
            this.labelProductionDate.Name = "labelProductionDate";
            this.labelProductionDate.Size = new System.Drawing.Size(84, 17);
            this.labelProductionDate.TabIndex = 24;
            this.labelProductionDate.Text = "생산일자";
            this.labelProductionDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxProductionDate
            // 
            this.textBoxProductionDate.BackColor = System.Drawing.Color.Gray;
            this.textBoxProductionDate.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxProductionDate.ForeColor = System.Drawing.Color.White;
            this.textBoxProductionDate.Location = new System.Drawing.Point(137, 218);
            this.textBoxProductionDate.Name = "textBoxProductionDate";
            this.textBoxProductionDate.Size = new System.Drawing.Size(183, 27);
            this.textBoxProductionDate.TabIndex = 23;
            this.textBoxProductionDate.Text = "2025.03.09";
            // 
            // labelProductionLine
            // 
            this.labelProductionLine.AutoSize = true;
            this.labelProductionLine.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelProductionLine.ForeColor = System.Drawing.Color.Cyan;
            this.labelProductionLine.Location = new System.Drawing.Point(46, 174);
            this.labelProductionLine.Name = "labelProductionLine";
            this.labelProductionLine.Size = new System.Drawing.Size(84, 17);
            this.labelProductionLine.TabIndex = 22;
            this.labelProductionLine.Text = "생산라인";
            this.labelProductionLine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxProductionLine
            // 
            this.textBoxProductionLine.BackColor = System.Drawing.Color.Gray;
            this.textBoxProductionLine.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxProductionLine.ForeColor = System.Drawing.Color.White;
            this.textBoxProductionLine.Location = new System.Drawing.Point(137, 171);
            this.textBoxProductionLine.Name = "textBoxProductionLine";
            this.textBoxProductionLine.Size = new System.Drawing.Size(485, 27);
            this.textBoxProductionLine.TabIndex = 21;
            this.textBoxProductionLine.Text = "(대전)커피캔라인";
            // 
            // labelRemainingRibbon
            // 
            this.labelRemainingRibbon.AutoSize = true;
            this.labelRemainingRibbon.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelRemainingRibbon.ForeColor = System.Drawing.Color.Cyan;
            this.labelRemainingRibbon.Location = new System.Drawing.Point(46, 128);
            this.labelRemainingRibbon.Name = "labelRemainingRibbon";
            this.labelRemainingRibbon.Size = new System.Drawing.Size(84, 17);
            this.labelRemainingRibbon.TabIndex = 20;
            this.labelRemainingRibbon.Text = "잔여리본";
            this.labelRemainingRibbon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxRemainingRibbon
            // 
            this.textBoxRemainingRibbon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxRemainingRibbon.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxRemainingRibbon.ForeColor = System.Drawing.Color.White;
            this.textBoxRemainingRibbon.Location = new System.Drawing.Point(137, 125);
            this.textBoxRemainingRibbon.Name = "textBoxRemainingRibbon";
            this.textBoxRemainingRibbon.Size = new System.Drawing.Size(183, 27);
            this.textBoxRemainingRibbon.TabIndex = 19;
            this.textBoxRemainingRibbon.Text = "4214";
            // 
            // labelPlannedQuantity
            // 
            this.labelPlannedQuantity.AutoSize = true;
            this.labelPlannedQuantity.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPlannedQuantity.ForeColor = System.Drawing.Color.Cyan;
            this.labelPlannedQuantity.Location = new System.Drawing.Point(46, 82);
            this.labelPlannedQuantity.Name = "labelPlannedQuantity";
            this.labelPlannedQuantity.Size = new System.Drawing.Size(84, 17);
            this.labelPlannedQuantity.TabIndex = 18;
            this.labelPlannedQuantity.Text = "계획수량";
            this.labelPlannedQuantity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxPlannedQuantity
            // 
            this.textBoxPlannedQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPlannedQuantity.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxPlannedQuantity.ForeColor = System.Drawing.Color.White;
            this.textBoxPlannedQuantity.Location = new System.Drawing.Point(137, 79);
            this.textBoxPlannedQuantity.Name = "textBoxPlannedQuantity";
            this.textBoxPlannedQuantity.Size = new System.Drawing.Size(183, 27);
            this.textBoxPlannedQuantity.TabIndex = 17;
            this.textBoxPlannedQuantity.Text = "20000";
            this.textBoxPlannedQuantity.TextChanged += new System.EventHandler(this.textBoxPlannedQuantity_TextChanged);
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonRemainingAmountRegister);
            this.panelButton.Controls.Add(this.buttonPerformanceSendLog);
            this.panelButton.Controls.Add(this.buttonAllHistoryView);
            this.panelButton.Controls.Add(this.buttonPerformanceManage);
            this.panelButton.Controls.Add(this.buttonPopDeviceLog);
            this.panelButton.Controls.Add(this.buttonBulkBarcodePrint);
            this.panelButton.Controls.Add(this.buttonProductionPlan);
            this.panelButton.Controls.Add(this.buttonWorkerSetting);
            this.panelButton.Controls.Add(this.buttonSettingBasicInfo);
            this.panelButton.Controls.Add(this.buttonHardwareConfiguration);
            this.panelButton.Controls.Add(this.buttonSystemConfiguration);
            this.panelButton.Controls.Add(this.buttonWorkerConfiguration);
            this.panelButton.Controls.Add(this.buttonExit);
            this.panelButton.Controls.Add(this.buttonHelp);
            this.panelButton.Controls.Add(this.buttonPrintTest);
            this.panelButton.Controls.Add(this.buttonReissue);
            this.panelButton.Controls.Add(this.buttonReset);
            this.panelButton.Controls.Add(this.buttonStop);
            this.panelButton.Controls.Add(this.buttonPause);
            this.panelButton.Location = new System.Drawing.Point(657, 211);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(351, 518);
            this.panelButton.TabIndex = 27;
            // 
            // buttonRemainingAmountRegister
            // 
            this.buttonRemainingAmountRegister.BackColor = System.Drawing.Color.Black;
            this.buttonRemainingAmountRegister.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonRemainingAmountRegister.ForeColor = System.Drawing.Color.Cyan;
            this.buttonRemainingAmountRegister.Location = new System.Drawing.Point(121, 362);
            this.buttonRemainingAmountRegister.Name = "buttonRemainingAmountRegister";
            this.buttonRemainingAmountRegister.Size = new System.Drawing.Size(106, 63);
            this.buttonRemainingAmountRegister.TabIndex = 21;
            this.buttonRemainingAmountRegister.Text = "잔량등록";
            this.buttonRemainingAmountRegister.UseVisualStyleBackColor = false;
            this.buttonRemainingAmountRegister.Click += new System.EventHandler(this.buttonRemainingAmountRegister_Click);
            // 
            // buttonPerformanceSendLog
            // 
            this.buttonPerformanceSendLog.BackColor = System.Drawing.Color.Black;
            this.buttonPerformanceSendLog.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonPerformanceSendLog.ForeColor = System.Drawing.Color.Cyan;
            this.buttonPerformanceSendLog.Location = new System.Drawing.Point(15, 362);
            this.buttonPerformanceSendLog.Name = "buttonPerformanceSendLog";
            this.buttonPerformanceSendLog.Size = new System.Drawing.Size(106, 63);
            this.buttonPerformanceSendLog.TabIndex = 20;
            this.buttonPerformanceSendLog.Text = "실적전송\r\n이력조회";
            this.buttonPerformanceSendLog.UseVisualStyleBackColor = false;
            this.buttonPerformanceSendLog.Click += new System.EventHandler(this.buttonPerformanceSendLog_Click);
            // 
            // buttonAllHistoryView
            // 
            this.buttonAllHistoryView.BackColor = System.Drawing.Color.Black;
            this.buttonAllHistoryView.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAllHistoryView.ForeColor = System.Drawing.Color.Cyan;
            this.buttonAllHistoryView.Location = new System.Drawing.Point(15, 296);
            this.buttonAllHistoryView.Name = "buttonAllHistoryView";
            this.buttonAllHistoryView.Size = new System.Drawing.Size(106, 63);
            this.buttonAllHistoryView.TabIndex = 19;
            this.buttonAllHistoryView.Text = "각종이력\r\n조회";
            this.buttonAllHistoryView.UseVisualStyleBackColor = false;
            this.buttonAllHistoryView.Click += new System.EventHandler(this.buttonAllHistoryView_Click);
            // 
            // buttonPerformanceManage
            // 
            this.buttonPerformanceManage.BackColor = System.Drawing.Color.Black;
            this.buttonPerformanceManage.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonPerformanceManage.ForeColor = System.Drawing.Color.Cyan;
            this.buttonPerformanceManage.Location = new System.Drawing.Point(15, 229);
            this.buttonPerformanceManage.Name = "buttonPerformanceManage";
            this.buttonPerformanceManage.Size = new System.Drawing.Size(106, 63);
            this.buttonPerformanceManage.TabIndex = 18;
            this.buttonPerformanceManage.Text = "실적관리";
            this.buttonPerformanceManage.UseVisualStyleBackColor = false;
            this.buttonPerformanceManage.Click += new System.EventHandler(this.buttonPerformanceManage_Click);
            // 
            // buttonPopDeviceLog
            // 
            this.buttonPopDeviceLog.BackColor = System.Drawing.Color.Black;
            this.buttonPopDeviceLog.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonPopDeviceLog.ForeColor = System.Drawing.Color.Cyan;
            this.buttonPopDeviceLog.Location = new System.Drawing.Point(15, 163);
            this.buttonPopDeviceLog.Name = "buttonPopDeviceLog";
            this.buttonPopDeviceLog.Size = new System.Drawing.Size(106, 63);
            this.buttonPopDeviceLog.TabIndex = 17;
            this.buttonPopDeviceLog.Text = "POP 장비\r\n관리이력";
            this.buttonPopDeviceLog.UseVisualStyleBackColor = false;
            this.buttonPopDeviceLog.Click += new System.EventHandler(this.buttonPopDeviceLog_Click);
            // 
            // buttonBulkBarcodePrint
            // 
            this.buttonBulkBarcodePrint.BackColor = System.Drawing.Color.Black;
            this.buttonBulkBarcodePrint.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonBulkBarcodePrint.ForeColor = System.Drawing.Color.White;
            this.buttonBulkBarcodePrint.Location = new System.Drawing.Point(15, 96);
            this.buttonBulkBarcodePrint.Name = "buttonBulkBarcodePrint";
            this.buttonBulkBarcodePrint.Size = new System.Drawing.Size(106, 63);
            this.buttonBulkBarcodePrint.TabIndex = 16;
            this.buttonBulkBarcodePrint.Text = "바코드\r\n일괄출력";
            this.buttonBulkBarcodePrint.UseVisualStyleBackColor = false;
            this.buttonBulkBarcodePrint.Click += new System.EventHandler(this.buttonBulkBarcodePrint_Click);
            // 
            // buttonProductionPlan
            // 
            this.buttonProductionPlan.BackColor = System.Drawing.Color.Black;
            this.buttonProductionPlan.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonProductionPlan.ForeColor = System.Drawing.Color.Cyan;
            this.buttonProductionPlan.Location = new System.Drawing.Point(15, 27);
            this.buttonProductionPlan.Name = "buttonProductionPlan";
            this.buttonProductionPlan.Size = new System.Drawing.Size(106, 63);
            this.buttonProductionPlan.TabIndex = 15;
            this.buttonProductionPlan.Text = "생산계획";
            this.buttonProductionPlan.UseVisualStyleBackColor = false;
            this.buttonProductionPlan.Click += new System.EventHandler(this.buttonProductionPlan_Click);
            // 
            // buttonWorkerSetting
            // 
            this.buttonWorkerSetting.BackColor = System.Drawing.Color.Black;
            this.buttonWorkerSetting.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonWorkerSetting.ForeColor = System.Drawing.Color.Cyan;
            this.buttonWorkerSetting.Location = new System.Drawing.Point(121, 296);
            this.buttonWorkerSetting.Name = "buttonWorkerSetting";
            this.buttonWorkerSetting.Size = new System.Drawing.Size(106, 63);
            this.buttonWorkerSetting.TabIndex = 14;
            this.buttonWorkerSetting.Text = "작업자\r\n설정";
            this.buttonWorkerSetting.UseVisualStyleBackColor = false;
            this.buttonWorkerSetting.Click += new System.EventHandler(this.buttonWorkerSetting_Click);
            // 
            // buttonSettingBasicInfo
            // 
            this.buttonSettingBasicInfo.BackColor = System.Drawing.Color.Black;
            this.buttonSettingBasicInfo.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSettingBasicInfo.ForeColor = System.Drawing.Color.White;
            this.buttonSettingBasicInfo.Location = new System.Drawing.Point(121, 229);
            this.buttonSettingBasicInfo.Name = "buttonSettingBasicInfo";
            this.buttonSettingBasicInfo.Size = new System.Drawing.Size(106, 63);
            this.buttonSettingBasicInfo.TabIndex = 13;
            this.buttonSettingBasicInfo.Text = "기본정보\r\n생성";
            this.buttonSettingBasicInfo.UseVisualStyleBackColor = false;
            this.buttonSettingBasicInfo.Click += new System.EventHandler(this.buttonSettingBasicInfo_Click);
            // 
            // buttonHardwareConfiguration
            // 
            this.buttonHardwareConfiguration.BackColor = System.Drawing.Color.Black;
            this.buttonHardwareConfiguration.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonHardwareConfiguration.ForeColor = System.Drawing.Color.White;
            this.buttonHardwareConfiguration.Location = new System.Drawing.Point(121, 163);
            this.buttonHardwareConfiguration.Name = "buttonHardwareConfiguration";
            this.buttonHardwareConfiguration.Size = new System.Drawing.Size(106, 63);
            this.buttonHardwareConfiguration.TabIndex = 12;
            this.buttonHardwareConfiguration.Text = "H/W\r\n환경설정";
            this.buttonHardwareConfiguration.UseVisualStyleBackColor = false;
            this.buttonHardwareConfiguration.Click += new System.EventHandler(this.buttonHardwareConfiguration_Click);
            // 
            // buttonSystemConfiguration
            // 
            this.buttonSystemConfiguration.BackColor = System.Drawing.Color.Black;
            this.buttonSystemConfiguration.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSystemConfiguration.ForeColor = System.Drawing.Color.White;
            this.buttonSystemConfiguration.Location = new System.Drawing.Point(121, 96);
            this.buttonSystemConfiguration.Name = "buttonSystemConfiguration";
            this.buttonSystemConfiguration.Size = new System.Drawing.Size(106, 63);
            this.buttonSystemConfiguration.TabIndex = 11;
            this.buttonSystemConfiguration.Text = "시스템\r\n환경설정";
            this.buttonSystemConfiguration.UseVisualStyleBackColor = false;
            this.buttonSystemConfiguration.Click += new System.EventHandler(this.buttonSystemConfiguration_Click);
            // 
            // buttonWorkerConfiguration
            // 
            this.buttonWorkerConfiguration.BackColor = System.Drawing.Color.Black;
            this.buttonWorkerConfiguration.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonWorkerConfiguration.ForeColor = System.Drawing.Color.White;
            this.buttonWorkerConfiguration.Location = new System.Drawing.Point(121, 27);
            this.buttonWorkerConfiguration.Name = "buttonWorkerConfiguration";
            this.buttonWorkerConfiguration.Size = new System.Drawing.Size(106, 63);
            this.buttonWorkerConfiguration.TabIndex = 10;
            this.buttonWorkerConfiguration.Text = "작업\r\n환경설정";
            this.buttonWorkerConfiguration.UseVisualStyleBackColor = false;
            this.buttonWorkerConfiguration.Click += new System.EventHandler(this.buttonWorkerConfiguration_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Black;
            this.buttonExit.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(228, 428);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(106, 63);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "종료";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Black;
            this.buttonHelp.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonHelp.ForeColor = System.Drawing.Color.Cyan;
            this.buttonHelp.Location = new System.Drawing.Point(228, 362);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(106, 63);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "도움말";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonPrintTest
            // 
            this.buttonPrintTest.BackColor = System.Drawing.Color.Black;
            this.buttonPrintTest.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonPrintTest.ForeColor = System.Drawing.Color.White;
            this.buttonPrintTest.Location = new System.Drawing.Point(228, 296);
            this.buttonPrintTest.Name = "buttonPrintTest";
            this.buttonPrintTest.Size = new System.Drawing.Size(106, 63);
            this.buttonPrintTest.TabIndex = 7;
            this.buttonPrintTest.Text = "인쇄\r\n테스트";
            this.buttonPrintTest.UseVisualStyleBackColor = false;
            this.buttonPrintTest.Click += new System.EventHandler(this.buttonPrintTest_Click);
            // 
            // buttonReissue
            // 
            this.buttonReissue.BackColor = System.Drawing.Color.Black;
            this.buttonReissue.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonReissue.ForeColor = System.Drawing.Color.White;
            this.buttonReissue.Location = new System.Drawing.Point(228, 229);
            this.buttonReissue.Name = "buttonReissue";
            this.buttonReissue.Size = new System.Drawing.Size(106, 63);
            this.buttonReissue.TabIndex = 6;
            this.buttonReissue.Text = "재발행";
            this.buttonReissue.UseVisualStyleBackColor = false;
            this.buttonReissue.Click += new System.EventHandler(this.buttonReissue_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Black;
            this.buttonReset.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Image = ((System.Drawing.Image)(resources.GetObject("buttonReset.Image")));
            this.buttonReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReset.Location = new System.Drawing.Point(228, 163);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(106, 63);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "리셋";
            this.buttonReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Black;
            this.buttonStop.Font = new System.Drawing.Font("돋움체", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonStop.ForeColor = System.Drawing.Color.White;
            this.buttonStop.Image = ((System.Drawing.Image)(resources.GetObject("buttonStop.Image")));
            this.buttonStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStop.Location = new System.Drawing.Point(228, 96);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(106, 63);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "중지";
            this.buttonStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelBoxInfo);
            this.Controls.Add(this.panelCommStatus);
            this.Controls.Add(this.panelHeader);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDemon)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCommStatus.ResumeLayout(false);
            this.panelCommStatus.PerformLayout();
            this.panelBoxInfo.ResumeLayout(false);
            this.panelBoxInfo.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentDateTime;
        private System.Windows.Forms.TextBox textBoxManagerName;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelBarcodeNumber;
        private System.Windows.Forms.Label labelBoxStartNumber;
        private System.Windows.Forms.Label labelCommStatus;
        private System.Windows.Forms.Label labelAL;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelManagerName;
        private System.Windows.Forms.PictureBox pictureBoxAL;
        private System.Windows.Forms.PictureBox pictureBoxServer;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.PictureBox pictureBoxDemon;
        private System.Windows.Forms.Label labelDemon;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelCommStatus;
        private System.Windows.Forms.Panel panelBoxInfo;
        private System.Windows.Forms.Label labelBoxEndNumber;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Label labelRemainingRibbon;
        private System.Windows.Forms.TextBox textBoxRemainingRibbon;
        private System.Windows.Forms.Label labelProducedQuantity;
        private System.Windows.Forms.TextBox textBoxProducedQuantity;
        private System.Windows.Forms.Label labelRemainingLabel;
        private System.Windows.Forms.TextBox textBoxRemainingLabel;
        private System.Windows.Forms.Label labelShiftType;
        private System.Windows.Forms.TextBox textBoxShiftType;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.Label labelStorageLocation;
        private System.Windows.Forms.TextBox textBoxStorageLocation;
        private System.Windows.Forms.Label labelBoxCode;
        private System.Windows.Forms.TextBox textBoxBoxCode;
        private System.Windows.Forms.Label labelShelfLife;
        private System.Windows.Forms.TextBox textBoxShelfLife;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.TextBox textBoxExpirationDate;
        private System.Windows.Forms.Label labelBoxPerPallet;
        private System.Windows.Forms.TextBox textBoxBoxPerPallet;
        private System.Windows.Forms.Label labelBomVersion;
        private System.Windows.Forms.TextBox textBoxBomVersion;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelProductionDate;
        private System.Windows.Forms.TextBox textBoxProductionDate;
        private System.Windows.Forms.Label labelProductionLine;
        private System.Windows.Forms.TextBox textBoxProductionLine;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonPrintTest;
        private System.Windows.Forms.Button buttonReissue;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPerformanceSendLog;
        private System.Windows.Forms.Button buttonAllHistoryView;
        private System.Windows.Forms.Button buttonPerformanceManage;
        private System.Windows.Forms.Button buttonPopDeviceLog;
        private System.Windows.Forms.Button buttonBulkBarcodePrint;
        private System.Windows.Forms.Button buttonProductionPlan;
        private System.Windows.Forms.Button buttonWorkerSetting;
        private System.Windows.Forms.Button buttonSettingBasicInfo;
        private System.Windows.Forms.Button buttonHardwareConfiguration;
        private System.Windows.Forms.Button buttonSystemConfiguration;
        private System.Windows.Forms.Button buttonWorkerConfiguration;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelPlannedQuantity;
        private System.Windows.Forms.TextBox textBoxPlannedQuantity;
        private System.Windows.Forms.Button buttonRemainingAmountRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


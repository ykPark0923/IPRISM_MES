using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteMES.FormData
{
    public class MainFormData
    {
        


        #region Label
        private string labelCurrentDateTime = string.Empty;
        public string LabelCurrentDateTime { get => labelCurrentDateTime; set => labelCurrentDateTime = value; }

        private string label1 = string.Empty;
        public string Label1 { get => label1; set => label1 = value; }

        private string label2 = string.Empty;
        public string Label2 { get => label2; set => label2 = value; }

        private string label3 = string.Empty;
        public string Label3 { get => label3; set => label3 = value; }

        private string label4 = string.Empty;
        public string Label4 { get => label4; set => label4 = value; }
        #endregion


        #region TextBox
        private string textBoxManagerName = string.Empty;
        public string TextBoxManagerName { get => textBoxManagerName; set => textBoxManagerName = value; }

        private int textBoxPlannedQuantity = 0;
        public int TextBoxPlannedQuantity { get => textBoxPlannedQuantity; set => textBoxPlannedQuantity = value; }

        private int textBoxProducedQuantity = 0;
        public int TextBoxProducedQuantity { get => textBoxProducedQuantity; set => textBoxProducedQuantity = value; }

        private int textBoxRemainingRibbon = 0;
        public int TextBoxRemainingRibbon { get => textBoxRemainingRibbon; set => textBoxRemainingRibbon = value; }

        private int textBoxRemainingLabel = 0;
        public int TextBoxRemainingLabel { get => textBoxRemainingLabel; set => textBoxRemainingLabel = value; }

        private string textBoxProductionLine = string.Empty;
        public string TextBoxProductionLine { get => textBoxProductionLine; set => textBoxProductionLine = value; }

        private DateTime textBoxProductionDate = DateTime.Now;
        public DateTime TextBoxProductionDate { get => textBoxProductionDate; set => textBoxProductionDate = value; }

        private string textBoxShiftType = string.Empty;
        public string TextBoxShiftType { get => textBoxShiftType; set => textBoxShiftType = value; }

        private string textBoxProductName = string.Empty;
        public string TextBoxProductName { get => textBoxProductName; set => textBoxProductName = value; }

        private string textBoxUnit = string.Empty;
        public string TextBoxUnit { get => textBoxUnit; set => textBoxUnit = value; }

        private string textBoxSerialNumber = string.Empty;
        public string TextBoxSerialNumber { get => textBoxSerialNumber; set => textBoxSerialNumber = value; }

        private string textBoxBomVersion = string.Empty;
        public string TextBoxBomVersion { get => textBoxBomVersion; set => textBoxBomVersion = value; }

        private string textBoxStorageLocation = string.Empty;
        public string TextBoxStorageLocation { get => textBoxStorageLocation; set => textBoxStorageLocation = value; }

        private int textBoxBoxPerPallet = 0;
        public int TextBoxBoxPerPallet { get => textBoxBoxPerPallet; set => textBoxBoxPerPallet = value; }

        private string textBoxBoxCode = string.Empty;
        public string TextBoxBoxCode { get => textBoxBoxCode; set => textBoxBoxCode = value; }

        private DateTime textBoxExpirationDate = DateTime.Now;
        public DateTime TextBoxExpirationDate { get => textBoxExpirationDate; set => textBoxExpirationDate = value; }

        private int textBoxShelfLife = 0;
        public int TextBoxShelfLife { get => textBoxShelfLife; set => textBoxShelfLife = value; }
        #endregion
    }
}

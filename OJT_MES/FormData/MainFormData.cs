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
        private string currentDateTime = string.Empty;
        public string CurrentDateTime { get => currentDateTime; set => currentDateTime = value; }

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
        private string managerName = string.Empty;
        public string ManagerName { get => managerName; set => managerName = value; }

        private int plannedQuantity = 0;
        public int PlannedQuantity { get => plannedQuantity; set => plannedQuantity = value; }

        private int producedQuantity = 0;
        public int ProducedQuantity { get => producedQuantity; set => producedQuantity = value; }

        private int remainingRibbon = 0;
        public int RemainingRibbon { get => remainingRibbon; set => remainingRibbon = value; }

        private int remainingLabel = 0;
        public int RemainingLabel { get => remainingLabel; set => remainingLabel = value; }

        private string productionLine = string.Empty;
        public string ProductionLine { get => productionLine; set => productionLine = value; }

        private DateTime productionDate = DateTime.Now;
        public DateTime ProductionDate { get => productionDate; set => productionDate = value; }

        private string shiftType = string.Empty;
        public string ShiftType { get => shiftType; set => shiftType = value; }

        private string productName = string.Empty;
        public string ProductName { get => productName; set => productName = value; }

        private string unit = string.Empty;
        public string Unit { get => unit; set => unit = value; }

        private string serialNumber = string.Empty;
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }

        private string bomVersion = string.Empty;
        public string BomVersion { get => bomVersion; set => bomVersion = value; }

        private string storageLocation = string.Empty;
        public string StorageLocation { get => storageLocation; set => storageLocation = value; }

        private int boxPerPallet = 0;
        public int BoxPerPallet { get => boxPerPallet; set => boxPerPallet = value; }

        private string boxCode = string.Empty;
        public string BoxCode { get => boxCode; set => boxCode = value; }

        private DateTime expirationDate = DateTime.Now;
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }

        private int shelfLife = 0;
        public int ShelfLife { get => shelfLife; set => shelfLife = value; }
        #endregion
    }
}

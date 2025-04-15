using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteMES.FormData
{
    internal class MainFormData
    {
        private string managerName = string.Empty;

        public string ManagerName { get => managerName; set => managerName = value; }


        private int plannedQuantity = 0;

        public int PlannedQuantity { get => plannedQuantity; set => plannedQuantity = value; }
    }
}

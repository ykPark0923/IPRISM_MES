using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteMES.FormData
{
    public class LoginFormData
    {
        #region TextBox
        private string workerId = string.Empty;
        public string WorkerId { get => workerId; set => workerId = value; }

        private string workerPassword = string.Empty;
        public string WorkerPassword { get => workerPassword; set => workerPassword = value; }
        #endregion
    }
}

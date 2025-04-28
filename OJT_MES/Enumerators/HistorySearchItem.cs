using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel; // enum Description 필요

namespace LotteMES.Enumerators
{
    public enum HistorySearchItem
    {
        [Description("POP 장비 관리 이력")]
        PopEquipmentHistory,

        [Description("최근 에러 로그")]
        RecentErrorLog,

        [Description("작업 이력")]
        WorkHistory,

        [Description("다운로드/업로드 이력")]
        TransferHistory
    }
}

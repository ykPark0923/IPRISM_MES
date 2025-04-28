using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LotteMES.Styles;
using LotteMES.Helpers;
using LotteMES.Bases;

namespace LotteMES.Forms
{
    public partial class AllHistoryViewForm : MESFormBase
    {
        public AllHistoryViewForm()
        {
            InitializeComponent();

            //테두리
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void AllHistoryViewForm_Load(object sender, EventArgs e)
        {
            SetStyles();
        }

        protected override void SetStyles()
        {
            #region BackColor
            this.BackColor = Style.CommonBackgroundColor;
            panelSplitBar.BackColor = Style.CommonSplitBarBackgroundColor;
            dataGridViewHistory.BackColor = Style.CommonListBackgroundColor;

            buttonSearch.BackColor = Style.CommonButtonBackgroundColor;
            buttonClose.BackColor = Style.CommonButtonBackgroundColor;

            comboBoxDateFrom.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxDateTo.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxSearchType.BackColor = Style.CommonComboBoxBackgroundColor;

            labelTitle.BackColor = Style.CommonLabelBackgroundColor;
            labelDateInput.BackColor = Style.CommonLabelBackgroundColor;
            labelSearchType.BackColor = Style.CommonLabelBackgroundColor;
            #endregion

            #region ForeColor
            dataGridViewHistory.ForeColor = Style.CommonListForeColor;

            buttonSearch.ForeColor = Style.CommonForeColor;
            buttonClose.ForeColor = Style.CommonForeColor;

            comboBoxDateFrom.ForeColor = Style.CommonSettingForeColor;
            comboBoxDateTo.ForeColor = Style.CommonSettingForeColor;
            comboBoxSearchType.ForeColor = Style.CommonSettingForeColor;

            labelTitle.ForeColor = Style.CommonForeColor;
            labelDateInput.ForeColor = Style.CommonForeColor;
            labelSearchType.ForeColor = Style.CommonForeColor;
            #endregion

            #region Font
            dataGridViewHistory.Font = Style.CommonListFont;

            buttonSearch.Font = Style.CommonFont;
            buttonClose.Font = Style.CommonFont;

            comboBoxDateFrom.Font = Style.CommonFont;
            comboBoxDateTo.Font = Style.CommonFont;
            comboBoxSearchType.Font = Style.CommonFont;

            labelTitle.Font = Style.CommonTitleFont;
            labelDateInput.Font = Style.CommonFont;
            labelSearchType.Font = Style.CommonFont;
            #endregion            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

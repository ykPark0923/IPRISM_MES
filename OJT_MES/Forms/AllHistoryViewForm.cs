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
using LotteMES.FormData;
using LotteMES.Constants;
using LotteMES.Enumerators;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LotteMES.Forms
{
    public partial class AllHistoryViewForm : MESFormBase
    {
        EnumInfo m_data = new EnumInfo();

        public AllHistoryViewForm()
        {
            InitializeComponent();

            //테두리
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void AllHistoryViewForm_Load(object sender, EventArgs e)
        {
            SetStyles();
            UpdateComboBoxFromEnum();
        }

        /// <summary>
        /// Enum list 업데이트
        /// </summary>
        private void UpdateComboBoxFromEnum()
        {
            foreach (HistorySearchItem item in Enum.GetValues(typeof(HistorySearchItem)))
            {
                comboBoxSearchType.Items.Add(new EnumInfo
                {
                    Text = EnumHelper.GetDescription(item),
                    Value = item
                });
            }

            comboBoxSearchType.DisplayMember = "Text";
            comboBoxSearchType.ValueMember = "Value";
        }


        protected override void SetStyles()
        {
            #region BackColor
            this.BackColor = Style.CommonBackgroundColor;
            panelSplitBar.BackColor = Style.CommonSplitBarBackgroundColor;
            dataGridViewHistory.BackColor = Style.CommonListBackgroundColor;

            buttonSearch.BackColor = Style.CommonButtonBackgroundColor;
            buttonClose.BackColor = Style.CommonButtonBackgroundColor;

            dateTimePickerDateFrom.BackColor = Style.CommonComboBoxBackgroundColor;
            dateTimePickerDateTo.BackColor = Style.CommonComboBoxBackgroundColor;
            comboBoxSearchType.BackColor = Style.CommonComboBoxBackgroundColor;

            labelTitle.BackColor = Style.CommonLabelBackgroundColor;
            labelDateInput.BackColor = Style.CommonLabelBackgroundColor;
            labelSearchType.BackColor = Style.CommonLabelBackgroundColor;
            #endregion

            #region ForeColor
            dataGridViewHistory.ForeColor = Style.CommonListForeColor;

            buttonSearch.ForeColor = Style.CommonForeColor;
            buttonClose.ForeColor = Style.CommonForeColor;

            dateTimePickerDateTo.ForeColor = Style.CommonSettingForeColor;
            comboBoxSearchType.ForeColor = Style.CommonSettingForeColor;

            labelTitle.ForeColor = Style.CommonForeColor;
            labelDateInput.ForeColor = Style.CommonForeColor;
            labelSearchType.ForeColor = Style.CommonForeColor;
            #endregion

            #region Font
            dataGridViewHistory.Font = Style.CommonListFont;

            buttonSearch.Font = Style.CommonFont;
            buttonClose.Font = Style.CommonFont;

            dateTimePickerDateFrom.Font = Style.CommonFont;
            dateTimePickerDateTo.Font = Style.CommonFont;
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            HistorySearchItem selectedEnum;

            if (comboBoxSearchType.SelectedItem is EnumInfo selectedItem)
            {
                selectedEnum = (HistorySearchItem)selectedItem.Value;
                Console.WriteLine($"선택된 항목: {selectedEnum}");
            }
            
        }
    }
}

using LotteMES.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LotteMES.FormData;
using LotteMES.Styles;
using LotteMES.Helpers;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using System.Reflection.Emit;

namespace LotteMES.Forms
{
    public partial class SettingBasicInfoForm : MESFormBase
    {
        //MainFormData m_data = new MainFormData();

        public SettingBasicInfoForm()
        {
            InitializeComponent();

            // 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;

            SetStyles();
        }
        
        /// <summary>
        /// 컨트롤로부터 데이터 객체의 값들을 업데이트
        /// </summary>
        protected override void SetObjectFromControls()
        {
            
        }

        /// <summary>
        /// 데이터 객체의 값들로부터 컨트롤을 업데이트
        /// </summary>
        protected override void UpdateControlsFromObject()
        {
            
        }

        protected override void SetStyles()
        {
            #region BackColor
            this.BackColor = Style.CommonBackgroundColor;
            labelTitle.BackColor = Style.CommonLabelBackgroundColor;
            panelSplitBar.BackColor = Style.CommonSplitBarBackgroundColor;
            labelSearchBasicCode.BackColor = Style.CommonLabelBackgroundColor;
            comboBoxSearchBasicCode.BackColor = Style.CommonComboBoxBackgroundColor;

            dataGridViewSettingBasicInfo.BackColor = Style.CommonListBackgroundColor;
            buttonDownloadProductInfo.BackColor = Style.CommonButtonBackgroundColor;
            buttonDownloadLineInfo.BackColor = Style.CommonButtonBackgroundColor;
            buttonClose.BackColor = Style.CommonButtonBackgroundColor;

            #endregion

            #region ForeColor
            labelTitle.ForeColor = Style.CommonForeColor;
            labelSearchBasicCode.ForeColor = Style.CommonForeColor;
            comboBoxSearchBasicCode.ForeColor = Style.CommonComboBoxForeColor;

            dataGridViewSettingBasicInfo.ForeColor = Style.CommonListForeColor;
            buttonDownloadProductInfo.ForeColor = Style.CommonForeColor;
            buttonDownloadLineInfo.ForeColor = Style.CommonForeColor;
            buttonClose.ForeColor = Style.CommonForeColor;

            #endregion

            #region Font
            labelTitle.Font = Style.CommonTitleFont;

            labelSearchBasicCode.Font = Style.CommonFont;
            comboBoxSearchBasicCode.Font = Style.CommonFont;
            dataGridViewSettingBasicInfo.Font = Style.CommonFont;
            buttonDownloadProductInfo.Font = Style.CommonFont;
            buttonDownloadLineInfo.Font = Style.CommonFont;
            buttonClose.Font = Style.CommonFont;
            #endregion            
        }

    }
}

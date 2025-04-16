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

namespace LotteMES.Forms
{
    public partial class MainForm : MESFormBase
    {
        MainFormData m_data = new MainFormData();

        public MainForm()
        {
            InitializeComponent();
            
            // 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 작업 표시줄을 포함한 화면 전체로 설정
            this.WindowState = FormWindowState.Maximized;

            SetStyles();
        }

        protected override void SetObjectFromControls()
        {
            m_data.ManagerName = textBoxManagerName.Text;
            m_data.PlannedQuantity = int.Parse(textBoxPlannedQuantity.Text);
        }

        protected override void SetStyles()
        {
            buttonPause.BackColor = Style.ButtonBackgroundColor;

            // 폰트 (볼드, 사이즈, 이탤릭, 밑줄)
            // 버튼 폰트, 타이틀 폰트 등등...
            // 백그라운드 컬러 ( 버튼 , 레이블, 텍스트박스, 폼)
            // 포어컬러
        }

        /// <summary>
        /// 데이터 객체의 값들로부터 컨트롤을 업데이트
        /// </summary>
        protected override void UpdateControlsFromObject()
        {
            textBoxManagerName.Text = m_data.ManagerName;
            textBoxPlannedQuantity.Text = m_data.PlannedQuantity.ToString();
        }

    }
}

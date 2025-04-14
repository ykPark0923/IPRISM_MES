using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT_MES
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            // 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
            // 작업 표시줄을 포함한 화면 전체로 설정
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

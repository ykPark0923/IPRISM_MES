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
using LotteMES.Helpers;

namespace LotteMES.Forms
{
    public partial class LoginForm : MESFormBase
    {

        public LoginForm()
        {
            InitializeComponent();

            // 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;

            SetStyles();
        }
    }
}

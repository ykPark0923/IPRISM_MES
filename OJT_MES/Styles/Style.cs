using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteMES.Styles
{
    internal class Style
    {

        private static Color buttonBackgroundColor = Color.Black;

        /// <summary>
        /// 버튼 공통 배경 컬러
        /// </summary>
        internal static Color ButtonBackgroundColor { get => buttonBackgroundColor; set => buttonBackgroundColor = value; }


        private static Color textboxBackgroundColor = Color.Black;

        /// <summary>
        /// 텍스트박스 공통 배경 컬러
        /// </summary>
        internal static Color TextboxBackgroundColor { get => textboxBackgroundColor; set => textboxBackgroundColor = value; }
    }
}

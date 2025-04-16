using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteMES.Styles
{
    public class Style
    {
        #region Common
        private static Font commonFont = new Font("돋움체", 13, FontStyle.Bold);  // 기본 폰트 설정
        /// <summary>
        /// 공통 폰트
        /// </summary>
        internal static Font CommonFont
        {
            get => commonFont;
            set => commonFont = value ?? new Font("돋움체", 13, FontStyle.Bold);  // null 방지 및 기본값 설정
        }


        private static Color commonForeColorWhite = Color.White;  // 기본 폰트색상 설정
        /// <summary>
        /// 공통 폰트컬러 화이트
        /// </summary>
        internal static Color CommonForeColorWhite
        {
            get => commonForeColorWhite;
            set => commonForeColorWhite = value;
        }

        private static Color commonForeColorCyan = Color.Cyan;
        /// <summary>
        /// 공통 폰트컬러 블루
        /// </summary>
        internal static Color CommonForeColorCyan
        {
            get => commonForeColorCyan;
            set => commonForeColorCyan = value;
        }

        private static Color commonForeColorRed = Color.Red;
        /// <summary>
        /// 공통 폰트컬러 레드
        /// </summary>
        internal static Color CommonForeColorRed
        {
            get => commonForeColorRed;
            set => commonForeColorRed = value;
        }


        private static Color commonBackgroundColorBlack = Color.Black;
        /// <summary>
        /// 공통 배경컬러 블랙
        /// </summary>
        internal static Color CommonBackgroundColorBlack
        {
            get => commonBackgroundColorBlack;
            set => commonBackgroundColorBlack = value;
        }

        private static Color commonBackgroundColorWhite = Color.White;
        /// <summary>
        /// 공통 배경컬러 화이트
        /// </summary>
        internal static Color CommonBackgroundColorWhite
        {
            get => commonBackgroundColorWhite;
            set => commonBackgroundColorWhite = value;
        }

        private static Color commonBackgroundColorTransparent = Color.Transparent;
        /// <summary>
        /// 공통 배경컬러 투명
        /// </summary>
        internal static Color CommonBackgroundColorTransparent
        {
            get => commonBackgroundColorTransparent;
            set => commonBackgroundColorTransparent = value;
        }
        #endregion


        #region Button
        private static Color buttonBackgroundColorMint = Color.MintCream;
        /// <summary>
        /// 버튼 배경컬러 민트
        /// </summary>
        internal static Color ButtonBackgroundColorMint
        {
            get => buttonBackgroundColorMint;
            set => buttonBackgroundColorMint = value;
        }
        #endregion


        #region TextBox
        private static Color textBoxBackgroundColorLightGray = Color.LightGray;
        /// <summary>
        /// 텍스트박스 배경컬러 연그레이
        /// </summary>
        internal static Color TextBoxBackgroundColorLightGray
        {
            get => textBoxBackgroundColorLightGray;
            set => textBoxBackgroundColorLightGray = value;
        }

        private static Color textBoxBackgroundColorDarkGray = Color.DarkGray;
        /// <summary>
        /// 텍스트박스 배경컬러 다크그레이
        /// </summary>
        internal static Color TextBoxBackgroundColorDarkGray
        {
            get => textBoxBackgroundColorDarkGray;
            set => textBoxBackgroundColorDarkGray = value;
        }

        private static Color textBoxBackgroundColorGray = Color.Gray;
        /// <summary>
        /// 텍스트박스 배경컬러 그레이
        /// </summary>
        internal static Color TextBoxBackgroundColorGray
        {
            get => textBoxBackgroundColorGray;
            set => textBoxBackgroundColorGray = value;
        }

        private static Color textBoxBackgroundColorLightYellow = Color.LightYellow;
        /// <summary>
        /// 텍스트박스 배경컬러 연옐로우
        /// </summary>
        internal static Color TextBoxBackgroundColorLightYellow
        {
            get => textBoxBackgroundColorLightYellow;
            set => textBoxBackgroundColorLightYellow = value;
        }

        private static Color textBoxBackgroundColorYellow = Color.Yellow;
        /// <summary>
        /// 텍스트박스 배경컬러 옐로우
        /// </summary>
        internal static Color TextBoxBackgroundColorYellow
        {
            get => textBoxBackgroundColorYellow;
            set => textBoxBackgroundColorYellow = value;
        }
        #endregion


        #region MainForm
        private static Color mainFormPictureBoxColorRed = Color.Red;
        /// <summary>
        /// 메인폼 pcitureBox 배경컬러 레드
        /// </summary>
        internal static Color MainFormPictureBoxColorRed
        {
            get => mainFormPictureBoxColorRed;
            set => mainFormPictureBoxColorRed = value;
        }

        private static Color mainFormCommunicationColorGreen = Color.DarkOliveGreen;
        /// <summary>
        /// 메인폼 pcitureBox 배경컬러 그린
        /// </summary>
        internal static Color MainFormCommunicationColorGreen
        {
            get => mainFormCommunicationColorGreen;
            set => mainFormCommunicationColorGreen = value;
        }

        private static Color mainFormCommunicationColorRed = Color.Red;
        /// <summary>
        /// 메인폼 pcitureBox 배경컬러 레드
        /// </summary>
        internal static Color MainFormCommunicationColorRed
        {
            get => mainFormCommunicationColorRed;
            set => mainFormCommunicationColorRed = value;
        }
        private static Font mainFormDatetimeFontSize = new Font("돋움체", 15, FontStyle.Bold);  // 기본 폰트에 크기설정
        /// <summary>
        /// 메인폼 현재시각 폰트크기 설정
        /// </summary>
        internal static Font MainFormDatetimeFontSize
        {
            get => mainFormDatetimeFontSize;
            set => mainFormDatetimeFontSize = value ?? new Font("돋움체", 15, FontStyle.Bold);  // null 방지 및 기본값 설정
        }

        private static Font mainFormLabel2FontSize = new Font("돋움체", 15, FontStyle.Bold);  // 기본 폰트에 크기설정
        /// <summary>
        /// 메인폼 라벨2 폰트크기 설정
        /// </summary>
        internal static Font MainFormLabel2FontSize
        {
            get => mainFormLabel2FontSize;
            set => mainFormLabel2FontSize = value ?? new Font("돋움체", 30, FontStyle.Bold);  // null 방지 및 기본값 설정
        }

        private static Font mainFormLabel3FontSize = new Font("맑은고딕", 30, FontStyle.Bold);  // 기본 폰트에 크기설정
        /// <summary>
        /// 메인폼 라벨2 폰트크기 설정
        /// </summary>
        internal static Font MainFormLabel3FontSize
        {
            get => mainFormLabel3FontSize;
            set => mainFormLabel3FontSize = value ?? new Font("맑은고딕", 30, FontStyle.Bold);  // null 방지 및 기본값 설정
        }
        #endregion

    }
}

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
        private static Font commonFont = new Font("돋움체", 13 );  // 기본 폰트 설정
        /// <summary>
        /// 공통 폰트
        /// </summary>
        internal static Font CommonFont
        {
            get => commonFont;
            set => commonFont = value ?? new Font("돋움체", 13);  // null 방지 및 기본값 설정
        }

        private static Font commonTitleFont = new Font("돋움체", 35, FontStyle.Bold);  // 기본 폰트 설정
        /// <summary>
        /// 공통 title 폰트
        /// </summary>
        internal static Font CommonTitleFont
        {
            get => commonTitleFont;
            set => commonTitleFont = value ?? new Font("돋움체", 35, FontStyle.Bold);  // null 방지 및 기본값 설정
        }

        private static Color commonForeColor = Color.White;  // 기본 폰트색상 설정
        /// <summary>
        /// 공통 폰트컬러 화이트
        /// </summary>
        internal static Color CommonForeColor
        {
            get => commonForeColor;
            set => commonForeColor = value;
        }

        private static Color commonComboBoxForeColor = Color.Black;
        /// <summary>
        /// 공통 콤보박스 폰트컬러 블랙
        /// </summary>
        internal static Color CommonComboBoxForeColor
        {
            get => commonComboBoxForeColor;
            set => commonComboBoxForeColor = value;
        }

        private static Color commonListForeColor = Color.Black;
        /// <summary>
        /// 공통 리스트 폰트컬러 블랙
        /// </summary>
        internal static Color CommonListForeColor
        {
            get => commonListForeColor;
            set => commonListForeColor = value;
        }

        private static Color commonComboBoxBackgroundColor = Color.LightGray;
        /// <summary>
        /// 공통 콤보박스 배경컬러 그레이
        /// </summary>
        internal static Color CommonComboBoxBackgroundColor
        {
            get => commonComboBoxBackgroundColor;
            set => commonComboBoxBackgroundColor = value;
        }

        private static Color commonSplitBarBackgroundColor = Color.White;
        /// <summary>
        /// 공통 스플릿바 컬러 White
        /// </summary>
        internal static Color CommonSplitBarBackgroundColor
        {
            get => commonSplitBarBackgroundColor;
            set => commonSplitBarBackgroundColor = value;
        }

        private static Color commonListBackgroundColor = Color.White;
        /// <summary>
        /// 공통 리스트배경컬러 화이트
        /// </summary>
        internal static Color CommonListBackgroundColor
        {
            get => commonListBackgroundColor;
            set => commonListBackgroundColor = value;
        }

        private static Color commonListSelectedBackgroundColor = Color.Cyan;
        /// <summary>
        /// 공통 선택된 리스트 배경컬러 Cyan
        /// </summary>
        internal static Color CommonListSelectedBackgroundColor
        {
            get => commonListSelectedBackgroundColor;
            set => commonListSelectedBackgroundColor = value;
        }

        private static Color commonBackgroundColor = Color.Black;
        /// <summary>
        /// 공통 배경컬러 블랙
        /// </summary>
        internal static Color CommonBackgroundColor
        {
            get => commonBackgroundColor;
            set => commonBackgroundColor = value;
        }

        private static Color commonSettingBackgroundColor = Color.White;
        /// <summary>
        /// 공통 셋팅화면 배경컬러 
        /// </summary>
        internal static Color CommonSettingBackgroundColor
        {
            get => commonSettingBackgroundColor;
            set => commonSettingBackgroundColor = value;
        }

        private static Color commonLabelBackgroundColor = Color.Transparent;
        /// <summary>
        /// 공통 라벨 배경컬러 투명
        /// </summary>
        internal static Color CommonLabelBackgroundColor
        {
            get => commonLabelBackgroundColor;
            set => commonLabelBackgroundColor = value;
        }

        private static Color commonButtonBackgroundColor = Color.Turquoise;
        /// <summary>
        /// 공통 버튼 배경컬러 민트
        /// </summary>
        internal static Color CommonButtonBackgroundColor
        {
            get => commonButtonBackgroundColor;
            set => commonButtonBackgroundColor = value;
        }
        #endregion


        #region TextBox
        private static Color textBoxBackgroundColorLight = Color.LightGray;
        /// <summary>
        /// 텍스트박스 배경컬러 연그레이
        /// </summary>
        internal static Color TextBoxBackgroundColorLight
        {
            get => textBoxBackgroundColorLight;
            set => textBoxBackgroundColorLight = value;
        }

        private static Color textBoxBackgroundColorReadOnly = Color.DarkGray;
        /// <summary>
        /// 텍스트박스 배경컬러 다크그레이 수정불가
        /// </summary>
        internal static Color TextBoxBackgroundColorReadOnly
        {
            get => textBoxBackgroundColorReadOnly;
            set => textBoxBackgroundColorReadOnly = value;
        }

        private static Color textBoxBackgroundColor = Color.Gray;
        /// <summary>
        /// 텍스트박스 배경컬러 그레이 기본
        /// </summary>
        internal static Color TextBoxBackgroundColor
        {
            get => textBoxBackgroundColor;
            set => textBoxBackgroundColor = value;
        }

        private static Color textBoxBackgroundColorEditable = Color.Khaki;
        /// <summary>
        /// 텍스트박스 배경컬러 옐로우 수정가능
        /// </summary>
        internal static Color TextBoxBackgroundColorEditable
        {
            get => textBoxBackgroundColorEditable;
            set => textBoxBackgroundColorEditable = value;
        }
        #endregion


        #region MainForm
        private static Color mainFormForeColorData = Color.Cyan;
        /// <summary>
        /// 메인폼 폰트컬러 블루
        /// </summary>
        internal static Color MainFormForeColorData
        {
            get => mainFormForeColorData;
            set => mainFormForeColorData = value;
        }

        private static Color mainFormButtonBackgroundColor = Color.Black;
        /// <summary>
        /// 메인폼 버튼 배경컬러 블랙
        /// </summary>
        internal static Color MainFormButtonBackgroundColor
        {
            get => mainFormButtonBackgroundColor;
            set => mainFormButtonBackgroundColor = value;
        }


        private static Color mainFormCommStatusColorError = Color.Red;
        /// <summary>
        /// 메인폼 Communication필드 컬러 에러 - 레드
        /// </summary>
        internal static Color MainFormCommStatusColorError
        {
            get => mainFormCommStatusColorError;
            set => mainFormCommStatusColorError = value;
        }


        private static Color mainFormCommStatusColorGood = Color.DarkOliveGreen;
        /// <summary>
        /// 메인폼 Communication필드 컬러 정상 - 그린
        /// </summary>
        internal static Color MainFormCommStatusColorGood
        {
            get => mainFormCommStatusColorGood;
            set => mainFormCommStatusColorGood = value;
        }

        private static Color mainFormLabel2ForeColor = Color.Red;
        /// <summary>
        /// 메인폼 라벨2 글씨컬러
        /// </summary>
        internal static Color MainFormLabel2ForeColor
        {
            get => mainFormLabel2ForeColor;
            set => mainFormLabel2ForeColor = value;
        }

        private static Color mainFormLabel3ForeColor = Color.Cyan;
        /// <summary>
        /// 메인폼 라벨3 글씨컬러
        /// </summary>
        internal static Color MainFormLabel3ForeColor
        {
            get => mainFormLabel3ForeColor;
            set => mainFormLabel3ForeColor = value;
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

        private static Font mainFormLabel2FontSize = new Font("돋움체", 30, FontStyle.Bold);  // 기본 폰트에 크기설정
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
        /// 메인폼 라벨3 폰트크기 설정
        /// </summary>
        internal static Font MainFormLabel3FontSize
        {
            get => mainFormLabel3FontSize;
            set => mainFormLabel3FontSize = value ?? new Font("맑은고딕", 30, FontStyle.Bold);  // null 방지 및 기본값 설정
        }
        #endregion

    }
}

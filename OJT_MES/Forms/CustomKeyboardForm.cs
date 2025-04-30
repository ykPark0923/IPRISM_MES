using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteMES.Forms
{
    public partial class CustomKeyboardForm : Form
    {
        private TextBox inputTextBox;
        private bool isKorean = true; // 한/영 상태
        private bool isShift = false;
        private Point defaultPosition = new Point(300, 300);

        public string InputText => inputTextBox.Text;

        public CustomKeyboardForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = defaultPosition;
            this.TopMost = true;
            InitializeKeyboardLayout();
        }

        private void InitializeKeyboardLayout()
        {
            this.Text = "키패드";
            this.Width = 900;
            this.Height = 450;
            this.Controls.Clear();

            inputTextBox = new TextBox
            {
                Width = 860,
                Top = 10,
                Left = 10,
                Font = new Font("맑은 고딕", 14),
                ReadOnly = true
            };
            this.Controls.Add(inputTextBox);

            int topOffset = 50;
            int leftOffset = 10;
            int keyWidth = 60;
            int keyHeight = 50;
            int spacing = 5;

            string[] numberRow = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            AddKeyRow(numberRow, topOffset, leftOffset, keyWidth, keyHeight, spacing);

            string[] row1 = isKorean ? new[] { "ㅂ", "ㅈ", "ㄷ", "ㄱ", "ㅅ", "ㅛ", "ㅕ", "ㅑ", "ㅐ", "ㅔ" }
                                     : new[] { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P" };
            string[] row2 = isKorean ? new[] { "ㅁ", "ㄴ", "ㅇ", "ㄹ", "ㅎ", "ㅗ", "ㅓ", "ㅏ", "ㅣ" }
                                     : new[] { "A", "S", "D", "F", "G", "H", "J", "K", "L" };
            string[] row3 = isKorean ? new[] { "ㅋ", "ㅌ", "ㅊ", "ㅍ", "ㅠ", "ㅜ", "ㅡ" }
                                     : new[] { "Z", "X", "C", "V", "B", "N", "M" };

            AddKeyRow(row1, topOffset + (keyHeight + spacing), leftOffset, keyWidth, keyHeight, spacing);
            AddKeyRow(row2, topOffset + 2 * (keyHeight + spacing), leftOffset + 30, keyWidth, keyHeight, spacing);
            AddKeyRow(row3, topOffset + 3 * (keyHeight + spacing), leftOffset + 60, keyWidth, keyHeight, spacing);

            string[] specialKeys = { "한/영", "Shift", ".", ",", "←", "스페이스", "입력" };
            AddSpecialKeys(specialKeys, topOffset + 4 * (keyHeight + spacing), leftOffset, keyWidth, keyHeight, spacing);
        }

        private void AddKeyRow(string[] keys, int top, int left, int width, int height, int spacing)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                string keyText = keys[i];
                if (!isKorean && isShift) keyText = keyText.ToUpper();
                else if (!isKorean) keyText = keyText.ToLower();

                Button btn = new Button
                {
                    Text = keyText,
                    Width = width,
                    Height = height,
                    Top = top,
                    Left = left + i * (width + spacing)
                };
                btn.Click += (s, e) => inputTextBox.Text += btn.Text;
                this.Controls.Add(btn);
            }
        }

        private void AddSpecialKeys(string[] keys, int top, int left, int width, int height, int spacing)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Button btn = new Button
                {
                    Text = keys[i],
                    Width = width,
                    Height = height,
                    Top = top,
                    Left = left + i * (width + spacing)
                };

                switch (keys[i])
                {
                    case "한/영":
                        btn.Click += (s, e) =>
                        {
                            isKorean = !isKorean;
                            InitializeKeyboardLayout();
                        };
                        break;
                    case "Shift":
                        btn.Click += (s, e) =>
                        {
                            isShift = !isShift;
                            InitializeKeyboardLayout();
                        };
                        break;
                    case "←":
                        btn.Click += (s, e) =>
                        {
                            if (inputTextBox.Text.Length > 0)
                                inputTextBox.Text = inputTextBox.Text.Substring(0, inputTextBox.Text.Length - 1);
                        };
                        break;
                    case "스페이스":
                        btn.Click += (s, e) => inputTextBox.Text += " ";
                        break;
                    case "입력":
                        btn.Click += (s, e) => this.DialogResult = DialogResult.OK;
                        break;
                    default:
                        btn.Click += (s, e) => inputTextBox.Text += btn.Text;
                        break;
                }

                this.Controls.Add(btn);
            }
        }
    }
}

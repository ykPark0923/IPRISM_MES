using LotteMES.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteMES.Keyboard
{
    public static class KeyboardBinder
    {        public static void BindTextBoxes(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.DoubleClick += ShowKeypad;
                }

                // 재귀적으로 내부 컨트롤까지 검사
                if (control.HasChildren)
                    BindTextBoxes(control);
            }
        }

        private static void ShowKeypad(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                using (var keypad = new CustomKeyboardForm())
                {
                    if (keypad.ShowDialog() == DialogResult.OK)
                    {
                        tb.Text = keypad.InputText;
                    }
                }
            }
        }
    }
}

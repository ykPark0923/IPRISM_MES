using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteMES.Bases
{
    public class MESFormBase : Form
    {
        virtual protected void SetStyles() { }
        virtual protected void UpdateControlsFromObject() { }
        virtual protected void SetObjectFromControls() { }

    }
}

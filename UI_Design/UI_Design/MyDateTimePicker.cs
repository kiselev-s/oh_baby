using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    class MyDateTimePicker : DateTimePicker
    {
        const int WM_ERASEBKGND = 0x14;
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == WM_ERASEBKGND)
            {
                using (var g = Graphics.FromHdc(m.WParam))
                {
                    using (var b = new SolidBrush(ColorTranslator.FromHtml("#3ae6ca")))
                    {
                        g.FillRectangle(b, ClientRectangle);
                    }
                }
                return;
            }

            base.WndProc(ref m);
        }
    }
}

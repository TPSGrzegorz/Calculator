using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWFA
{
    class NewButton : Button
    {
        public NewButton()
        {
            SetStyle(ControlStyles.Selectable, false);
        }
         
    }
}

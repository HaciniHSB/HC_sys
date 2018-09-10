using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HC_Sender
{
    public static class Commons
    {
        public static IEnumerable<Control> GetAllComponents(Control Aontrol, Type AType)
        {
            var controls = Aontrol.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllComponents(ctrl, AType))
            .Concat(controls)
            .Where(c => c.GetType() == AType);
        }
    }
}

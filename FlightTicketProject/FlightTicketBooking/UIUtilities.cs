using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace FlightTicketBooking
{
    public static class UIUtilities
    {
        public static void FillListControl(ListControl control, string displayMember, string valueMember, DataTable dt, bool insertBlank = false, string defaultText = "")
        {
            if (insertBlank)
            {
                DataRow row = dt.NewRow();
                row[valueMember] = DBNull.Value;
                row[displayMember] = defaultText;
                dt.Rows.InsertAt(row, 0);
            }

            control.DisplayMember = displayMember;
            control.ValueMember = valueMember;
            control.DataSource = dt;
        }

        public static void ClearControls(Control.ControlCollection controls)
        {
            foreach (Control ctl in controls)
            {
                switch (ctl)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                    case CheckBox chk:
                        chk.Checked = false;
                        break;
                    case GroupBox gB:
                        ClearControls(gB.Controls);
                        break;
                    case ComboBox cmb:
                        cmb.SelectedIndex = 0;
                        break;
                    case RichTextBox rTxt:
                        rTxt.Clear();
                        break;
                    case DateTimePicker dtp:
                        dtp.Value = DateTime.Now;
                        break;
                }
            }
        }
    }
}

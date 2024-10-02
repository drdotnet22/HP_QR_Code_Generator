using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_QR_Code_Generator
{
    internal class Utilities
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is Button)
                {
                    if (control.Text == "Go to output folder")
                    {
                        Button button = (Button)control;
                        button.Dispose();
                    }
                    else if (control.Text == "Clear form")
                    {
                        Button button = (Button)control;
                        button.Dispose();
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace StudentAttandance.functions
{
    static public class ValidationsClass
    {
        static public bool ValidateTextBox(System.Windows.Forms.Panel f)
        {
            string errorStr = "";
            bool isValid = true;
            foreach (System.Windows.Forms.Control control in f.Controls)
            {

                if (control.Tag == null) continue;
                if (control.GetType() == typeof(System.Windows.Forms.TextBox) && control.Tag.ToString().Contains("isrequired"))
                {
                    System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)control;
                    if (textBox.Text.Trim() == "")
                    {
                        isValid = false;
                        errorStr += ("\nhe text box " + control.Name + " is required.");
                    }
                }
                else if (control.GetType() == typeof(DatePicker) && control.Tag.ToString().Contains("isrequired"))
                {
                    DateTimePicker datePicker = (DateTimePicker)control;
                    if (datePicker.Value == null)
                    {
                        isValid = false;
                        errorStr += ("\nThe date picker " + control.Name + " is required.");
                    }
                }
                else if (control.GetType() == typeof(System.Windows.Forms.ComboBox) && control.Tag.ToString().Contains("isrequired"))
                {
                    System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)control;
                    if (comboBox.Text.Trim() == "")
                    {
                        isValid = false;
                        errorStr += ("\nThe combo box " + control.Name + " is required.");
                    }
                }
            }
            if (!isValid)
            {
                MessageBox.Show(errorStr);
            }
            return isValid;
        }

        static public void ClearInputs(System.Windows.Forms.Panel panel)
        {
            foreach (System.Windows.Forms.Control control in panel.Controls)
            {
                if (control.Tag != null && control.Tag.ToString().Contains("noclear")) continue;
                else if (control.GetType() == typeof(System.Windows.Forms.TextBox))
                {
                    control.Text = String.Empty;
                }
                else if (control.GetType() == typeof(System.Windows.Forms.ComboBox))
                {
                    System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)control;
                    comboBox.Text = String.Empty;
                    comboBox.SelectedIndex = -1;
                }
            }
        }
    }
}

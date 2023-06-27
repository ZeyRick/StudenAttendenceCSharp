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
            bool isValid = true;
            foreach (System.Windows.Forms.Control control in f.Controls)
            {
                Debug.WriteLine(f);
                if (control.Tag == null) continue;
                else if (control.GetType() == typeof(System.Windows.Forms.TextBox) && control.Tag.ToString().Contains("isrequired"))
                {
                    System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)control;
                    if (textBox.Text.Trim() == "")
                    {
                        isValid = false;
                        MessageBox.Show("The text box " + control.Name + " is required.");
                    }
                }
                else if (control.GetType() == typeof(DatePicker) && control.Tag.ToString().Contains("isrequired"))
                {
                    DateTimePicker datePicker = (DateTimePicker)control;
                    if (datePicker.Value == null)
                    {
                        isValid = false;
                        MessageBox.Show("The date picker " + control.Name + " is required.");
                    }
                }
                else if (control.GetType() == typeof(System.Windows.Forms.ComboBox) && control.Tag.ToString().Contains("isrequired"))
                {
                    System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)control;
                    if (comboBox.SelectedIndex < 0)
                    {
                        isValid = false;
                        MessageBox.Show("The combo box " + control.Name + " is required.");
                    }
                }
            }
            return isValid;
        }
    }
}

using System;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Helper
{
    public static class FormsHelper
    {
        // Classe feita para evitar a repetição de código nos controles dos forms

        public static void MudarForm(Form FormAtual, Form FormDesejado)
        {
            FormAtual.Hide();
            FormDesejado.ShowDialog();
            FormAtual.Close();
        }

        public static void LimparControlsForms(ControlCollection Controls)
        {
            Action<ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is NumericUpDown)
                    {
                        (control as NumericUpDown).Value = 0;
                    }
                    if (control is ComboBox)
                    {
                        (control as ComboBox).SelectedIndex = 0;
                    }
                    if (control is DateTimePicker)
                    {
                        (control as DateTimePicker).Value = DateTime.Now;
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(Controls);
        }
    }
}

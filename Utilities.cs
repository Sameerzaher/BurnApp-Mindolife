using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Utilities
    {
        public Utilities()
        {

        }
        public void ResetAllControls(Control panel)
        {
            //loop of controls 
            foreach (Control control in panel.Controls)
            {
                //clear TextBox or maskedtextbox or NumicUpDown            
                if (control is TextBox || control is MaskedTextBox)
                {
                    control.Text = null;
                }
                //clear ComboBox
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.Text = "";

                }
                //return numeric to 0
                if (control is NumericUpDown)
                {
                    NumericUpDown numeric = (NumericUpDown)control;
                    numeric.Value = 0;
                }
                //return date time to now
                if (control is DateTimePicker)
                {
                    DateTimePicker datetime = (DateTimePicker)control;
                    datetime.Value = DateTime.Now;
                }
            }
        }
        public void FillComboBoxPackage(Package [] PackageArray,ComboBox cmb)
        {
            /*Complete Mode To ComboBox By write */
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            for (int i = 0; i < PackageArray.Length; i++)
            {
                cmb.Items.Add(PackageArray[i].Id);
                auto.Add(PackageArray[i].Id.ToString());
            }
            cmb.AutoCompleteCustomSource = auto;//Complete mode
        }
        public void FillComboBoxFirmware(firmware[] firmwareArray, ComboBox cmb)
        {
            /*Complete Mode To ComboBox By write */
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            for (int i = 0; i < firmwareArray.Length; i++)
            {
                cmb.Items.Add(firmwareArray[i].Id);
                auto.Add(firmwareArray[i].Id.ToString());
            }
            cmb.AutoCompleteCustomSource = auto;//Complete mode
        }
        public void ClearComboBox(Panel pnl)
        {
            foreach (Control ctrl in pnl.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)(Object)ctrl;
                    cmb.Items.Clear();
                }
            }
        }
    }
}

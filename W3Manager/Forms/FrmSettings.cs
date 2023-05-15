namespace EmployeeManagementSystem.Forms
{
    using System;
    using System.Windows.Forms;
    
    using EmployeeManagementSystem.Common.Enumerations;
    

    /// <summary>
    /// Represents a settings form
    /// </summary>
    /// <seealso cref="FrmMain"/>
    public partial class FrmSettings : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmSettings"/> class
        /// </summary>
        public FrmSettings()
        {
            this.InitializeComponent();
          
            this.SetRadioButtonChecked();
        }  

        /// <summary>
        /// Cancel button to close the form
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void BtnCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Save button to apply changes to the AppSettings and close the form
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void BtnSaveClick(object sender, EventArgs e)
        {
            var phonePatternPair = this.GetPhoneFormat();
            Properties.Settings.Default["PhonePattern"] = phonePatternPair.Item1;
            Properties.Settings.Default["PhonePatternLabel"] = phonePatternPair.Item2;
           
            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Determines which radio button is checked and returns the matching regular expression pattern
        /// </summary>
        /// <returns>Regular expression pattern mapped to checked radio button</returns>
        private Tuple<string, string> GetPhoneFormat()
        {
            if (this.RdoBtn_Dots.Checked)
            {
                return new Tuple<string, string>(PhoneRegexFormats.DotFormat, this.RdoBtn_Dots.Text);
            }

            if (this.RdoBtn_Dashes.Checked)
            {
                return new Tuple<string, string>(PhoneRegexFormats.DashFormat, this.RdoBtn_Dashes.Text);
            }

            if (this.RdoBtn_Standard.Checked)
            {
                return new Tuple<string, string>(PhoneRegexFormats.StandardFormat, this.RdoBtn_Standard.Text);
            }

            return new Tuple<string, string>(PhoneRegexFormats.InternationalFormat, this.RdoBtn_Intl.Text);
        }

       
        /// <summary>
        /// Grabs the current PhonePatternLabel (tied to the pattern) and sets the proper RadioButton
        /// </summary>
        private void SetRadioButtonChecked()
        {
            string patternLabel = Properties.Settings.Default.PhonePatternLabel;

            switch (patternLabel)
            {
                case PhoneDisplayFormats.Dashed:
                    this.RdoBtn_Dashes.Checked = true;
                    break;
                case PhoneDisplayFormats.Standard:
                    this.RdoBtn_Standard.Checked = true;
                    return;
                case PhoneDisplayFormats.International:
                    this.RdoBtn_Intl.Checked = true;
                    return;
                default:
                    return;
            }
        }
    }
}

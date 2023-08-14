using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace HRIS.UserCustomControl
{
    public class CustomDateTimePicker : DateTimePicker
    {
        private TextBox hintTextBox;

        public CustomDateTimePicker()
        {
            InitializeHintTextBox();

            this.Enter += CustomDateTimePicker_Enter;
            this.Leave += CustomDateTimePicker_Leave;
            this.ValueChanged += CustomDateTimePicker_ValueChanged;
            this.KeyDown += CustomDateTimePicker_KeyDown;
        }

        private void InitializeHintTextBox()
        {
            hintTextBox = new TextBox();
            hintTextBox.ForeColor = SystemColors.WindowText;
            hintTextBox.BorderStyle = BorderStyle.None;
            hintTextBox.Location = new Point(4, 4); // Adjust as needed
            hintTextBox.ReadOnly = true;
            hintTextBox.TabStop = false;
            hintTextBox.Visible = true;
            hintTextBox.BackColor = Color.White;
            this.Controls.Add(hintTextBox);
        }

        private void CustomDateTimePicker_Enter(object sender, EventArgs e)
        {
            UpdateHintText();
        }

        private void CustomDateTimePicker_Leave(object sender, EventArgs e)
        {
            UpdateHintText();
        }

        private void CustomDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateHintText();
        }

        private void CustomDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                this.Value = DateTimePicker.MinimumDateTime;
                UpdateHintText();
                this.Focus();
            }
        }

        private void UpdateHintText()
        {
            if (this.Value != DateTimePicker.MinimumDateTime)
            {
                hintTextBox.Text = this.Value.ToString("yyyy-MM-dd");
                hintTextBox.ForeColor = SystemColors.WindowText;
            }
            else
            {
                hintTextBox.Text = "Select a date...";
                hintTextBox.ForeColor = SystemColors.GrayText;
            }
        }
    }
}





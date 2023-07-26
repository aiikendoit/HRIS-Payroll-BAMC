using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Class
{
    public struct UniversalStatic
    {
        public static void formresize(Form form)
        {
            form.Height = form.Height - 100;
        }
        public static void customDatagrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White; 
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.Gainsboro;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            // Apply custom column settings
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].FillWeight = 1;
            }
            //row 
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            //'column header 
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersHeight = 35;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(150, 175, 184);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(150, 175, 184);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
           
            //column header font
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);

            //'row back color
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            //'selection backcolor
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 228, 231);
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 228, 231);
            //'forecolor
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            //'selection forecolor
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
            //'row template
            dgv.RowTemplate.DividerHeight = 0;
            dgv.RowTemplate.Height = 35;
        }
        public static bool IsEmpty(TextBox textBox)
        {
            bool isEmpty = false;

            if (textBox != null)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.BackColor = Color.PeachPuff;
                    MessageBox.Show("Field cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isEmpty = true;
                }
            }

            return isEmpty;
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            // Regular expression pattern for email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Use Regex.IsMatch to check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }
    }
}

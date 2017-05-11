using MetroFramework.Controls;
using System.Globalization;
using System.Windows.Forms;

namespace TotalAtendimento
{
    public partial class Int32TextBox : MetroTextBox
    {
        public Int32TextBox()
        {
            InitializeComponent();
        }

        private void Int32TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberFormatInfo fi = CultureInfo.CurrentCulture.NumberFormat;

            if (e.KeyChar == '\b')
               return;

            if (this.Text.Length >= 5)
            {
                e.Handled = true;
                return;
            }

            string c = e.KeyChar.ToString();
            if (char.IsDigit(c, 0))
                return;

            // copy/paste
            if ((((int)e.KeyChar == 22) || ((int)e.KeyChar == 3))
                && ((ModifierKeys & Keys.Control) == Keys.Control))
            {
                string text = Clipboard.GetText();
                int i;

                if (!string.IsNullOrEmpty(text) &&
                    !((text.IndexOf('+') >= 0) && (SelectionStart != 0)) &&
                    int.TryParse(text, out i))
                {
                    if (!((i < 0) && (SelectionStart != 0)))
                        return;
                }
            }
            e.Handled = true;
        }

        private void Int32TextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (this.Text == "")
                this.Text = "0";
        }
    }
}

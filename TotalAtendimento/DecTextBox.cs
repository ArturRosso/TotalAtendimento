using System;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Globalization;

namespace TotalAtendimento
{
    public partial class DecTextBox : MetroTextBox
    {
        public DecTextBox()
        {
            InitializeComponent();
        }

        private void DecTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberFormatInfo fi = CultureInfo.CurrentCulture.NumberFormat;

            if (e.KeyChar == '\b')
                return;

            if (this.Text.Length >= 11)
            {
                e.Handled = true;
                return;
            }

            string c = e.KeyChar.ToString();
            if (char.IsDigit(c, 0))
                return;

            if ((SelectionStart == 0) && (c.Equals(fi.NegativeSign)))
                return;

            // copy/paste
            if ((((int)e.KeyChar == 22) || ((int)e.KeyChar == 3))
                && ((ModifierKeys & Keys.Control) == Keys.Control))
            {
                string text = Clipboard.GetText();
                int i;

                if (text.Contains("."))
                    text = text.Replace(".", "");

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

        private void DecTextBox_TextChanged(object sender, EventArgs e)
        {
            string lsNovoValor = this.Text;
            decimal ldcValorFomartado = 0;
            int liPosicao = this.SelectionStart;
            int liTamanhoTexto = this.Text.Length;

            if (lsNovoValor == "")
            {
                this.Text = ",00";
                return;
            }

            if (lsNovoValor.Contains("."))
                lsNovoValor = lsNovoValor.Replace(".", "");

            if (lsNovoValor.Contains(","))
                lsNovoValor = lsNovoValor.Replace(",", "");
            else
                lsNovoValor += "00";

            if (int.Parse(lsNovoValor) == 0)
            {
                this.Text = ",00";
                return;
            }

            if (lsNovoValor.Length > 9)
                lsNovoValor = lsNovoValor.Substring(lsNovoValor.Length - 9, 9);

            if (decimal.TryParse(lsNovoValor, out ldcValorFomartado))
            {
                ldcValorFomartado /= 100;
            }
            else
            {
                return;
            }

            this.Text = string.Format("{0:N}", ldcValorFomartado);
            this.SelectionStart = this.Text.Length;

            this.SelectionStart = (liPosicao + (this.Text.Length - liTamanhoTexto));
        }

        public decimal GetValor()
        {
            string lsValor = this.Text;
            decimal ldcValor;

            if (lsValor.Contains("."))
                lsValor.Replace(".", "");

            ldcValor = decimal.Parse(lsValor);

            return ldcValor;
        }

    }
}

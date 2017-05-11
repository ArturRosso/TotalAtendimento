using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalAtendimento
{
    public partial class Teste : MetroForm
    {
        public Teste()
        {
            InitializeComponent();


            
        }

        private void Teste_Load(object sender, EventArgs e)
        {

        }

        private void Teste_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Teste_Click(object sender, EventArgs e)
        {

        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
            e.DrawText();
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            //îe.DrawDefault = true;
        }
    }
}

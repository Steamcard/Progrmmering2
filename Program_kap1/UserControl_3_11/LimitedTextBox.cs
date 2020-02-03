using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl_3_11
{
    public partial class LimitedTextBox : UserControl
    {
        public LimitedTextBox()
        {
            InitializeComponent();
        }

        private void lblTextCounter_Click(object sender, EventArgs e)
        {
            int antal = tbxData1.TextLength;
            lblTextCounter.Text = ("("+antal.ToString()+")");
        }
    }
}

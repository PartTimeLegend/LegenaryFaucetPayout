using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FaucetPayout
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPayout_Click(object sender, EventArgs e)
        {
            var ll = new LogicLayer.WebRequests();
            lblStatus.Text = ll.Payout().ToString(CultureInfo.InvariantCulture);
        }
    }
}

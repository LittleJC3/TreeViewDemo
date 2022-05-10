using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeViewUtilitiesNamespace;

namespace myTreeView
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TreeViewUtilities.Clear(tvDemo);
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            TreeViewUtilities.Init(tvDemo);
        }

        private void btnAddPlayerName_Click(object sender, EventArgs e)
        {
            TreeViewUtilities.AddName(tvDemo, tbPlayerName.Text);
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            TreeViewUtilities.AddNumber(tvDemo, tbNumber.Text);
        }
    }
}

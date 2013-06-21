using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RWFile_NET
{
    public partial class Test : Form
    {
        private string testpath;
        public Test()
        {
            InitializeComponent();
        }

        private void Load(object sender, EventArgs e)
        {
            this.chkRam.CheckState = CheckState.Checked;
            ThreadPool.QueueUserWorkItem(TestDisk);
        }

        private void chkStateChanged(object sender, EventArgs e)
        {
            if (this.chkFlash.Checked && ((CheckBox)sender).Equals(this.chkFlash))
            {
                this.chkRam.CheckState = CheckState.Unchecked;
                this.chkSD.CheckState = CheckState.Unchecked;
                testpath = "\\FlashDrv\\TestFile";
            }
            else if (this.chkRam.Checked && ((CheckBox)sender).Equals(this.chkRam))
            {
                this.chkFlash.CheckState = CheckState.Unchecked;
                this.chkSD.CheckState = CheckState.Unchecked;
                testpath = "\\FlashDrv\\TestFile";
            }
            else if (this.chkSD.Checked && ((CheckBox)sender).Equals(this.chkSD))
            {
                this.chkFlash.CheckState = CheckState.Unchecked;
                this.chkRam.CheckState = CheckState.Unchecked;
            }
        }
    }
}
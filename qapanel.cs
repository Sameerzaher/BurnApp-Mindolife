﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class qapanel : Form
    {
        public qapanel()
        {
            InitializeComponent();
        }

        private void bckbtmfrmqa_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
        }
    }
}

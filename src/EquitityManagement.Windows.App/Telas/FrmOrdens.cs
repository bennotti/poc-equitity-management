﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquitityManagement.Windows.App.Telas
{
    public partial class FrmOrdens : Form
    {
        public FrmOrdens()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //
            this.DialogResult = DialogResult.OK;
        }
    }
}

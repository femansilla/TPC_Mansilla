﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewsApp
{
    public partial class FichaClienteForm : Form
    {
        private int iD;

        public FichaClienteForm()
        {
            InitializeComponent();
        }

        public FichaClienteForm(int iD)
        {
            this.iD = iD;
        }
    }
}

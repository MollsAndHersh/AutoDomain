﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDomain
{
    public partial class Mainform : Form
    {

        /// <summary>
        /// QueryProgress from 0 to 100
        /// </summary>
        public int QueryProgress
        {
            get
            {
                return pbQuery.Value;
            }
            set
            {
                pbQuery.Value = value;
            }
        }





        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }
    }
}
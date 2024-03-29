﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace prosek.ui
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            this.Show();
            loadingLabel.Text = "Loading Process...";
            loadingLabel.Text = "Process Loaded";

            this.Opacity = 0.0f;
            this.ShowInTaskbar = false;

            App app = new App();
            app.Closed += (s, args) => this.Close();
            app.Show();
        }
    }
}

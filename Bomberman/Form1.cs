﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman {
    public partial class Bomberman : Form {

        public Bomberman() {
            InitializeComponent();
        }

        private void timerGameLoop_Tick(object sender, EventArgs e) {

        }

        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;

            base.OnPaint(e);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerMain
{
    public partial class Form1 : Form
    {
        ServerSocket ss;
        public Form1()
        {
            InitializeComponent();
            ss = new ServerSocket();
            ss.Start();
        }
    }
}

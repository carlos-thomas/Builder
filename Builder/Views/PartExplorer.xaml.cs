﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Builder
    {
    public partial class PartExplorer
        {
        public PartExplorer ()
            {
            InitializeComponent();
            }

        private void Ok_Click (object sender, RoutedEventArgs e)
            {
            DialogResult = true;
            }
        }
    }

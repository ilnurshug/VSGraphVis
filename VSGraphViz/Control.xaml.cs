﻿using System.Windows;
using System.Windows.Controls;

namespace VSGraphViz
{
    public partial class Control : UserControl
    {
        public Control()
        {
            InitializeComponent();
        }
        public void setText(string text)
        {
            tb1.Text = text;
        }
    }
}
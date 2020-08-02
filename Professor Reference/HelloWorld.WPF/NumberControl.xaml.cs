﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for NumberControl.xaml
    /// </summary>
    public partial class NumberControl : UserControl
    {
        public NumberControl()
        {
            InitializeComponent();
        }

        public int Value
        {
            get;
            private set;
        }

        private void TextBoxPasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                if (!IsValidNumber(text))
                {
                    e.CancelCommand();
                    // THIS DOESN'T WORK: e.Handled = true;
                }
            }
            else
            {
                e.CancelCommand();
                // THIS DOESN'T WORK: e.Handled = true;
            }
        }

        private void uxNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!IsValidNumber(e.Text))
            {
                e.Handled = true;
            }

            //e.Handled = !IsValidNumber(e.Text);
        }

        private bool IsValidNumber(string text)
        {
            foreach (var ch in text)
            {
                if (!char.IsDigit(ch))
                {
                    return false;
                }
            }

            int result;
            if (!int.TryParse(uxNumber.Text + text, out result))
            {
                return false;
            }

            Value = result;

            return true;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Text.RegularExpressions;
using Windows.ApplicationModel.DataTransfer;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Remove_Line_Breaks
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            string str_input = input_box.Text;
            string str_output = Regex.Replace(str_input, "\n|\r\n|\r", " ");
            output_box.Text = str_output;
        }

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            string none = "";
            input_box.Text = none;
            output_box.Text = none;
        }
        private void Clip_Button_Click(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(output_box.Text);
            Clipboard.SetContent(dataPackage);
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Input_box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

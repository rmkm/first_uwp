using System;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str_input = input_box.Text;
            string str_output = Regex.Replace(str_input, "\n|\r\n|\r", "");
            output_box.Text = str_output;
        }

        private void Clear_button_Click(object sender, RoutedEventArgs e)
        {
            string none = "";
            input_box.Text = none;
            output_box.Text = none;
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

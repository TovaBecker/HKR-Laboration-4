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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Task7_Convert
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

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            //Field for value from textbox
            double input;

            //Text shown to the user
            string text = "";

            if (double.TryParse(fahrenheitIn.Text, out input))
            {
                //Field for the result of the calculation
                double celsius = ((input - 32) * 5)/9;

                //Create result string
                text = $"{celsius}";
            }
            else
            {
                //Set error message
                text = "Error - not a valid input";
            }

            //Set resualt message
            resultText.Text = text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EightySeven.UWP
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

        private void ButtonSubmitTapped(object sender, RoutedEventArgs e)
        {
            var stationName = txtStationName.Text;
            if (!string.IsNullOrWhiteSpace(stationName))
            {
                var date = dpEntryDate.Date.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                var time = tpEntryTime.Time.ToString();
                tbSubmissionResult.Text = String.Format("Submission succeeded at {0} on {1} of {2}", stationName, time, date);
            }
            else
            {
                tbSubmissionResult.Text = String.Format("Submission failed. Cannot comprehend station name.");
            }
        }
    }
}

using CefSharp;
using CefSharp.Wpf;
using Iridium.Browser;
using System;
using System.Windows.Controls;

namespace Iridium.Pages
{
    /// <summary>
    /// Interaction logic for BrowserPage.xaml
    /// </summary>
    public partial class BrowserPage : Page
    {
        public BrowserPage()
        {
            var path = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Seven",
                "Iridium",
                "Cache"
                );

            var settings = new CefSettings
            {
                CachePath = path
            };

            Cef.Initialize(settings);

            InitializeComponent();

            Browser.LifeSpanHandler = new SampleLifeSpanHandler();
        }
    }
}

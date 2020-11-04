using CefSharp.Wpf;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

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

            CefSharp.Cef.Initialize(settings);

            InitializeComponent();
        }
    }
}

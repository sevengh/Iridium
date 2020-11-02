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
    /// Interaction logic for TitlePage.xaml
    /// </summary>
    public partial class TitlePage : Page
    {
        public TitlePage()
        {
            InitializeComponent();
            Application.Current.MainWindow.KeyDown += new KeyEventHandler(Page_KeyDown);
            Application.Current.MainWindow.MouseDown += new MouseButtonEventHandler(Page_MouseDown);
        }

        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Current.MainWindow.KeyDown -= new KeyEventHandler(Page_KeyDown);
            NavigateBrowser();
        }

        private void Page_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.MainWindow.MouseDown -= new MouseButtonEventHandler(Page_MouseDown);
            NavigateBrowser();
        }

        void NavigateBrowser()
        {
            NavigationService?.Navigate(new Uri("Pages/BrowserPage.xaml", UriKind.Relative));
        }
    }
}

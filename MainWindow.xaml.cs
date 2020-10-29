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
using AudioSwitcher.AudioApi.CoreAudio;

namespace Iridium
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly CoreAudioDevice defaultPlaybackDevice = null;

        public MainWindow()
        {
            InitializeComponent();
            defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
        }

        bool isActiveSoundKeys = true;

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F11 && WindowState != WindowState.Normal)
            {
                WindowState = WindowState.Normal;
                WindowStyle = WindowStyle.SingleBorderWindow;
            }
            else if (e.Key == Key.F11 && WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
                WindowStyle = WindowStyle.None;
            }

            if (e.Key == Key.F12)
                isActiveSoundKeys = !isActiveSoundKeys;

            else if (e.Key == Key.VolumeMute && isActiveSoundKeys)
                defaultPlaybackDevice.SetMuteAsync(!defaultPlaybackDevice.IsMuted);

            else if (e.Key == Key.VolumeUp && isActiveSoundKeys)
                defaultPlaybackDevice.SetVolumeAsync(defaultPlaybackDevice.Volume + 1);

            else if (e.Key == Key.VolumeDown && isActiveSoundKeys)
                defaultPlaybackDevice.SetVolumeAsync(defaultPlaybackDevice.Volume - 1);
        }
    }
}

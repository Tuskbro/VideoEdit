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
using System.Threading;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System.Windows.Threading;
using Microsoft.Win32;
using System.Windows.Interop;
using System.Runtime.InteropServices;
using System.IO;


namespace Preview
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static WinAPI winAPI = new WinAPI();

        Thread thread = new Thread(delegate () {
            while (true)
            {
                winAPI.DemoKiller();
            }
        });

        public MainWindow()
        {
            InitializeComponent();
        }

       
       

        private void PlayPriviewBtn_Click(object sender, RoutedEventArgs e)
        {
            
            axTimeLine.Play();

        }

        private void PausePriviewBtn_Click(object sender, RoutedEventArgs e)
        {
            axTimeLine.Pause();
            


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            IntPtr helper = new WindowInteropHelper(this).Handle;
            axTimeLine.SetPreviewWnd((int)PictureBox.Handle);
            
            thread.Start();

        }

        private void StopPriViewBtn_Click(object sender, RoutedEventArgs e)
        {
            axTimeLine.Stop();
        }

       

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            float iduration;
            int iwidth;
            int iheight;
            float framerate;
            int videobitrate;
            int iaudiobitrate;
            int iaudiochannel;
            int audiosamplerate;
            int ivideostreamcount;
            int iaudiostreamcouunt;
            string strmediacontainer;
            string strvideostreamformat;
            string straudiostreamformat;

            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*|mpg (*.mpg*.vob) | *.mpg;*.vob|avi (*.avi) | *.avi|Divx (*.divx) | *.divx|wmv (*.wmv)| *.wmv|QuickTime (*.mov)| *.mov|MP4 (*.mp4) | *.mp4|AVCHD (*.m2ts*.ts*.mts*m2t)|*.m2ts;*.ts;*.mts;*.m2t|wav (*.wav)|*.wav|MP3 (*.mp3)|*.mp3|WMA (*.wma)|*.wma||";
            if (openFileDialog.ShowDialog() == true)
            { 
                string strFile = openFileDialog.FileName;
                axTimeLine.GetMediaInfo(strFile, out iduration, out iwidth, out iheight, out framerate, out videobitrate, out iaudiobitrate, out iaudiochannel, out audiosamplerate, out ivideostreamcount,out iaudiostreamcouunt, out strmediacontainer, out strvideostreamformat, out straudiostreamformat);
                axTimeLine.SetVideoTrackResolution(iwidth, iheight);
                axTimeLine.AddVideoClip(1, strFile, 0, axTimeLine.GetMediaDuration(strFile), 0);
                axTimeLine.AddAudioClip(5, strFile, 0, axTimeLine.GetMediaDuration(strFile), 0,(float)1.0);

            }
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            ExportOptions export = new ExportOptions();
            export.TimeLine = axTimeLine;
            export.Show();
            
        }

        

      

        private void Window_Closed(object sender, EventArgs e)
        {
            thread.Abort();
        }
    }
}

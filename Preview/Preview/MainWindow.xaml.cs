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
using System.Data;

namespace Preview
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        static WinAPI winAPI = new WinAPI();
        int iwidth;
        int iheight;
        float iduration;
        
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
        Thread thread = new Thread(delegate () {
            while (true)
            {
                winAPI.DemoKiller();
            }
        });

        public MainWindow()
        {
            InitializeComponent();
            Tools.axTimeLine = axTimeLine;
            
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

        class ProdjectClip {
           public string Name { get; set; }
           public string Format { get; set; }
           public string Path { get; set; }
           public string Size { get; set; }


        }

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            

            ProdjectClip item = new ProdjectClip();

            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*|mpg (*.mpg*.vob) | *.mpg;*.vob|avi (*.avi) | *.avi|Divx (*.divx) | *.divx|wmv (*.wmv)| *.wmv|QuickTime (*.mov)| *.mov|MP4 (*.mp4) | *.mp4|AVCHD (*.m2ts*.ts*.mts*m2t)|*.m2ts;*.ts;*.mts;*.m2t|wav (*.wav)|*.wav|MP3 (*.mp3)|*.mp3|WMA (*.wma)|*.wma||";
            if (openFileDialog.ShowDialog() == true)
            { 
                string strFile = openFileDialog.FileName;
               
                FileInfo F = new FileInfo(strFile);

                item.Path = strFile;
                item.Name = openFileDialog.SafeFileName;
                item.Format = strFile.Substring(strFile.LastIndexOf("."),strFile.Length - strFile.LastIndexOf("."));
                item.Size = (F.Length/1024).ToString();
            }
            Name.Binding = new Binding("Name");
            Format.Binding = new Binding("Format");
            Size.Binding = new Binding("Size");
            Path.Binding = new Binding("Path");

            
          
            FileList.Items.Add(item);
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

        private void OpenPlayer_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player();
            player.Show();
        }

       
       

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string strFile = openFileDialog.FileName;
                axTimeLine.LoadProject(strFile);
            }
        }

        private void NewProject_Click(object sender, RoutedEventArgs e)
        {
            axTimeLine.Clear();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                string strFile = saveFileDialog.FileName;
                axTimeLine.SaveProject(strFile+".LSC");
            }
        }

        

        private void FileList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            ProdjectClip row = (ProdjectClip)FileList.Items[FileList.SelectedIndex];
            switch (row.Format) {

                case ".mp4":
                case ".mpg":
                case ".avi":
                case ".mov":
                    {
                        axTimeLine.GetMediaInfo(row.Path, out iduration, out iwidth, out iheight, out framerate, out videobitrate, out iaudiobitrate, out iaudiochannel, out audiosamplerate, out ivideostreamcount, out iaudiostreamcouunt, out strmediacontainer, out strvideostreamformat, out straudiostreamformat);
                        axTimeLine.SetVideoTrackResolution(iwidth, iheight);
                        axTimeLine.AddVideoClip(1, row.Path, 0, axTimeLine.GetMediaDuration(row.Path), 0);
                        axTimeLine.AddAudioClip(5, row.Path, 0, axTimeLine.GetMediaDuration(row.Path), 0, (float)1.0);

                        break; }
                case ".png":
                case ".jpg":
                case ".jpeg":
                    {
                        axTimeLine.AddImageClip(4,row.Path, axTimeLine.GetMediaDuration(row.Path), 2);
                        break;
                    }
                case ".WAV":
                case ".mp3":
                    {
                        
                        axTimeLine.AddAudioClip(5, row.Path, 0, axTimeLine.GetMediaDuration(row.Path), 0, (float)1.0);

                        break;
                    }
            }
           
        }

       
        private void AxTimeLine_OnClickClip(object sender, AxTimelineAxLib._ITimelineControlEvents_OnClickClipEvent e)
        {
            Tools.clipIndex = e.clipIndex;
            Tools.clipTrack = e.trackIndex;
        }


        private void Help_Click(object sender, RoutedEventArgs e)
        {
            Reference refer = new Reference();
            refer.Show();
        }
    }
}

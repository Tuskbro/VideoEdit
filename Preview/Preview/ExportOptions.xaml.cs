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
using System.Windows.Shapes;

using Microsoft.Win32;


namespace Preview
{
    /// <summary>
    /// Логика взаимодействия для ExportOptions.xaml
    /// </summary>
    public partial class ExportOptions : Window
    {
        public  AxTimelineAxLib.AxTimelineControl TimeLine { get; set; }
        
        public ExportOptions()
        {
           
            InitializeComponent();
           
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            TimeLine.OnConvertProgress += TimeLine_OnConvertProgress;
            string strFilter = "";
            int iresult = 0;
            if (Format.SelectedIndex == 0) { TimeLine.OutputType = 2; }else 
             { TimeLine.OutputType = 2; }

            TimeLine.SetVideoTrackFrameRate(float.Parse(FrameRate.Text));
            TimeLine.SetVideoTrackResolution(int.Parse(ResolutionWidth.Text), int.Parse(ResolutionHeight.Text));

            /*  if (TimeLine.OutputType == 0)
              {

                  if (chkUseVideocomp.Checked)
                      TimeLine.AVIVideoCompressor = cboavivencoder.SelectedIndex;
                  else
                      TimeLine.AVIVideoCompressor = -1;

                  if (chkUseAudiocomp.Checked)
                      TimeLine.AVIAudioCompressor = cboaviaencoder.SelectedIndex;
                  else
                      TimeLine.AVIAudioCompressor = -1;

                  strFilter = "AVI File (*.avi)|*.avi||";
              }
              else if (TimeLine.OutputType == 1)
              {
                  strFilter = "WMV File (*.wmv)|*.wmv||";
                  TimeLine.WMVProfile = cboWMVProfile.SelectedIndex;
              }
              else */
            if (TimeLine.OutputType == 2)
              {
                /*  TimeLine.MP4AspectRatio = AspectRadio.SelectedIndex;
                  TimeLine.MP4AudioBitrate = int.Parse(AudioBitrate.Text);
                  TimeLine.MP4AudioChannels = int.Parse(AudioChannel.Text);
                  TimeLine.MP4AudioSampleRate = int.Parse(SampleRate.Text);
                  TimeLine.MP4Framerate = float.Parse(FrameRate.Text);
                  TimeLine.MP4H264Preset = H264Preset.SelectedIndex;
                  TimeLine.MP4Height = int.Parse(ResolutionHeight.Text);
                  TimeLine.MP4Width = int.Parse(ResolutionWidth.Text);
                  TimeLine.MP4VideoBitrate = int.Parse(VideoBitrate.Text);
                 */ strFilter = "MP4 File (*.mp4)|*.mp4||";
        }

            System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog.Filter = strFilter;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iresult = TimeLine.Save(saveFileDialog.FileName);


                //ListBox1.Items.Clear();
                //get current graph filters and add to listbox
               // for (int i = 0; i < TimeLine.DecoderGetCurrentFiltersCount() - 1; i++)
              //  {
               //     ListBox1.Items.Add(TimeLine.DecoderGetCurrentFilterName(i));
               // }

                if (iresult != 1)
                {
                    MessageBox.Show("Save Failed");
                }
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
            
        }

        private void TimeLine_OnConvertProgress(object sender, AxTimelineAxLib._ITimelineControlEvents_OnConvertProgressEvent e)
        {
            ConvertProgresBar.Value = e.progress;
        }

       
    }
}

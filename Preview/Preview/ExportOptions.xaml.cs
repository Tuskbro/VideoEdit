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

            if (TimeLine.OutputType == 2)
              {
               
                  strFilter = "MP4 File (*.mp4)|*.mp4||";
        }

            System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog.Filter = strFilter;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iresult = TimeLine.Save(saveFileDialog.FileName);


               

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

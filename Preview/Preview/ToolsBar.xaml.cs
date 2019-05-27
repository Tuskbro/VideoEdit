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
using System.Drawing;

using System.Windows.Shapes;
using System.Windows.Forms;
using System.Globalization;

namespace Preview
{
    /// <summary>
    /// Логика взаимодействия для ToolsBar.xaml
    /// </summary>
    public partial class ToolsBar : System.Windows.Controls.UserControl
    {
        public  AxTimelineAxLib.AxTimelineControl axTimeLine;
       public int clipIndex { get; set; }
       public int clipTrack { get; set; }
        public string path;
        public float clipStar,volume, clipStop, clipMedia;
        int font,x,y,r,g,b;

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            axTimeLine.DeleteClip(clipTrack,clipIndex);
        }

        public ToolsBar()
        {
            InitializeComponent();
           
        }
       
        private void TimeLineScale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            axTimeLine.SetScale(float.Parse(LineScale.SelectedItem.ToString()));
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int font=0;
            FontDialog fd = new FontDialog();
            var result = fd.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {

                font = (int)fd.Font.ToHfont();
               
            }
            
            axTimeLine.AddTextClip2(7, SetText.Text, 1, 10, font, 100, 100, 255,255,255);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LineScale.Items.Add(0.01);
            LineScale.Items.Add(0.03);
            LineScale.Items.Add(0.05);
            LineScale.Items.Add(0.1);
            LineScale.Items.Add(0.2);
            LineScale.Items.Add(0.4);
            LineScale.Items.Add(0.4);
            LineScale.Items.Add(0.4);
            LineScale.Items.Add(1.0);
            LineScale.Items.Add(2.0);

            LineScale.Items.Add(3.0);



           
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
           
            switch (clipTrack)
            {
                case 1:
                    {
                        axTimeLine.GetVideoClip(clipTrack, clipIndex, ref path, ref clipStar, ref clipStop, ref clipMedia);
                       
                       
                        if (StartTime.Text != "") { clipStar = (float)Convert.ToDecimal(StartTime.Text); }
                        if (EndTime.Text != "") { clipStop = (float)Convert.ToDecimal(EndTime.Text); }

                        axTimeLine.ChangeVideoClip(clipTrack, clipIndex, path, clipStar, clipStop, clipMedia);
                        
                        break;
                    }
                case 7: {
                        axTimeLine.GetTextClip2(clipTrack, clipIndex, out path, out clipStar, out clipStop, out font, out x, out y, out r, out g, out b);
                        if (StartTime.Text != "") { clipStar = (float)Convert.ToDecimal(StartTime.Text); }
                        if (EndTime.Text != "") { clipStop = (float)Convert.ToDecimal(EndTime.Text); }
                        axTimeLine.ChangeTextClip2(clipTrack, clipIndex,  path,  clipStar,  clipStop,  font,  x,  y,  r,  g,  b);

                        break; }

                case 4: {
                        axTimeLine.GetImageClip(clipTrack, clipIndex, ref path, ref clipStar, ref clipStop);

                        if (StartTime.Text != "") { clipStar = (float)Convert.ToDecimal(StartTime.Text); }
                        if (EndTime.Text != "") { clipStop = (float)Convert.ToDecimal(EndTime.Text); }

                        axTimeLine.ChangeImageClip(clipTrack, clipIndex,  path,  clipStar, clipStop);
                        break; }

                case 5: {
                        axTimeLine.GetAudioClip(clipTrack, clipIndex, ref path, ref clipStar, ref clipStop, ref clipMedia,ref volume);
                        if (StartTime.Text != "") { clipStar = (float)Convert.ToDecimal(StartTime.Text); }
                        if (EndTime.Text != "") { clipStop = (float)Convert.ToDecimal(EndTime.Text); }

                        axTimeLine.ChangeAudioClip(clipTrack, clipIndex, path, clipStar, clipStop, clipMedia, volume);
                        break; }
            }
        }

       
        void OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !e.Text.All(IsGood);
        }

        private void OnPasting(object sender, DataObjectPastingEventArgs e)
        {
            var stringData = (string)e.DataObject.GetData(typeof(string));
            if (stringData == null || !stringData.All(IsGood))
                e.CancelCommand();
        }

        bool IsGood(char c)
        {
            if (c >= '0' && c <= '9')
                return true;
            if (c ==',')
                return true;
           
            return false;
        }


    }
   
}

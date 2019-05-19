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

namespace Preview
{
    /// <summary>
    /// Логика взаимодействия для ToolsBar.xaml
    /// </summary>
    public partial class ToolsBar : UserControl
    {
        public  AxTimelineAxLib.AxTimelineControl axTimeLine;
        public ToolsBar()
        {
            InitializeComponent();
           
        }

        private void TimeLineScale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            axTimeLine.SetScale((float)TimeLineScale.SelectedValue);
        }
    }
}

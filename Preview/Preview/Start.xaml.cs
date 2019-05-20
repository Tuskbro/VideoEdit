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

namespace Preview
{
    /// <summary>
    /// Логика взаимодействия для Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        public Start()
        {
            InitializeComponent();
        }

        private void OpenEditor_Click(object sender, RoutedEventArgs e)
        {
            MainWindow editor = new MainWindow();
            editor.Show();
            this.Close();
        }

        private void OpenPlayer_Click(object sender, RoutedEventArgs e)
        {

            Player player = new Player();
            player.Show();
            this.Close();
        }
    }
}

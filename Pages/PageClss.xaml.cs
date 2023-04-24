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
using WpfAppPractwork1.Windows;

namespace WpfAppPractwork1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageClss.xaml
    /// </summary>
    public partial class PageClss : Page
    {
        public PageClss()
        {
            InitializeComponent();
        }

        private void Rctngl_Click(object sender, RoutedEventArgs e)
        {
            RctnglWindow rctnglWindow = new RctnglWindow();
            rctnglWindow.Show();
        }

        private void Prlg_Click(object sender, RoutedEventArgs e)
        {
            PrlgWindow prlgWindow = new PrlgWindow();
            prlgWindow.Show();
        }

        private void Trzp_Click(object sender, RoutedEventArgs e)
        {
            TrzpWindow trzpWindow = new TrzpWindow();
            trzpWindow.Show();
        }


        private void Rhmb_Click(object sender, RoutedEventArgs e)
        {
            RhmbWindow rhmbWindow = new RhmbWindow();
            rhmbWindow.Show();
        }
    }
}

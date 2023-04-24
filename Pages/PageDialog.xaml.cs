using Microsoft.Win32;
using QIQI.WpfFontPicker;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
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
using ThemeEditor.Controls.ColorPicker;

namespace WpfAppPractwork1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageDialog.xaml
    /// </summary>
    public partial class PageDialog : Page
    {
        public PageDialog()
        {
            InitializeComponent();
        }


        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\";
            if (ofd.ShowDialog() == false)
                return;
            string filename = ofd.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            MessageBox.Show($"Файл {filename} открыт. Пароль {fileText}");
        }

        private void Saveas_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "(*.txt)|*.txt";
            if (sfd.ShowDialog() == false)
            {

                return;
            }
            string FilePath = sfd.FileName;
            object content = Saveas.Content;
            System.IO.File.WriteAllText(FilePath, content.ToString()); 

        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == false)
            {
                printDialog.PrintVisual(WinDialog, "Распечатать");

            }

        }
            private void Fontset_Click(object sender, RoutedEventArgs e)
        {
           FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == false)
            {
                fontDialog.ShowDialog();
            }
        }

        private void Colorset_Click(object sender, RoutedEventArgs e)
        {
            ColorPicker colorPicker = new ColorPicker();
        }
    }
}

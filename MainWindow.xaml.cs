using System.Windows;
using System.IO;
using System.Windows.Controls;

namespace Pizza_Bartova
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string localPath;
        public MainWindow()
        {
            InitializeComponent();
            frame.Navigate(new MainWindow());
            localPath = System.IO.Directory.GetCurrentDirectory();
            OpenPages(pages.main);
        }
        public enum pages
        {
            main,
        }
        public void OpenPages(pages _pages)
        {
            if (_pages == pages.main)
                frame.Navigate(new Layouts.Main(this));
        }
    }
}

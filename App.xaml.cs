using System.Configuration;
using System.Data;
using System.Windows;
using YouTubeViewers.WPF.Stores;
using YouTubeViewers.WPF.ViewModels;

namespace YouTubeViewers.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore = new SelectedYoutubeViewerStore();
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new YouTubeViewerViewModel(_selectedYoutubeViewerStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}

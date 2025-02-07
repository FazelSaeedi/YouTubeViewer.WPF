using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YouTubeViewers.WPF.ViewModels
{
    public class YouTubeViewerViewModel : ViewModelBase
    {
        public YouTubeViewersListingViewModel YouTubeViewersListingViewModel { get; }
        public YouTubeViewerDetailViewModel YouTubeViewerDetailViewModel { get; }
        public ICommand AddYouTubeViewersCommand { get; }
        public YouTubeViewerViewModel(Stores.SelectedYoutubeViewerStore _selectedYoutubeViewerStore)
        {
            YouTubeViewersListingViewModel = new YouTubeViewersListingViewModel(_selectedYoutubeViewerStore);
            YouTubeViewerDetailViewModel = new YouTubeViewerDetailViewModel(_selectedYoutubeViewerStore);
        }
    }
}

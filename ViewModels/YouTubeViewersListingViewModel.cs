using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.WPF.Models;
using YouTubeViewers.WPF.Stores;

namespace YouTubeViewers.WPF.ViewModels
{
    public class YouTubeViewersListingViewModel : ViewModelBase
    {
        private readonly SelectedYoutubeViewerStore selectedYoutubeViewerStore;
        private readonly ObservableCollection<YouTubeViewersListingItemViewModel> _youTubeViewersListingItemViewModel;
        public IEnumerable<YouTubeViewersListingItemViewModel> YouTubeViewersListingItemViewModel => _youTubeViewersListingItemViewModel;

        public YouTubeViewersListingViewModel(Stores.SelectedYoutubeViewerStore _selectedYoutubeViewerStore)
        {
            _youTubeViewersListingItemViewModel = new ObservableCollection<YouTubeViewersListingItemViewModel>();

            _youTubeViewersListingItemViewModel.Add(new YouTubeViewersListingItemViewModel(new YoutubeViewer("Fazel" , true , true)));
            _youTubeViewersListingItemViewModel.Add(new YouTubeViewersListingItemViewModel(new YoutubeViewer("Ali", false, true)));
            _youTubeViewersListingItemViewModel.Add(new YouTubeViewersListingItemViewModel(new YoutubeViewer("Hassan", true, false)));
            
        }

        private YouTubeViewersListingItemViewModel _selectedYouTubeViewerListingItemViewModel; 
        public YouTubeViewersListingItemViewModel SelectedYouTubeViewerListingItemViewModel
        {
            get
            {
                return _selectedYouTubeViewerListingItemViewModel;
            }
            set
            {
                _selectedYouTubeViewerListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedYouTubeViewerListingItemViewModel));

                selectedYoutubeViewerStore.SelectedYoutubeViewer = _selectedYouTubeViewerListingItemViewModel?.YoutubeViewer;
            }
        }

    }
}

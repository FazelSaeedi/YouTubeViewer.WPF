using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.WPF.Models;
using YouTubeViewers.WPF.Stores;

namespace YouTubeViewers.WPF.ViewModels
{
    public class YouTubeViewerDetailViewModel : ViewModelBase
    {
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;
        private YoutubeViewer SelectedYoutubeViewer => _selectedYoutubeViewerStore.SelectedYoutubeViewer;

        public bool HasSelectedYoutubeViewer => SelectedYoutubeViewer != null;

        public string UserName  => SelectedYoutubeViewer?.Username ?? "Unknown" ;
        public string IsSubscribedDisplay => (SelectedYoutubeViewer?.IsSubscribed ?? false )? "Yes" : "No";
        public string IsMemberDisplay  => (SelectedYoutubeViewer?.IsMembered ?? false) ?  "Yes" : "No" ;

        public YouTubeViewerDetailViewModel(Stores.SelectedYoutubeViewerStore selectedYoutubeViewerStore)
        {

            _selectedYoutubeViewerStore = selectedYoutubeViewerStore;

            _selectedYoutubeViewerStore.SelectedYoutubeViewerChanged += SelectedYoutubeViewerStore_SelectedYouTubeViewrChange;
        }

        private void SelectedYoutubeViewerStore_SelectedYouTubeViewrChange()
        {
            OnPropertyChanged(nameof(HasSelectedYoutubeViewer));
            OnPropertyChanged(nameof(UserName));
            OnPropertyChanged(nameof(IsSubscribedDisplay));
            OnPropertyChanged(nameof(IsMemberDisplay));
        }

        protected override void Dispose()
        {
            _selectedYoutubeViewerStore.SelectedYoutubeViewerChanged -= SelectedYoutubeViewerStore_SelectedYouTubeViewrChange;
            base.Dispose();
        }
    }
}

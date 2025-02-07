using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YouTubeViewers.WPF.Models;

namespace YouTubeViewers.WPF.ViewModels
{
    public class YouTubeViewersListingItemViewModel
    {
        public ICommand EditCommand { get;  }
        public ICommand DeleteCommand{ get;  }
        public YoutubeViewer YoutubeViewer { get; }
        public string UserName => YoutubeViewer.Username;

        public YouTubeViewersListingItemViewModel(YoutubeViewer youtubeViewer)
        {
            YoutubeViewer = youtubeViewer;
        }
    }
}

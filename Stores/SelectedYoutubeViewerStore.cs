using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.WPF.Models;

namespace YouTubeViewers.WPF.Stores
{
    public class SelectedYoutubeViewerStore
    {
        private YoutubeViewer _selectedYoutubeId;
        public YoutubeViewer SelectedYoutubeViewer
        {
            get 
            {
                return _selectedYoutubeId; 
            }
            set 
            { 
                _selectedYoutubeId = value;
                this.SelectedYoutubeViewerChanged.Invoke();
            }
        }


        public event Action SelectedYoutubeViewerChanged;
       
    }
}


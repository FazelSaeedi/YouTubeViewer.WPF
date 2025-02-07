using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.WPF.Models
{
    public class YoutubeViewer
    {
        public string Username { get; }
        public bool IsSubscribed { get; }
        public bool IsMembered { get; }

        public YoutubeViewer( string userName , bool isSubscribe , bool isMembered)
        {
            Username = userName ;
            IsSubscribed = isSubscribe ;
            IsMembered = isMembered ;
        }
    }

    
}

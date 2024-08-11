using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_adv_c_.Youtube
{
    internal class Channel
    {
        public string ChannelName {  get; set; }
        public List<Video> Videos { get; set; }
        public override string ToString()
        {
            return $"channel name:{ChannelName}";
        }
        public void AddVideo(Video video)
        {

            Videos.Add(video);
            UploadVideo?.Invoke(video,this);
        }
        public event Action<Video,Channel>? UploadVideo;
        public Channel()
        {
           Videos = new List<Video>();
        }
    }
}

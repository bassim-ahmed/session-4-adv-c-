using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_adv_c_.Youtube
{
    internal class Subscriber
    {
        public string SubscriberNmae {  get; set; }
        public void Notify(Video video,Channel channel)
        {
            Console.WriteLine($"{channel.ChannelName}new video has been added !!{SubscriberNmae} {video} ");
        }
        public override string ToString()
        {
            return $"subscriber name {SubscriberNmae}";
        }
       
    }
}

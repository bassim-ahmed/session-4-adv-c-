using session_3_adv_c_.Fifa;
using session_3_adv_c_.Youtube;
using System.Collections;
using System.Threading.Channels;

namespace session_3_adv_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ex 1
            //Ball ball = new Ball() { Id=12};
            //Console.WriteLine(ball);
            //ball.Location = new Location()
            //{
            //    X = 12,
            //    Y = 12,
            //    Z = 12,
            //};
            //Console.WriteLine(ball);
            //Player p1 = new Player() { Name="kahraba" ,TeamName="ahly"};
            //Player p2 = new Player() { Name = "ali", TeamName = "ahly" };
            //Player p3 = new Player() { Name = "shika", TeamName = "zamalk" };
            //Player p4 = new Player() { Name = "zezo", TeamName = "zamalk" };
            //Refree r1 = new Refree() { Name = "bassim" };
            //ball.BallLocationChange += p1.Run;
            //ball.BallLocationChange += p2.Run;
            //ball.BallLocationChange += p3.Run;
            //ball.BallLocationChange += p4.Run; 
            //ball.BallLocationChange += r1.Look;
            //ball.Location = new Location()
            //{
            //    X = 13,
            //    Y = 14,
            //    Z = 16,
            //};
            //Console.WriteLine(ball);
            #endregion
            #region ex2
            //Youtube.Channel channel = new Youtube.Channel() { ChannelName = "abc" };
            //channel.AddVideo(new Youtube.Video() { Title = "title01", Description = "desc1" });
            //Subscriber s1 = new Subscriber() { SubscriberNmae = "ahmed" };
            //Subscriber s2 = new Subscriber() { SubscriberNmae = "ali" };
            //Subscriber s3 = new Subscriber() { SubscriberNmae = "bassim" };

            //Subscriber s4 = new Subscriber() { SubscriberNmae = "mogsen" };
            //channel.UploadVideo += s1.Notify;
            //channel.UploadVideo += s2.Notify;
            //channel.UploadVideo += s3.Notify;
            //channel.UploadVideo += s4.Notify;
            //channel.AddVideo(new Youtube.Video() { Title = "title01", Description = "desc1" });
            #endregion
            #region hashtable non gneris
            Hashtable Note=new Hashtable();
            Console.WriteLine($"count: {Note.Count }");
            Note.Add("Ahmed", 99999);
            Note.Add("Ali", 99999999999);
            Note.Add("bassim", 9);
            foreach (DictionaryEntry entry in Note) {

                Console.WriteLine($"key:{entry.Key},value:{entry.Value}");

            }
            foreach(object item in Note.Keys)
            {
                Console.WriteLine(item);
            }
            Note["bassim"] = 11111;


            #endregion
            #region part 6 generic collection
            Dictionary<string,long> Note=new Dictionary<string,long>();
            Note.Add("ahmed", 7777);
            foreach (KeyValuePair<string,long> entry in Note) {
                Console.WriteLine($"{entry.Key},{entry.Value}");
            }
            #endregion

        }
    }
}

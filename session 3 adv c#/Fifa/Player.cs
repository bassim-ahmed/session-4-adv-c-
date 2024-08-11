using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_adv_c_.Fifa
{
    internal class Player
    {
        public string Name {  get; set; }
        public string TeamName {  get; set; }

        public void Run()
        {
            Console.WriteLine($"player{ Name} is running" );
        }
    }
}

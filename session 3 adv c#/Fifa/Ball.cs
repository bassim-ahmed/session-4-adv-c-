using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_adv_c_.Fifa
{
    internal class Ball
    {
        public int Id { get; set; }
        public Location location;
        public Location Location
        {
            get { return location; }
            set
            {
                if (!value.Equals(location)) {

                    location = value;
                BallLocationChange?.Invoke();
            }
            }
        }
        public  event Action? BallLocationChange;
        public override string ToString()
        {
            return $"id:{Id},Location:{Location}";
        }

    }
}

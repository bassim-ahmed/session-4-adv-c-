﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_3_adv_c_.Youtube
{
    internal class Video
    {
        public string Title {  get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"{Title} {Description}";
        }
    }
}

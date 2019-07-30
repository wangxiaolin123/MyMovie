﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMovie.Areas.T1News.Models.Local
{
    public class NewsDetails
    {

        public int NewID { get; set; }
        public string ClassesName { get; set; }
        public string Title { get; set; } 
        public string Author { get; set; }
        public string Original { get; set; }
        public string Content { get; set; }
    }
}
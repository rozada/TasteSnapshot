using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace TasteSnapshot.ViewModels
{
    public class YummyViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
        //public File Image { get; set; }
    }
}
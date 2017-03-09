using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteSnapshot.Models
{
    public class Yummy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }      
        public byte[] Photo { get; set; }

        public virtual ICollection<CustomProperty> CustomProperties { get; set; }
    }
}
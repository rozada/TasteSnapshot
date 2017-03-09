using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteSnapshot.Models
{
    public class CustomProperty
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public Type  Type{ get; set; }        

        public int YummyID { get; set; }
        public virtual Yummy Yummy { get; set; }
    }
}
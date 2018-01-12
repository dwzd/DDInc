using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDInc.Models
{
    public enum Sex
    {
        Male, Female
    }
    public class Worker
    {
        public int ID { get; set; }
        public string  LastName { get; set; }
        public string FirstName { get; set; }
        public Sex Sex { get; set; }
        public double? Rating { get; set; }
    }
}
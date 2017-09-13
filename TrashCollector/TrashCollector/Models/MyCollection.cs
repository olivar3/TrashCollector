using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class MyCollection
    {
        public int Id { get; set; }
        public int NumberThisMonth  { get; set; }
        public string Date { get; set; }
        public double Cost { get; set; }
    }
}
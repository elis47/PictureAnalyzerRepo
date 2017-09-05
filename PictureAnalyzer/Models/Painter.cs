using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PictureAnalyzer.Models
{
    public class Painter
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime PassDate { get; set; }

        public virtual ICollection<Painting> Paintings { get; set; }
    }
}
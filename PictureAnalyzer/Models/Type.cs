﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PictureAnalyzer.Models
{
    public class Type
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PersonalityTraits { get; set; }

        public virtual ICollection<Painting> Paintings { get; set; }
    }
}
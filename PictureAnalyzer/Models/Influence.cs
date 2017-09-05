using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PictureAnalyzer.Models
{
    public class Influence
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Display(Name = "Beginning year")]
        public int BeginYear { get; set; }
        [Display(Name = "Ending year")]
        public int EndYear { get; set; }

        public virtual ICollection<Painting> Paintings { get; set; }
    }
}
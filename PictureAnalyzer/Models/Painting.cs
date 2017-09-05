using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PictureAnalyzer.Models
{
    public class Painting
    {
        public int ID { get; set; }
        [StringLength(50, ErrorMessage = "The name can not be longer than 50 characters.")]
        public string Name { get; set; }
        [StringLength(250, ErrorMessage = "The description can not be longer than 250 characters.")]
        public string Description { get; set; }

        public string CurrentOwner { get; set; }
        public double HarmonyIndex { get; set; }
        public double ConstrastIndex { get; set; }
        public double LuminosityIndex { get; set; }

        //public string ApplicationUserID { get; set; }
        public int PainterID { get; set; }
        public int TypeID { get; set; }
        public int InfluenceID { get; set; }
        public int ProfileID { get; set; }
        public int GalleryID { get; set; }

        //public virtual ApplicationUser User { get; set; }
        public virtual Painter Painter { get; set; }
        public virtual Type Type { get; set; }
        public virtual Influence Influence { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Gallery Gallery { get; set; }
        public virtual ICollection<Color> Colors { get; set; }
    }
}
namespace PictureAnalyzer.Migrations
{
    using PictureAnalyzer.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PictureAnalyzer.DAL.PictureAnalyzerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PictureAnalyzer.DAL.PictureAnalyzerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            var painters = new List<Painter>
            {
            new Painter{Name="Vincent van Gogh",Description="In just over a decade he created about 2,100 artworks, including around 860 oil paintings, most of them in the last two years of his life in France, where he died. They include landscapes, still lifes, portraits and self-portraits, and are characterised by bold colours and dramatic, impulsive and expressive brushwork that contributed to the foundations of modern art. His suicide at 37 followed years of mental illness and poverty.",Country="Dutch",BirthDate=DateTime.Parse("1853-03-30"),PassDate=DateTime.Parse("1890-06-29")},
            new Painter{Name="Pablo Picasso",Description="Regarded as one of the most influential artists of the 20th century, he is known for co-founding the Cubist movement, the invention of constructed sculpture, the co-invention of collage, and for the wide variety of styles that he helped develop and explore.",Country="Spain",BirthDate=DateTime.Parse("1881-10-25"),PassDate=DateTime.Parse("1973-05-08")},
            new Painter{Name="Leonardo da Vinci",Description="Da Vinci was someone who was skilled and knowledgeable in many, many subjects, including science, mathematics, music, and most importantly, art. He was the epitome of a Renaissance man if there never was one.",Country="Italy",BirthDate=DateTime.Parse("1452-04-29"),PassDate=DateTime.Parse("1519-05-02")}
            };
            painters.ForEach(p => context.Painters.Add(p));
            context.SaveChanges();


            var colors = new List<Color>
            {
            new Color{Name="Blue",Description="freedom",PersonalityTraits="traveller",},
            new Color{Name="Red",Description="passion",PersonalityTraits="lover",}
            };
            colors.ForEach(c => context.Colors.Add(c));
            context.SaveChanges();



            //var types = new List<Models.Type>
            //{
            //new Models.Type{Name="Nature",Description="",PersonalityTraits=""},
            //new Models.Type{Name="Portrait",Description="",PersonalityTraits=""},
            //new Models.Type{Name="Animals",Description="",PersonalityTraits=""},
            //new Models.Type{Name="Abstract",Description="",PersonalityTraits=""}
            //};
            //types.ForEach(t => context.Types.Add(t));
            //context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PictureAnalyzer.Models;

namespace PictureAnalyzer.DAL
{
    public class PictureAnalyzerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PictureAnalyzerContext>
    {
        protected override void Seed(PictureAnalyzerContext context)
        {

        }
    }
}
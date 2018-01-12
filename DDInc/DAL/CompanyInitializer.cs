using DDInc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDInc.DAL
{
    public class CompanyInitializer : System.Data.Entity.DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            var companyWorkers = new List<Worker>
            {
                new Worker{FirstName="Andy",LastName="George",Sex = Sex.Male},
                new Worker{FirstName="Laura",LastName="Smith",Sex = Sex.Female},
                new Worker{FirstName="Jason",LastName="Black",Sex = Sex.Male},
                new Worker{FirstName="Linda",LastName="Queen",Sex = Sex.Female},
                new Worker{FirstName="James",LastName="Brown", Sex = Sex.Male}
            };
            companyWorkers.ForEach(s => context.Workers.Add(s));
            context.SaveChanges();
        }
    }
}
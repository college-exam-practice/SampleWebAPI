namespace MVCClub.Migrations
{
    using ClubDomain.Classes.ClubModels;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCClub.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCClub.Models.ApplicationDbContext context)
        { {
                //context.Members.AddOrUpdate(new Member() {

                //    StudentID = "S00083446", approved = true, MemberID = 1, AssociatedClub = 1, myClub = new Club{ ClubName = "Bellator", ClubId = 2, adminID = 100 }
                //});

        }
            


            //},
            // new Member
            //{
            //    MemberID = 2, AssociatedClub = 3, StudentID = "Yin Yang", approved = false
            //}

            //   },
            //clubEvents = new List<ClubEvent>()
            //   {
            //         new ClubEvent
            //       {
            //           EventID = 1, Venue = "Pjonyang", Location = "Vienam" , ClubId = 3, StartDateTime = DateTime.Parse("1/11/1983"), EndDateTime = DateTime.Parse("3/12/1984")
            //       },
            //           new ClubEvent
            //       {
            //           EventID = 2, Venue = "Bangkok", Location = "Thailand" , ClubId = 3, StartDateTime = DateTime.Parse("2/1/2000"), EndDateTime = DateTime.Parse("19/3/2001")
            //       }
            //   }
            //   }
            //}
            //,
            //    },
            //    new Club
            //    {

            //    },
            //    new Club
            //    {

            //    }
            //}
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


        }
    }
}

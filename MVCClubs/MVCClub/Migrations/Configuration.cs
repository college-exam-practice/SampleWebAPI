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
        {
            context.Clubs.AddOrUpdate(new Club[]
            {
                new Club{ ClubId = 1, ClubName = "UFC", adminID = 100,CreationDate = DateTime.Parse( "19-2-1983"), clubMembers =
                new List<Member>()
                {
                    new Member
                    {
                        MemberID = 1, AssociatedClub = 1, StudentID = "S00083446", approved = true
                    },
                     new Member
                    {
                        MemberID = 2, AssociatedClub = 2, StudentID = "S007", approved = false
                    }

                },
             clubEvents = new List<ClubEvent>()
                {
                      new ClubEvent
                    {
                        EventID = 1, Venue = "MGM Grand", Location = "Las Vegas" , ClubId = 1, StartDateTime = DateTime.Parse("12/11/1984"), EndDateTime = DateTime.Parse("13/12/1984")
                    },
                        new ClubEvent
                    {
                        EventID = 2, Venue = "3 Arena", Location = "Dublin" , ClubId = 1, StartDateTime = DateTime.Parse("2/1/1994"), EndDateTime = DateTime.Parse("19/3/1999")
                    }
                }
                }
            }
                                //,
            //    },
            //    new Club
            //    {

            //    },
            //    new Club
            //    {

            //    }
            //}
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


        }
    }
}

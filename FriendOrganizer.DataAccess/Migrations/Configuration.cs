namespace FriendOrganizer.DataAccess.Migrations
{
    using FriendOrganizer.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                        new Friend { FirstName = "Tomas", LastName = "Gebel", Email = "tomasagebel@fubar.com" },
                        new Friend { FirstName = "B�rje", LastName = "Lundin", Email = "rattensriddare@fubar.com" },
                        new Friend { FirstName = "Quick", LastName = "Dirty", Email = "quickanddirty@fubar.com" },
                        new Friend { FirstName = "Rune-�rjan", LastName = "�rjansson", Email = "rune�rjan@fubar.com" }
                );
            context.ProgrammingLanguages.AddOrUpdate(
                pl => pl.Name,
                    new ProgrammingLanguage { Name = "C#" },
                    new ProgrammingLanguage { Name = "Java" },
                    new ProgrammingLanguage { Name = "Ruby" },
                    new ProgrammingLanguage { Name = "Python" },
                    new ProgrammingLanguage { Name = "Swift" },
                    new ProgrammingLanguage { Name = "Visual Basic" }
                    );

            context.SaveChanges();

            context.FriendPhoneNumbers.AddOrUpdate(
                fp => fp.Number,
                    new FriendPhoneNumber { Number = "031-177000", FriendId = context.Friends.First().Id });

            context.Meetings.AddOrUpdate(m => m.Title,
                new Meeting
                {
                    Title = "Watching Star Trek Discovery",
                    DateFrom = new DateTime(2017, 11, 7),
                    DateTo = new DateTime(2017, 11, 7),
                    Friends = new List<Friend>
                    {
                        context.Friends.Single(f => f.FirstName == "B�rje" && f.LastName == "Lundin")
                    }
                });
        }
    }
}

namespace FriendOrganizer.DataAccess.Migrations
{
    using FriendOrganizer.Model;
    using System;
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
                        new Friend { FirstName = "Börje", LastName = "Lundin", Email = "rattensriddare@fubar.com" },
                        new Friend { FirstName = "Quick", LastName = "Dirty", Email = "quickanddirty@fubar.com" },
                        new Friend { FirstName = "Rune-Örjan", LastName = "Örjansson", Email = "runeörjan@fubar.com" }
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


        }
    }
}

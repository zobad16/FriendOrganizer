namespace FriendOrganizer.DataAccess.Migrations
{
    using Model;
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
                new Friend { FirstName = "Zobad", LastName = "Mahmood" },
                new Friend { FirstName = "Amna", LastName = "Mahmood" },
                new Friend { FirstName = "Arfa", LastName = "Mahmood" },
                new Friend { FirstName = "Farwa", LastName = "Mahmood" }
                );
        }
    }
}

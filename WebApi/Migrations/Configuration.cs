namespace WebApi.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApi.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApi.DBConatext.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApi.DBConatext.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var p1 = new Players { FirstName = "Juan", LastName = "Dela Cruz", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p2 = new Players { FirstName = "Jose", LastName = "Rizal", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p3 = new Players { FirstName = "Andres", LastName = "Bonifacio", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            var p4 = new Players { FirstName = "Juan", LastName = "Luna", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };

            var t1 = new Team { Name= "San Miguel Beerman", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Players = new List<Players> {p1,p2 } };
            var t2 = new Team { Name = "Alaska Aces", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, Players = new List<Players> { p3, p4 } };

            p1.Team = t1;
            p2.Team = t1;
            p3.Team = t2;
            p4.Team = t2;

            var game = new Game { AwayTeam = t1, HomeTeam = t2, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, StartTime = DateTime.Now };

            context.Players.Add(p1);
            context.Players.Add(p2);
            context.Players.Add(p3);
            context.Players.Add(p4);
            context.Teams.Add(t1);
            context.Teams.Add(t2);
            context.Games.Add(game);



        }
    }
}

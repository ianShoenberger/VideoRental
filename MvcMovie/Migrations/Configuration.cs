namespace MvcMovie.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MvcMovie.Models.ApplicationDbContext";
        }

        protected override void Seed(MvcMovie.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //You can use the DbSet<T>.AddOrUpdate() helper extension method
            //to avoid creating duplicate seed data.E.g.
            System.Diagnostics.Debug.WriteLine("Seed method in migration config is invoked!");
            var passwordHash = new PasswordHasher();
            string password = passwordHash.HashPassword("123456");
            ApplicationUser AdminUser = new ApplicationUser()
            {
                UserName = "admin",
                FirstName = "Administrator",
                LastName = "Administrator",
                Address = "NY",
                PasswordHash = password,

            };
            context.Users.AddOrUpdate(p => p.UserName, AdminUser);

            string NormalUserPassword = passwordHash.HashPassword("111111");
            ApplicationUser NormalUser = new ApplicationUser()
            {
                UserName = "John",
                FirstName = "John",
                LastName = "Wick",
                Address = "3 W Squire Dr, Rochester, NY",
                PasswordHash = NormalUserPassword
            };

            context.Users.AddOrUpdate(u => u.UserName, NormalUser);

            IdentityRole AdminRole = new IdentityRole()
            {
                Name = "Administrator"
            };
            IdentityRole UserRole = new IdentityRole()
            {
                Name = "User"
            };
            context.Roles.AddOrUpdate(u => u.Name, AdminRole);
            context.Roles.AddOrUpdate(u => u.Name, UserRole);

            context.SaveChanges();

            var UserManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(context));
            UserManager.AddToRole(AdminUser.Id, AdminRole.Name);
            UserManager.AddToRole(NormalUser.Id, UserRole.Name);


        }
    }
}

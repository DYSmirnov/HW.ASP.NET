using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MvcCreditApp.Models
{
    public class AppDbInitializer:
        DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {

            //создайте объекты UserManager и RoleManager с помощью контекста данных для управления пользователями и ролями
            var userManager = new ApplicationUserManager(
                new UserStore<ApplicationUser>(context));

            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(context));

            //создайте две роли с именами admin и user
            var role1 = new IdentityRole { Name = "admin" };
            var role2 = new IdentityRole { Name = "user" };


            //Добавьте роли в базу данных
            roleManager.Create(role1);
            roleManager.Create(role2);

            //Создайте пользователя-администратора с указанием советующих параметров
            var admin = new ApplicationUser
            { Email = "admin@mail.ru", UserName = "admin@mail.ru" };
            string password = "Qwerty_311";
            var result = userManager.Create(admin, password);

            if (result.Succeeded)
            {
                userManager.AddToRole(admin.Id, role1.Name);
                userManager.AddToRole(admin.Id, role2.Name);
            }
            base.Seed(context);
        }
    }
}
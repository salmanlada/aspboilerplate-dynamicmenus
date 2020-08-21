using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyApp.Authorization.Roles;
using MyApp.Authorization.Users;
using MyApp.MultiTenancy;

namespace MyApp.EntityFrameworkCore
{
    public class MyAppDbContext : AbpZeroDbContext<Tenant, Role, User, MyAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options)
            : base(options)
        {
           
        }

        public virtual DbSet<CMS.CMS> CMSPages { get; set; }

        public virtual DbSet<Nav.NavItems> Menus { get; set; }
    }
}

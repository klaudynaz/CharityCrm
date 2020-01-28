using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CharityCrm.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        //public DbSet<Action> Action { get; set; }
        //public DbSet<DocumentTemplate> DocumentTemplate { get; set; }
        //public DbSet<Field> Field { get; set; }
        //public DbSet<File> File { get; set; }
        //public DbSet<Message> Message { get; set; }
        //public DbSet<Product> Product { get; set; }
        //public DbSet<ProductCategory> ProductCategory { get; set; }
        //public DbSet<Quest> Quest { get; set; }
        //public DbSet<Registration> Registratrion { get; set; }
        //public DbSet<RodoProposal> RodoProposal { get; set; }
        //public DbSet<Role> Role { get; set; }
        //public DbSet<Sale> Sale { get; set; }
        //public DbSet<User> User { get; set; }

    }

    //public static ApplicationDbContext Create()
    //{
    //    return new ApplicationDbContext();
    //}
}
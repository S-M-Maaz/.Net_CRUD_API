using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
namespace WebAPI.Data

{
    public class ContactsApiDbContext : DbContext
    {
        public ContactsApiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}

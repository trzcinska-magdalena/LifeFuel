using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LifeFuel.Data
{
    public class LifeFuelContext : IdentityDbContext
    {

        public LifeFuelContext()
        {
        }

        public LifeFuelContext(DbContextOptions options) : base(options)
        {
        }
    }
}

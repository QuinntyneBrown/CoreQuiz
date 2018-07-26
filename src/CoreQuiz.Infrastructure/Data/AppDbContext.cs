using System.Threading;
using System.Threading.Tasks;
using CoreQuiz.Core.Interfaces;
using CoreQuiz.Core.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CoreQuiz.Infrastructure.Data
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions options)
            :base(options) { }

        public DbSet<StoredEvent> StoredEvents { get; set; }
    }
}

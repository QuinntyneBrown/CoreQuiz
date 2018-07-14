using CoreQuiz.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CoreQuiz.Core.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<DomainEvent> DomainEvents { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

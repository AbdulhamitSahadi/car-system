using CarSystem.API.Data;
using CarSystem.API.Models.Domain;
using CarSystem.API.Repositories.Base;
using CarSystem.API.Repositories.IRepositories;

namespace CarSystem.API.Repositories.Repository
{
    public class WritingTestRepository : EntityBaseRepository<WritingTest>, IWritingTestRepository
    {
        private readonly ApplicationDbContext _context;

        public WritingTestRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}

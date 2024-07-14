using CarSystem.API.Data;
using CarSystem.API.Models.Domain;
using CarSystem.API.Repositories.Base;
using CarSystem.API.Repositories.IRepositories;

namespace CarSystem.API.Repositories.Repository
{
    public class DamageLicenseRepository : EntityBaseRepository<DamageLicense>, IDamageLicenseRepository
    {
        private readonly ApplicationDbContext _context;

        public DamageLicenseRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}

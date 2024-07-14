using CarSystem.API.Data;
using CarSystem.API.Models.Domain;
using CarSystem.API.Repositories.Base;
using CarSystem.API.Repositories.IRepositories;

namespace CarSystem.API.Repositories.Repository
{
    public class LicenseRepository : EntityBaseRepository<License>, ILicenseRepository
    {
        private readonly ApplicationDbContext _context;

        public LicenseRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}

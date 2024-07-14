using CarSystem.API.Data;
using CarSystem.API.Models.Domain;
using CarSystem.API.Repositories.Base;
using CarSystem.API.Repositories.IRepositories;

namespace CarSystem.API.Repositories.Repository
{
    public class LostLicenseRepository : EntityBaseRepository<LostLicense>, ILostLicenseRepository
    {
        private readonly ApplicationDbContext _context;

        public LostLicenseRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }
    }
}

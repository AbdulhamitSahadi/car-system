using CarSystem.API.Data;
using CarSystem.API.Models.Domain;
using CarSystem.API.Repositories.Base;
using CarSystem.API.Repositories.IRepositories;

namespace CarSystem.API.Repositories.Repository
{
    public class RenewalLicenseRepository : EntityBaseRepository<RenewalLicense>, IRenewalLicenseRepository
    {
        private readonly ApplicationDbContext _context;

        public RenewalLicenseRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}

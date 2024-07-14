using CarSystem.API.Data;
using CarSystem.API.Models.Domain;
using CarSystem.API.Repositories.Base;
using CarSystem.API.Repositories.IRepositories;

namespace CarSystem.API.Repositories.Reposiltory
{
    public class NationalityRepository : EntityBaseRepository<Nationality> , INationalityRepository
    {
        private readonly ApplicationDbContext _context;

        public NationalityRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        //public override Task<bool> UpdateAsync(Nationality entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

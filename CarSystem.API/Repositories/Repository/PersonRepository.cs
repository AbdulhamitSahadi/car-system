using CarSystem.API.Data;
using CarSystem.API.Models.Domain;
using CarSystem.API.Repositories.Base;
using CarSystem.API.Repositories.IRepositories;

namespace CarSystem.API.Repositories.Repository
{
    public class PersonRepository : EntityBaseRepository<Person>, IPersonRepository
    {
        private readonly ApplicationDbContext _context;

        public PersonRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}

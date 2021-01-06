using Personel.Dal.Repositories.Abstract;
using Personel_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Dal.Repositories.Concrete
{
    public class PersonelRepository : Repository<Personel_>, IPersonelRepository
    {
        public PersonelRepository(PersonelContext context):base(context)
        {

        }
        public IEnumerable<Personel_> GetPersonelsWithDepartment()
        {
            return PersonelContextt.Personels.Include("Department").ToList();
        }

        public PersonelContext PersonelContextt { get { return _context as PersonelContext; } }
    }
}

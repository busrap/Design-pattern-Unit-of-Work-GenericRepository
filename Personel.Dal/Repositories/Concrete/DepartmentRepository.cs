using Personel_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Dal.Repositories.Concrete
{
    using Personel.Dal.Repositories.Abstract;


    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(PersonelContext context) : base(context)
        {

        }

        public IEnumerable<Department> GetDepartmentsWithPersonels()
        {
            return PersonelContextt.Departments.Include("Personels").ToList();
        }

        public IEnumerable<Department> GetTopDepartments(int count)
        {
            return PersonelContextt.Departments.Take(count);
        }

        public PersonelContext PersonelContextt { get { return _context as PersonelContext; } }
        
    }
}

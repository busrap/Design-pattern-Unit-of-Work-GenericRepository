using Personel_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Dal.Repositories.Abstract
{
   public interface IPersonelRepository:IRepository<Personel_>
    {
       IEnumerable<Personel_> GetPersonelsWithDepartment();
    }
}

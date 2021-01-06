using Personel.Dal.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Dal.UnitOfWork
{
   public interface IUnitOfWork:IDisposable
    {
         IPersonelRepository PersonelRepository { get;}
         IDepartmentRepository DepartmentRepository { get;}
        int SaveComplete();
    }
}

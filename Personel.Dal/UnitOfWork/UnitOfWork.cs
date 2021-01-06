using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personel.Dal.Repositories.Abstract;
using Personel.Dal.Repositories.Concrete;

namespace Personel.Dal.UnitOfWork
{
   public class UnitOfWork : IUnitOfWork

    {
        private PersonelContext personelContext_;

        public UnitOfWork(PersonelContext context)
        {
            personelContext_ = context;
            DepartmentRepository = new DepartmentRepository(personelContext_);
            PersonelRepository = new PersonelRepository(personelContext_);
        }
        public IPersonelRepository PersonelRepository { get; private set; }

        public IDepartmentRepository DepartmentRepository { get; private set; }

        public int SaveComplete()
        {
           return personelContext_.SaveChanges();
        }

        public void Dispose()
        {
            personelContext_.Dispose();
        }
    }
}

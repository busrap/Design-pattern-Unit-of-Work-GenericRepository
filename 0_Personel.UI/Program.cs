using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personel.Dal.UnitOfWork;
using Personel.Dal;
using Personel_Domain;

namespace _0_Personel.UI
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            Department dp = new Department();
            Personel_ p = new Personel_();
            UnitOfWork unitOFwork = new UnitOfWork(new PersonelContext());

            //unitOFwork.DepartmentRepository.Add(new Department() { Name = "Bilgi işlem", IsActive = true, CreateDate = DateTime.Now });
        
            dp.Name = "İnsan Kaynakları";
            dp.IsActive = true;
            dp.CreateDate = DateTime.Now;

            unitOFwork.DepartmentRepository.Add(dp);

            unitOFwork.DepartmentRepository.Remove(2);

            unitOFwork.SaveComplete();
        }
    }
}

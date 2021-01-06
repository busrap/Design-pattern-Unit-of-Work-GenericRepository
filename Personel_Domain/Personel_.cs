using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Domain
{
   public class Personel_:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        //Personel ve departman arasında birçok ilişki olduğundan
        //Bir personel'in bir departmanı olur ama bir departman'ın birden fazla personeli olur
        public int DepartmentID { get; set; }
        public Department Department { get; set; }//==> navigation property
    }
}

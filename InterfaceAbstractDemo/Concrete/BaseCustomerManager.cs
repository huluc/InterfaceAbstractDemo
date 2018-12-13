using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    //Bu sınıf new lenememeli. Bu yüzden abstract yapıyoruz.
    public abstract class BaseCustomerManager :ICustomerService
    {
        //virtual sayesinde artık bu metodu ezebiliriz. Çünkü Starbucks daki Save metodu ayrı çalışacak.
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Logged to db!");
        }
    }
}

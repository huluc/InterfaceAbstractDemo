using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    class StarbucksCustomerManager :BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            
            if (_customerCheckService.CheckIfRealPerson(customer) == true)
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("not a valid user!");
            }
        }
        //Bu metodu buraya yazmak uygun değil. Çünkü Mernis doğrulaması farklı bir class dan da yapılmak istenebilir. Inteface lerin ability özellğini kullanalım.

        //private bool CheckIfRealPerson(Customer customer)
        //{
        //    throw new NotImplementedException();
        //}

    }

}

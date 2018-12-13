using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            //BaseCustomerManager customerManager = new NeroCustomerManager();//Mernis doğrulaması istemiyor.
            customerManager.Save(new Customer(){DateOfBirth = new DateTime(1989,01,01),FirstName = "H",LastName = "Uluç", NationalityId ="2xxxxxxxxxx"});
            Console.ReadLine();
        }
    }
}

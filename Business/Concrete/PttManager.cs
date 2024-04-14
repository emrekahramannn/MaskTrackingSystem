using Business.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        // Dependency Injection (this class is dependent on another class that implements IPersonCheckService)
        IPersonCheckService _personCheckService;
        public PttManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        public void GiveMask(IPerson person)
        {
            /*
                The supplier can give a mask to the person according to the accuracy of the information entered 
                param: Iperson (Citizen, Foreigner) 
            */
            if (_personCheckService.CheckIfRealPerson(person))
            {
                Console.WriteLine(person.FirstName.ToUpper() + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName.ToUpper() + " için maske VERİLMEDİ.");
            }
        }
    }
}

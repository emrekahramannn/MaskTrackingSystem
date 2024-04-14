using Business.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CitizenManager : IApplicantService
    {
        // Dependency Injection (this class is dependent on another class that implements IPersonCheckService)
        IPersonCheckService _personCheckService;
        public CitizenManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        // A Person can apply for a mask
        public void ApplyForMask(IPerson person)
        {
            // Checks if the person is a real person or not
            if (_personCheckService.CheckIfRealPerson(person))
            {
                Console.WriteLine($"Sayın {person.FirstName.ToUpper()} {person.LastName.ToUpper()} maskenizi en yakın PTT şubesinden alabilirsiniz.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Lütfen girmiş olduğunuz bilgileri kontrol ediniz.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime BirthDate { get; set; }
        string NationalityId { get; set; }
    }
}

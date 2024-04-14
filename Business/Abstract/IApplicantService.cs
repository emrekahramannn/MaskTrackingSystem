using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        // Applicant classes have to implement this interface
        void ApplyForMask(IPerson person);
    }
}

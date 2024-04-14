using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISupplierService
    {
        // Mask suppliers's business classes have to implement this interface
        void GiveMask(IPerson person);
    }
}

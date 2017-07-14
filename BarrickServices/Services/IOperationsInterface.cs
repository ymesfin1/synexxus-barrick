using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using synexxusbarrick.Entities;

namespace synexxusbarrick.BarrickServices.Services
{
    public interface IOperationsInterface
    {
        List<Operations> GetOperations();
        Operations GetOperations(int id);
    }
}

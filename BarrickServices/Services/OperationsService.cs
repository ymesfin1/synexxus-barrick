using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using synexxusbarrick.Entities;

namespace synexxusbarrick.BarrickServices.Services
{
    public class OperationsService : IOperationsInterface
    {
        private BarrickOperationsContext db = new BarrickOperationsContext();

        public List<Operations> GetOperations()
        {
            // throw new NotImplementedException();
            return db.Operations.ToList();
        }

        public Operations GetOperations(int id)
        {
            throw new NotImplementedException();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using synexxusbarrick.Entities;
using synexxusbarrick.BarrickServices.Services;

using System.Data;
namespace synexxus_barrick.Controllers
{
    [Produces("application/json")]
    [Route("api/BarrickOperations")]
    public class BarrickOperationsController : Controller
    {
        private IOperationsInterface operationsService = new OperationsService();

        public IEnumerable<Operations> Get()
        {
            return operationsService.GetOperations();
        }


    }
}
  
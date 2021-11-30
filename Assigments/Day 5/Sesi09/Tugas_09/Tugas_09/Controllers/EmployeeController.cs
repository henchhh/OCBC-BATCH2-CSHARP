using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Tugas_09.Models;
using MySql.Data.MySqlClient;

namespace Tugas_09.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {   
        private EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }

        [HttpGet(Name = "Get All")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetAllEmployee();
        }

        [HttpGet("{id}", Name = "Get Where")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetEmployee(id);
        }

        [HttpPost(Name = "Create")]
        public ActionResult<IEnumerable<EmployeeItem>> CreateEmployeeItem([FromBody] EmployeeItem employeeItem)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.CreateEmployee(employeeItem);
        }

        [HttpPut("{id}",Name = "Update")]
        public ActionResult<IEnumerable<EmployeeItem>> UpdateEmployeeItem([FromBody] EmployeeItem employeeItem)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.UpdateEmployee(employeeItem);
        }

        [HttpDelete("{id}",Name = "Delete")]
        public ActionResult<IEnumerable<EmployeeItem>> DeleteEmployeeItem([FromBody] EmployeeItem employeeItem)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.DeleteEmployee(employeeItem);
        }
    }
}

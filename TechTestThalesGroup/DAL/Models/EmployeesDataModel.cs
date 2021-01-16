using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class EmployeesDataModel
    {
        public List<EmployeeModel> data = new List<EmployeeModel>();
        public IList<EmployeeModel> GetData { get { return data; } }
    }
}

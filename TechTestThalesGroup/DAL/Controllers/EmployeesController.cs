using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Controllers
{
    public class EmployeesController
    {
        
        public async Task<EmployeeModel> GetEmployeeInfo(int idEmployee)
        {
            string url = "http://dummy.restapiexample.com/api/v1/employee/" + idEmployee.ToString(); 
            HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                   EmployeeDataModel employee = await response.Content.ReadAsAsync<EmployeeDataModel>();
                   return employee.data;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
        }

        public async Task<EmployeesDataModel> GetEmployeesInfoList()
        {
            string url = "http://dummy.restapiexample.com/api/v1/employees" ;
            HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                EmployeesDataModel employee = await response.Content.ReadAsAsync<EmployeesDataModel>();
                return employee;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

    }
}

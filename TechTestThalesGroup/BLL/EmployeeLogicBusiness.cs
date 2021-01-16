using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Controllers;
using DAL.Models;

namespace BLL
{
    public class EmployeeLogicBusiness
    {

        public async Task<EmployeesDataModel>  GetInformationEmployees(int idEmployee)
        {
            EmployeesController EmplController = new EmployeesController();
            EmployeeModel employee = new EmployeeModel();
            EmployeesDataModel employees = new EmployeesDataModel();
            if (idEmployee >= 0)
            {
                        employee = await EmplController.GetEmployeeInfo(idEmployee);
                        employees.data.Add(employee);
            }
            else
            {
                employees = await EmplController.GetEmployeesInfoList();
            }
            CalculateAnualSalary(employees);
            return employees;
        }


        public void ExecuteLogic(EmployeesDataModel employeeData)
        {
            //Calculate anual salary for all employees of the list 
            CalculateAnualSalary(employeeData);
        }

        private void CalculateAnualSalary(EmployeesDataModel employeeData) 
        {
            int MonthsNumb = 12;
            if (employeeData != null) 
            {
                //Calculate Anual Salary
                foreach (var empl in employeeData.data)
                {
                    if (empl.employee_salary > 0)
                    {
                        empl.employee_anual_salary = empl.employee_salary * MonthsNumb;
                    }

                }
            }
            
        }
    }
}

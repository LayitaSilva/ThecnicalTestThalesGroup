using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DAL.Models;
using BLL;

namespace TechTestTestProyect
{
    [TestClass]
    public class TestEmployeeLogic
    {
        [TestMethod]
        public void TestBll() 
        {
            EmployeeLogicBusiness bll = new EmployeeLogicBusiness();
            Assert.IsNotNull(bll, "El business logic layer is created OK ");
        }

        [TestMethod]
        public void TestModel()
        {
            EmployeesDataModel result = new EmployeesDataModel();
            Assert.IsNotNull(result, "Model is not null");
        }

        [TestMethod]
        public async void TestEmployeeConsult() 
        {
            EmployeeLogicBusiness bll = new EmployeeLogicBusiness();
            EmployeesDataModel result = new EmployeesDataModel();
            int idEmployee= 1;
            result = await bll.GetInformationEmployees(idEmployee);
            Assert.IsNotNull(result, "Model is not null");
        }

        [TestMethod]
        public async void TestEmployeeConsultRespones()
        {
            EmployeeLogicBusiness bll = new EmployeeLogicBusiness();
            EmployeesDataModel result = new EmployeesDataModel();
            int idEmployee = 1;
            result = await bll.GetInformationEmployees(idEmployee);
            Assert.IsTrue(result.data.Count > 0);
        }

        [TestMethod]
        public async void TestEmployeeSalary() 
        {
            EmployeeLogicBusiness bll = new EmployeeLogicBusiness();
            EmployeesDataModel result = new EmployeesDataModel();
            int idEmployee = 1;
            result = await bll.GetInformationEmployees(idEmployee);
            Assert.AreEqual(result.data[0].employee_anual_salary, result.data[0].employee_salary * 12);
        }
    }
}

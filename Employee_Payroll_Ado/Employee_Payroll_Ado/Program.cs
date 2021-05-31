using EmployeePayrollADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Payroll_Ado
{
    /// <summary>
    /// Entry point of the Program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Employee Payroll Services Using ADO.NET");
            //Creating a instance object of EmployeeRepository class.
            Inputdata();//uc3


            //  repository.EnsureDataBaseConnection();
           
            // repository.GetAllEmployeeData();
            Console.ReadLine();
        }

        public static void Inputdata()
        {
            EmployeeRepository repository = new EmployeeRepository();
            EmployeeModel model = new EmployeeModel();
          
            model.EmployeeName = "Nilima";
            model.Address = "Wadal";
            model.BasicPay = 70000;
            model.Deductions = 500;
            model.Department = "It";
            model.Gender = "F";
            model.PhoneNumber = 9090898787;
            model.NetPay = 73000;
            model.Tax = 1000;
            model.StartDate = DateTime.Now;
            model.TaxablePay = 500;

            repository.AddEmployee(model);
        }
    }
}
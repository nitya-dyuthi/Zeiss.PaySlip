using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zeiss.DataAccess
{
    public class PayDA
    {
        
        public int GetBasicPay(string empID, Int16 month, Int16 year)
        {
            //connect to db
            //execute stored proc - best practice/query
            //get basic pay
            //close connection
            return 10000;
        }
    }

    public class EmployeeDA
    {
        public string empID, firstName, lastName, DOJ;
        public EmployeeDA GetEmployeeDetails(string empID)
        {
            //connect to db
            //execute sp/qury
            //get emp deets to emp instance and return emp
            EmployeeDA emp = new EmployeeDA();
            emp.empID = "M123";
            emp.firstName = "Raj";
            emp.lastName = "Kumar";
            emp.DOJ = "01-05-2016";
            return emp;
        }
    }
}

//get hra, lta, etc.

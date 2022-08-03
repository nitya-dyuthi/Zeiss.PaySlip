using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.BL;
namespace Zeiss.PaySlip
{
    public class PaySlip
    {
        string empID;
        string firstName;
        string lastName;
        string department;
        DateTime DOJ;
        short month, year;
        int basicPay, DA, HRA, LTA, PF, profTax, incomeTax, loan;
        
        public void PrintPaySlip(string empID, short month, short year)
        {
            Console.WriteLine("Payslip for:" + year.ToString() + ", " + month.ToString());
            
            EmployeeBL emp = new EmployeeBL();
            Console.WriteLine(emp.firstName);
            emp = emp.GetEmpDetails(empID);
            Console.WriteLine("Employee ID:" + empID + "Name: " + emp.firstName + " " + emp.lastName + " Date of Joining: " + emp.DOJ);
        }
    }
    
}

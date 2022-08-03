using Zeiss.DataAccess;
namespace Zeiss.BL
{
    public class PayBL
    {
        public int GetBasicPay(string empID, Int16 month, Int16 year)
        {
            PayDA payda = new DataAccess.PayDA();
            int basicPay = payda.GetBasicPay(empID, month, year);
            return basicPay;
        }
        public int CalculateDA(string empID, Int16 month, Int16 year)
        {
            int basicPay = GetBasicPay(empID, month, year);
            int da = 0;
            if (basicPay > 25000)
                da = basicPay * 30 / 100;
            else
                da = basicPay * 40 / 100;
            return da;
        }
    }

    public class EmployeeBL
    {
        public string empID, firstName, lastName, DOJ;
        public EmployeeBL GetEmpDetails(string empID)
        {
            EmployeeDA emp1 = new EmployeeDA();
            emp1.GetEmployeeDetails(empID);
            EmployeeBL emp2 = new EmployeeBL();
            emp2.empID = emp1.empID;
            emp2.firstName = emp1.firstName;
            emp2.lastName = emp1.lastName;
            emp2.DOJ = emp1.DOJ;
            return emp2;
        }
    }
}
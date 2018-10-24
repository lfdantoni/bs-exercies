
using ProfPracN1.Enums;
using ProfPracN1.Helpers;

namespace ProfPracN1.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public JobTitleEnum JobTitle { get; set; }
        public string JobTitleDescription { get { return EmployeeHelper.GetJobTitleDescription(JobTitle); } }
        public double Salary1 { get; set; }
        public double Salary2 { get; set; }
        public double Salary3 { get; set; }
        public double Total { get { return Salary1 + Salary2 + Salary3; } }
        public double Average { get { return Total / 3; } }
    }
}

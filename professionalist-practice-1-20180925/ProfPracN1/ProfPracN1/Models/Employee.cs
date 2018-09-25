
using ProfPracN1.Enums;

namespace ProfPracN1.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public JobTitleEnum JobTitle { get; set; }
        public double Salary1 { get; set; }
        public double Salary2 { get; set; }
        public double Salary3 { get; set; }
    }
}

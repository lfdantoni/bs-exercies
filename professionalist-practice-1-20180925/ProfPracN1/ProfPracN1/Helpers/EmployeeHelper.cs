using ProfPracN1.Enums;
using System.Collections.Generic;

namespace ProfPracN1.Helpers
{
    public static class EmployeeHelper
    {
        public static Dictionary<JobTitleEnum, string> GetAllJobTitleDescriptions()
        {
            return new Dictionary<JobTitleEnum, string>()
            {
                {JobTitleEnum.Administrative, "Administrativo"},
                {JobTitleEnum.Instructor, "Instructor"},
                {JobTitleEnum.Manager, "Gerente"}
            };
        }
    }
}

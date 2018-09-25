using ProfPracN1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

using ProfPracN1.Enums;
using System.Collections.Generic;

namespace ProfPracN1.Helpers
{
    public static class EmployeeHelper
    {
        public static Dictionary<JobTitleComboOptionsEnum, string> GetComboJobTitleOptions()
        {
            return new Dictionary<JobTitleComboOptionsEnum, string>()
            {
                {JobTitleComboOptionsEnum.NotSelected, string.Empty},
                {JobTitleComboOptionsEnum.Administrative, "Administrativo"},
                {JobTitleComboOptionsEnum.Instructor, "Instructor"},
                {JobTitleComboOptionsEnum.Manager, "Gerente"}
            };
        }

        public static JobTitleEnum? GetJobTitle(JobTitleComboOptionsEnum option)
        {
            switch (option)
            {
                case JobTitleComboOptionsEnum.Manager:
                    return JobTitleEnum.Manager;
                case JobTitleComboOptionsEnum.Administrative:
                    return JobTitleEnum.Administrative;
                case JobTitleComboOptionsEnum.Instructor:
                    return JobTitleEnum.Instructor;
                default:
                    return null;
            }
        }
    }
}

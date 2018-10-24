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
                {JobTitleComboOptionsEnum.CleaningStuff, "Operario de Limpieza"},
                {JobTitleComboOptionsEnum.GeneralStuff, "Operario General"},
                {JobTitleComboOptionsEnum.Painter, "Pintor"}
            };
        }

        public static JobTitleEnum? GetJobTitle(JobTitleComboOptionsEnum option)
        {
            switch (option)
            {
                case JobTitleComboOptionsEnum.Painter:
                    return JobTitleEnum.Painter;
                case JobTitleComboOptionsEnum.CleaningStuff:
                    return JobTitleEnum.CleaningStuff;
                case JobTitleComboOptionsEnum.GeneralStuff:
                    return JobTitleEnum.GenenralStaff;
                default:
                    return null;
            }
        }

        public static string GetJobTitleDescription(JobTitleEnum jobTitle)
        {
            switch (jobTitle)
            {
                case JobTitleEnum.Painter:
                    return "Pintor";
                case JobTitleEnum.CleaningStuff:
                    return "Operario de Limpieza";
                case JobTitleEnum.GenenralStaff:
                    return "Operario General";
                default:
                    return string.Empty;
            }
        }
    }
}

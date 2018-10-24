using System;

namespace ProfPracN1.Models
{
    public class Task
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int DeliveryDays { get; set; }
        public DateTime DeliveryDate {
            get
            {
                return Date.AddDays(DeliveryDays);
            }
        }
    }
}

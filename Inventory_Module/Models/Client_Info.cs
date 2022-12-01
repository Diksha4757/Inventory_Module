using System.ComponentModel.DataAnnotations;

namespace Inventory_Module.Models
{
    public class Client_Info
    {
        [Key]
        public int client_id { get; set; }
        public int global_id { get; set; }
        public string client_name { get; set; }
        public string client_code { get; set; }
        public string client_business_name { get; set; }
        public string client_GSTNo { get; set; }
        public string client_contact { get; set; }
        public string client_reference_contact { get; set; }
        public string client_reference_name { get; set; }
        public string client_business_description { get; set; }
        public int  pincode { get; set; }
        public string country_code { get; set; }
        public int country_id { get; set; }
        public int state_id { get; set; }
        public int city_id { get; set; }
        public string client_logo { get; set; }
        public string Pan_No { get; set; }
        public int  IsDeleted { get; set; }
        public DateTime Client_Enrollment_Date { get; set; }
        public string Subscription_period { get; set; }
        


    }
}

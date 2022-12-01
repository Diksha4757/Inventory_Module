using System.ComponentModel.DataAnnotations;

namespace Inventory_Module.Models
{
    public class Log_maintain_class
    {
        [Key]
        public int error_id { get; set; }
        //public int global_id { get; set; }
        //public int client_id { get; set; }
        public string? error_line_number { get; set; }
        public string? error_trace { get; set; }
        public string ? error_messege { get; set; }
        public string ? error_inner_exception { get; set; }
        public string? error_data { get; set; }
        public DateTime? created_date { get; set; }
    }
}

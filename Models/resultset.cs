using System.ComponentModel.DataAnnotations;

namespace trampo.Models
{
 public class resultset
    {
        [Key]
        public dynamic data { get; set; }
        public string message { get; set; }
        public bool isSuccess { get; set; }
        public string exceptionMessage { get; set; }
    }
}
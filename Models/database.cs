
using System.ComponentModel.DataAnnotations;

namespace trampo.Models
{
   
    public class database {

       [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string date { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string pass { get; set; }
    }
}
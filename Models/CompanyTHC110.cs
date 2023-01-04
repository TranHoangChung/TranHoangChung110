using System.ComponentModel.DataAnnotations;
namespace TranHoangChung110.Models
{
    public class ComapyTHC110
    {
        [Key]
        public string? CompanyID {get; set;}
        public string? CompanyName {get; set;} 
    }
}
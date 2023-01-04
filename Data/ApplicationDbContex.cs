using TranHoangChung110.Models;
using Microsoft.EntityFrameworkCore;

namespace TranHoangChung110.Data
{
    public class ApplicationDbContex : DbContext
    {
        public ApplicationDbContex (DbContextOptions<ApplicationDbContex>options) : base(options)

        {

        }
        public DbSet<ComapyTHC110>CompanyTHC110 {get; set;} = default!;
       
    }
}
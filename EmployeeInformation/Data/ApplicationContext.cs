using EmployeeInformation.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeInformation.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Employee_Details> Employee_Details { get; set; }
    }
}

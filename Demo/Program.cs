using Demo.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnterpriseDbContext dbContext = new EnterpriseDbContext();
            //dbContext.Database.Migrate();
        }
    }
}

using EfDoctorWho;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class ApplicationContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
   optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-IUL55L7\SQLEXPRESS;Initial Catalog=DoctorWhoCore;Integrated Security=True");
        }
    }
}

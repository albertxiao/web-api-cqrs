using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiCQRS.Models;

namespace WebApiCQRS.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }
        Task<int> SaveChanges();
    }
}

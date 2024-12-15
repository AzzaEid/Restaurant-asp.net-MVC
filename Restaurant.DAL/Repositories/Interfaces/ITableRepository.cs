using Restaurant.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Repositories
{
    public interface ITableRepository
    {
        Task<List<Table>> GetAllTables();
        Task<Table> GetTableById(int Id);
        Task AddTable(Table table);
        Task DeleteTable(int Id);
        Task UpdateTable(Table table);


    }
}

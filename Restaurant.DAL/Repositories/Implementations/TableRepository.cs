using Microsoft.EntityFrameworkCore;
using Restaurant.DAL.Models;
using Restaurant.PL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Repositories
{
    public class TableRepository : ITableRepository
    {
 
        private readonly ApplicationDbContext _context;

        public TableRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Table>> GetAllTables()
        {
            return await _context.Tables.ToListAsync();        }

        public async Task<Table?> GetTableById(int id)
        {
            return await  _context.Tables.FindAsync(id);
        }


        public async Task AddTable(Table table)
        {
            await _context.Tables.AddAsync(table);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTable(Table table)
        {
            _context.Tables.Update(table);
            await _context.SaveChangesAsync();
        }
        /* we cannot add this method especially becuase EF keep the object tracked */

        public async Task DeleteTable(int id)
        {
            var table = await GetTableById(id);
            if (table != null)
            {
                _context.Tables.Remove(table);
                await _context.SaveChangesAsync();
            }
        }
    }

    
}

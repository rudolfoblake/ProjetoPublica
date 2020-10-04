using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BackEnd.Models;

namespace BackEnd.Context
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;
    
        public Repository(DataContext context)
        {
            this._context = context;
        }

        public void Add<T>(T entity) where T : class 
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<TabelaJogo[]> GetAllJogosAsync()
        {
            IQueryable<TabelaJogo> query = _context.TabelaJogo;

            query = query.AsNoTracking().OrderBy(tb => tb.Id);

            return await query.ToArrayAsync();
        }

        public async Task<TabelaJogo> GetJogoAsyncById(int jogoId)
        {
            IQueryable<TabelaJogo> query = _context.TabelaJogo;
                                   
            query = query.AsNoTracking()
                         .OrderBy(tb => tb.Id)
                         .Where(tb => tb.Id == jogoId);

            return await query.FirstOrDefaultAsync();
        }                
    }
}
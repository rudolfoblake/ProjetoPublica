
using System.Threading.Tasks;
using BackEnd.Models;
using System;

namespace BackEnd.Context
{
    public interface IRepository
    {
        // Geral

        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        // TabelaJogo

        Task<TabelaJogo[]> GetAllJogosAsync(); 
        Task<TabelaJogo> GetJogoAsyncById(int jogoId);
       
    }
}



 
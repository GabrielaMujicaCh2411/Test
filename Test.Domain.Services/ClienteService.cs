using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Model.DbModel;

namespace Test.Domain.Services
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> TodosAsync();

        Task<Cliente> ObtenerPorIdAsync(int id);

        Task<Cliente> ActualizarAsync(Cliente entity);

        Task<bool> EliminarAsync(Cliente entity);
    }
   
    public class ClienteService : IClienteService
    {
        private readonly TestContext _context;

        public ClienteService(TestContext context)
        {
            this._context = context;
        }

        public Task<Cliente> ActualizarAsync(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarAsync(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Cliente> ObtenerPorIdAsync(int id)
        {
            return await _context.Cliente.FirstOrDefaultAsync(m => m.ClienteId == id);
        }

        public async Task<IEnumerable<Cliente>> TodosAsync()
        {
            return await _context.Cliente.ToListAsync();
        }
    }
}

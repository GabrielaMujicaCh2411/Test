using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Model.DbModel;

namespace Test.Domain.Services
{
    public interface IEmpleadoService
    {
        Task<IEnumerable<Empleado>> TodosAsync();

        Task<Empleado> ObtenerPorIdAsync(int id);

        Task<Empleado> ActualizarAsync(Empleado entity);

        Task<bool> EliminarAsync(Empleado entity);
    }

    public class EmpleadoService : IEmpleadoService
    {
        private readonly TestContext _context;

        public EmpleadoService(TestContext context)
        {
            this._context = context;
        }

        public Task<Empleado> ActualizarAsync(Empleado entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarAsync(Empleado entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Empleado> ObtenerPorIdAsync(int id)
        {
            return await _context.Empleado.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Empleado>> TodosAsync()
        {
            return await _context.Empleado.ToListAsync();
        }
    }
}

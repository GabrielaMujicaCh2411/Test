using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Domain.Model.DbModel;

namespace Test.Domain.Services
{
    public interface ICargoService
    {
        Task<IEnumerable<Cargo>> TodosAsync();
    }

    public class CargoService : ICargoService
    {
        public Task<IEnumerable<Cargo>> TodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Domain.Model.DbModel;

namespace Test.Domain.Services
{
    public interface ICargoService
    {
        Task<IEnumerable<Compra>> TodosAsync();
    }

    public class CompraService : ICargoService
    {
        public Task<IEnumerable<Compra>> TodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}

using API_PetCare_Connect.Data.Models;

namespace API_PetCare_Connect.Repository.IRepository;

public interface IClienteRepository : IRepository<Cliente>
{
    Task<Cliente?> GetByDniAsync(string dni);
}

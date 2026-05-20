using API_PetCare_Connect.Data.Models;

namespace API_PetCare_Connect.Repository.IRepository;

public interface IProductoRepository : IRepository<Producto>
{
    Task<List<Producto>> SearchByNameAsync(string name);
}

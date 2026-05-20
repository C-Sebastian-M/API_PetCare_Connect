using API_PetCare_Connect.Data.Models;

namespace API_PetCare_Connect.Repository.IRepository;

public interface IInventarioSedeRepository : IRepository<InventarioSede>
{
    Task<InventarioSede?> GetByProductoAndSedeAsync(int productoId, int sedeId);
}

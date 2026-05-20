using API_PetCare_Connect.Data.Models;

namespace API_PetCare_Connect.Repository.IRepository;

public interface IMovimientoInventarioRepository : IRepository<MovimientoInventario>
{
    Task<List<MovimientoInventario>> GetByProductoIdAsync(int productoId);
    Task<List<MovimientoInventario>> GetBySedeIdAsync(int sedeId);
}

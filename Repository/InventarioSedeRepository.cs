using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class InventarioSedeRepository : Repository<InventarioSede>, IInventarioSedeRepository
{
    private readonly PetCareConnectContext _context;

    public InventarioSedeRepository(PetCareConnectContext context) : base(context)
    {
        _context = context;
    }

    public async Task<InventarioSede?> GetByProductoAndSedeAsync(int productoId, int sedeId)
    {
        return await _context.InventarioSedes
            .FirstOrDefaultAsync(i => i.IdProducto == productoId && i.IdSede == sedeId);
    }
}

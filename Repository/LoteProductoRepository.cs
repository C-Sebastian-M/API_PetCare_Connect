using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class LoteProductoRepository : Repository<LoteProducto>, ILoteProductoRepository
{
    private readonly PetCareConnectContext _context;

    public LoteProductoRepository(PetCareConnectContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<LoteProducto>> GetByProductoIdAsync(int productoId)
    {
        return await _context.LoteProductos
            .Where(l => l.IdProducto == productoId)
            .ToListAsync();
    }
}

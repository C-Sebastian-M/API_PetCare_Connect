using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class MovimientoInventarioRepository : Repository<MovimientoInventario>, IMovimientoInventarioRepository
{
    private readonly PetCareConnectContext _context;

    public MovimientoInventarioRepository(PetCareConnectContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<MovimientoInventario>> GetByProductoIdAsync(int productoId)
    {
        return await _context.MovimientoInventarios
            .Where(m => m.IdProducto == productoId)
            .OrderByDescending(m => m.FechaMovimiento)
            .ToListAsync();
    }

    public async Task<List<MovimientoInventario>> GetBySedeIdAsync(int sedeId)
    {
        return await _context.MovimientoInventarios
            .Where(m => m.IdSede == sedeId)
            .OrderByDescending(m => m.FechaMovimiento)
            .ToListAsync();
    }
}

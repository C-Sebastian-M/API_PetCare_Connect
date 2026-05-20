using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class ProductoRepository : Repository<Producto>, IProductoRepository
{
    private readonly PetCareConnectContext _context;

    public ProductoRepository(PetCareConnectContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Producto>> SearchByNameAsync(string name)
    {
        return await _context.Productos
            .Where(p => p.NombreProducto.Contains(name))
            .ToListAsync();
    }
}

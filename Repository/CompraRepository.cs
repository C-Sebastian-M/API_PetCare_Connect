using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class CompraRepository : Repository<Compra>, ICompraRepository
{
    private readonly PetCareConnectContext _context;

    public CompraRepository(PetCareConnectContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Compra>> GetByProveedorIdAsync(int proveedorId)
    {
        return await _context.Compras.Where(c => c.IdProveedor == proveedorId).ToListAsync();
    }
}

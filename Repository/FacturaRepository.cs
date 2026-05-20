using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class FacturaRepository : Repository<Factura>, IFacturaRepository
{
    private readonly PetCareConnectContext _context;

    public FacturaRepository(PetCareConnectContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Factura>> GetByClienteIdAsync(int clienteId)
    {
        return await _context.Facturas.Where(f => f.IdCliente == clienteId).ToListAsync();
    }
}

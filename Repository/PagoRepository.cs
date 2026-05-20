using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class PagoRepository : Repository<Pago>, IPagoRepository
{
    private readonly PetCareConnectContext _context;

    public PagoRepository(PetCareConnectContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Pago>> GetByFacturaIdAsync(int facturaId)
    {
        return await _context.Pagos.Where(p => p.IdFactura == facturaId).ToListAsync();
    }
}

using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class MascotaRepository : Repository<Mascotum>, IMascotaRepository
{
    private readonly PetCareConnectContext _context;

    public MascotaRepository(PetCareConnectContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Mascotum>> GetByClienteIdAsync(int clienteId)
    {
        return await _context.Mascota.Where(m => m.IdCliente == clienteId).ToListAsync();
    }
}

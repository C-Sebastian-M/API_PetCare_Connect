using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class ConsultaRepository : Repository<Consultum>, IConsultaRepository
{
    private readonly PetCareConnectContext _context;

    public ConsultaRepository(PetCareConnectContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Consultum>> GetByMascotaIdAsync(int mascotaId)
    {
        return await _context.Consulta.Where(c => c.IdMascota == mascotaId).ToListAsync();
    }
}

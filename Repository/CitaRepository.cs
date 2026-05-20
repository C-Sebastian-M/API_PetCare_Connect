using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class CitaRepository : Repository<Citum>, ICitaRepository
{
    private readonly PetCareConnectContext _context;

    public CitaRepository(PetCareConnectContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Citum>> GetByMascotaIdAsync(int mascotaId)
    {
        return await _context.Cita.Where(c => c.IdMascota == mascotaId).ToListAsync();
    }

    public async Task<List<Citum>> GetByEmpleadoIdAsync(int empleadoId)
    {
        return await _context.Cita.Where(c => c.IdEmpleado == empleadoId).ToListAsync();
    }
}

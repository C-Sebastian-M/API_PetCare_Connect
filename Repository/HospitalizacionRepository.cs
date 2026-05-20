using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class HospitalizacionRepository : Repository<Hospitalizacion>, IHospitalizacionRepository
{
    private readonly PetCareConnectContext _context;

    public HospitalizacionRepository(PetCareConnectContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Hospitalizacion>> GetByMascotaIdAsync(int mascotaId)
    {
        return await _context.Hospitalizacions.Where(h => h.IdMascota == mascotaId).ToListAsync();
    }
}

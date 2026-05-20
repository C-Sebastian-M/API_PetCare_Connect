using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class JaulaRepository : Repository<Jaula>, IJaulaRepository
{
    private readonly PetCareConnectContext _context;

    public JaulaRepository(PetCareConnectContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Jaula>> GetBySedeIdAsync(int sedeId)
    {
        return await _context.Jaulas.Where(j => j.IdSede == sedeId).ToListAsync();
    }
}

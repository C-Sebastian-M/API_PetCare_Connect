using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class MedicamentoRepository : Repository<Medicamento>, IMedicamentoRepository
{
    private readonly PetCareConnectContext _context;

    public MedicamentoRepository(PetCareConnectContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<Medicamento>> GetByProductoIdAsync(int productoId)
    {
        return await _context.Medicamentos
            .Where(m => m.IdProducto == productoId)
            .ToListAsync();
    }
}

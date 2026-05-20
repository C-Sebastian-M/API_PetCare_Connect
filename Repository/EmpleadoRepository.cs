using Microsoft.EntityFrameworkCore;
using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
{
    private readonly PetCareConnectContext _context;

    public EmpleadoRepository(PetCareConnectContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Empleado?> GetByDniAsync(string dni)
    {
        return await _context.Empleados.FirstOrDefaultAsync(e => e.DniEmpleado == dni);
    }

    public async Task<List<Empleado>> GetBySedeIdAsync(int sedeId)
    {
        return await _context.Empleados.Where(e => e.IdSede == sedeId).ToListAsync();
    }
}

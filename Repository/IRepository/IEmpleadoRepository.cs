using API_PetCare_Connect.Data.Models;

namespace API_PetCare_Connect.Repository.IRepository;

public interface IEmpleadoRepository : IRepository<Empleado>
{
    Task<Empleado?> GetByDniAsync(string dni);
    Task<List<Empleado>> GetBySedeIdAsync(int sedeId);
}

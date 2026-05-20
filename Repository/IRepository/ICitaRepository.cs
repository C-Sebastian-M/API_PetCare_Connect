using API_PetCare_Connect.Data.Models;

namespace API_PetCare_Connect.Repository.IRepository;

public interface ICitaRepository : IRepository<Citum>
{
    Task<List<Citum>> GetByMascotaIdAsync(int mascotaId);
    Task<List<Citum>> GetByEmpleadoIdAsync(int empleadoId);
}

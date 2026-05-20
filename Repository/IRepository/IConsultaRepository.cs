using API_PetCare_Connect.Data.Models;

namespace API_PetCare_Connect.Repository.IRepository;

public interface IConsultaRepository : IRepository<Consultum>
{
    Task<List<Consultum>> GetByMascotaIdAsync(int mascotaId);
}

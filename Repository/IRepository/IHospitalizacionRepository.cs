using API_PetCare_Connect.Data.Models;

namespace API_PetCare_Connect.Repository.IRepository;

public interface IHospitalizacionRepository : IRepository<Hospitalizacion>
{
    Task<List<Hospitalizacion>> GetByMascotaIdAsync(int mascotaId);
}

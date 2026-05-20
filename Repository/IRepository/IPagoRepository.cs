using API_PetCare_Connect.Data.Models;

namespace API_PetCare_Connect.Repository.IRepository;

public interface IPagoRepository : IRepository<Pago>
{
    Task<List<Pago>> GetByFacturaIdAsync(int facturaId);
}

using API_PetCare_Connect.Data.Models;

namespace API_PetCare_Connect.Repository.IRepository;

public interface IMedicamentoRepository : IRepository<Medicamento>
{
    Task<List<Medicamento>> GetByProductoIdAsync(int productoId);
}

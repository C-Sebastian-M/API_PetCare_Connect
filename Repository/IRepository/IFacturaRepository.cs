using API_PetCare_Connect.Data.Models;

namespace API_PetCare_Connect.Repository.IRepository;

public interface IFacturaRepository : IRepository<Factura>
{
    Task<List<Factura>> GetByClienteIdAsync(int clienteId);
}

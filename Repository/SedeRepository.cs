using API_PetCare_Connect.Data.Models;
using API_PetCare_Connect.Repository.IRepository;

namespace API_PetCare_Connect.Repository;

public class SedeRepository : Repository<Sede>, ISedeRepository
{
    public SedeRepository(PetCareConnectContext context) : base(context)
    {
    }
}

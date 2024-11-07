using Kreata.Backend.Datas.Entities;
using Kreta.Backend.Datas.REsponses;

namespace Kreata.Backend.Repos
{
    public interface IParentRepo
    {
        Task<List<Parent>> GetAll();
        Task<Parent?> GetBy(Guid id);
        Task<ControllerResponse> UpdateParentAsync(Parent Parent);
    }
}

using Kreata.Backend.Datas.Entities;
using Kreta.Backend.Datas.REsponses;
using System.Threading.Tasks;

namespace Kreata.Backend.Repos
{
    public interface ITeacherRepo
    {
        Task<List<Teacher>> GetAll();
        Task<Teacher?> GetBy(Guid id);

        Task<ControllerResponse> UpdateTeacherAsync(Teacher teacher);
    }
}
using Kreata.Backend.Datas.Entities;
using Kreta.Backend.Datas.REsponses;

namespace Kreata.Backend.Repos
{
    public interface IStudentRepo
    {
        Task<List<Student>> GetAll();
        Task<Student?> GetBy(Guid id);
        Task<ControllerResponse> UpdateStudentAsync(Student student);
    }
}

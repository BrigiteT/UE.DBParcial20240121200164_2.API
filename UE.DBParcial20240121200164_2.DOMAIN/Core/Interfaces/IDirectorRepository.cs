using UE.DBParcial20240121200164_2.DOMAIN.Core.Entities;

namespace UE.DBParcial20240121200164_2.DOMAIN.Core.Interfaces
{
    public interface IDirectorRepository
    {
        Task<bool> Create(Director director);
        Task<bool> Delete(int id);
        Task<IEnumerable<Director>> GetAll();
        Task<Director> GetById(int id);
        Task<bool> Update(Director director);
    }
}
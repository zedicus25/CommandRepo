using WildNature_Back.Models;

namespace WildNature_Back.Configuration
{
    public interface IController<T> where T : class
    {
        Task<List<T>> Add(T t);
        Task<List<T>> Edit(int id, string newName);
        Task<List<T>> Remove(int id);
        Task<List<T>> Select();
    }
}

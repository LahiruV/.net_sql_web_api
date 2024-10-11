using Zenra_Web_API.Models;

namespace Zenra_Web_API.Services.IServices
{
    public interface IYourEntityService
    {
        IEnumerable<YourEntity> GetAll();
        YourEntity GetById(int id);
        void Create(YourEntity entity);
        void Update(YourEntity entity);
        void Delete(int id);
    }
}

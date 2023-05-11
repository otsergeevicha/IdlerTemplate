using Services.ServiceLocator;

namespace Services.SaveLoadLogic
{
    public interface ISave : IService
    {
        void Save();
    }
}
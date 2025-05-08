using IMS.CoreBusiness;

namespace IMS.UseCases.Inventories.Interfaces
{
    public interface IViewInventoriesByUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}
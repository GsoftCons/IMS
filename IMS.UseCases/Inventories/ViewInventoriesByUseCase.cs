using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories
{
    public class ViewInventoriesByUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoriesByUseCase(IInventoryRepository invetoryRepository)
        {
            this.inventoryRepository = invetoryRepository;
        }



        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name= "")
        {
            return await inventoryRepository.GetInventoriesByNameAsync(name);
        }
    }
}

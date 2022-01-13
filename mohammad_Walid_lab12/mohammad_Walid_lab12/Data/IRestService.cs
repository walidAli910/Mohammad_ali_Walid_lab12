using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mohammad_Walid_lab12.Droid.Models;

namespace mohammad_Walid_lab12.Droid.Data
{
    interface IRestService
    {
        public interface IRestService
        {
            Task<List<ShopList>> RefreshDataAsync();
            Task SaveShopListAsync(ShopList item, bool isNewItem);
            Task DeleteShopListAsync(int id);
        }
    }
}
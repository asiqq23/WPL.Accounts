using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WPL.Accounts.Services
{
    public interface IOrderService
    {
        Task<List<Order>> GeOrders();
    }

    public class OrderService : IOrderService
    {
        public async Task<List<Order>> GeOrders()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("http://order-service:3333/api/orders");

                var stringData = await response.Content.ReadAsStringAsync();
                var orders = JsonConvert.DeserializeObject<List<Order>>(stringData);

                return orders;
            }
        }
    }
}
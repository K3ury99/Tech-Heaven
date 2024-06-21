using Tienda.Domain.Entities;

namespace Tienda.Domain.Repository
{
    public interface IOrderRepository
    {
        Orden GetOrderById(int orderId);
        IEnumerable<Orden> GetOrdersByCustomerId(int customerId);
        void AddOrder(Orden order);
        void UpdateOrder(Orden order);
        void DeleteOrder(int orderId);
    }
}

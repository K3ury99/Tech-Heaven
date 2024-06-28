using Tienda.Domain.Entities;

namespace Tienda.Domain.Repository
{
    public interface IClienteRepository
    {
        ClienteException GetCustomerById(int customerId);
        ClienteException GetCustomerByEmail(string email);
        void AddCustomer(ClienteException customer);
        void UpdateCustomer(ClienteException customer);
        void DeleteCustomer(int customerId);
    }
}

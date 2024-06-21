using Tienda.Domain.Entities;

namespace Tienda.Domain.Repository
{
    public interface ICustomerRepository
    {
        Cliente GetCustomerById(int customerId);
        Cliente GetCustomerByEmail(string email);
        void AddCustomer(Cliente customer);
        void UpdateCustomer(Cliente customer);
        void DeleteCustomer(int customerId);
    }
}

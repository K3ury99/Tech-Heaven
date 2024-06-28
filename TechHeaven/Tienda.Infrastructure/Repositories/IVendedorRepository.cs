using Tienda.Domain.Entities;

namespace Tienda.Domain.Repository
{
    public interface IVendedorRepository
    {
        VendedorException GetVendedorById(int vendedorId);
        VendedorException GetVendedorByEmail(string email);
        void AddVendedor(VendedorException vendedor);
        void UpdateVendedor(VendedorException vendedor);
        void DeleteVendedor(int vendedorId);
    }
}

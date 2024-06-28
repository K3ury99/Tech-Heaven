using Tienda.Domain.Entities;

namespace Tienda.Domain.Repository
{
    public interface ISucursalRepository
    {
        SucursalException GetSucursalById(int sucursalId);
        SucursalException GetSucursalByNombre(string nombre);
        void AddSucursal(SucursalException sucursal);
        void UpdateSucursal(SucursalException sucursal);
        void DeleteSucursal(int sucursalId);
    }
}

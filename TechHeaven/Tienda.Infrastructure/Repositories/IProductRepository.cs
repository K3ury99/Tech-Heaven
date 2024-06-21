using Tienda.Domain.Entities;

namespace Tienda.Domain.Repository
{
    public interface IProductRepository
    {
        Producto GetProductById(int productId);
        IEnumerable<Producto> GetProductsByCategoryId(int categoryId);
        void AddProduct(Producto product);
        void UpdateProduct(Producto product);
        void DeleteProduct(int productId);
    }
}

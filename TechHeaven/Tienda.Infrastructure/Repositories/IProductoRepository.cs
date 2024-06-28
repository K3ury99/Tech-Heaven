using Tienda.Domain.Entities;

namespace Tienda.Domain.Repository
{
    public interface IProductoRepository
    {
        ProductoException GetProductById(int productId);
        IEnumerable<ProductoException> GetProductsByCategoryId(int categoryId);
        void AddProduct(ProductoException product);
        void UpdateProduct(ProductoException product);
        void DeleteProduct(int productId);
    }
}

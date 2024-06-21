using Tienda.Domain.Entities;

namespace Tienda.Domain.Repository
{
    public interface ICategoryRepository
    {
        Categoria GetCategoryById(int categoryId);
        IEnumerable<Categoria> GetAllCategories();
        void AddCategory(Categoria category);
        void UpdateCategory(Categoria category);
        void DeleteCategory(int categoryId);
    }
}

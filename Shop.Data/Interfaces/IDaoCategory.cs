

using Shop.Data.Entities;

namespace Shop.Data.Interfaces
{
    public interface IDaoCategory
    {
        List<Category> GetCategories();
        Category GetCategory(int Id);
        void SaveCategory(Category category);
        void UpdateCategory(Category category);
        void RemoveCategory(Category category);
    }
}

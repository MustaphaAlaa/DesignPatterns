namespace Facade;

public class CreateCategory : ICreateCategory
{
    private List<Category> _categories;

    public CreateCategory(List<Category> categories)
    {
        _categories = categories;
    }

    public void Create(Category category)
    {
        _categories.Add(category);
    }
}
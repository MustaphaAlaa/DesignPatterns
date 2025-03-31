namespace Facade;

public class GetAllCategories : IGetAllCategories
{
    private List<Category> _categories;

    public GetAllCategories(List<Category> categories)
    {
        _categories = categories;
    }

    public List<Category> GetAll()
    {
        return _categories;
    }
}

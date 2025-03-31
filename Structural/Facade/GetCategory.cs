namespace Facade;

public class GetCategory : IGetCategory
{
    private List<Category> _categories;

    public GetCategory(List<Category> categories)
    {
        _categories = categories;
    }


    public Category Get(int id)
    {
        return _categories.Find(c => c.Id == id);
    }
}

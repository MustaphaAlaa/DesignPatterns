namespace Facade;

public class DeleteCategory : IDeleteCategory
{
    private List<Category> _categories;

    public DeleteCategory(List<Category> categories)
    {
        _categories = categories;
    }

    public bool Delete(int id)
    {
        var category = _categories.Find(c => c.Id == id);
        if (category != null)
        {
            if (_categories.Remove(category)) ;
            return true;
        }

        else
            return false;
    }
}
namespace Facade;

public class UpdateCategory : IUpdateCategory
{
    private List<Category> _categories;

    public UpdateCategory(List<Category> categories)
    {
        _categories = categories;
    }

    public bool Update(Category UpdateDTO)
    {
        var category = _categories.FindIndex(c => c.Id == UpdateDTO.Id);
        if (category > -1)
        {
            _categories[category].Name = UpdateDTO.Name;
            _categories[category].Description = UpdateDTO.Description;

            return true;
        }
        else
            return false;
    }
}

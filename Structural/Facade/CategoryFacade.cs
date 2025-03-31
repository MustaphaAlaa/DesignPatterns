namespace Facade;

public class CategoryFacade
{
    private List<Category> Categories = new();

    public CategoryFacade()
    {
        //in real world i;ll use Dependency Injection
        _createCategory = new CreateCategory(Categories);
        _updateCategory = new UpdateCategory(Categories);
        _deleteCategory = new DeleteCategory(Categories);
        _getCategory = new GetCategory(Categories);
        _getAllCategories = new GetAllCategories(Categories);
    }

    private ICreateCategory _createCategory;
    private IUpdateCategory _updateCategory;
    private IDeleteCategory _deleteCategory;
    private IGetCategory _getCategory;
    private IGetAllCategories _getAllCategories;

    public void Create(Category category)
    {
        _createCategory.Create(category);
        Console.WriteLine($"{category.Name} Category is Created");
    }

    public void Update(Category category)
    {
        Console.WriteLine(_updateCategory.Update(category) ? $"Category with id {category} is Updated" : "Category Note Found");
    }

    public void Delete(int Id)
    {
        Console.WriteLine(_deleteCategory.Delete(Id) ? $"Category with id {Id} is Deleted" : "Category Note Found");
    }

    public void Get(int Id)
    {
        Category category = _getCategory.Get(Id);
        Console.WriteLine(category.ToString() ?? "Category Not Found");
    }
    

    public void GetAll(){
         if(!Categories.Any())
             Console.WriteLine("No Categories Found");
         
         foreach(var category in Categories)
             Console.WriteLine(category);
    }
}
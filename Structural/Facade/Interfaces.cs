namespace Facade;
 
public interface ICreateCategory
{
    void Create(Category category);
}

public interface IUpdateCategory
{
    bool Update(Category category);
}

public interface IDeleteCategory
{
    bool Delete(int id);
}

public interface IGetCategory
{
    Category Get(int id);
}

public interface IGetAllCategories
{
    List<Category> GetAll();
}

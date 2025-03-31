// See https://aka.ms/new-console-template for more information

using Facade;

 
 
 CategoryFacade categoryFacade = new();
 
 
Category category1 = new()
{
 Id = 18654,
 Name = "Novels",
 Description = "Novel Category",
};

 
Category category2 = new()
{
 Id = 89652,
 Name = "Horrors",
 Description = "Horrrs Category",
};
 
 categoryFacade.Create(category1);
 categoryFacade.Create(category2);
 categoryFacade.Get(category1.Id);
 categoryFacade.Get(category2.Id);
 
 category1.Name = "Criminal Novels"; 
 categoryFacade.Update(category1);

categoryFacade.Delete(category2.Id);


categoryFacade.GetAll();
 
categoryFacade.Delete(category1.Id);
categoryFacade.GetAll();

using System.Diagnostics.Contracts;

namespace FactoryMethod;


public interface INotification
{
    void Notify(string message);
}

 
using System.Text;

namespace Decorator
{
    public interface ICoffee //Base Component and Decorator will implement it
    {
        decimal Cost();
        StringBuilder Description();

    }
}

 
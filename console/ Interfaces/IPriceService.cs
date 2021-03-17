using System.Collections.Generic;

namespace console. Interfaces
{
    public interface IPriceService
    {
        double buyPrice(string[] stockArray);
        List<int> buyDay(string[] stockArray);
        double sellPrice(string[] stockArray);
        List<int> sellDay(string[] stockArray);
    }
}
namespace console. Interfaces
{
    public interface IPriceService
    {
        double buyPrice(string[] stockArray);
        int buyDay(string[] stockArray);
        double sellPrice(string[] stockArray);
        int sellDay(string[] stockArray);
    }
}
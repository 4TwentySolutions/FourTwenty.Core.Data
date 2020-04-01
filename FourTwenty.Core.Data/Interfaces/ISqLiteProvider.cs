namespace FourTwenty.Core.Data.Interfaces
{
    public interface ISqlProvider<out T>
    {
        T GetConnection(bool forceNewConnection = false);
    }
}

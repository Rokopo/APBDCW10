namespace cw10.Service;

public interface IClientService
{
    Task DeleteClientIfHaveNotTrips(int IdClient);
}
using cw10.Dto;

namespace cw10.Service;

public interface ITripsService
{
    Task<tripsGET> getTripsSortedByDate(int page = 1, int pageSize = 10);
    Task PutClientIntoTrip(int IdTrip, clientPOST clientPOST);
}
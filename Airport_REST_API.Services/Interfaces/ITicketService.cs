using Airport_REST_API.DataAccess.Models;

namespace Airport_REST_API.Services.Interfaces
{
    public interface ITicketService : IService<Ticket>
    {
        bool AddObject(Ticket obj);
        bool UpdateObject(int id, Ticket obj);
    }
}

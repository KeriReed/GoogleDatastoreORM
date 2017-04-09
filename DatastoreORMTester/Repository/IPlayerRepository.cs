using System;
using System.Threading.Tasks;
using DatastoreORM.Repository;
using DatastoreORMTester.DAO;

namespace DatastoreORMTester.Repository
{
    public interface IPlayerRepository: IRepository<PlayerDAO, long>
    {
        Task<PlayerDAO[]> GetNewPlayers(int limit, DateTime fromTime);
    }
}

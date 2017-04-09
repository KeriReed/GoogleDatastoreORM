using DatastoreORM;
using DatastoreORM.DAO;

namespace DatastoreORMTester.DAO
{
    [Kind("Country")]
    public class CountryDAO: BaseDAO
    {
        [KindKey(false)]
        public string CountryCode { get; set; }
        public string Name { get; set; }
    }
}

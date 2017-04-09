using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatastoreORM.Repository;
using DatastoreORMTester.DAO;

namespace DatastoreORMTester.Repository
{
    public class CountryRepository : DatastoreRepository<CountryDAO, string>, ICountryRepository
    {
        public CountryRepository(string projectId) : base(projectId)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatastoreORM.Repository;
using DatastoreORMTester.DAO;

namespace DatastoreORMTester.Repository
{
    public interface ICountryRepository: IRepository<CountryDAO, string>
    {
    }
}

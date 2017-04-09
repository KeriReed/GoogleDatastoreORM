using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatastoreORMTester.DAO;
using DatastoreORMTester.Repository;

namespace DatastoreORMTester
{
    public class ORMTester
    {

        private readonly ICountryRepository _countryRepository;
        private readonly IPlayerRepository _playerRepository;

        public ORMTester(string projectId)
        {
            _countryRepository = new CountryRepository(projectId);
            _playerRepository = new PlayerRepository(projectId);
        }

        public async Task<string> AddCountry()
        {
            return await _countryRepository.InsertAsync(new CountryDAO
            {
                CountryCode = "IL",
                Name = "Israel"
            });
        }
        public Task<CountryDAO> GetCountry(string countryCode)
        {
            return _countryRepository.GetByIdAsync(countryCode);
        }

        public async Task<long> AddPlayer()
        {
            return await _playerRepository.InsertAsync(new PlayerDAO
            {
                Name = "Tomer",
                Hobbies = new List<string> { "Play Guitar", "Running"},
                PlayerStatus = PlayerStatus.Active,
                RegisterTime = new DateTime(2017,1,1,0,0,0,DateTimeKind.Utc),
                Score = 100,
                AddressInfo = new AddressInfo
                {
                    CountryCode = "IL",
                    Address = "Street address",
                    ZipCode = "1234dd"
                },
                PlayerSoliders = new List<PlayerSolider>
                {
                    new PlayerSolider
                    {
                        Name = "Solider1",
                        Power = 1
                    },
                    new PlayerSolider
                    {
                        Name = "Solider2",
                        Power = 7
                    }
                }
            });
        }
        public Task<PlayerDAO> GetPlayer(long id)
        {
            return _playerRepository.GetByIdAsync(id);
        }
    }
}

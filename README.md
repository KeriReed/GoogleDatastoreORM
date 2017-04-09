**Google Datastore ORM**

A mini-ORM layer, with the Repository pattern, on top of the Google Datastore db.
Supports async/await.

In order to use it, you should do the following:
1) Create a DAO object - and use the DAOAttributes for meta definitions.
2) Create your "kind" repository and inherit from the DatastoreRepository.
3) Use the base CRUD operations (Create - Insert, Read - GetById , Update, Delete) or use the Query by property name.

See the DatastoreORMTester project as an example.
```
[Kind("Country")]
public class CountryDAO: BaseDAO
{
    [KindKey(false)]
    public string CountryCode { get; set; }
    public string Name { get; set; }
}

public class CountryRepository : DatastoreRepository<CountryDAO, string>, ICountryRepository
{
    public CountryRepository(string projectId) : base(projectId)
    {
    }
}

await _countryRepository.InsertAsync(new CountryDAO
{
    CountryCode = "IL",
    Name = "Israel"
});
```

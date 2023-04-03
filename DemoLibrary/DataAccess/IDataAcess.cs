using DemoLibrary.Models;
using DemoLibrary.ViewModels;

namespace DemoLibrary.DataAccess
{
    public interface IDataAcess
    {
        List<Person> GetPeople();
        Person InsertPerson(PersonVM newPerson);
    }
}
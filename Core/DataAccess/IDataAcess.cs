using Core.Models;
using Core.ViewModels;

namespace Core.DataAccess
{
    public interface IDataAcess
    {
        List<Person> GetPeople();
        Person InsertPerson(PersonViewModel newPerson);
    }
}
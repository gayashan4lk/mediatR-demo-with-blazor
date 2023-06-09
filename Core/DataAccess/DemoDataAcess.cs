﻿using Core.Models;
using Core.ViewModels;

namespace Core.DataAccess
{
    public class DemoDataAcess : IDataAcess
    {
        private List<Person> people = new();

        public DemoDataAcess()
        {
            people.Add(new Person { Id = 1, FirstName = "Johnny", LastName = "Walker" });
            people.Add(new Person { Id = 2, FirstName = "Tim", LastName = "Browney" });
        }

        public List<Person> GetPeople()
        {
            return people;
        }

        public Person InsertPerson(PersonViewModel newPerson)
        {
            Person person = new()
            {
                Id = people.Max(x => x.Id) + 1,
                FirstName = newPerson.FirstName,
                LastName = newPerson.LastName,
            };
            people.Add(person);
            return person;
        }
    }
}

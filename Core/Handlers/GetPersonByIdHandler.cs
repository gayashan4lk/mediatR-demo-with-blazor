﻿using BlazorUI.Application.Queries;
using Core.DataAccess;
using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorUI.Application.Handlers
{
    internal class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, Person>
    {
        private readonly IDataAcess _data;

        public GetPersonByIdHandler(IDataAcess data)
        {
            _data = data;
        }
        public async Task<Person> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            if (request.id < 0)
            {
                return new Person();
            }

            var people = await Task.Run(() => _data.GetPeople());
            var person = people.FirstOrDefault(x => x.Id == request.id);
            return person;
        }
    }
}
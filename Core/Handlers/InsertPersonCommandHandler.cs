using BlazorUI.Application.Commands;
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
    public class InsertPersonCommandHandler : IRequestHandler<InsertPersonCommand, Person>
    {
        private readonly IDataAcess _data;

        public InsertPersonCommandHandler(IDataAcess data)
        {
            _data = data;
        }

        public async Task<Person> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var person = await Task.Run(() => _data.InsertPerson(request.PersonVM));
            return person;
        }
    }
}

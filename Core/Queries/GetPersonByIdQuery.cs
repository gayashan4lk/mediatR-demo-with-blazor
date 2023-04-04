using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorUI.Application.Queries
{
    public record GetPersonByIdQuery(int id) : IRequest<Person>;
    
}

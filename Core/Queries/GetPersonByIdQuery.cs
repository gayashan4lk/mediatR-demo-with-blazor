using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorUI.Application.Queries
{
    public record GetPersonByIdQuery(int Id) : IRequest<Person>;

    //public class GetPersonByIdQuery : IRequest<Person>
    //{
    //    public int Id { get; set; }

    //    public GetPersonByIdQuery(int id)
    //    {
    //        Id = id;
    //    }
    //}
}

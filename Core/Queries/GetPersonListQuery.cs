using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Queries
{
    public record GetPersonListQuery : IRequest<List<Person>>;

    //public class GetPersonListQuery : IRequest<List<Person>>
    //{
    //}
}

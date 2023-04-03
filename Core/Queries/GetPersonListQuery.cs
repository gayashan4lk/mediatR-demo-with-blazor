using Core.Models;
using MediatR;

namespace Core.Queries
{
    public record GetPersonListQuery : IRequest<List<Person>>;

    //public class GetPersonListQuery : IRequest<List<Person>>
    //{
    //}
}

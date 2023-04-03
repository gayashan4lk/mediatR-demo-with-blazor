using Core.DataAccess;
using Core.Models;
using Core.Queries;
using MediatR;

namespace Core.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<Person>>
    {
        private readonly IDataAcess _data;
        public GetPersonListHandler(IDataAcess data)
        {
            _data = data;
        }
        public async Task<List<Person>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var people = await Task.Run(() => _data.GetPeople());
            return  people;
        }
    }
    
}

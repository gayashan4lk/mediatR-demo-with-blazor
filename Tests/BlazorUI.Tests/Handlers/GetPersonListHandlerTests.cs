using Core.DataAccess;
using Core.Handlers;
using Core.Models;
using Core.Queries;

namespace BlazorUI.Tests
{
    public class GetPersonListHandlerTests
    {
        [Fact]
        public async void ShouldReturnNotNullListOfPersons()
        {
            // Arrange
            var data = new DemoDataAcess();
            var handler = new GetPersonListHandler(data);
            var request = new GetPersonListQuery();
            var cancellationToken = new CancellationToken();

            // Act
            var result = await handler.Handle(request, cancellationToken);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async void ShouldReturnMoreThanZeroListOfPersons()
        {
            // Arrange
            var data = new DemoDataAcess();
            var handler = new GetPersonListHandler(data);
            var request = new GetPersonListQuery();
            var cancellationToken = new CancellationToken();

            // Act
            var result = await handler.Handle(request, cancellationToken);

            // Assert
            Assert.True(result.Count > 0, "More than zero persons returned.");
        }
    }
}
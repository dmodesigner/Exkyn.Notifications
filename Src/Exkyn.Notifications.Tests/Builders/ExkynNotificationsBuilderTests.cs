using Exkyn.Notifications.Builders;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace Exkyn.Notifications.Tests.Builders;

public class ExkynNotificationsBuilderTests
{
    [Fact]
    public void Constructor_ShouldAssignServicesPropertyCorrectly()
    {
        //Arrange
        var services = new ServiceCollection();
        
        //Act
        var builder = new ExkynNotificationsBuilder(services);
        
        //Assert
        builder.Services.Should().NotBeNull();

        // Verifica se é a mesma referência na memória (importante para injeção de dependência)
        builder.Services.Should().BeSameAs(services);
    }
}
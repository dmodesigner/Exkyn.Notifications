using Exkyn.Notifications.Abstractions;
using Exkyn.Notifications.Extensions;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace Exkyn.Notifications.Tests.Extensions;

public class ExkynNotificationsExtensionTests
{
    [Fact]
    public void AddExkynNOtifications_WhenServicesIsNull_ShouldThrowArgumentNullException()
    {
        //Arrange
        IServiceCollection services = null;
        
        //Act
        Action action = () => services.AddExkynNotifications();
        
        //Assert
        action.Should().Throw<ArgumentNullException>();
    }
    
    [Fact]
    public void AddExkynNotifications_ShouldReturnBuilderWithCorrectServices()
    {
        //Arrange
        var services = new ServiceCollection();
        
        //Act
        var builder = services.AddExkynNotifications();
        
        //Assert
        builder.Should().NotBeNull();
        
        //Garante que o objeto retornado implementa a interface correta
        builder.Should().BeAssignableTo<IExkynNotificationsBuilder>();
        
        //Garante que a coleção de serviços dentro do builder é a mesma coleção que foi criado na etapa Arrange
        builder.Services.Should().BeSameAs(services);
    }
}
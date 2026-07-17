using Microsoft.Extensions.DependencyInjection;

namespace Exkyn.Notifications.Abstractions;

public interface IExkynNotificationsBuilder
{
    IServiceCollection Services { get; }
}

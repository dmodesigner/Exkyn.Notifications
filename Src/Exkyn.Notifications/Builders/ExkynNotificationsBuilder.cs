using Exkyn.Notifications.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Exkyn.Notifications.Builders;

internal class ExkynNotificationsBuilder(IServiceCollection services) : IExkynNotificationsBuilder
{
    public IServiceCollection Services { get; } = services;
}

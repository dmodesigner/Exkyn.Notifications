using Exkyn.Notifications.Abstractions;
using Exkyn.Notifications.Builders;
using Microsoft.Extensions.DependencyInjection;

namespace Exkyn.Notifications.Extensions;

public static class ExkynNotificationsExtension
{
    public static IExkynNotificationsBuilder AddExkynNotifications(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);
        
        return new ExkynNotificationsBuilder(services);   
    }
}

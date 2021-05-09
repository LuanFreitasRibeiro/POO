using System.Collections.Generic;

namespace POO.NotificationContext.Interfaces
{
    public interface INotifiable
    {
        void AddNotification(Notification notification);
        void AddNotifications(IEnumerable<Notification> notifications);
    }
}
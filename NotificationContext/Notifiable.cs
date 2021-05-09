using System.Collections.Generic;
using System.Linq;
using POO.NotificationContext.Interfaces;

namespace POO.NotificationContext
{
    public abstract class Notifiable : INotifiable
    {
        public List<Notification> Notifications { get; set; }

        public Notifiable()
        {
            Notifications = new List<Notification>();
        }
        
        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }

        public bool IsInvalid => Notifications.Any();
    }
}
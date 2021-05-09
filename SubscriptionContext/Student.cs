using System.Collections.Generic;
using System.Linq;
using POO.NotificationContext;
using POO.SharedContext;

namespace POO.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public void CrateSubscription(Subscription subscription)
        {
            if(IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já tem uma assinatura ativa"));
                return;
            }

            Subscriptions.Add(subscription);
        }
        
        public bool IsPremium => Subscriptions.Any(x => x.IsInactive);
    }
}

using System;
using POO.NotificationContext;

namespace POO.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); // SPOF - Sinlge Point of Failure
        }
        public Guid Id { get; set; }
    }
}
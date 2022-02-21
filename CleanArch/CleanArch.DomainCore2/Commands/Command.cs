using CleanArch.DomainCore2.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.DomainCore2.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}

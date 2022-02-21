using CleanArch.DomainCore2.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.DomainCore2.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T Command) where T : Command;
    }
}
